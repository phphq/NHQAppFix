using System.Diagnostics;

namespace NHQAppFix.Classes
{
    public class Common
    {
        public static void GoToNovaHq()
        {
            Process.Start(Config.NoavHqUrlApp);
        }

    }

}