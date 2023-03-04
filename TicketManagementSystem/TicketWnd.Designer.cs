namespace TicketManagementSystem
{
    partial class TicketWnd
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
            this.pbTicket = new System.Windows.Forms.PictureBox();
            this.gbTicketData = new System.Windows.Forms.GroupBox();
            this.lbDateOfPurchase = new System.Windows.Forms.Label();
            this.lbOwnerName = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbTicket)).BeginInit();
            this.gbTicketData.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbTicket
            // 
            this.pbTicket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbTicket.Image = global::TicketManagementSystem.Properties.Resources.Ticket;
            this.pbTicket.Location = new System.Drawing.Point(12, 12);
            this.pbTicket.Name = "pbTicket";
            this.pbTicket.Size = new System.Drawing.Size(265, 219);
            this.pbTicket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTicket.TabIndex = 0;
            this.pbTicket.TabStop = false;
            // 
            // gbTicketData
            // 
            this.gbTicketData.Controls.Add(this.lbId);
            this.gbTicketData.Controls.Add(this.lbStatus);
            this.gbTicketData.Controls.Add(this.lbType);
            this.gbTicketData.Controls.Add(this.lbPrice);
            this.gbTicketData.Controls.Add(this.lbOwnerName);
            this.gbTicketData.Controls.Add(this.lbDateOfPurchase);
            this.gbTicketData.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTicketData.Location = new System.Drawing.Point(283, 12);
            this.gbTicketData.Name = "gbTicketData";
            this.gbTicketData.Size = new System.Drawing.Size(291, 222);
            this.gbTicketData.TabIndex = 1;
            this.gbTicketData.TabStop = false;
            this.gbTicketData.Text = "Ticket Data";
            // 
            // lbDateOfPurchase
            // 
            this.lbDateOfPurchase.AutoSize = true;
            this.lbDateOfPurchase.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateOfPurchase.Location = new System.Drawing.Point(6, 196);
            this.lbDateOfPurchase.Name = "lbDateOfPurchase";
            this.lbDateOfPurchase.Size = new System.Drawing.Size(157, 23);
            this.lbDateOfPurchase.TabIndex = 0;
            this.lbDateOfPurchase.Text = "Date of purchase:";
            // 
            // lbOwnerName
            // 
            this.lbOwnerName.AutoSize = true;
            this.lbOwnerName.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOwnerName.Location = new System.Drawing.Point(6, 163);
            this.lbOwnerName.Name = "lbOwnerName";
            this.lbOwnerName.Size = new System.Drawing.Size(158, 23);
            this.lbOwnerName.TabIndex = 0;
            this.lbOwnerName.Text = "Owner username:";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(6, 96);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(56, 23);
            this.lbPrice.TabIndex = 0;
            this.lbPrice.Text = "Price:";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(6, 64);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(65, 23);
            this.lbStatus.TabIndex = 0;
            this.lbStatus.Text = "Status:";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.Location = new System.Drawing.Point(6, 129);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(54, 23);
            this.lbType.TabIndex = 0;
            this.lbType.Text = "Type:";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(6, 35);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(30, 23);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "Id:";
            // 
            // TicketWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 239);
            this.Controls.Add(this.gbTicketData);
            this.Controls.Add(this.pbTicket);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TicketWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ticket";
            ((System.ComponentModel.ISupportInitialize)(this.pbTicket)).EndInit();
            this.gbTicketData.ResumeLayout(false);
            this.gbTicketData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTicket;
        private System.Windows.Forms.GroupBox gbTicketData;
        private System.Windows.Forms.Label lbDateOfPurchase;
        private System.Windows.Forms.Label lbOwnerName;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbId;
    }
}