using System;
using System.Reflection;
using System.Windows.Forms;
using System.Collections.Generic;

using NHQAppFix.Forms;

namespace NHQAppFix
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }

    public static class Config
    {
        public static bool ProgramDebug = false;

        public static string ProgramName = "NovaHQ App Fix Installer";

        public static string ProgramVersion = Assembly.GetCallingAssembly().GetName().Version.Major + "." +
                                              Assembly.GetCallingAssembly().GetName().Version.Minor;

        public static string NoavHqUrl = "http://novahq.net/";
        public static string NoavHqUrlApp = NoavHqUrl + "?app=NHQAppFix" + ProgramVersion;

        public static Dictionary<string, string> AppFixDict = new Dictionary<string, string>
        {
            { "", "" },
            { "df1.sdb", "Delta Force 1 Window Border Fix" },
            { "lw.sdb", "Delta Force LW Window Border / Memory Swap Fix" },
            { "tfd.sdb","Delta Force TFD Window Border / Memory Swap Fix" },
            { "med.sdb", "NovaLogic MED Exception Crash Fix" },
            { "test.sdb", "Test" },
            { "extract", "SUPER USER: Extract *.sdb files for manual install..." },
        };

    }

}