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
    public partial class FormCategoriesEdit : Form
    {

        public FormCategoriesEdit()
        {
            InitializeComponent();
        }

        private void FormCategoriesEdit_Show(object sender, EventArgs e)
        {
            try
            {
                ListBox_Categories.Items.Clear();
                ListBox_Categories.Items.AddRange(ClassSystemActions.CategoryNames.ToArray());
                
                if (ListBox_Categories.Items.Count > 1)
                {
                    this.ButtonEdit.Enabled = true;
                    this.ButtonDelete.Enabled = true;
                    ListBox_Categories.SelectedIndex = 0;
                }
                else
                {
                    this.ButtonEdit.Enabled = false;
                    this.ButtonDelete.Enabled = false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            FormCategories_NewEdit frmCatnewedit = new FormCategories_NewEdit();
            frmCatnewedit.CatID = 0;
            if (frmCatnewedit.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                this.FormCategoriesEdit_Show(sender, e);
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            FormCategories_NewEdit frmCatnewedit = new FormCategories_NewEdit();
            frmCatnewedit.CatID = ClassSystemActions.CategoryIDs[ListBox_Categories.SelectedIndex];
            frmCatnewedit.TextBox_CategoryName.Text = Convert.ToString(ListBox_Categories.Items[ListBox_Categories.SelectedIndex]);
            if (frmCatnewedit.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                this.FormCategoriesEdit_Show(sender, e);
        }

        private void ListBox_Categories_Change(object sender, EventArgs e)
        {
            if (ListBox_Categories.SelectedIndex == 0)
            {
                this.ButtonEdit.Enabled = false;
                this.ButtonDelete.Enabled = false;
            }
            else
            {
                this.ButtonEdit.Enabled = true;
                this.ButtonDelete.Enabled = true;
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Наистина ли желаете да изтриете избраната категория ?", "ВНИМАНИЕ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    SqlConnection myConnection = new SqlConnection(ClassSystemActions.CommandString());
                    myConnection.Open();

                    SqlCommand myCommand = new SqlCommand("pr_DeleteCategory", myConnection);
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.AddWithValue("@ID", ClassSystemActions.CategoryIDs[ListBox_Categories.SelectedIndex]);

                    myCommand.ExecuteNonQuery();

                    myConnection.Close();

                    ClassSystemActions.CategoryNames.RemoveAt(ListBox_Categories.SelectedIndex);
                    ClassSystemActions.CategoryIDs.RemoveAt(ListBox_Categories.SelectedIndex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                FormCategoriesEdit_Show(sender, e);
            }
        }

    }
}
