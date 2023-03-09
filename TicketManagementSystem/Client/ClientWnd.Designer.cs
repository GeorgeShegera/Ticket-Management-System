namespace TicketManagementSystem
{
    partial class ClientWnd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientWnd));
            this.pbClient = new System.Windows.Forms.PictureBox();
            this.BtnApplicationInfo = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.LActive = new System.Windows.Forms.Label();
            this.lbActiveTickets = new System.Windows.Forms.ListBox();
            this.BtnViewAllTickets = new System.Windows.Forms.Button();
            this.BtnBalanceReplenishment = new System.Windows.Forms.Button();
            this.BtnViewTicket = new System.Windows.Forms.Button();
            this.gbClientData = new System.Windows.Forms.GroupBox();
            this.lbBalance = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbDataOfBirth = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.BtnCancelTicket = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbClient)).BeginInit();
            this.gbClientData.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbClient
            // 
            this.pbClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbClient.Image = ((System.Drawing.Image)(resources.GetObject("pbClient.Image")));
            this.pbClient.Location = new System.Drawing.Point(12, 12);
            this.pbClient.Name = "pbClient";
            this.pbClient.Size = new System.Drawing.Size(261, 217);
            this.pbClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClient.TabIndex = 0;
            this.pbClient.TabStop = false;
            // 
            // BtnApplicationInfo
            // 
            this.BtnApplicationInfo.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApplicationInfo.Location = new System.Drawing.Point(559, 21);
            this.BtnApplicationInfo.Name = "BtnApplicationInfo";
            this.BtnApplicationInfo.Size = new System.Drawing.Size(230, 43);
            this.BtnApplicationInfo.TabIndex = 1;
            this.BtnApplicationInfo.Text = "Application Information ";
            this.BtnApplicationInfo.UseVisualStyleBackColor = true;
            this.BtnApplicationInfo.Click += new System.EventHandler(this.BtnApplicationInfo_Click);
            // 
            // BtnSettings
            // 
            this.BtnSettings.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSettings.Location = new System.Drawing.Point(559, 119);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(230, 43);
            this.BtnSettings.TabIndex = 1;
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.UseVisualStyleBackColor = true;
            // 
            // LActive
            // 
            this.LActive.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LActive.Location = new System.Drawing.Point(12, 246);
            this.LActive.Name = "LActive";
            this.LActive.Size = new System.Drawing.Size(541, 25);
            this.LActive.TabIndex = 2;
            this.LActive.Text = "Active Tickets";
            this.LActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbActiveTickets
            // 
            this.lbActiveTickets.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActiveTickets.FormattingEnabled = true;
            this.lbActiveTickets.ItemHeight = 21;
            this.lbActiveTickets.Location = new System.Drawing.Point(12, 274);
            this.lbActiveTickets.Name = "lbActiveTickets";
            this.lbActiveTickets.Size = new System.Drawing.Size(541, 130);
            this.lbActiveTickets.TabIndex = 3;
            // 
            // BtnViewAllTickets
            // 
            this.BtnViewAllTickets.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViewAllTickets.Location = new System.Drawing.Point(559, 365);
            this.BtnViewAllTickets.Name = "BtnViewAllTickets";
            this.BtnViewAllTickets.Size = new System.Drawing.Size(230, 39);
            this.BtnViewAllTickets.TabIndex = 1;
            this.BtnViewAllTickets.Text = "View all Tickets";
            this.BtnViewAllTickets.UseVisualStyleBackColor = true;
            // 
            // BtnBalanceReplenishment
            // 
            this.BtnBalanceReplenishment.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBalanceReplenishment.Location = new System.Drawing.Point(559, 70);
            this.BtnBalanceReplenishment.Name = "BtnBalanceReplenishment";
            this.BtnBalanceReplenishment.Size = new System.Drawing.Size(230, 43);
            this.BtnBalanceReplenishment.TabIndex = 1;
            this.BtnBalanceReplenishment.Text = "Balance Replenishment";
            this.BtnBalanceReplenishment.UseVisualStyleBackColor = true;
            this.BtnBalanceReplenishment.Click += new System.EventHandler(this.BtnBalanceReplenishment_Click);
            // 
            // BtnViewTicket
            // 
            this.BtnViewTicket.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViewTicket.Location = new System.Drawing.Point(559, 275);
            this.BtnViewTicket.Name = "BtnViewTicket";
            this.BtnViewTicket.Size = new System.Drawing.Size(230, 39);
            this.BtnViewTicket.TabIndex = 1;
            this.BtnViewTicket.Text = "View Ticket";
            this.BtnViewTicket.UseVisualStyleBackColor = true;
            // 
            // gbClientData
            // 
            this.gbClientData.Controls.Add(this.lbBalance);
            this.gbClientData.Controls.Add(this.lbEmail);
            this.gbClientData.Controls.Add(this.lbDataOfBirth);
            this.gbClientData.Controls.Add(this.lbSurname);
            this.gbClientData.Controls.Add(this.lbName);
            this.gbClientData.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClientData.Location = new System.Drawing.Point(279, 12);
            this.gbClientData.Name = "gbClientData";
            this.gbClientData.Size = new System.Drawing.Size(274, 217);
            this.gbClientData.TabIndex = 4;
            this.gbClientData.TabStop = false;
            this.gbClientData.Text = "Client Data";
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBalance.Location = new System.Drawing.Point(6, 164);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(80, 23);
            this.lbBalance.TabIndex = 0;
            this.lbBalance.Text = "Balance:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(6, 130);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(60, 23);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email:";
            // 
            // lbDataOfBirth
            // 
            this.lbDataOfBirth.AutoSize = true;
            this.lbDataOfBirth.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataOfBirth.Location = new System.Drawing.Point(6, 98);
            this.lbDataOfBirth.Name = "lbDataOfBirth";
            this.lbDataOfBirth.Size = new System.Drawing.Size(120, 23);
            this.lbDataOfBirth.TabIndex = 0;
            this.lbDataOfBirth.Text = "Data of Birth:";
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSurname.Location = new System.Drawing.Point(6, 62);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(89, 23);
            this.lbSurname.TabIndex = 0;
            this.lbSurname.Text = "Surname:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(6, 29);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(64, 23);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name:";
            // 
            // BtnCancelTicket
            // 
            this.BtnCancelTicket.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelTicket.Location = new System.Drawing.Point(559, 320);
            this.BtnCancelTicket.Name = "BtnCancelTicket";
            this.BtnCancelTicket.Size = new System.Drawing.Size(230, 39);
            this.BtnCancelTicket.TabIndex = 1;
            this.BtnCancelTicket.Text = "Cancel Ticket";
            this.BtnCancelTicket.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(559, 168);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(230, 43);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            // 
            // ClientWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 416);
            this.Controls.Add(this.gbClientData);
            this.Controls.Add(this.lbActiveTickets);
            this.Controls.Add(this.LActive);
            this.Controls.Add(this.BtnCancelTicket);
            this.Controls.Add(this.BtnViewTicket);
            this.Controls.Add(this.BtnBalanceReplenishment);
            this.Controls.Add(this.BtnViewAllTickets);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnSettings);
            this.Controls.Add(this.BtnApplicationInfo);
            this.Controls.Add(this.pbClient);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ClientWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.pbClient)).EndInit();
            this.gbClientData.ResumeLayout(false);
            this.gbClientData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbClient;
        private System.Windows.Forms.Button BtnApplicationInfo;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Label LActive;
        private System.Windows.Forms.ListBox lbActiveTickets;
        private System.Windows.Forms.Button BtnViewAllTickets;
        private System.Windows.Forms.Button BtnBalanceReplenishment;
        private System.Windows.Forms.Button BtnViewTicket;
        private System.Windows.Forms.GroupBox gbClientData;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button BtnCancelTicket;
        private System.Windows.Forms.Label lbDataOfBirth;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Button BtnExit;
    }
}