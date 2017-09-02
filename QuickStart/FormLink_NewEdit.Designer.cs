namespace QuickStart
{
    partial class FormLink_NewEdit
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
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelExePath = new System.Windows.Forms.Label();
            this.LabelParameters = new System.Windows.Forms.Label();
            this.LabelIconPath = new System.Windows.Forms.Label();
            this.TextBox_Name = new System.Windows.Forms.TextBox();
            this.TextBox_ExePath = new System.Windows.Forms.TextBox();
            this.TextBox_IconPath = new System.Windows.Forms.TextBox();
            this.ComboBoxCategories = new System.Windows.Forms.ComboBox();
            this.LabelCategory = new System.Windows.Forms.Label();
            this.TextBox_Parameters = new System.Windows.Forms.TextBox();
            this.OpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.Button_ExePath = new System.Windows.Forms.Button();
            this.Button_IconPath = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.Button_StartupDir = new System.Windows.Forms.Button();
            this.TextBox_StartupDir = new System.Windows.Forms.TextBox();
            this.LabelStartupDir = new System.Windows.Forms.Label();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelName.Location = new System.Drawing.Point(12, 15);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(32, 13);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Име";
            // 
            // LabelExePath
            // 
            this.LabelExePath.AutoSize = true;
            this.LabelExePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelExePath.Location = new System.Drawing.Point(12, 41);
            this.LabelExePath.Name = "LabelExePath";
            this.LabelExePath.Size = new System.Drawing.Size(133, 13);
            this.LabelExePath.TabIndex = 1;
            this.LabelExePath.Text = "Файл за изпълнение";
            // 
            // LabelParameters
            // 
            this.LabelParameters.AutoSize = true;
            this.LabelParameters.Location = new System.Drawing.Point(12, 119);
            this.LabelParameters.Name = "LabelParameters";
            this.LabelParameters.Size = new System.Drawing.Size(64, 13);
            this.LabelParameters.TabIndex = 2;
            this.LabelParameters.Text = "Параметри";
            // 
            // LabelIconPath
            // 
            this.LabelIconPath.AutoSize = true;
            this.LabelIconPath.Location = new System.Drawing.Point(12, 93);
            this.LabelIconPath.Name = "LabelIconPath";
            this.LabelIconPath.Size = new System.Drawing.Size(39, 13);
            this.LabelIconPath.TabIndex = 3;
            this.LabelIconPath.Text = "Икона";
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.Location = new System.Drawing.Point(151, 12);
            this.TextBox_Name.MaxLength = 50;
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.Size = new System.Drawing.Size(231, 20);
            this.TextBox_Name.TabIndex = 1;
            this.TextBox_Name.TextChanged += new System.EventHandler(this.MandatoryItem_Change);
            // 
            // TextBox_ExePath
            // 
            this.TextBox_ExePath.Location = new System.Drawing.Point(151, 38);
            this.TextBox_ExePath.Name = "TextBox_ExePath";
            this.TextBox_ExePath.ReadOnly = true;
            this.TextBox_ExePath.Size = new System.Drawing.Size(200, 20);
            this.TextBox_ExePath.TabIndex = 5;
            this.TextBox_ExePath.TabStop = false;
            this.TextBox_ExePath.TextChanged += new System.EventHandler(this.MandatoryItem_Change);
            // 
            // TextBox_IconPath
            // 
            this.TextBox_IconPath.Location = new System.Drawing.Point(151, 90);
            this.TextBox_IconPath.Name = "TextBox_IconPath";
            this.TextBox_IconPath.ReadOnly = true;
            this.TextBox_IconPath.Size = new System.Drawing.Size(200, 20);
            this.TextBox_IconPath.TabIndex = 6;
            this.TextBox_IconPath.TabStop = false;
            // 
            // ComboBoxCategories
            // 
            this.ComboBoxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCategories.FormattingEnabled = true;
            this.ComboBoxCategories.Location = new System.Drawing.Point(151, 142);
            this.ComboBoxCategories.Name = "ComboBoxCategories";
            this.ComboBoxCategories.Size = new System.Drawing.Size(231, 21);
            this.ComboBoxCategories.TabIndex = 6;
            // 
            // LabelCategory
            // 
            this.LabelCategory.AutoSize = true;
            this.LabelCategory.Location = new System.Drawing.Point(12, 145);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(60, 13);
            this.LabelCategory.TabIndex = 8;
            this.LabelCategory.Text = "Категория";
            // 
            // TextBox_Parameters
            // 
            this.TextBox_Parameters.Location = new System.Drawing.Point(151, 116);
            this.TextBox_Parameters.MaxLength = 50;
            this.TextBox_Parameters.Name = "TextBox_Parameters";
            this.TextBox_Parameters.Size = new System.Drawing.Size(231, 20);
            this.TextBox_Parameters.TabIndex = 5;
            // 
            // OpenDialog
            // 
            this.OpenDialog.InitialDirectory = "%MyDocuments%";
            this.OpenDialog.RestoreDirectory = true;
            this.OpenDialog.ShowReadOnly = true;
            this.OpenDialog.SupportMultiDottedExtensions = true;
            // 
            // Button_ExePath
            // 
            this.Button_ExePath.Location = new System.Drawing.Point(357, 37);
            this.Button_ExePath.Name = "Button_ExePath";
            this.Button_ExePath.Size = new System.Drawing.Size(25, 20);
            this.Button_ExePath.TabIndex = 2;
            this.Button_ExePath.Text = "...";
            this.Button_ExePath.UseVisualStyleBackColor = true;
            this.Button_ExePath.Click += new System.EventHandler(this.Button_ExePath_Click);
            // 
            // Button_IconPath
            // 
            this.Button_IconPath.Location = new System.Drawing.Point(357, 90);
            this.Button_IconPath.Name = "Button_IconPath";
            this.Button_IconPath.Size = new System.Drawing.Size(25, 20);
            this.Button_IconPath.TabIndex = 4;
            this.Button_IconPath.Text = "...";
            this.Button_IconPath.UseVisualStyleBackColor = true;
            this.Button_IconPath.Click += new System.EventHandler(this.Button_IconPath_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(397, 230);
            this.shapeContainer1.TabIndex = 12;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderWidth = 3;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 16;
            this.lineShape1.X2 = 380;
            this.lineShape1.Y1 = 178;
            this.lineShape1.Y2 = 178;
            // 
            // ButtonOK
            // 
            this.ButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOK.Enabled = false;
            this.ButtonOK.Location = new System.Drawing.Point(15, 192);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(100, 23);
            this.ButtonOK.TabIndex = 7;
            this.ButtonOK.Text = "ОК";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(282, 192);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(100, 23);
            this.ButtonCancel.TabIndex = 8;
            this.ButtonCancel.Text = "Отказ";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // Button_StartupDir
            // 
            this.Button_StartupDir.Location = new System.Drawing.Point(357, 63);
            this.Button_StartupDir.Name = "Button_StartupDir";
            this.Button_StartupDir.Size = new System.Drawing.Size(25, 20);
            this.Button_StartupDir.TabIndex = 3;
            this.Button_StartupDir.Text = "...";
            this.Button_StartupDir.UseVisualStyleBackColor = true;
            this.Button_StartupDir.Click += new System.EventHandler(this.Button_StartupDir_Click);
            // 
            // TextBox_StartupDir
            // 
            this.TextBox_StartupDir.Location = new System.Drawing.Point(151, 64);
            this.TextBox_StartupDir.Name = "TextBox_StartupDir";
            this.TextBox_StartupDir.ReadOnly = true;
            this.TextBox_StartupDir.Size = new System.Drawing.Size(200, 20);
            this.TextBox_StartupDir.TabIndex = 16;
            this.TextBox_StartupDir.TabStop = false;
            // 
            // LabelStartupDir
            // 
            this.LabelStartupDir.AutoSize = true;
            this.LabelStartupDir.Location = new System.Drawing.Point(12, 67);
            this.LabelStartupDir.Name = "LabelStartupDir";
            this.LabelStartupDir.Size = new System.Drawing.Size(106, 13);
            this.LabelStartupDir.TabIndex = 15;
            this.LabelStartupDir.Text = "Път за изпълнение";
            // 
            // FolderBrowserDialog
            // 
            this.FolderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // FormLink_NewEdit
            // 
            this.AcceptButton = this.ButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(397, 230);
            this.ControlBox = false;
            this.Controls.Add(this.Button_StartupDir);
            this.Controls.Add(this.TextBox_StartupDir);
            this.Controls.Add(this.LabelStartupDir);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.Button_IconPath);
            this.Controls.Add(this.Button_ExePath);
            this.Controls.Add(this.TextBox_Parameters);
            this.Controls.Add(this.LabelCategory);
            this.Controls.Add(this.ComboBoxCategories);
            this.Controls.Add(this.TextBox_IconPath);
            this.Controls.Add(this.TextBox_ExePath);
            this.Controls.Add(this.TextBox_Name);
            this.Controls.Add(this.LabelIconPath);
            this.Controls.Add(this.LabelParameters);
            this.Controls.Add(this.LabelExePath);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLink_NewEdit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLink_NewEdit";
            this.Shown += new System.EventHandler(this.FormLink_NewEdit_Show);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelExePath;
        private System.Windows.Forms.Label LabelParameters;
        private System.Windows.Forms.Label LabelIconPath;
        private System.Windows.Forms.TextBox TextBox_Name;
        private System.Windows.Forms.TextBox TextBox_ExePath;
        private System.Windows.Forms.TextBox TextBox_IconPath;
        private System.Windows.Forms.ComboBox ComboBoxCategories;
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.TextBox TextBox_Parameters;
        private System.Windows.Forms.OpenFileDialog OpenDialog;
        private System.Windows.Forms.Button Button_ExePath;
        private System.Windows.Forms.Button Button_IconPath;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button Button_StartupDir;
        private System.Windows.Forms.TextBox TextBox_StartupDir;
        private System.Windows.Forms.Label LabelStartupDir;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
    }
}