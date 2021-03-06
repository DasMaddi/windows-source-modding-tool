﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace source_modding_tool.SourceSDK
{
    public class RunPreset
    {
        public string name = "";

        public string engine = "";
        public string game = "";
        public string mod = "";

        public int runMode = SourceSDK.RunMode.DEFAULT;
        public string exePath = "";
        public string command;

        public RunPreset()
        {

        }

        public RunPreset(int runMode) : this()
        {
            this.runMode = runMode;
        }

        public string GetArguments(Launcher launcher, Control parent)
        {
            Game game = launcher.GetCurrentGame();
            Mod mod = launcher.GetCurrentMod();
            string arguments = "";

            Point location = parent.PointToScreen(Point.Empty);

            switch (runMode)
            {
                case SourceSDK.RunMode.DEFAULT:
                    {
                        switch (game.engine)
                        {
                            case Engine.SOURCE:
                                arguments = "-game \"" + mod.installPath + "\" -windowed -noborder" +
                                 " -x " + location.X +
                                " -y " + location.Y +
                                " -width " + parent.Width +
                                " -height " + parent.Height +
                                " -multirun" +
                                " " + command;
                                break;
                            case Engine.SOURCE2:
                                arguments = " -game " + new DirectoryInfo(mod.installPath).Name + " -windowed -noborder -vr_enable_fake_vr_test" +
                                " -x " + location.X +
                                " -y " + location.Y +
                                " -width " + parent.Width +
                                " -height " + parent.Height +
                                " " + command;
                                break;
                            case Engine.GOLDSRC:
                                arguments = "-game " + new DirectoryInfo(mod.installPath).Name + " -windowed -noborder" +
                                 " -x " + location.X +
                                " -y " + location.Y +
                                " -width " + parent.Width +
                                " -height " + parent.Height +
                                " " + command;
                                break;
                        }
                    }
                    break;
                case SourceSDK.RunMode.FULLSCREEN:
                    {
                        switch (game.engine)
                        {
                            case Engine.SOURCE:
                                arguments = "-game \"" + mod.installPath + "\" -fullscreen" +
                                " -x 0" +
                                " -y 0" +
                                " -width " + Screen.PrimaryScreen.Bounds.Width +
                                " -height " + Screen.PrimaryScreen.Bounds.Height +
                                " " + command;
                                break;
                            case Engine.SOURCE2:
                                arguments = "-game " + new DirectoryInfo(mod.installPath).Name + " -fullscreen -vr_enable_fake_vr_test" +
                                " -x 0" +
                                " -y 0" +
                                " -width " + Screen.PrimaryScreen.Bounds.Width +
                                " -height " + Screen.PrimaryScreen.Bounds.Height +
                                " " + command;
                                break;
                            case Engine.GOLDSRC:
                                arguments = "-game " + new DirectoryInfo(mod.installPath).Name + " -fullscreen" +
                                " -x 0" +
                                " -y 0" +
                                " -width " + Screen.PrimaryScreen.Bounds.Width +
                                " -height " + Screen.PrimaryScreen.Bounds.Height +
                                " " + command;
                                break;
                        }
                    }
                    break;
                case SourceSDK.RunMode.WINDOWED:
                    switch(game.engine)
                    {
                        case Engine.SOURCE:
                            arguments = "-game \"" + mod.installPath + "\" -windowed -noborder -multirun" +
                            " -x " + location.X +
                            " -y " + location.Y +
                            " -width " + parent.Width +
                            " -height " + parent.Height +
                            " " + command;
                            break;
                        case Engine.SOURCE2:
                            arguments = " -game " + new DirectoryInfo(mod.installPath).Name + " -windowed -noborder -vr_enable_fake_vr_test" +
                            " -x " + location.X +
                            " -y " + location.Y +
                            " -width " + parent.Width +
                            " -height " + parent.Height +
                            " " + command;
                            break;
                        case Engine.GOLDSRC:
                            arguments = "-game " + new DirectoryInfo(mod.installPath).Name + " -windowed -noborder" +
                            " -x " + location.X +
                            " -y " + location.Y +
                            " -width " + parent.Width +
                            " -height " + parent.Height +
                            " " + command;
                            break;
                    }
                    break;
                case SourceSDK.RunMode.VR:
                    switch(game.engine)
                    {
                        case Engine.SOURCE:
                            arguments = "-game \"" + mod.installPath + "\" -vr" +
                            " " + command;
                            break;
                        case Engine.SOURCE2:
                            arguments = "-game " + new DirectoryInfo(mod.installPath).Name + " -vr" +
                            " " + command;
                            break;
                    }
                    break;
            }
            return arguments;
        }

        public static class CoverageType
        {
            public static int GLOBAL = 0;
            public static int GAME_SPECIFIC = 1;
            public static int MOD_SPECIFIC = 2;
        }
    }
}
