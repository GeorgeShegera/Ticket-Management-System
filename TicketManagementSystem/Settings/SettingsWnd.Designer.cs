namespace TicketManagementSystem
{
    partial class SettingsWnd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWnd));
            this.lbSettings = new System.Windows.Forms.Label();
            this.gbPersonalData = new System.Windows.Forms.GroupBox();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.pbBirthDate = new System.Windows.Forms.PictureBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.pbSurname = new System.Windows.Forms.PictureBox();
            this.pbName = new System.Windows.Forms.PictureBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.lbBirth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.gbAccountData = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.pbNewPass = new System.Windows.Forms.PictureBox();
            this.tbOldPass = new System.Windows.Forms.TextBox();
            this.lbNewPassword = new System.Windows.Forms.Label();
            this.pbOldPass = new System.Windows.Forms.PictureBox();
            this.lbOldPassword = new System.Windows.Forms.Label();
            this.gbPersonalData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBirthDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSurname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbName)).BeginInit();
            this.gbAccountData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOldPass)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSettings
            // 
            this.lbSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSettings.Location = new System.Drawing.Point(12, 9);
            this.lbSettings.Name = "lbSettings";
            this.lbSettings.Size = new System.Drawing.Size(113, 35);
            this.lbSettings.TabIndex = 2;
            this.lbSettings.Text = "Settings";
            this.lbSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbPersonalData
            // 
            this.gbPersonalData.Controls.Add(this.dtpBirth);
            this.gbPersonalData.Controls.Add(this.pbBirthDate);
            this.gbPersonalData.Controls.Add(this.tbName);
            this.gbPersonalData.Controls.Add(this.pbSurname);
            this.gbPersonalData.Controls.Add(this.pbName);
            this.gbPersonalData.Controls.Add(this.tbSurname);
            this.gbPersonalData.Controls.Add(this.lbBirth);
            this.gbPersonalData.Controls.Add(this.label1);
            this.gbPersonalData.Controls.Add(this.lbName);
            this.gbPersonalData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbPersonalData.Location = new System.Drawing.Point(12, 57);
            this.gbPersonalData.Name = "gbPersonalData";
            this.gbPersonalData.Size = new System.Drawing.Size(525, 158);
            this.gbPersonalData.TabIndex = 3;
            this.gbPersonalData.TabStop = false;
            this.gbPersonalData.Text = "Personal Data";
            // 
            // dtpBirth
            // 
            this.dtpBirth.Enabled = false;
            this.dtpBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirth.Location = new System.Drawing.Point(161, 107);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(150, 31);
            this.dtpBirth.TabIndex = 7;
            this.dtpBirth.Tag = "BirthDate";
            this.dtpBirth.Value = new System.DateTime(2023, 2, 13, 0, 0, 0, 0);
            this.dtpBirth.ValueChanged += new System.EventHandler(this.AccountData_Changed);
            // 
            // pbBirthDate
            // 
            this.pbBirthDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbBirthDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBirthDate.Image = ((System.Drawing.Image)(resources.GetObject("pbBirthDate.Image")));
            this.pbBirthDate.Location = new System.Drawing.Point(317, 107);
            this.pbBirthDate.Name = "pbBirthDate";
            this.pbBirthDate.Size = new System.Drawing.Size(34, 31);
            this.pbBirthDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBirthDate.TabIndex = 4;
            this.pbBirthDate.TabStop = false;
            this.pbBirthDate.Tag = "BirthDate";
            this.pbBirthDate.Click += new System.EventHandler(this.Edit_Changed);
            // 
            // tbName
            // 
            this.tbName.Enabled = false;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(161, 33);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(314, 31);
            this.tbName.TabIndex = 1;
            this.tbName.Tag = "Name";
            this.tbName.TextChanged += new System.EventHandler(this.AccountData_Changed);
            // 
            // pbSurname
            // 
            this.pbSurname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbSurname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSurname.Image = ((System.Drawing.Image)(resources.GetObject("pbSurname.Image")));
            this.pbSurname.Location = new System.Drawing.Point(481, 70);
            this.pbSurname.Name = "pbSurname";
            this.pbSurname.Size = new System.Drawing.Size(34, 31);
            this.pbSurname.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSurname.TabIndex = 4;
            this.pbSurname.TabStop = false;
            this.pbSurname.Tag = "Surname";
            this.pbSurname.Click += new System.EventHandler(this.Edit_Changed);
            // 
            // pbName
            // 
            this.pbName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbName.ErrorImage = null;
            this.pbName.Image = ((System.Drawing.Image)(resources.GetObject("pbName.Image")));
            this.pbName.Location = new System.Drawing.Point(481, 33);
            this.pbName.Name = "pbName";
            this.pbName.Size = new System.Drawing.Size(34, 31);
            this.pbName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbName.TabIndex = 4;
            this.pbName.TabStop = false;
            this.pbName.Tag = "Name";
            this.pbName.Click += new System.EventHandler(this.Edit_Changed);
            // 
            // tbSurname
            // 
            this.tbSurname.Enabled = false;
            this.tbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSurname.Location = new System.Drawing.Point(161, 70);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(314, 31);
            this.tbSurname.TabIndex = 1;
            this.tbSurname.Tag = "Surname";
            this.tbSurname.TextChanged += new System.EventHandler(this.AccountData_Changed);
            // 
            // lbBirth
            // 
            this.lbBirth.BackColor = System.Drawing.SystemColors.Control;
            this.lbBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBirth.Location = new System.Drawing.Point(11, 107);
            this.lbBirth.Name = "lbBirth";
            this.lbBirth.Size = new System.Drawing.Size(144, 31);
            this.lbBirth.TabIndex = 0;
            this.lbBirth.Text = "Date of Birth:";
            this.lbBirth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Surname:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(11, 34);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(144, 30);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name:";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbAccountData
            // 
            this.gbAccountData.Controls.Add(this.btnSave);
            this.gbAccountData.Controls.Add(this.tbNewPass);
            this.gbAccountData.Controls.Add(this.pbNewPass);
            this.gbAccountData.Controls.Add(this.tbOldPass);
            this.gbAccountData.Controls.Add(this.lbNewPassword);
            this.gbAccountData.Controls.Add(this.pbOldPass);
            this.gbAccountData.Controls.Add(this.lbOldPassword);
            this.gbAccountData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbAccountData.Location = new System.Drawing.Point(12, 234);
            this.gbAccountData.Name = "gbAccountData";
            this.gbAccountData.Size = new System.Drawing.Size(525, 154);
            this.gbAccountData.TabIndex = 6;
            this.gbAccountData.TabStop = false;
            this.gbAccountData.Text = "Account Data";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(430, 111);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 37);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbNewPass
            // 
            this.tbNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNewPass.Location = new System.Drawing.Point(226, 74);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.Size = new System.Drawing.Size(249, 31);
            this.tbNewPass.TabIndex = 6;
            this.tbNewPass.Tag = "NewPass";
            this.tbNewPass.UseSystemPasswordChar = true;
            // 
            // pbNewPass
            // 
            this.pbNewPass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbNewPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbNewPass.Image = ((System.Drawing.Image)(resources.GetObject("pbNewPass.Image")));
            this.pbNewPass.Location = new System.Drawing.Point(481, 74);
            this.pbNewPass.Name = "pbNewPass";
            this.pbNewPass.Size = new System.Drawing.Size(34, 31);
            this.pbNewPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNewPass.TabIndex = 5;
            this.pbNewPass.TabStop = false;
            this.pbNewPass.Tag = "NewPass";
            this.pbNewPass.Click += new System.EventHandler(this.Visible_Click);
            // 
            // tbOldPass
            // 
            this.tbOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOldPass.Location = new System.Drawing.Point(226, 37);
            this.tbOldPass.Name = "tbOldPass";
            this.tbOldPass.Size = new System.Drawing.Size(249, 31);
            this.tbOldPass.TabIndex = 6;
            this.tbOldPass.Tag = "OldPass";
            this.tbOldPass.UseSystemPasswordChar = true;
            // 
            // lbNewPassword
            // 
            this.lbNewPassword.BackColor = System.Drawing.SystemColors.Control;
            this.lbNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNewPassword.Location = new System.Drawing.Point(11, 74);
            this.lbNewPassword.Name = "lbNewPassword";
            this.lbNewPassword.Size = new System.Drawing.Size(209, 31);
            this.lbNewPassword.TabIndex = 0;
            this.lbNewPassword.Text = "Input new password:";
            this.lbNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbOldPass
            // 
            this.pbOldPass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbOldPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbOldPass.Image = ((System.Drawing.Image)(resources.GetObject("pbOldPass.Image")));
            this.pbOldPass.Location = new System.Drawing.Point(481, 37);
            this.pbOldPass.Name = "pbOldPass";
            this.pbOldPass.Size = new System.Drawing.Size(34, 31);
            this.pbOldPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOldPass.TabIndex = 5;
            this.pbOldPass.TabStop = false;
            this.pbOldPass.Tag = "OldPass";
            this.pbOldPass.Click += new System.EventHandler(this.Visible_Click);
            // 
            // lbOldPassword
            // 
            this.lbOldPassword.BackColor = System.Drawing.SystemColors.Control;
            this.lbOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbOldPassword.Location = new System.Drawing.Point(11, 37);
            this.lbOldPassword.Name = "lbOldPassword";
            this.lbOldPassword.Size = new System.Drawing.Size(209, 31);
            this.lbOldPassword.TabIndex = 0;
            this.lbOldPassword.Text = "Input old password:";
            this.lbOldPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SettingsWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 396);
            this.Controls.Add(this.gbAccountData);
            this.Controls.Add(this.gbPersonalData);
            this.Controls.Add(this.lbSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SettingsWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.gbPersonalData.ResumeLayout(false);
            this.gbPersonalData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBirthDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSurname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbName)).EndInit();
            this.gbAccountData.ResumeLayout(false);
            this.gbAccountData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOldPass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbSettings;
        private System.Windows.Forms.GroupBox gbPersonalData;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbSurname;
        private System.Windows.Forms.PictureBox pbOldPass;
        private System.Windows.Forms.PictureBox pbBirthDate;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.PictureBox pbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label lbBirth;
        private System.Windows.Forms.GroupBox gbAccountData;
        private System.Windows.Forms.Label lbOldPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbNewPass;
        private System.Windows.Forms.PictureBox pbNewPass;
        private System.Windows.Forms.TextBox tbOldPass;
        private System.Windows.Forms.Label lbNewPassword;
        private System.Windows.Forms.DateTimePicker dtpBirth;
    }
}