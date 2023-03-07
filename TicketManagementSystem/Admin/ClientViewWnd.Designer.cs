namespace TicketManagementSystem
{
    partial class ClientViewWnd
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
            this.gbClientData = new System.Windows.Forms.GroupBox();
            this.lbBalance = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbBirthDate = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.pbClient = new System.Windows.Forms.PictureBox();
            this.lbTickets = new System.Windows.Forms.ListBox();
            this.lTickets = new System.Windows.Forms.Label();
            this.btnViewTicket = new System.Windows.Forms.Button();
            this.btnSellTicket = new System.Windows.Forms.Button();
            this.btnCancelTcket = new System.Windows.Forms.Button();
            this.gbClientData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClient)).BeginInit();
            this.SuspendLayout();
            // 
            // gbClientData
            // 
            this.gbClientData.Controls.Add(this.lbBalance);
            this.gbClientData.Controls.Add(this.lbEmail);
            this.gbClientData.Controls.Add(this.lbBirthDate);
            this.gbClientData.Controls.Add(this.lbSurname);
            this.gbClientData.Controls.Add(this.lbName);
            this.gbClientData.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClientData.Location = new System.Drawing.Point(319, 12);
            this.gbClientData.Name = "gbClientData";
            this.gbClientData.Size = new System.Drawing.Size(364, 260);
            this.gbClientData.TabIndex = 1;
            this.gbClientData.TabStop = false;
            this.gbClientData.Text = "Client Data";
            // 
            // lbBalance
            // 
            this.lbBalance.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBalance.Location = new System.Drawing.Point(6, 174);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(352, 25);
            this.lbBalance.TabIndex = 2;
            this.lbBalance.Text = "Balance:";
            this.lbBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbEmail
            // 
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(6, 139);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(352, 25);
            this.lbEmail.TabIndex = 2;
            this.lbEmail.Text = "Email:";
            this.lbEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbBirthDate
            // 
            this.lbBirthDate.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBirthDate.Location = new System.Drawing.Point(6, 104);
            this.lbBirthDate.Name = "lbBirthDate";
            this.lbBirthDate.Size = new System.Drawing.Size(352, 25);
            this.lbBirthDate.TabIndex = 2;
            this.lbBirthDate.Text = "Birth Date:";
            this.lbBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSurname
            // 
            this.lbSurname.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSurname.Location = new System.Drawing.Point(6, 69);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(352, 25);
            this.lbSurname.TabIndex = 2;
            this.lbSurname.Text = "Surname:";
            this.lbSurname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(6, 35);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(352, 25);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name:";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbClient
            // 
            this.pbClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbClient.Image = global::TicketManagementSystem.Properties.Resources.Client;
            this.pbClient.Location = new System.Drawing.Point(12, 12);
            this.pbClient.Name = "pbClient";
            this.pbClient.Size = new System.Drawing.Size(301, 260);
            this.pbClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClient.TabIndex = 0;
            this.pbClient.TabStop = false;
            // 
            // lbTickets
            // 
            this.lbTickets.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTickets.FormattingEnabled = true;
            this.lbTickets.ItemHeight = 21;
            this.lbTickets.Location = new System.Drawing.Point(12, 327);
            this.lbTickets.Name = "lbTickets";
            this.lbTickets.Size = new System.Drawing.Size(464, 130);
            this.lbTickets.TabIndex = 2;
            // 
            // lTickets
            // 
            this.lTickets.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTickets.Location = new System.Drawing.Point(12, 299);
            this.lTickets.Name = "lTickets";
            this.lTickets.Size = new System.Drawing.Size(464, 25);
            this.lTickets.TabIndex = 2;
            this.lTickets.Text = "Tickets";
            this.lTickets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnViewTicket
            // 
            this.btnViewTicket.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTicket.Location = new System.Drawing.Point(482, 417);
            this.btnViewTicket.Name = "btnViewTicket";
            this.btnViewTicket.Size = new System.Drawing.Size(201, 39);
            this.btnViewTicket.TabIndex = 3;
            this.btnViewTicket.Text = "View Ticket";
            this.btnViewTicket.UseVisualStyleBackColor = true;
            this.btnViewTicket.Click += new System.EventHandler(this.btnViewTicket_Click);
            // 
            // btnSellTicket
            // 
            this.btnSellTicket.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellTicket.Location = new System.Drawing.Point(482, 327);
            this.btnSellTicket.Name = "btnSellTicket";
            this.btnSellTicket.Size = new System.Drawing.Size(201, 39);
            this.btnSellTicket.TabIndex = 3;
            this.btnSellTicket.Text = "Sell new ticket";
            this.btnSellTicket.UseVisualStyleBackColor = true;
            this.btnSellTicket.Click += new System.EventHandler(this.btnSellTicket_Click);
            // 
            // btnCancelTcket
            // 
            this.btnCancelTcket.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelTcket.Location = new System.Drawing.Point(482, 372);
            this.btnCancelTcket.Name = "btnCancelTcket";
            this.btnCancelTcket.Size = new System.Drawing.Size(201, 39);
            this.btnCancelTcket.TabIndex = 3;
            this.btnCancelTcket.Text = "Cancel ticket";
            this.btnCancelTcket.UseVisualStyleBackColor = true;
            this.btnCancelTcket.Click += new System.EventHandler(this.btnCancelTcket_Click);
            // 
            // ClientViewWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 464);
            this.Controls.Add(this.btnCancelTcket);
            this.Controls.Add(this.btnSellTicket);
            this.Controls.Add(this.btnViewTicket);
            this.Controls.Add(this.lTickets);
            this.Controls.Add(this.lbTickets);
            this.Controls.Add(this.gbClientData);
            this.Controls.Add(this.pbClient);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ClientViewWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Client";
            this.gbClientData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbClient;
        private System.Windows.Forms.GroupBox gbClientData;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.Label lbBirthDate;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.ListBox lbTickets;
        private System.Windows.Forms.Label lTickets;
        private System.Windows.Forms.Button btnViewTicket;
        private System.Windows.Forms.Button btnSellTicket;
        private System.Windows.Forms.Button btnCancelTcket;
    }
}