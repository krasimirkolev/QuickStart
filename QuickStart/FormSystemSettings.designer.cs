namespace QuickStart
{
    partial class FormSystemSettings
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
            this.ButtonOK = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBox_CoreHost = new System.Windows.Forms.TextBox();
            this.TextBox_CoreUsername = new System.Windows.Forms.TextBox();
            this.TextBox_CoreDatabase = new System.Windows.Forms.TextBox();
            this.TextBox_CoreTimeout = new System.Windows.Forms.NumericUpDown();
            this.TextBox_CorePassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox_CoreTimeout)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonOK
            // 
            this.ButtonOK.Location = new System.Drawing.Point(12, 148);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(100, 23);
            this.ButtonOK.TabIndex = 6;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(168, 148);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(100, 23);
            this.ButtonCancel.TabIndex = 7;
            this.ButtonCancel.Text = "Отказ/Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сървър/Host:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Потребител/Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Парола/Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "База данни/Database:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Време за чакане/Connection timeout:";
            // 
            // TextBox_CoreHost
            // 
            this.TextBox_CoreHost.Location = new System.Drawing.Point(141, 7);
            this.TextBox_CoreHost.Name = "TextBox_CoreHost";
            this.TextBox_CoreHost.Size = new System.Drawing.Size(129, 20);
            this.TextBox_CoreHost.TabIndex = 1;
            // 
            // TextBox_CoreUsername
            // 
            this.TextBox_CoreUsername.Location = new System.Drawing.Point(141, 33);
            this.TextBox_CoreUsername.Name = "TextBox_CoreUsername";
            this.TextBox_CoreUsername.Size = new System.Drawing.Size(129, 20);
            this.TextBox_CoreUsername.TabIndex = 2;
            // 
            // TextBox_CoreDatabase
            // 
            this.TextBox_CoreDatabase.Location = new System.Drawing.Point(141, 86);
            this.TextBox_CoreDatabase.Name = "TextBox_CoreDatabase";
            this.TextBox_CoreDatabase.Size = new System.Drawing.Size(129, 20);
            this.TextBox_CoreDatabase.TabIndex = 4;
            // 
            // TextBox_CoreTimeout
            // 
            this.TextBox_CoreTimeout.Location = new System.Drawing.Point(210, 112);
            this.TextBox_CoreTimeout.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.TextBox_CoreTimeout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TextBox_CoreTimeout.Name = "TextBox_CoreTimeout";
            this.TextBox_CoreTimeout.Size = new System.Drawing.Size(60, 20);
            this.TextBox_CoreTimeout.TabIndex = 5;
            this.TextBox_CoreTimeout.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // TextBox_CorePassword
            // 
            this.TextBox_CorePassword.Location = new System.Drawing.Point(141, 59);
            this.TextBox_CorePassword.Name = "TextBox_CorePassword";
            this.TextBox_CorePassword.PasswordChar = '#';
            this.TextBox_CorePassword.Size = new System.Drawing.Size(129, 20);
            this.TextBox_CorePassword.TabIndex = 3;
            // 
            // FormSystemSettings
            // 
            this.AcceptButton = this.ButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(281, 185);
            this.ControlBox = false;
            this.Controls.Add(this.TextBox_CorePassword);
            this.Controls.Add(this.TextBox_CoreTimeout);
            this.Controls.Add(this.TextBox_CoreDatabase);
            this.Controls.Add(this.TextBox_CoreUsername);
            this.Controls.Add(this.TextBox_CoreHost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormSystemSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.Shown += new System.EventHandler(this.FormDatabaseConnection_Show);
            ((System.ComponentModel.ISupportInitialize)(this.TextBox_CoreTimeout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBox_CoreHost;
        private System.Windows.Forms.TextBox TextBox_CoreUsername;
        private System.Windows.Forms.TextBox TextBox_CoreDatabase;
        private System.Windows.Forms.NumericUpDown TextBox_CoreTimeout;
        private System.Windows.Forms.TextBox TextBox_CorePassword;
    }
}