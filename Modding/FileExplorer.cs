﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;
using System.IO;

namespace SourceModdingTool.Tools
{
    public partial class VPKExplorer : DevExpress.XtraEditors.XtraForm
    {
        string gamePath;
        string modPath;
        Steam sourceSDK;

        string currentDirectory = "";
        Stack<string> previousDirectories = new Stack<string>();
        Stack<string> nextDirectories = new Stack<string>();

        List<VPK.File> files = new List<VPK.File>();

        string filter = "";

        VPKManager vpkManager;

        public VPKExplorer(Steam sourceSDK)
        {
            InitializeComponent();

            this.sourceSDK = sourceSDK;
        }

        private void VPKExplorer_Load(object sender, EventArgs e)
        {
            gamePath = sourceSDK.GetGamePath();
            modPath = sourceSDK.GetModPath();

            vpkManager = new VPKManager(sourceSDK);

            listFiles();
            traverseFileTree();
            traverseDirectory(currentDirectory);
        }

        class Folder {
            List<string> files = new List<string>();
            List<Folder> folders = new List<Folder>();
        }

        private void listFiles()
        {
            listFiles(false);
        }

        private void listFiles(bool reload)
        {
            if (reload)
                vpkManager.Reload();
            files = vpkManager.getAllFiles();
        }

        private void traverseFileTree()
        {
            dirs.BeginUnboundLoad();
            dirs.Nodes.Clear();

            Stack<TreeListNode> stack = new Stack<TreeListNode>();
            Stack<string> stackString = new Stack<string>();

            stack.Push(dirs.AppendNode(new object[] { "root" },null));
            stack.Peek().Tag = "";
            stack.Peek().StateImageIndex = 0;

            for (int f = 0; f < files.Count; f++)
            {
                VPK.File file = files[f];

                string[] fileSplit = file.path.Split('/');

                while (stackString.Count >= fileSplit.Length)
                {
                    stackString.Pop();
                    stack.Pop();
                }

                for (int i = stackString.Count - 1; i >= 0; i--)
                {
                    if (stackString.Peek() != fileSplit[i])
                    {
                        stackString.Pop();
                        stack.Pop();
                    }
                    else
                        break;
                }

                for (int i = stack.Count - 1; i < fileSplit.Length - 1; i++)
                {
                    string tag = fileSplit[i] + "/";
                    if (stackString.Count > 0)
                        tag = stack.Peek().Tag.ToString() + tag;

                    stack.Push(dirs.AppendNode(new object[] { fileSplit[i] }, stack.Peek()));
                    stack.Peek().Tag = tag;
                    stack.Peek().StateImageIndex = 0;
                    stackString.Push(fileSplit[i]);
                }
            }

            dirs.ExpandToLevel(0);

            dirs.EndUnboundLoad();
        }

        private void traverseDirectory(string directory)
        {
            currentDirectory = directory;
            buttonUp.Enabled = (currentDirectory != "");
            buttonBack.Enabled = (previousDirectories.Count > 0);
            buttonForward.Enabled = (nextDirectories.Count > 0);

            filter = "";
            textSearch.EditValue = "";

            if (directory.Contains("/"))
                repositoryTextSearch.NullValuePrompt = "Search in " + directory.Substring(0, directory.Length - 1).Split('/').Last();
            else
                repositoryTextSearch.NullValuePrompt = "Search";

            textDirectory.EditValue = directory;

            list.BeginUnboundLoad();
            list.Nodes.Clear();

            List<string> usedFiles = new List<string>();

            for (int f = 0; f < files.Count; f++)
            {
                VPK.File file = files[f];
                string path = file.path;

                if (!path.StartsWith(directory))
                    continue;

                path = path.Substring(directory.Length);

                string[] fileSplit = path.Split('/');

                if (fileSplit.Length > 1)
                {
                    // It's a directory
                    if (usedFiles.Contains(fileSplit[0]))
                        continue;

                    TreeListNode node = list.AppendNode(new object[] { fileSplit[0], "Folder" }, null);
                    node.Tag = directory + fileSplit[0] + "/";
                    node.StateImageIndex = 0;
                    usedFiles.Add(fileSplit[0]);
                } else
                {
                    // It's a file
                    TreeListNode node = list.AppendNode(new object[] { fileSplit[0], file.type, file.pack }, null);
                    node.Tag = directory + path;
                    node.StateImageIndex = 1;
                    usedFiles.Add(path);
                } 
            }

            list.EndUnboundLoad();
        }

        private void traverseDirectoryFiltered(string directory)
        {
            buttonUp.Enabled = (currentDirectory != "");
            buttonBack.Enabled = (previousDirectories.Count > 0);
            buttonForward.Enabled = (nextDirectories.Count > 0);

            textDirectory.EditValue = "Search results for " + filter;

            list.BeginUnboundLoad();
            list.Nodes.Clear();

            List<VPK.File> filtered = files.Where(x => x.path.Contains(filter)).ToList();

            List<string> usedFiles = new List<string>();

            for (int f = 0; f < filtered.Count; f++)
            {
                VPK.File file = filtered[f];
                string path = file.path;

                if (!path.StartsWith(directory))
                    continue;

                string[] fileSplit = path.Split('/');

                string dir = "";
                for (int j = 0; j < fileSplit.Length; j++)
                {
                    dir = dir + fileSplit[j] + "/";

                    if (!fileSplit[j].Contains(filter))
                        continue;

                    if (j < fileSplit.Length - 1)
                    {
                        // It's a directory
                        if (usedFiles.Contains(dir))
                            continue;

                        TreeListNode node = list.AppendNode(new object[] { path, "Folder" }, null);
                        node.Tag = dir;
                        node.StateImageIndex = 0;
                        usedFiles.Add(dir);
                    } else
                    {
                        // It's a file
                        TreeListNode node = list.AppendNode(new object[] { path, file.type, file.pack }, null);
                        node.Tag = path;
                        node.StateImageIndex = 1;
                        usedFiles.Add(path);
                    }
                }
            }

            list.EndUnboundLoad();
        }

        private void dirs_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (dirs.FocusedNode == null || dirs.FocusedNode.Tag == null)
                return;

            string directory = dirs.FocusedNode.Tag.ToString();

            if (directory != currentDirectory)
            {
                previousDirectories.Push(currentDirectory);
                nextDirectories.Clear();
            }

            traverseDirectory(directory);
        }

        private void list_DoubleClick(object sender, EventArgs e)
        {
            TreeList tree = sender as TreeList;
            TreeListHitInfo hi = tree.CalcHitInfo(tree.PointToClient(Control.MousePosition));
            if (hi.Node != null)
            {
                string tag = hi.Node.Tag.ToString();
                if (tag.EndsWith("/"))
                {
                    // It's a folder
                    if (tag != currentDirectory)
                    {
                        previousDirectories.Push(currentDirectory);
                        nextDirectories.Clear();
                    }

                    traverseDirectory(tag);
                } else
                {
                    // It's a file
                    editSelected();
                }
            }
        }

        private void buttonUp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (currentDirectory == "")
                return;

            previousDirectories.Push(currentDirectory);
            nextDirectories.Clear();

            if (currentDirectory.Contains("/"))
                currentDirectory = currentDirectory.Substring(0, currentDirectory.LastIndexOf("/"));

            if (currentDirectory.Contains("/"))
                currentDirectory = currentDirectory.Substring(0, currentDirectory.LastIndexOf("/") + 1);
            else
                currentDirectory = "";



            traverseDirectory(currentDirectory);
        }

        private void buttonBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (previousDirectories.Count > 0)
            {
                nextDirectories.Push(currentDirectory);
                traverseDirectory(previousDirectories.Pop());
            }
        }

        private void buttonForward_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (nextDirectories.Count > 0)
            {
                previousDirectories.Push(currentDirectory);
                traverseDirectory(nextDirectories.Pop());
            }
        }

        private void repositoryTextSearch_EditValueChanged(object sender, EventArgs e)
        {
            filter = ((TextEdit) sender).EditValue.ToString();
            if (filter != "")
                traverseDirectoryFiltered(currentDirectory);
            else
                traverseDirectory(currentDirectory);
        }

        private void extractSelected()
        {
            var nodes = list.Selection;
            List<string> values = new List<string>();
            foreach (TreeListNode node in nodes)
            {
                values.Add(node.Tag.ToString());
            }

            foreach(string filePath in values)
            {
                vpkManager.extractFile(filePath);
            }

            string modPath = sourceSDK.GetModPath();
            Process.Start(modPath);

            listFiles(true);
            traverseDirectory(currentDirectory);
        }

        private List<string> getSelectedPaths()
        {
            List<string> selectedPaths = new List<string>();
            foreach (TreeListNode node in list.Selection)
                selectedPaths.Add(node.Tag.ToString());

            return selectedPaths;
        }

        private void editSelected()
        {
            string modPath = sourceSDK.GetModPath();

            foreach (string filePath in getSelectedPaths())
            {
                string extractedPath = vpkManager.getExtractedPath(filePath);

                if (extractedPath == "")
                {
                    vpkManager.extractFile(filePath);
                    extractedPath = modPath + "\\" + filePath;
                } else if(extractedPath != modPath + "\\" + filePath)
                {
                    File.Copy(extractedPath, modPath + "\\" + filePath, true);
                }

                Process.Start("notepad", extractedPath);
            }

            listFiles(true);
            traverseDirectory(currentDirectory);
        }

        private void list_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void list_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                bool hasFolders = false;
                bool hasFiles = false;
                bool fileExists = true;

                List<string> selectedPaths = getSelectedPaths();
                foreach(string filePath in selectedPaths)
                {
                    if (filePath.EndsWith("/"))
                        hasFolders = true;
                    else
                    {
                        fileExists = fileExists && vpkManager.getExtractedPath(filePath) != "";
                        hasFiles = true;
                    }
                }

                filePopDeleteButton.Enabled = !hasFolders & fileExists;
                filePopExtractButton.Enabled = !hasFolders;
                filePopOpenButton.Enabled = selectedPaths.Count == 1;
                filePopMenu.ShowPopup(MousePosition);
            }
                
        }

        void deleteSelected()
        {
            List<string> selectedPaths = getSelectedPaths();
            foreach (string filePath in selectedPaths)
            {
                string fullPath = vpkManager.getExtractedPath(filePath);
                File.Delete(fullPath);
            }

            listFiles(true);
            traverseDirectory(currentDirectory);
        }

        private void filePopDeleteButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            deleteSelected();
        }

        private void filePopOpenButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            editSelected();
        }

        private void filePopExtractButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            extractSelected();
        }

        private void filePopOpenFileLocationButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string modPath = sourceSDK.GetModPath();

            List<string> paths = getSelectedPaths();
            for (int i = 0; i < paths.Count; i++)
            {

                paths[i] = vpkManager.getExtractedPath(paths[i]).Replace("/", "\\");
                if (paths[i].Contains("\\"))
                {
                    paths[i] = paths[i].Substring(0, paths[i].LastIndexOf("\\") + 1);
                }
            }

            paths = paths.Distinct().ToList();
            foreach(string path in paths)
            {
                Process.Start(path);
            }
        }
    }
}