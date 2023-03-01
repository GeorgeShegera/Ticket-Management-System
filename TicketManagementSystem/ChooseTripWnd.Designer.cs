namespace TicketManagementSystem
{
    partial class ChooseTripWnd
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
            this.lbTrips = new System.Windows.Forms.ListBox();
            this.gbTripFilters = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ArrivalPlace = new System.Windows.Forms.Label();
            this.dtpArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.lArrivalDate = new System.Windows.Forms.Label();
            this.cbArrivalFilters = new System.Windows.Forms.CheckBox();
            this.gbDepartureFilters = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbDeparturePlace = new System.Windows.Forms.Label();
            this.dtpDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.lDepartureDate = new System.Windows.Forms.Label();
            this.cbDepartureFilters = new System.Windows.Forms.CheckBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.lTrips = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.btnBuyTicket = new System.Windows.Forms.Button();
            this.gbTripFilters.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbDepartureFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTrips
            // 
            this.lbTrips.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrips.FormattingEnabled = true;
            this.lbTrips.ItemHeight = 21;
            this.lbTrips.Location = new System.Drawing.Point(392, 47);
            this.lbTrips.Name = "lbTrips";
            this.lbTrips.Size = new System.Drawing.Size(230, 298);
            this.lbTrips.TabIndex = 0;
            // 
            // gbTripFilters
            // 
            this.gbTripFilters.Controls.Add(this.groupBox1);
            this.gbTripFilters.Controls.Add(this.cbArrivalFilters);
            this.gbTripFilters.Controls.Add(this.gbDepartureFilters);
            this.gbTripFilters.Controls.Add(this.cbDepartureFilters);
            this.gbTripFilters.Controls.Add(this.btnApply);
            this.gbTripFilters.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTripFilters.Location = new System.Drawing.Point(11, 37);
            this.gbTripFilters.Name = "gbTripFilters";
            this.gbTripFilters.Size = new System.Drawing.Size(375, 348);
            this.gbTripFilters.TabIndex = 2;
            this.gbTripFilters.TabStop = false;
            this.gbTripFilters.Text = "Trips\' filters";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.ArrivalPlace);
            this.groupBox1.Controls.Add(this.dtpArrivalDate);
            this.groupBox1.Controls.Add(this.lArrivalDate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 102);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arrival Filters";
            this.groupBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(168, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(190, 28);
            this.textBox2.TabIndex = 1;
            // 
            // ArrivalPlace
            // 
            this.ArrivalPlace.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrivalPlace.Location = new System.Drawing.Point(10, 27);
            this.ArrivalPlace.Name = "ArrivalPlace";
            this.ArrivalPlace.Size = new System.Drawing.Size(152, 28);
            this.ArrivalPlace.TabIndex = 0;
            this.ArrivalPlace.Text = "Arrival Place:";
            this.ArrivalPlace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpArrivalDate
            // 
            this.dtpArrivalDate.CustomFormat = "HH:mm, dd.MM.yyyy";
            this.dtpArrivalDate.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpArrivalDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpArrivalDate.Location = new System.Drawing.Point(168, 61);
            this.dtpArrivalDate.Name = "dtpArrivalDate";
            this.dtpArrivalDate.Size = new System.Drawing.Size(190, 32);
            this.dtpArrivalDate.TabIndex = 2;
            // 
            // lArrivalDate
            // 
            this.lArrivalDate.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lArrivalDate.Location = new System.Drawing.Point(10, 61);
            this.lArrivalDate.Name = "lArrivalDate";
            this.lArrivalDate.Size = new System.Drawing.Size(152, 32);
            this.lArrivalDate.TabIndex = 0;
            this.lArrivalDate.Text = "Arrival Date:";
            this.lArrivalDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbArrivalFilters
            // 
            this.cbArrivalFilters.AutoSize = true;
            this.cbArrivalFilters.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArrivalFilters.Location = new System.Drawing.Point(19, 58);
            this.cbArrivalFilters.Name = "cbArrivalFilters";
            this.cbArrivalFilters.Size = new System.Drawing.Size(121, 25);
            this.cbArrivalFilters.TabIndex = 4;
            this.cbArrivalFilters.Text = "Arrival Filters";
            this.cbArrivalFilters.UseVisualStyleBackColor = true;
            // 
            // gbDepartureFilters
            // 
            this.gbDepartureFilters.Controls.Add(this.textBox1);
            this.gbDepartureFilters.Controls.Add(this.lbDeparturePlace);
            this.gbDepartureFilters.Controls.Add(this.dtpDepartureDate);
            this.gbDepartureFilters.Controls.Add(this.lDepartureDate);
            this.gbDepartureFilters.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDepartureFilters.Location = new System.Drawing.Point(5, 89);
            this.gbDepartureFilters.Name = "gbDepartureFilters";
            this.gbDepartureFilters.Size = new System.Drawing.Size(364, 102);
            this.gbDepartureFilters.TabIndex = 3;
            this.gbDepartureFilters.TabStop = false;
            this.gbDepartureFilters.Text = "Departure Filters";
            this.gbDepartureFilters.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 28);
            this.textBox1.TabIndex = 1;
            // 
            // lbDeparturePlace
            // 
            this.lbDeparturePlace.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeparturePlace.Location = new System.Drawing.Point(10, 27);
            this.lbDeparturePlace.Name = "lbDeparturePlace";
            this.lbDeparturePlace.Size = new System.Drawing.Size(152, 28);
            this.lbDeparturePlace.TabIndex = 0;
            this.lbDeparturePlace.Text = "Departure Place:";
            this.lbDeparturePlace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpDepartureDate
            // 
            this.dtpDepartureDate.CustomFormat = "HH:mm, dd.MM.yyyy";
            this.dtpDepartureDate.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDepartureDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepartureDate.Location = new System.Drawing.Point(168, 61);
            this.dtpDepartureDate.Name = "dtpDepartureDate";
            this.dtpDepartureDate.Size = new System.Drawing.Size(190, 32);
            this.dtpDepartureDate.TabIndex = 2;
            // 
            // lDepartureDate
            // 
            this.lDepartureDate.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDepartureDate.Location = new System.Drawing.Point(10, 61);
            this.lDepartureDate.Name = "lDepartureDate";
            this.lDepartureDate.Size = new System.Drawing.Size(152, 32);
            this.lDepartureDate.TabIndex = 0;
            this.lDepartureDate.Text = "Departure Date:";
            this.lDepartureDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbDepartureFilters
            // 
            this.cbDepartureFilters.AutoSize = true;
            this.cbDepartureFilters.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartureFilters.Location = new System.Drawing.Point(19, 27);
            this.cbDepartureFilters.Name = "cbDepartureFilters";
            this.cbDepartureFilters.Size = new System.Drawing.Size(145, 25);
            this.cbDepartureFilters.TabIndex = 4;
            this.cbDepartureFilters.Text = "Departure Filters";
            this.cbDepartureFilters.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(280, 305);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(89, 34);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // lTrips
            // 
            this.lTrips.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTrips.Location = new System.Drawing.Point(12, 9);
            this.lTrips.Name = "lTrips";
            this.lTrips.Size = new System.Drawing.Size(595, 25);
            this.lTrips.TabIndex = 1;
            this.lTrips.Text = "Upcomming Trips";
            this.lTrips.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(418, 351);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(99, 34);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // btnBuyTicket
            // 
            this.btnBuyTicket.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyTicket.Location = new System.Drawing.Point(523, 351);
            this.btnBuyTicket.Name = "btnBuyTicket";
            this.btnBuyTicket.Size = new System.Drawing.Size(99, 34);
            this.btnBuyTicket.TabIndex = 3;
            this.btnBuyTicket.Text = "Buy ticket";
            this.btnBuyTicket.UseVisualStyleBackColor = true;
            // 
            // ChooseTripWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 392);
            this.Controls.Add(this.gbTripFilters);
            this.Controls.Add(this.lTrips);
            this.Controls.Add(this.lbTrips);
            this.Controls.Add(this.btnBuyTicket);
            this.Controls.Add(this.btnView);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChooseTripWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Choice of trip";
            this.gbTripFilters.ResumeLayout(false);
            this.gbTripFilters.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbDepartureFilters.ResumeLayout(false);
            this.gbDepartureFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbTrips;
        private System.Windows.Forms.GroupBox gbTripFilters;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbDeparturePlace;
        private System.Windows.Forms.DateTimePicker dtpDepartureDate;
        private System.Windows.Forms.Label lDepartureDate;
        private System.Windows.Forms.DateTimePicker dtpArrivalDate;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lArrivalDate;
        private System.Windows.Forms.Label ArrivalPlace;
        private System.Windows.Forms.Label lTrips;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.GroupBox gbDepartureFilters;
        private System.Windows.Forms.CheckBox cbArrivalFilters;
        private System.Windows.Forms.CheckBox cbDepartureFilters;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnBuyTicket;
    }
}