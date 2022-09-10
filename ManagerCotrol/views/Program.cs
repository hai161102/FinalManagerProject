using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCotrol
{
    internal static class Program
    {
        private const string FileName = @"gothic.ttf";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Form1Helpers.FONT_FAMILY = Form1Helpers.getFont(Properties.Resources.GOTHIC).Families[0];
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
