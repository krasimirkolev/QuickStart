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
    public partial class FormLink_NewEdit : Form
    {

        public List<int> CategoryIDs = new List<int>();
        public List<string> Categories = new List<string>();

        public FormLink_NewEdit()
        {
            InitializeComponent();
        }

        private void FormLink_NewEdit_Show(object sender, EventArgs e)
        {
            foreach (string category in Categories)
                ComboBoxCategories.Items.Add(category);

            ComboBoxCategories.Items[0] = "";

            if (ClassSystemActions.ItemID > 0)
            {
                TextBox_Name.Text = ClassSystemActions.ItemName;
                TextBox_ExePath.Text = ClassSystemActions.ExePath;
                TextBox_StartupDir.Text = ClassSystemActions.StartupDir;
                TextBox_IconPath.Text = ClassSystemActions.IconPath;
                TextBox_Parameters.Text = ClassSystemActions.Parameters;
            }
            ComboBoxCategories.SelectedIndex = CategoryIDs.IndexOf(ClassSystemActions.CategoryID);
        }

        private void MandatoryItem_Change(object sender, EventArgs e)
        {
            if (TextBox_Name.Text.Length < 1 || TextBox_ExePath.Text.Length < 1)
                ButtonOK.Enabled = false;
            else if (TextBox_Name.Text.Length > 0 && TextBox_ExePath.Text.Length > 0)
                ButtonOK.Enabled = true;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection myConnection = new SqlConnection(ClassSystemActions.CommandString());
                myConnection.Open();

                SqlCommand myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                myCommand.CommandType = CommandType.StoredProcedure;

                if (ClassSystemActions.ItemID == 0)
                {
                    myCommand.CommandText = "pr_InsertItem";
                }
                else
                {
                    myCommand.CommandText = "pr_UpdateItem";
                    myCommand.Parameters.AddWithValue("@ID", ClassSystemActions.ItemID);
                }

                myCommand.Parameters.AddWithValue("@Name", TextBox_Name.Text);
                myCommand.Parameters.AddWithValue("@ExePath", TextBox_ExePath.Text);
                if (TextBox_StartupDir.Text.Length > 0)
                {
                    myCommand.Parameters.AddWithValue("@StartupDir", TextBox_StartupDir.Text);
                }
                if (TextBox_IconPath.Text.Length > 0)
                {
                    myCommand.Parameters.AddWithValue("@IconPath", TextBox_IconPath.Text);
                }
                if (TextBox_Parameters.Text.Length > 0)
                {
                    myCommand.Parameters.AddWithValue("@Parameters", TextBox_Parameters.Text);
                }
                myCommand.Parameters.AddWithValue("@CategoryID", CategoryIDs[ComboBoxCategories.SelectedIndex]);

                if (ClassSystemActions.ItemID == 0)
                {
                    ClassSystemActions.ItemID = Convert.ToInt32(myCommand.ExecuteScalar());
                }
                else
                {
                    myCommand.ExecuteNonQuery();
                }
                
                myConnection.Close();

                ClassSystemActions.ItemName = TextBox_Name.Text;
                ClassSystemActions.ExePath = TextBox_ExePath.Text;
                ClassSystemActions.StartupDir = TextBox_StartupDir.Text;
                ClassSystemActions.IconPath = TextBox_IconPath.Text;
                ClassSystemActions.Parameters = TextBox_Parameters.Text;
                ClassSystemActions.CategoryID = CategoryIDs[ComboBoxCategories.SelectedIndex];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Button_ExePath_Click(object sender, EventArgs e)
        {
            if (TextBox_ExePath.Text.Length < 2)
            {

                if (TextBox_StartupDir.Text.Length > 0 && Directory.Exists(Path.GetDirectoryName(TextBox_StartupDir.Text)))
                    OpenDialog.InitialDirectory = Path.GetDirectoryName(TextBox_StartupDir.Text);
                else
                    OpenDialog.InitialDirectory = Convert.ToString(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)) + @"\";
            }
            else
                OpenDialog.InitialDirectory = Path.GetDirectoryName(TextBox_ExePath.Text);//Convert.ToString(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));

            if (OpenDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TextBox_ExePath.Text = OpenDialog.FileName;
                TextBox_StartupDir.Text = Path.GetDirectoryName(OpenDialog.FileName);
                if(TextBox_IconPath.Text.Length < 2)
                    TextBox_IconPath.Text = OpenDialog.FileName;
            }
        }

        private void Button_IconPath_Click(object sender, EventArgs e)
        {
            if (TextBox_IconPath.Text.Length < 2)
            {
                if (TextBox_ExePath.Text.Length > 0 && Directory.Exists(Path.GetDirectoryName(TextBox_ExePath.Text)))
                    OpenDialog.InitialDirectory = Path.GetDirectoryName(TextBox_ExePath.Text);
                else
                    OpenDialog.InitialDirectory = Convert.ToString(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)) + @"\";
            }
            else
                OpenDialog.InitialDirectory = Path.GetDirectoryName(TextBox_IconPath.Text);

            if (OpenDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                TextBox_IconPath.Text = OpenDialog.FileName;
        }

        private void Button_StartupDir_Click(object sender, EventArgs e)
        {
            if (TextBox_StartupDir.Text.Length < 2)
            {
                if (TextBox_ExePath.Text.Length > 0 && Directory.Exists(Path.GetDirectoryName(TextBox_ExePath.Text)))
                {
                    FolderBrowserDialog.SelectedPath = Path.GetDirectoryName(TextBox_ExePath.Text) + @"\";
                }
            }
            else
                FolderBrowserDialog.SelectedPath = TextBox_StartupDir.Text;

            if (FolderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                TextBox_StartupDir.Text = FolderBrowserDialog.SelectedPath;
            else
                TextBox_StartupDir.Text = string.Empty;
        }

    }
}
