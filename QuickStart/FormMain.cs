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
    public partial class FormMain : Form
    {

        
        List<int> ItemsIDs = new List<int>();
        List<string> ItemsExePaths = new List<string>();
        List<string> ItemsStartupDirs = new List<string>();
        List<string> ItemsParameters = new List<string>();
        List<int> ItemsCategoryIDs = new List<int>();
        List<string> ItemsNames = new List<string>();
        List<string> ItemsIconPaths = new List<string>();

        List<int> ShownItemsIDs = new List<int>();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Show(object sender, EventArgs e)
        {
            try
            {
                SqlConnection myConnection = new SqlConnection(ClassSystemActions.CommandString());
                myConnection.Open();

                SqlCommand myCommand = new SqlCommand("pr_GetCategories", myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = myCommand.ExecuteReader();

                ComboBoxCategories.Items.Clear();
                ClassSystemActions.CategoryIDs.Clear();
                ClassSystemActions.CategoryNames.Clear();

                ClassSystemActions.CategoryIDs.Add(0);
                ClassSystemActions.CategoryNames.Add("Всички");
                ComboBoxCategories.Items.Add("Всички");

                while (reader.Read())
                {
                    ClassSystemActions.CategoryIDs.Add((int)(reader["ID"]));
                    ClassSystemActions.CategoryNames.Add(Convert.ToString(reader["Name"]));
                    ComboBoxCategories.Items.Add(Convert.ToString(reader["Name"]));
                }
                reader.Close();

                myConnection.Close();

                ButtonItemEdit.Enabled = false;
                ButtonItemDelete.Enabled = false;

                QuickStart.Properties.Settings.Default.CategoryID = 0;
                QuickStart.Properties.Settings.Default.Save();

                myConnection.Open();
                myCommand.CommandText = "pr_GetItemsByCategoryID";
                myCommand.Connection = myConnection;
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("@CategoryID", 0);
                reader = myCommand.ExecuteReader();

                ImageList.Images.Clear();
                ListViewItems.Items.Clear();
                ItemsIDs.Clear();
                ItemsNames.Clear();
                ItemsExePaths.Clear();
                ItemsStartupDirs.Clear();
                ItemsIconPaths.Clear();
                ItemsParameters.Clear();
                ItemsCategoryIDs.Clear();

                while (reader.Read())
                {
                    ItemsIDs.Add((int)(reader["ID"]));
                    ItemsNames.Add((string)(reader["Name"]));
                    ItemsExePaths.Add((string)(reader["ExePath"]));
                    ItemsStartupDirs.Add(Convert.ToString(reader["StartupDir"]));
                    ItemsIconPaths.Add(Convert.ToString(reader["IconPath"]));
                    ItemsParameters.Add(Convert.ToString(reader["Parameters"]));
                    ItemsCategoryIDs.Add(Convert.ToInt32(reader["CategoryID"]));
                    try
                    {
                        ImageList.Images.Add(Image.FromFile(Convert.ToString(reader["IconPath"])));
                    }
                    catch
                    {
                        try
                        {
                            ImageList.Images.Add(Icon.ExtractAssociatedIcon(Convert.ToString(reader["IconPath"])).ToBitmap());
                        }
                        catch
                        {
                            try
                            {
                                Bitmap bmp = new Bitmap(ListViewItems.LargeImageList.ImageSize.Width, ListViewItems.LargeImageList.ImageSize.Height);
                                using (Graphics gr = Graphics.FromImage(bmp)) {gr.Clear(Color.FromKnownColor(KnownColor.Window));}

                                ImageList.Images.Add(bmp);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                reader.Close();
                myConnection.Close();

                ComboBoxCategories.SelectedIndex = ClassSystemActions.CategoryIDs.IndexOf(QuickStart.Properties.Settings.Default.CategoryID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonCategoriesEdit_Click(object sender, EventArgs e)
        {
            FormCategoriesEdit frmCatedit = new FormCategoriesEdit();
            frmCatedit.ShowDialog();
            FormMain_Show(sender, e);
        }

        private void ListViewItems_DoubleClick(object sender, EventArgs e)
        {
            if (ListViewItems.SelectedItems.Count > 0)
            {
                if (Directory.Exists(ItemsStartupDirs[ShownItemsIDs[ListViewItems.SelectedIndices[0]]]))
                    Directory.SetCurrentDirectory(ItemsStartupDirs[ShownItemsIDs[ListViewItems.SelectedIndices[0]]]);
                System.Diagnostics.Process.Start(ItemsExePaths[ShownItemsIDs[ListViewItems.SelectedIndices[0]]], ItemsParameters[ShownItemsIDs[ListViewItems.SelectedIndices[0]]]);
            }
        }

        private void ButtonItemNew_Click(object sender, EventArgs e)
        {
            FormLink_NewEdit frmLink = new FormLink_NewEdit();
            ClassSystemActions.ItemID = 0;

            foreach (string item in ComboBoxCategories.Items)
                frmLink.Categories.Add(item);

            foreach (int index in ClassSystemActions.CategoryIDs)
                frmLink.CategoryIDs.Add(index);

            ClassSystemActions.CategoryID = ClassSystemActions.CategoryIDs[ComboBoxCategories.SelectedIndex];

            if (frmLink.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //try
                //{
                //    SqlConnection myConnection = new SqlConnection(ClassSystemActions.CommandString());
                //    myConnection.Open();

                //    SqlCommand myCommand = new SqlCommand("pr_GetItem", myConnection);
                //    myCommand.CommandType = CommandType.StoredProcedure;
                //    myCommand.Parameters.AddWithValue("@ID", 0);
                //    SqlDataReader reader = myCommand.ExecuteReader();
                //    reader.Read();

                //    ItemsIDs.Add((int)reader["ID"]);
                //    ItemsNames.Add((string)reader["Name"]);
                //    ItemsExePaths.Add((string)reader["ExePath"]);
                //    ItemsStartupDirs.Add(Convert.ToString(reader["StartupDir"]));
                //    ItemsIconPaths.Add(Convert.ToString(reader["IconPath"]));
                //    try
                //    {
                //        ImageList.Images.Add(Image.FromFile(Convert.ToString(reader["IconPath"])));
                //    }
                //    catch
                //    {
                //        try
                //        {
                //            ImageList.Images.Add(Icon.ExtractAssociatedIcon(Convert.ToString(reader["IconPath"])).ToBitmap());
                //        }
                //        catch
                //        {
                //            try
                //            {
                //                Bitmap bmp = new Bitmap(32, 32);
                //                using (Graphics gr = Graphics.FromImage(bmp)) { gr.Clear(Color.FromKnownColor(KnownColor.Window)); }

                //                ImageList.Images.Add(bmp);
                //            }
                //            catch (Exception ex)
                //            {
                //                MessageBox.Show(ex.Message, "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //            }
                //        }
                //    }
                //    ItemsParameters.Add(Convert.ToString(reader["Parameters"]));
                //    ItemsCategoryIDs.Add(Convert.ToInt32(reader["CategoryID"]));

                //    reader.Close();
                //    myConnection.Close();

                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message, "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
                ItemsIDs.Add(ClassSystemActions.ItemID);
                ItemsNames.Add(ClassSystemActions.ItemName);
                ItemsExePaths.Add(ClassSystemActions.ExePath);
                ItemsStartupDirs.Add(ClassSystemActions.StartupDir);
                ItemsIconPaths.Add(ClassSystemActions.IconPath);

                try
                {
                    ImageList.Images.Add(Image.FromFile(Convert.ToString(ClassSystemActions.IconPath)));
                }
                catch
                {
                    try
                    {
                        ImageList.Images.Add(Icon.ExtractAssociatedIcon(Convert.ToString(ClassSystemActions.IconPath)).ToBitmap());
                    }
                    catch
                    {
                        try
                        {
                            Bitmap bmp = new Bitmap(ListViewItems.LargeImageList.ImageSize.Width, ListViewItems.LargeImageList.ImageSize.Height);
                            using (Graphics gr = Graphics.FromImage(bmp)) { gr.Clear(Color.FromKnownColor(KnownColor.Window)); }

                            ImageList.Images.Add(bmp);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

                ItemsParameters.Add(ClassSystemActions.Parameters);
                ItemsCategoryIDs.Add(ClassSystemActions.CategoryID);

                ShowItemsByCategoryID(ClassSystemActions.CategoryIDs.IndexOf(QuickStart.Properties.Settings.Default.CategoryID));

            }

        }

        private void ButtonItemEdit_Click(object sender, EventArgs e)
        {
            FormLink_NewEdit frmLink = new FormLink_NewEdit();
            ClassSystemActions.ItemID = ItemsIDs[ShownItemsIDs[ListViewItems.SelectedIndices[0]]];
            ClassSystemActions.ItemName = ItemsNames[ShownItemsIDs[ListViewItems.SelectedIndices[0]]];
            ClassSystemActions.ExePath = ItemsExePaths[ShownItemsIDs[ListViewItems.SelectedIndices[0]]];
            ClassSystemActions.StartupDir = ItemsStartupDirs[ShownItemsIDs[ListViewItems.SelectedIndices[0]]];
            ClassSystemActions.IconPath = ItemsIconPaths[ShownItemsIDs[ListViewItems.SelectedIndices[0]]];
            ClassSystemActions.Parameters = ItemsParameters[ShownItemsIDs[ListViewItems.SelectedIndices[0]]];
            ClassSystemActions.CategoryID = ItemsCategoryIDs[ShownItemsIDs[ListViewItems.SelectedIndices[0]]];

            foreach (string item in ComboBoxCategories.Items)
                frmLink.Categories.Add(item);

            foreach (int index in ClassSystemActions.CategoryIDs)
                frmLink.CategoryIDs.Add(index);

            if (frmLink.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                ItemsNames[ShownItemsIDs[ListViewItems.SelectedIndices[0]]] = ClassSystemActions.ItemName;
                ItemsExePaths[ShownItemsIDs[ListViewItems.SelectedIndices[0]]] = ClassSystemActions.ExePath;
                ItemsStartupDirs[ShownItemsIDs[ListViewItems.SelectedIndices[0]]] = ClassSystemActions.StartupDir;
                ItemsIconPaths[ShownItemsIDs[ListViewItems.SelectedIndices[0]]] = ClassSystemActions.IconPath;

                try
                {
                    ImageList.Images[ShownItemsIDs[ListViewItems.SelectedIndices[0]]] = Image.FromFile(Convert.ToString(ClassSystemActions.IconPath));
                }
                catch
                {
                    try
                    {
                        ImageList.Images[ShownItemsIDs[ListViewItems.SelectedIndices[0]]] = Icon.ExtractAssociatedIcon(Convert.ToString(ClassSystemActions.IconPath)).ToBitmap();
                    }
                    catch
                    {
                        try
                        {
                            Bitmap bmp = new Bitmap(ListViewItems.LargeImageList.ImageSize.Width, ListViewItems.LargeImageList.ImageSize.Height);
                            using (Graphics gr = Graphics.FromImage(bmp)) { gr.Clear(Color.FromKnownColor(KnownColor.Window)); }

                            ImageList.Images[ShownItemsIDs[ListViewItems.SelectedIndices[0]]] = bmp;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

                ItemsParameters[ShownItemsIDs[ListViewItems.SelectedIndices[0]]] = ClassSystemActions.Parameters;
                ItemsCategoryIDs[ShownItemsIDs[ListViewItems.SelectedIndices[0]]] = ClassSystemActions.CategoryID;

                ShowItemsByCategoryID(ClassSystemActions.CategoryIDs.IndexOf(QuickStart.Properties.Settings.Default.CategoryID));
            }

        }

        private void ComboBoxCategories_Change(object sender, EventArgs e)
        {
            QuickStart.Properties.Settings.Default.CategoryID = ClassSystemActions.CategoryIDs[ComboBoxCategories.SelectedIndex];
            QuickStart.Properties.Settings.Default.Save();

            ShowItemsByCategoryID(QuickStart.Properties.Settings.Default.CategoryID);
        }

        private void ListViewItems_Click(object sender, EventArgs e)
        {
            if (ListViewItems.SelectedItems.Count > 0)
            {
                ButtonItemEdit.Enabled = true;
                ButtonItemDelete.Enabled = true;
            }
            else
            {
                ButtonItemEdit.Enabled = false;
                ButtonItemDelete.Enabled = false;
            }
        }

        private void ComboBoxCategories_Click(object sender, EventArgs e)
        {
            ButtonItemEdit.Enabled = false;
            ButtonItemDelete.Enabled = false;
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                NotifyIcon.Visible = true;
            }
        }

        private void NotifyIcon_DblClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            NotifyIcon.Visible = false;
        }

        private void ButtonItemDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Наистина ли желаете да изтриете избраната връзка ?", "ВНИМАНИЕ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    SqlConnection myConnection = new SqlConnection(ClassSystemActions.CommandString());
                    myConnection.Open();

                    SqlCommand myCommand = new SqlCommand("pr_DeleteItem", myConnection);
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.AddWithValue("@ID", ItemsIDs[ShownItemsIDs[ListViewItems.SelectedIndices[0]]]);
                    myCommand.ExecuteNonQuery();

                    ImageList.Images.RemoveAt(ShownItemsIDs[ListViewItems.SelectedIndices[0]]);
                    ItemsIDs.RemoveAt(ShownItemsIDs[ListViewItems.SelectedIndices[0]]);
                    ItemsNames.RemoveAt(ShownItemsIDs[ListViewItems.SelectedIndices[0]]);
                    ItemsExePaths.RemoveAt(ShownItemsIDs[ListViewItems.SelectedIndices[0]]);
                    ItemsStartupDirs.RemoveAt(ShownItemsIDs[ListViewItems.SelectedIndices[0]]);
                    ItemsIconPaths.RemoveAt(ShownItemsIDs[ListViewItems.SelectedIndices[0]]);
                    ItemsParameters.RemoveAt(ShownItemsIDs[ListViewItems.SelectedIndices[0]]);
                    ItemsCategoryIDs.RemoveAt(ShownItemsIDs[ListViewItems.SelectedIndices[0]]);

                    ListViewItems.Items.RemoveAt(ShownItemsIDs[ListViewItems.SelectedIndices[0]]);
                    myConnection.Close();

                    ShowItemsByCategoryID(QuickStart.Properties.Settings.Default.CategoryID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ShowItemsByCategoryID(int CategoryID)
        {
            ShownItemsIDs.Clear();
            ListViewItems.Items.Clear();

            for (int i = 0; i < ItemsIDs.Count; i++)
            {
                if (ItemsCategoryIDs[i] == CategoryID || CategoryID == 0)
                {
                    ShownItemsIDs.Add(i);
                    ListViewItems.Items.Add(ItemsNames[i], i);
                }
            }
        }

        private void ContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            ContextMenuStrip.Items.Clear();
        }

    }
}
