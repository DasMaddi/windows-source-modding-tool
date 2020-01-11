﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SourceModdingTool.SourceSDK
{
    public class KeyValue
    {
        private string key = "";
        private string value = null;

        private Dictionary<string, List<KeyValue>> childrenIndex = null;
        private List<KeyValue> children = null;

        public KeyValue(string key, string value)
        {
            this.key = key;
            this.value = value;
        }

        public KeyValue(string key)
        {
            this.key = key;
            childrenIndex = new Dictionary<string, List<KeyValue>>();
            children = new List<KeyValue>();
        }

        public bool isParentKey()
        {
            return (childrenIndex != null && value == null);
        }

        public void addChild(string key, KeyValue value)
        {
            value.key = key;
            addChild(value);
        }

        public void addChild(string key, string value)
        {
            addChild(new KeyValue(key, value));
        }

        public void addChild(KeyValue value)
        {
            if (!childrenIndex.ContainsKey(value.getKey()))
                childrenIndex.Add(value.getKey(), new List<KeyValue>());

            childrenIndex[value.getKey()].Add(value);
            children.Add(value);
        }

        public KeyValue getChildByKey(string key)
        {
            if (childrenIndex != null && childrenIndex.ContainsKey(key))
                return childrenIndex[key][0];

            return null;
        }

        public List<KeyValue> getChildrenByKey(string key)
        {
            if (childrenIndex != null && childrenIndex.ContainsKey(key))
                return childrenIndex[key];

            return null;
        }

        public Dictionary<string, List<KeyValue>> getChildrenByKey()
        {
            return childrenIndex;
        }

        public List<KeyValue> getChildren()
        {
            return children;
        }

        public KeyValue findChildByKey(string key)
        {
            if (childrenIndex != null && childrenIndex.ContainsKey(key))
                return childrenIndex[key][0];

            if (childrenIndex != null)
                foreach (string k in childrenIndex.Keys)
                    foreach (KeyValue child in childrenIndex[k])
                    {
                        KeyValue result = child.findChildByKey(key);
                        if (result != null)
                            return result;
                    }

            return null;
        }

        public List<KeyValue> findChildrenByKey(string key)
        {
            List<KeyValue> result = new List<KeyValue>();
            if (childrenIndex != null && childrenIndex.ContainsKey(key))
                result.AddRange(childrenIndex[key]);

            if (childrenIndex != null)
                foreach (string k in childrenIndex.Keys)
                    foreach (KeyValue child in childrenIndex[k])
                    {
                        result.AddRange(child.findChildrenByKey(key));
                    }

            return result;
        }

        public void clearChildren()
        {
            childrenIndex = new Dictionary<string, List<KeyValue>>();
            children = new List<KeyValue>();
        }

        public string getValue()
        {
            return value;
        }

        public string getValue(string key)
        {
            KeyValue child = getChildByKey(key);
            if (child != null)
                return child.getValue();

            return "";
        }

        public string getKey()
        {
            return key;
        }

        public void setValue(string value)
        {
            if (this.value != null && childrenIndex == null)
                this.value = value;
        }

        public void setValue(string key, string value)
        {
            if (this.value != null || childrenIndex == null)
                return;

            KeyValue child = getChildByKey(key);
            if (child != null)
            {
                child.setValue(value);
                return;
            }

            addChild(key, new KeyValue(key, value));
        }

        public static KeyValue readChunkfile(String path)
        {
            // Parse Valve chunkfile format
            KeyValue root = null;
            List<KeyValue> list = new List<KeyValue>();
            Stack<KeyValuePair<string, KeyValue>> stack = new Stack<KeyValuePair<string, KeyValue>>();

            if (File.Exists(path))
            {
                using (StreamReader r = new StreamReader(path))
                {
                    while (r.Peek() >= 0)
                    {
                        String line = r.ReadLine();
                        line = line.Trim();
                        line = Regex.Replace(line, @"\s+", " ");

                        // Ignore the commented part of the line
                        if (line.StartsWith("//"))
                            continue;

                        string[] words = splitByWords(line);

                        if (words.Length > 0 && words[0].Contains("{")) // It opens a group
                        {
                            // We actually don't need to do anything.
                        }
                        else if (words.Length > 0 && words[0].Contains("}"))    // It closes a group
                        {
                            KeyValuePair<string, KeyValue> child = stack.Pop();
                            if (stack.Count > 0)
                                stack.Peek().Value.addChild(child.Key, child.Value);
                            else
                                list.Add(child.Value);
                            //root = child.Value;
                        }
                        else if (words.Length == 1 || words.Length > 1 && words[1].StartsWith("//"))    // It's a parent key
                        {
                            line = line.Replace("\"", "").ToLower();
                            KeyValue parent = new KeyValue(line);
                            stack.Push(new KeyValuePair<string, KeyValue>(line, new KeyValue(line)));
                        }
                        else if (words.Length >= 2) // It's a value key
                        {
                            string key = words[0].Replace("\"", "").ToLower();
                            KeyValue value = new KeyValue(key, words[1]);
                            stack.Peek().Value.addChild(key, value);
                        }
                    }
                }
            }
            else
            {
                throw new FileNotFoundException();
            }

            if (list.Count > 1)
            {
                root = new KeyValue("");
                foreach (KeyValue keyValue in list)
                    root.addChild(keyValue);

                return root;
            }
            else
                return list[0];

        }

        public static void writeChunkFile(string path, KeyValue root)
        {
            writeChunkFile(path, root, Encoding.UTF8);
        }

        public static void writeChunkFile(string path, KeyValue root, bool quotes)
        {
            writeChunkFile(path, root, quotes, Encoding.UTF8);
        }

        public static void writeChunkFile(string path, KeyValue root, Encoding encoding)
        {
            writeChunkFile(path, root, true, encoding);
        }

        public static void writeChunkFile(string path, KeyValue root, bool quotes, Encoding encoding)
        {
            List<string> lines = writeChunkFileTraverse(root, 0, quotes);
            Directory.CreateDirectory(Path.GetDirectoryName(path));
            File.WriteAllLines(path, lines, encoding);
        }

        private static List<string> writeChunkFileTraverse(KeyValue node, int level, bool quotes)
        {
            List<string> lines = new List<string>();

            string tabs = "";
            for (int i = 0; i < level; i++)
            {
                tabs = tabs + "\t";
            }

            if (node.isParentKey())
            {
                if (node.key != "")
                {
                    lines.Add(tabs + (quotes ? "\"" : "") + node.key + (quotes ? "\"" : ""));
                    lines.Add(tabs + "{");
                }

                foreach (KeyValue entry in node.getChildren())
                    lines.AddRange(writeChunkFileTraverse(entry, level + 1, quotes));

                if (node.key != "")
                    lines.Add(tabs + "}");
            }
            else if (node.getValue() != null)
            {
                lines.Add(tabs + (quotes ? "\"" : "") + node.key + (quotes ? "\"" : "") + "\t\"" + node.value + "\"");
            }

            return lines;
        }

        public static string[] splitByWords(string fullString)
        {
            List<string> words = new List<string>();

            string[] parts = fullString.Split('\"');
            for (int i = 0; i < parts.Length; i++)
            {
                if (i % 2 == 1)
                {
                    // between quotes
                    string subpart = parts[i].Replace("\"", "");
                    words.Add(subpart);
                }
                else
                {
                    string[] subparts = parts[i].Split(null);
                    // outside quotes
                    foreach (string subpart in subparts)
                    {
                        if (subpart != "" && subpart != " ")
                            words.Add(subpart);
                    }
                }
            }
            return words.ToArray();
        }

    }
}
