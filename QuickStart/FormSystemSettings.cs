using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using SystemActions;

namespace QuickStart
{
    public partial class FormSystemSettings : Form
    {
        public FormSystemSettings()
        {
            InitializeComponent();
        }



        private void ButtonOK_Click(object sender, EventArgs e)
        {
            FormDatabaseConnection_SetSettings();
            if (!ClassSystemActions.DatabaseValidate())
            {
                MessageBox.Show("Връзката към базата данни не може да бъде инициализирана!", "ВНИМАНИЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ClassSystemActions.DatabaseSaveSettings();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void FormDatabaseConnection_Show(object sender, EventArgs e)
        {
            TextBox_CoreHost.Text = QuickStart.Properties.Settings.Default.Host;
            TextBox_CoreUsername.Text = QuickStart.Properties.Settings.Default.Username;
            TextBox_CorePassword.Text = QuickStart.Properties.Settings.Default.Password;
            TextBox_CoreDatabase.Text = QuickStart.Properties.Settings.Default.Database;
            if (QuickStart.Properties.Settings.Default.Timeout < TextBox_CoreTimeout.Value)
                QuickStart.Properties.Settings.Default.Timeout = TextBox_CoreTimeout.Minimum;
                TextBox_CoreTimeout.Value = QuickStart.Properties.Settings.Default.Timeout;
        }

        private void FormDatabaseConnection_SetSettings()
        {
            QuickStart.Properties.Settings.Default.Host = TextBox_CoreHost.Text;
            QuickStart.Properties.Settings.Default.Username = TextBox_CoreUsername.Text;
            QuickStart.Properties.Settings.Default.Password = TextBox_CorePassword.Text;
            QuickStart.Properties.Settings.Default.Database = TextBox_CoreDatabase.Text;
            QuickStart.Properties.Settings.Default.Timeout = TextBox_CoreTimeout.Value;
            QuickStart.Properties.Settings.Default.Save();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            ClassSystemActions.DatabaseLoadSettings();
        }

    }
}
