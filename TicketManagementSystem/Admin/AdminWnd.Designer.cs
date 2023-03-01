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
            this.gbUserData = new System.Windows.Forms.GroupBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbBirthDate = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.btnViewCompletedTrips = new System.Windows.Forms.Button();
            this.lbClients = new System.Windows.Forms.ListBox();
            this.gbClients = new System.Windows.Forms.GroupBox();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbTrains = new System.Windows.Forms.GroupBox();
            this.btnEditTrain = new System.Windows.Forms.Button();
            this.tbnAddTrain = new System.Windows.Forms.Button();
            this.lbTrains = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbUserData.SuspendLayout();
            this.gbClients.SuspendLayout();
            this.gbTrains.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOptions
            // 
            this.btnOptions.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.Location = new System.Drawing.Point(564, 70);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(230, 43);
            this.btnOptions.TabIndex = 1;
            this.btnOptions.Text = "Settings";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnApplicationInfo
            // 
            this.btnApplicationInfo.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplicationInfo.Location = new System.Drawing.Point(564, 21);
            this.btnApplicationInfo.Name = "btnApplicationInfo";
            this.btnApplicationInfo.Size = new System.Drawing.Size(230, 43);
            this.btnApplicationInfo.TabIndex = 2;
            this.btnApplicationInfo.Text = "Application Information ";
            this.btnApplicationInfo.UseVisualStyleBackColor = true;
            this.btnApplicationInfo.Click += new System.EventHandler(this.btnApplicationInfo_Click);
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
            this.gbUserData.Size = new System.Drawing.Size(307, 223);
            this.gbUserData.TabIndex = 4;
            this.gbUserData.TabStop = false;
            this.gbUserData.Text = "User Data";
            // 
            // lbEmail
            // 
            this.lbEmail.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(6, 153);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(295, 26);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email: ";
            this.lbEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbBirthDate
            // 
            this.lbBirthDate.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBirthDate.Location = new System.Drawing.Point(6, 117);
            this.lbBirthDate.Name = "lbBirthDate";
            this.lbBirthDate.Size = new System.Drawing.Size(295, 26);
            this.lbBirthDate.TabIndex = 0;
            this.lbBirthDate.Text = "Date of Birth:";
            this.lbBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSurname
            // 
            this.lbSurname.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSurname.Location = new System.Drawing.Point(6, 81);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(295, 26);
            this.lbSurname.TabIndex = 0;
            this.lbSurname.Text = "Surname:";
            this.lbSurname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(6, 46);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(295, 26);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name:";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnViewCompletedTrips
            // 
            this.btnViewCompletedTrips.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCompletedTrips.Location = new System.Drawing.Point(564, 119);
            this.btnViewCompletedTrips.Name = "btnViewCompletedTrips";
            this.btnViewCompletedTrips.Size = new System.Drawing.Size(230, 43);
            this.btnViewCompletedTrips.TabIndex = 5;
            this.btnViewCompletedTrips.Text = "View Completed Trips";
            this.btnViewCompletedTrips.UseVisualStyleBackColor = true;
            this.btnViewCompletedTrips.Click += new System.EventHandler(this.btnViewCompletedTrips_Click);
            // 
            // lbClients
            // 
            this.lbClients.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClients.FormattingEnabled = true;
            this.lbClients.ItemHeight = 21;
            this.lbClients.Location = new System.Drawing.Point(6, 23);
            this.lbClients.Name = "lbClients";
            this.lbClients.Size = new System.Drawing.Size(372, 193);
            this.lbClients.TabIndex = 9;
            // 
            // gbClients
            // 
            this.gbClients.BackColor = System.Drawing.Color.Transparent;
            this.gbClients.Controls.Add(this.btnEditClient);
            this.gbClients.Controls.Add(this.btnAddClient);
            this.gbClients.Controls.Add(this.lbClients);
            this.gbClients.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClients.Location = new System.Drawing.Point(410, 266);
            this.gbClients.Name = "gbClients";
            this.gbClients.Size = new System.Drawing.Size(384, 265);
            this.gbClients.TabIndex = 10;
            this.gbClients.TabStop = false;
            this.gbClients.Text = "Clients";
            // 
            // btnEditClient
            // 
            this.btnEditClient.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditClient.Location = new System.Drawing.Point(6, 222);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(102, 37);
            this.btnEditClient.TabIndex = 7;
            this.btnEditClient.Text = "Edit";
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.Location = new System.Drawing.Point(276, 222);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(102, 37);
            this.btnAddClient.TabIndex = 7;
            this.btnAddClient.Text = "Add";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(564, 168);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(230, 43);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbTrains
            // 
            this.gbTrains.BackColor = System.Drawing.Color.Transparent;
            this.gbTrains.Controls.Add(this.btnEditTrain);
            this.gbTrains.Controls.Add(this.tbnAddTrain);
            this.gbTrains.Controls.Add(this.lbTrains);
            this.gbTrains.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTrains.Location = new System.Drawing.Point(10, 266);
            this.gbTrains.Name = "gbTrains";
            this.gbTrains.Size = new System.Drawing.Size(384, 265);
            this.gbTrains.TabIndex = 10;
            this.gbTrains.TabStop = false;
            this.gbTrains.Text = "Trains";
            // 
            // btnEditTrain
            // 
            this.btnEditTrain.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTrain.Location = new System.Drawing.Point(7, 222);
            this.btnEditTrain.Name = "btnEditTrain";
            this.btnEditTrain.Size = new System.Drawing.Size(102, 37);
            this.btnEditTrain.TabIndex = 7;
            this.btnEditTrain.Text = "Edit";
            this.btnEditTrain.UseVisualStyleBackColor = true;
            this.btnEditTrain.Click += new System.EventHandler(this.btnEditTrain_Click);
            // 
            // tbnAddTrain
            // 
            this.tbnAddTrain.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnAddTrain.Location = new System.Drawing.Point(276, 222);
            this.tbnAddTrain.Name = "tbnAddTrain";
            this.tbnAddTrain.Size = new System.Drawing.Size(102, 37);
            this.tbnAddTrain.TabIndex = 7;
            this.tbnAddTrain.Text = "Add";
            this.tbnAddTrain.UseVisualStyleBackColor = true;
            this.tbnAddTrain.Click += new System.EventHandler(this.tbnAddTrain_Click);
            // 
            // lbTrains
            // 
            this.lbTrains.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrains.FormattingEnabled = true;
            this.lbTrains.ItemHeight = 21;
            this.lbTrains.Location = new System.Drawing.Point(6, 23);
            this.lbTrains.Name = "lbTrains";
            this.lbTrains.Size = new System.Drawing.Size(372, 193);
            this.lbTrains.TabIndex = 9;
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
            // AdminWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 537);
            this.Controls.Add(this.gbTrains);
            this.Controls.Add(this.gbClients);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnViewCompletedTrips);
            this.Controls.Add(this.gbUserData);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnApplicationInfo);
            this.Controls.Add(this.btnOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AdminWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administatior";
            this.gbUserData.ResumeLayout(false);
            this.gbClients.ResumeLayout(false);
            this.gbTrains.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnViewCompletedTrips;
        private System.Windows.Forms.ListBox lbClients;
        private System.Windows.Forms.GroupBox gbClients;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.GroupBox gbTrains;
        private System.Windows.Forms.Button btnEditTrain;
        private System.Windows.Forms.Button tbnAddTrain;
        private System.Windows.Forms.ListBox lbTrains;
    }
}