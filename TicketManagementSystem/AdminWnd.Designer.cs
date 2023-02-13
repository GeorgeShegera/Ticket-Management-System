namespace TicketManagementSystem
{
    partial class AdminWnd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminWnd));
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnApplicationInfo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbUserData = new System.Windows.Forms.GroupBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbBirthDate = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbTrips = new System.Windows.Forms.ListBox();
            this.gbTrips = new System.Windows.Forms.GroupBox();
            this.btnEditTrip = new System.Windows.Forms.Button();
            this.btnCancelTrip = new System.Windows.Forms.Button();
            this.btnAddTrip = new System.Windows.Forms.Button();
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.gbUsers = new System.Windows.Forms.GroupBox();
            this.btnSellTicket = new System.Windows.Forms.Button();
            this.btnCancelTicket = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbUserData.SuspendLayout();
            this.gbTrips.SuspendLayout();
            this.gbUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOptions
            // 
            this.btnOptions.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.Location = new System.Drawing.Point(563, 77);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(231, 40);
            this.btnOptions.TabIndex = 1;
            this.btnOptions.Text = "Settings";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnApplicationInfo
            // 
            this.btnApplicationInfo.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplicationInfo.Location = new System.Drawing.Point(563, 31);
            this.btnApplicationInfo.Name = "btnApplicationInfo";
            this.btnApplicationInfo.Size = new System.Drawing.Size(231, 40);
            this.btnApplicationInfo.TabIndex = 2;
            this.btnApplicationInfo.Text = "Application Information ";
            this.btnApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // gbUserData
            // 
            this.gbUserData.Controls.Add(this.lbEmail);
            this.gbUserData.Controls.Add(this.lbBirthDate);
            this.gbUserData.Controls.Add(this.lbSurname);
            this.gbUserData.Controls.Add(this.lbName);
            this.gbUserData.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUserData.Location = new System.Drawing.Point(250, 10);
            this.gbUserData.Name = "gbUserData";
            this.gbUserData.Size = new System.Drawing.Size(285, 223);
            this.gbUserData.TabIndex = 4;
            this.gbUserData.TabStop = false;
            this.gbUserData.Text = "User Data";
            // 
            // lbEmail
            // 
            this.lbEmail.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(6, 153);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(274, 26);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email: ";
            this.lbEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbBirthDate
            // 
            this.lbBirthDate.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBirthDate.Location = new System.Drawing.Point(6, 117);
            this.lbBirthDate.Name = "lbBirthDate";
            this.lbBirthDate.Size = new System.Drawing.Size(274, 26);
            this.lbBirthDate.TabIndex = 0;
            this.lbBirthDate.Text = "Date of Birth:";
            this.lbBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSurname
            // 
            this.lbSurname.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSurname.Location = new System.Drawing.Point(6, 81);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(274, 26);
            this.lbSurname.TabIndex = 0;
            this.lbSurname.Text = "Surname:";
            this.lbSurname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(6, 46);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(274, 26);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name:";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(563, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "View Completed Trips";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbTrips
            // 
            this.lbTrips.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrips.FormattingEnabled = true;
            this.lbTrips.ItemHeight = 21;
            this.lbTrips.Location = new System.Drawing.Point(6, 23);
            this.lbTrips.Name = "lbTrips";
            this.lbTrips.Size = new System.Drawing.Size(353, 193);
            this.lbTrips.TabIndex = 6;
            // 
            // gbTrips
            // 
            this.gbTrips.Controls.Add(this.btnEditTrip);
            this.gbTrips.Controls.Add(this.btnCancelTrip);
            this.gbTrips.Controls.Add(this.btnAddTrip);
            this.gbTrips.Controls.Add(this.lbTrips);
            this.gbTrips.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTrips.Location = new System.Drawing.Point(12, 271);
            this.gbTrips.Name = "gbTrips";
            this.gbTrips.Size = new System.Drawing.Size(365, 276);
            this.gbTrips.TabIndex = 8;
            this.gbTrips.TabStop = false;
            this.gbTrips.Text = "Trips";
            // 
            // btnEditTrip
            // 
            this.btnEditTrip.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTrip.Location = new System.Drawing.Point(6, 233);
            this.btnEditTrip.Name = "btnEditTrip";
            this.btnEditTrip.Size = new System.Drawing.Size(102, 37);
            this.btnEditTrip.TabIndex = 7;
            this.btnEditTrip.Text = "Edit Trip";
            this.btnEditTrip.UseVisualStyleBackColor = true;
            // 
            // btnCancelTrip
            // 
            this.btnCancelTrip.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelTrip.Location = new System.Drawing.Point(146, 233);
            this.btnCancelTrip.Name = "btnCancelTrip";
            this.btnCancelTrip.Size = new System.Drawing.Size(105, 37);
            this.btnCancelTrip.TabIndex = 7;
            this.btnCancelTrip.Text = "Cancel Trip";
            this.btnCancelTrip.UseVisualStyleBackColor = true;
            // 
            // btnAddTrip
            // 
            this.btnAddTrip.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTrip.Location = new System.Drawing.Point(257, 233);
            this.btnAddTrip.Name = "btnAddTrip";
            this.btnAddTrip.Size = new System.Drawing.Size(102, 37);
            this.btnAddTrip.TabIndex = 7;
            this.btnAddTrip.Text = "Add Trip";
            this.btnAddTrip.UseVisualStyleBackColor = true;
            // 
            // lbUsers
            // 
            this.lbUsers.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.ItemHeight = 21;
            this.lbUsers.Location = new System.Drawing.Point(6, 23);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(353, 193);
            this.lbUsers.TabIndex = 9;
            // 
            // gbUsers
            // 
            this.gbUsers.BackColor = System.Drawing.Color.Transparent;
            this.gbUsers.Controls.Add(this.btnSellTicket);
            this.gbUsers.Controls.Add(this.btnCancelTicket);
            this.gbUsers.Controls.Add(this.btnAddUser);
            this.gbUsers.Controls.Add(this.lbUsers);
            this.gbUsers.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUsers.Location = new System.Drawing.Point(429, 271);
            this.gbUsers.Name = "gbUsers";
            this.gbUsers.Size = new System.Drawing.Size(365, 276);
            this.gbUsers.TabIndex = 10;
            this.gbUsers.TabStop = false;
            this.gbUsers.Text = "Users";
            // 
            // btnSellTicket
            // 
            this.btnSellTicket.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellTicket.Location = new System.Drawing.Point(121, 233);
            this.btnSellTicket.Name = "btnSellTicket";
            this.btnSellTicket.Size = new System.Drawing.Size(129, 37);
            this.btnSellTicket.TabIndex = 7;
            this.btnSellTicket.Text = "Sell Ticket";
            this.btnSellTicket.UseVisualStyleBackColor = true;
            // 
            // btnCancelTicket
            // 
            this.btnCancelTicket.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelTicket.Location = new System.Drawing.Point(6, 233);
            this.btnCancelTicket.Name = "btnCancelTicket";
            this.btnCancelTicket.Size = new System.Drawing.Size(109, 37);
            this.btnCancelTicket.TabIndex = 7;
            this.btnCancelTicket.Text = "Cancel Ticket";
            this.btnCancelTicket.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(256, 233);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(103, 37);
            this.btnAddUser.TabIndex = 7;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(563, 169);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(230, 40);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // AdminWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 555);
            this.Controls.Add(this.gbUsers);
            this.Controls.Add(this.gbTrips);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbUserData);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnApplicationInfo);
            this.Controls.Add(this.btnOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AdminWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administatior";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbUserData.ResumeLayout(false);
            this.gbTrips.ResumeLayout(false);
            this.gbUsers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnApplicationInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbUserData;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbBirthDate;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbTrips;
        private System.Windows.Forms.GroupBox gbTrips;
        private System.Windows.Forms.Button btnEditTrip;
        private System.Windows.Forms.Button btnCancelTrip;
        private System.Windows.Forms.Button btnAddTrip;
        private System.Windows.Forms.ListBox lbUsers;
        private System.Windows.Forms.GroupBox gbUsers;
        private System.Windows.Forms.Button btnSellTicket;
        private System.Windows.Forms.Button btnCancelTicket;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnExit;
    }
}