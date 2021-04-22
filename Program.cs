using Bookshelf.Utilities;
using dotenv.net;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Bookshelf
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            //DotEnv.AutoConfig();
            DotEnv.Config(false, Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "../../../.env")),
                Encoding.UTF8);

            // Set initial language to system language
            Localization.CurrentLanguage = Thread.CurrentThread.CurrentUICulture.Name;
            //Localization.CurrentLanguage = Localization.English;
            //Localization.CurrentLanguage = Localization.Turkish;

            // Set initial theme to system theme
            Themes.CurrentTheme = GetSystemTheme();
            //Themes.CurrentTheme = Theme.Light;
            //Themes.CurrentTheme = Theme.Dark;

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ContainerForm());
            //Application.Run(new PlaygroundForm());
        }

        private static Theme GetSystemTheme()
        {
            try
            {
                var registryKey =
                    Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize");
                var value = registryKey?.GetValue("AppsUseLightTheme");

                if (value == null || (int) value == 1) return Theme.Light;

                return Theme.Dark;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return Theme.Light;
            }
        }
    }
}