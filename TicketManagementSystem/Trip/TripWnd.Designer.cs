namespace TicketManagementSystem
{
    partial class TripWnd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TripWnd));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.gbTripData = new System.Windows.Forms.GroupBox();
            this.gbDepartureData = new System.Windows.Forms.GroupBox();
            this.lbDeparturePlace = new System.Windows.Forms.Label();
            this.lbDepartureTime = new System.Windows.Forms.Label();
            this.gbArrivalData = new System.Windows.Forms.GroupBox();
            this.lbArrivalTime = new System.Windows.Forms.Label();
            this.lbArrivalPlace = new System.Windows.Forms.Label();
            this.lbState = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbTickets = new System.Windows.Forms.ListBox();
            this.lTickets = new System.Windows.Forms.Label();
            this.gbPrices = new System.Windows.Forms.GroupBox();
            this.lbBusinessPrice = new System.Windows.Forms.Label();
            this.lbMiddlePrice = new System.Windows.Forms.Label();
            this.lbEconomyPrice = new System.Windows.Forms.Label();
            this.btnTripSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.gbTripData.SuspendLayout();
            this.gbDepartureData.SuspendLayout();
            this.gbArrivalData.SuspendLayout();
            this.gbPrices.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(12, 13);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(283, 264);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // gbTripData
            // 
            this.gbTripData.Controls.Add(this.gbDepartureData);
            this.gbTripData.Controls.Add(this.gbArrivalData);
            this.gbTripData.Controls.Add(this.lbState);
            this.gbTripData.Controls.Add(this.lbName);
            this.gbTripData.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTripData.Location = new System.Drawing.Point(301, 13);
            this.gbTripData.Name = "gbTripData";
            this.gbTripData.Size = new System.Drawing.Size(347, 264);
            this.gbTripData.TabIndex = 1;
            this.gbTripData.TabStop = false;
            this.gbTripData.Text = "Trip Data";
            // 
            // gbDepartureData
            // 
            this.gbDepartureData.Controls.Add(this.lbDeparturePlace);
            this.gbDepartureData.Controls.Add(this.lbDepartureTime);
            this.gbDepartureData.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDepartureData.Location = new System.Drawing.Point(6, 80);
            this.gbDepartureData.Name = "gbDepartureData";
            this.gbDepartureData.Size = new System.Drawing.Size(335, 86);
            this.gbDepartureData.TabIndex = 2;
            this.gbDepartureData.TabStop = false;
            this.gbDepartureData.Text = "Daparture Data";
            // 
            // lbDeparturePlace
            // 
            this.lbDeparturePlace.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeparturePlace.Location = new System.Drawing.Point(6, 56);
            this.lbDeparturePlace.Name = "lbDeparturePlace";
            this.lbDeparturePlace.Size = new System.Drawing.Size(310, 24);
            this.lbDeparturePlace.TabIndex = 0;
            this.lbDeparturePlace.Text = "Departure Place:";
            this.lbDeparturePlace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDepartureTime
            // 
            this.lbDepartureTime.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartureTime.Location = new System.Drawing.Point(6, 23);
            this.lbDepartureTime.Name = "lbDepartureTime";
            this.lbDepartureTime.Size = new System.Drawing.Size(310, 24);
            this.lbDepartureTime.TabIndex = 0;
            this.lbDepartureTime.Text = "Departure Time:";
            this.lbDepartureTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbArrivalData
            // 
            this.gbArrivalData.Controls.Add(this.lbArrivalTime);
            this.gbArrivalData.Controls.Add(this.lbArrivalPlace);
            this.gbArrivalData.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbArrivalData.Location = new System.Drawing.Point(6, 172);
            this.gbArrivalData.Name = "gbArrivalData";
            this.gbArrivalData.Size = new System.Drawing.Size(335, 86);
            this.gbArrivalData.TabIndex = 1;
            this.gbArrivalData.TabStop = false;
            this.gbArrivalData.Text = "ArrivalData";
            // 
            // lbArrivalTime
            // 
            this.lbArrivalTime.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArrivalTime.Location = new System.Drawing.Point(6, 23);
            this.lbArrivalTime.Name = "lbArrivalTime";
            this.lbArrivalTime.Size = new System.Drawing.Size(310, 24);
            this.lbArrivalTime.TabIndex = 0;
            this.lbArrivalTime.Text = "Arrival Time:";
            this.lbArrivalTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbArrivalPlace
            // 
            this.lbArrivalPlace.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArrivalPlace.Location = new System.Drawing.Point(6, 58);
            this.lbArrivalPlace.Name = "lbArrivalPlace";
            this.lbArrivalPlace.Size = new System.Drawing.Size(310, 24);
            this.lbArrivalPlace.TabIndex = 0;
            this.lbArrivalPlace.Text = "Arrival Place:";
            this.lbArrivalPlace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbState
            // 
            this.lbState.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbState.Location = new System.Drawing.Point(2, 54);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(339, 23);
            this.lbState.TabIndex = 0;
            this.lbState.Text = "Status:";
            this.lbState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(2, 23);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(339, 23);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name:";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTickets
            // 
            this.lbTickets.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTickets.FormattingEnabled = true;
            this.lbTickets.ItemHeight = 21;
            this.lbTickets.Location = new System.Drawing.Point(12, 323);
            this.lbTickets.Name = "lbTickets";
            this.lbTickets.Size = new System.Drawing.Size(340, 172);
            this.lbTickets.TabIndex = 2;
            // 
            // lTickets
            // 
            this.lTickets.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTickets.Location = new System.Drawing.Point(12, 290);
            this.lTickets.Name = "lTickets";
            this.lTickets.Size = new System.Drawing.Size(340, 30);
            this.lTickets.TabIndex = 0;
            this.lTickets.Text = "Tickets";
            this.lTickets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbPrices
            // 
            this.gbPrices.Controls.Add(this.lbBusinessPrice);
            this.gbPrices.Controls.Add(this.lbMiddlePrice);
            this.gbPrices.Controls.Add(this.lbEconomyPrice);
            this.gbPrices.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrices.Location = new System.Drawing.Point(358, 363);
            this.gbPrices.Name = "gbPrices";
            this.gbPrices.Size = new System.Drawing.Size(290, 132);
            this.gbPrices.TabIndex = 3;
            this.gbPrices.TabStop = false;
            this.gbPrices.Text = "Prices";
            // 
            // lbBusinessPrice
            // 
            this.lbBusinessPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBusinessPrice.Location = new System.Drawing.Point(9, 93);
            this.lbBusinessPrice.Name = "lbBusinessPrice";
            this.lbBusinessPrice.Size = new System.Drawing.Size(275, 25);
            this.lbBusinessPrice.TabIndex = 0;
            this.lbBusinessPrice.Text = "Business class price:";
            this.lbBusinessPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbMiddlePrice
            // 
            this.lbMiddlePrice.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMiddlePrice.Location = new System.Drawing.Point(9, 58);
            this.lbMiddlePrice.Name = "lbMiddlePrice";
            this.lbMiddlePrice.Size = new System.Drawing.Size(275, 25);
            this.lbMiddlePrice.TabIndex = 0;
            this.lbMiddlePrice.Text = "Middle class price:";
            this.lbMiddlePrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbEconomyPrice
            // 
            this.lbEconomyPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEconomyPrice.Location = new System.Drawing.Point(9, 24);
            this.lbEconomyPrice.Name = "lbEconomyPrice";
            this.lbEconomyPrice.Size = new System.Drawing.Size(275, 25);
            this.lbEconomyPrice.TabIndex = 0;
            this.lbEconomyPrice.Text = "Economy class price:";
            this.lbEconomyPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTripSettings
            // 
            this.btnTripSettings.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTripSettings.Location = new System.Drawing.Point(358, 323);
            this.btnTripSettings.Name = "btnTripSettings";
            this.btnTripSettings.Size = new System.Drawing.Size(290, 34);
            this.btnTripSettings.TabIndex = 4;
            this.btnTripSettings.Text = "Trip Settings";
            this.btnTripSettings.UseVisualStyleBackColor = true;
            this.btnTripSettings.Click += new System.EventHandler(this.btnTripSettings_Click);
            // 
            // TripWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 505);
            this.Controls.Add(this.btnTripSettings);
            this.Controls.Add(this.gbPrices);
            this.Controls.Add(this.lTickets);
            this.Controls.Add(this.lbTickets);
            this.Controls.Add(this.gbTripData);
            this.Controls.Add(this.pictureBox);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TripWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TripWnd";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.gbTripData.ResumeLayout(false);
            this.gbDepartureData.ResumeLayout(false);
            this.gbArrivalData.ResumeLayout(false);
            this.gbPrices.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox gbTripData;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbDepartureTime;
        private System.Windows.Forms.Label lbArrivalTime;
        private System.Windows.Forms.Label lbDeparturePlace;
        private System.Windows.Forms.GroupBox gbDepartureData;
        private System.Windows.Forms.GroupBox gbArrivalData;
        private System.Windows.Forms.Label lbArrivalPlace;
        private System.Windows.Forms.ListBox lbTickets;
        private System.Windows.Forms.Label lTickets;
        private System.Windows.Forms.GroupBox gbPrices;
        private System.Windows.Forms.Label lbBusinessPrice;
        private System.Windows.Forms.Label lbMiddlePrice;
        private System.Windows.Forms.Label lbEconomyPrice;
        private System.Windows.Forms.Button btnTripSettings;
        private System.Windows.Forms.Label lbState;
    }
}