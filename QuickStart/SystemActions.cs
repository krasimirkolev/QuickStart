namespace SystemActions
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using System.IO;
    using System.Data.SqlClient;
    using QuickStart;

    public static class ClassSystemActions
    {
        #region Variables

        public static int ItemID = 0, CategoryID;
        public static string ItemName, ExePath, StartupDir, IconPath, Parameters;

        public static List<int> CategoryIDs = new List<int>();
        public static List<string> CategoryNames = new List<string>();




















        #endregion Variables

        //###########################################################################################

        #region Methods

        /// <summary>
        /// Gets a list of all ToolStripMenuItems
        /// </summary>
        /// <param name="menuStrip">The menu strip control</param>
        /// <returns>List of all ToolStripMenuItems</returns>

        //Database connection init and validation

        private static bool CheckSettings()
        {
            if (QuickStart.Properties.Settings.Default.Host.Length < 1 || QuickStart.Properties.Settings.Default.Username.Length < 1 ||
                QuickStart.Properties.Settings.Default.Password.Length < 1 || QuickStart.Properties.Settings.Default.Database.Length < 1 ||
                QuickStart.Properties.Settings.Default.Timeout < 1)
                return false;
            else
                return true;
        }

        public static bool DatabaseLoadSettings()
        {
            string readstring;

            if (!File.Exists("QuickStart.ini"))
                return false;

            System.IO.StreamReader readfile = new System.IO.StreamReader("QuickStart.ini");
            if (readfile == null)
            {
                readfile.Close();
                return false;
            }
            else
            {
                do
                {
                    readstring = readfile.ReadLine();
                    if (readstring == null)
                        continue;

                    if (readstring.Contains("Host:"))
                        QuickStart.Properties.Settings.Default.Host = readstring.Replace("Host:", "");
                    else if (readstring.Contains("Username:"))
                        QuickStart.Properties.Settings.Default.Username = readstring.Replace("Username:", "");
                    else if (readstring.Contains("Password:"))
                        QuickStart.Properties.Settings.Default.Password = readstring.Replace("Password:", "");
                    else if (readstring.Contains("Database:"))
                        QuickStart.Properties.Settings.Default.Database = readstring.Replace("Database:", "");
                    else if (readstring.Contains("Timeout:"))
                    {
                        if (readstring.Replace("Timeout:", "") != "")
                            QuickStart.Properties.Settings.Default.Timeout = Convert.ToDecimal(readstring.Replace("Timeout:", ""));
                        else
                            QuickStart.Properties.Settings.Default.Timeout = 1;
                    }
                }
                while (readfile.Peek() != -1);
                QuickStart.Properties.Settings.Default.Save();
                readfile.Close();
                return true;
            }
        }

        public static void DatabaseSaveSettings()
        {
            System.IO.StreamWriter writefile = new System.IO.StreamWriter("QuickStart.ini");

            if (writefile == null)
            {
                MessageBox.Show("Файлът със системни настройки не може да бъде отворен за запис!", "ВНИМАНИЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                writefile.Close();
            }
            else
            {
                writefile.WriteLine("Host:" + QuickStart.Properties.Settings.Default.Host);
                writefile.WriteLine("Username:" + QuickStart.Properties.Settings.Default.Username);
                writefile.WriteLine("Password:" + QuickStart.Properties.Settings.Default.Password);
                writefile.WriteLine("Database:" + QuickStart.Properties.Settings.Default.Database);
                writefile.WriteLine("Timeout:" + Convert.ToString(QuickStart.Properties.Settings.Default.Timeout));
                writefile.Close();
            }
        }

        public static bool DatabaseValidateConnection()
        {
            if (!DatabaseLoadSettings() || !CheckSettings() || !DatabaseValidate())
            {
                FormSystemSettings formdbCon = new FormSystemSettings();
                if (formdbCon.ShowDialog() == DialogResult.Cancel)
                    return false;
                else
                    return true;
            }
            else
                return true;

        }

        public static bool DatabaseValidate()
        {
            SqlConnection myConnection = new SqlConnection(CommandString());

            try
            {

                myConnection.Open();
                myConnection.Close();
                return true;
            }
            catch
            {
                myConnection.Dispose();
                return false;
            }
        }

        public static string CommandString()
        {
                return "user id=" + QuickStart.Properties.Settings.Default.Username +
                       ";password=" + QuickStart.Properties.Settings.Default.Password +
                       ";server=" + QuickStart.Properties.Settings.Default.Host +
                       ";Trusted_Connection=no" +
                       ";database=" + QuickStart.Properties.Settings.Default.Database +
                       ";connection timeout=" + Convert.ToString(QuickStart.Properties.Settings.Default.Timeout);
        }

        public static bool TestConnection(string CommandString)
        {
            SqlConnection myConnection = new SqlConnection(CommandString);
            try
            {
                myConnection.Open();
                myConnection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion Methods
    }
}

