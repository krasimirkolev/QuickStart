using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using SystemActions;

namespace QuickStart
{
    public partial class FormCategories_NewEdit : Form
    {
        public int CatID = 0;

        public FormCategories_NewEdit()
        {
            InitializeComponent();
        }

        private void datasettings_button_ok_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection myConnection = new SqlConnection(ClassSystemActions.CommandString());

                myConnection.Open();

                SqlCommand myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                myCommand.CommandType = CommandType.StoredProcedure;

                if (CatID == 0)
                {
                    myCommand.CommandText = "pr_CreateCategory";
                    myCommand.Parameters.AddWithValue("@CategoryName", TextBox_CategoryName.Text);
                    ClassSystemActions.CategoryIDs.Add(Convert.ToInt32(myCommand.ExecuteScalar()));
                    ClassSystemActions.CategoryNames.Add(TextBox_CategoryName.Text);
                }
                else
                {
                    myCommand.CommandText = "pr_UpdateCategory";
                    myCommand.Parameters.AddWithValue("@CategoryID", CatID);
                    myCommand.Parameters.AddWithValue("@CategoryName", TextBox_CategoryName.Text);
                    myCommand.ExecuteNonQuery();
                    ClassSystemActions.CategoryNames[ClassSystemActions.CategoryIDs.IndexOf(CatID)] = TextBox_CategoryName.Text;

                }





                myConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TextBox_PackName_Change(object sender, EventArgs e)
        {
            if (TextBox_CategoryName.Text.Length > 0)
                ButtonOK.Enabled = true;
            else
                ButtonOK.Enabled = false;
        }

        private void FormCategories_NewEdit_Show(object sender, EventArgs e)
        {

        }
    }
}
