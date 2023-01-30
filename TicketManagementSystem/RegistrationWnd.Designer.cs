namespace TicketManagementSystem
{
    partial class RegistrationWnd
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
            this.lbRegistration = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.lbAge = new System.Windows.Forms.Label();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnSighUp = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRegistration
            // 
            this.lbRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRegistration.Location = new System.Drawing.Point(12, 9);
            this.lbRegistration.Name = "lbRegistration";
            this.lbRegistration.Size = new System.Drawing.Size(426, 37);
            this.lbRegistration.TabIndex = 0;
            this.lbRegistration.Text = "Account Registration!";
            this.lbRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(12, 69);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(117, 31);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name:";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSurname
            // 
            this.lbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSurname.Location = new System.Drawing.Point(13, 116);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(116, 31);
            this.lbSurname.TabIndex = 1;
            this.lbSurname.Text = "Surname:";
            this.lbSurname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(144, 69);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(289, 31);
            this.tbName.TabIndex = 2;
            // 
            // tbSurname
            // 
            this.tbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSurname.Location = new System.Drawing.Point(144, 116);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(289, 31);
            this.tbSurname.TabIndex = 2;
            // 
            // lbAge
            // 
            this.lbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAge.Location = new System.Drawing.Point(13, 161);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(116, 31);
            this.lbAge.TabIndex = 3;
            this.lbAge.Text = "Age:";
            this.lbAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numAge
            // 
            this.numAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numAge.Location = new System.Drawing.Point(144, 162);
            this.numAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(105, 31);
            this.numAge.TabIndex = 4;
            this.numAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbEmail
            // 
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEmail.Location = new System.Drawing.Point(12, 233);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(116, 31);
            this.lbEmail.TabIndex = 3;
            this.lbEmail.Text = "Email:";
            this.lbEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEmail.Location = new System.Drawing.Point(144, 233);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(289, 31);
            this.tbEmail.TabIndex = 2;
            // 
            // lbPassword
            // 
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPassword.Location = new System.Drawing.Point(12, 325);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(116, 31);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Password:";
            this.lbPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.Location = new System.Drawing.Point(144, 325);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(289, 31);
            this.tbPassword.TabIndex = 2;
            // 
            // btnSighUp
            // 
            this.btnSighUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSighUp.Location = new System.Drawing.Point(306, 375);
            this.btnSighUp.Name = "btnSighUp";
            this.btnSighUp.Size = new System.Drawing.Size(127, 37);
            this.btnSighUp.TabIndex = 5;
            this.btnSighUp.Text = "Sign up";
            this.btnSighUp.UseVisualStyleBackColor = true;
            this.btnSighUp.Click += new System.EventHandler(this.btnSighUp_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUsername.Location = new System.Drawing.Point(144, 279);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(289, 31);
            this.tbUsername.TabIndex = 2;
            // 
            // lbUsername
            // 
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUsername.Location = new System.Drawing.Point(12, 279);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(116, 31);
            this.lbUsername.TabIndex = 3;
            this.lbUsername.Text = "Username:";
            this.lbUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RegistrationWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 426);
            this.Controls.Add(this.btnSighUp);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbSurname);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbRegistration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RegistrationWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRegistration;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnSighUp;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lbUsername;
    }
}