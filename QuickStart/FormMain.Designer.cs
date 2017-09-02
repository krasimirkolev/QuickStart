namespace QuickStart
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ButtonCategoriesEdit = new System.Windows.Forms.Button();
            this.ButtonItemNew = new System.Windows.Forms.Button();
            this.ListViewItems = new System.Windows.Forms.ListView();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.ComboBoxCategories = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonItemEdit = new System.Windows.Forms.Button();
            this.ButtonItemDelete = new System.Windows.Forms.Button();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // ButtonCategoriesEdit
            // 
            this.ButtonCategoriesEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonCategoriesEdit.Location = new System.Drawing.Point(12, 482);
            this.ButtonCategoriesEdit.Name = "ButtonCategoriesEdit";
            this.ButtonCategoriesEdit.Size = new System.Drawing.Size(100, 23);
            this.ButtonCategoriesEdit.TabIndex = 0;
            this.ButtonCategoriesEdit.Text = "Категории";
            this.ButtonCategoriesEdit.UseVisualStyleBackColor = true;
            this.ButtonCategoriesEdit.Click += new System.EventHandler(this.ButtonCategoriesEdit_Click);
            // 
            // ButtonItemNew
            // 
            this.ButtonItemNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonItemNew.Location = new System.Drawing.Point(12, 453);
            this.ButtonItemNew.Name = "ButtonItemNew";
            this.ButtonItemNew.Size = new System.Drawing.Size(100, 23);
            this.ButtonItemNew.TabIndex = 1;
            this.ButtonItemNew.Text = "Нова връзка";
            this.ButtonItemNew.UseVisualStyleBackColor = true;
            this.ButtonItemNew.Click += new System.EventHandler(this.ButtonItemNew_Click);
            // 
            // ListViewItems
            // 
            this.ListViewItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListViewItems.LargeImageList = this.ImageList;
            this.ListViewItems.Location = new System.Drawing.Point(12, 39);
            this.ListViewItems.MultiSelect = false;
            this.ListViewItems.Name = "ListViewItems";
            this.ListViewItems.Size = new System.Drawing.Size(334, 408);
            this.ListViewItems.TabIndex = 2;
            this.ListViewItems.UseCompatibleStateImageBehavior = false;
            this.ListViewItems.SelectedIndexChanged += new System.EventHandler(this.ListViewItems_Click);
            this.ListViewItems.DoubleClick += new System.EventHandler(this.ListViewItems_DoubleClick);
            // 
            // ImageList
            // 
            this.ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.ImageList.ImageSize = new System.Drawing.Size(32, 32);
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ComboBoxCategories
            // 
            this.ComboBoxCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCategories.FormattingEnabled = true;
            this.ComboBoxCategories.Location = new System.Drawing.Point(75, 12);
            this.ComboBoxCategories.Name = "ComboBoxCategories";
            this.ComboBoxCategories.Size = new System.Drawing.Size(271, 21);
            this.ComboBoxCategories.TabIndex = 3;
            this.ComboBoxCategories.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCategories_Change);
            this.ComboBoxCategories.Click += new System.EventHandler(this.ComboBoxCategories_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Категория";
            // 
            // ButtonItemEdit
            // 
            this.ButtonItemEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonItemEdit.Location = new System.Drawing.Point(130, 453);
            this.ButtonItemEdit.Name = "ButtonItemEdit";
            this.ButtonItemEdit.Size = new System.Drawing.Size(100, 23);
            this.ButtonItemEdit.TabIndex = 5;
            this.ButtonItemEdit.Text = "Ред. връзка";
            this.ButtonItemEdit.UseVisualStyleBackColor = true;
            this.ButtonItemEdit.Click += new System.EventHandler(this.ButtonItemEdit_Click);
            // 
            // ButtonItemDelete
            // 
            this.ButtonItemDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonItemDelete.Location = new System.Drawing.Point(246, 453);
            this.ButtonItemDelete.Name = "ButtonItemDelete";
            this.ButtonItemDelete.Size = new System.Drawing.Size(100, 23);
            this.ButtonItemDelete.TabIndex = 6;
            this.ButtonItemDelete.Text = "Изтрий връзка";
            this.ButtonItemDelete.UseVisualStyleBackColor = true;
            this.ButtonItemDelete.Click += new System.EventHandler(this.ButtonItemDelete_Click);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.ContextMenuStrip = this.ContextMenuStrip;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "QuickStart";
            this.NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_DblClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 519);
            this.Controls.Add(this.ButtonItemDelete);
            this.Controls.Add(this.ButtonItemEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxCategories);
            this.Controls.Add(this.ListViewItems);
            this.Controls.Add(this.ButtonItemNew);
            this.Controls.Add(this.ButtonCategoriesEdit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(345, 546);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuickStart";
            this.Shown += new System.EventHandler(this.FormMain_Show);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCategoriesEdit;
        private System.Windows.Forms.Button ButtonItemNew;
        private System.Windows.Forms.ListView ListViewItems;
        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.ComboBox ComboBoxCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonItemEdit;
        private System.Windows.Forms.Button ButtonItemDelete;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
    }
}

