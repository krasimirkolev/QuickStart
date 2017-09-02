using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QuickStart.Properties;
using SystemActions;

namespace QuickStart
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //QuickStart.Properties.Settings.Default.Upgrade();
            if (!ClassSystemActions.DatabaseValidateConnection())
                Application.Exit();
            else
                Application.Run(new FormMain());
        }
    }
}
