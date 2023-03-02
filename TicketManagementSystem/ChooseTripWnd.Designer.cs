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
            this.tbArrivalPlace = new System.Windows.Forms.TextBox();
            this.ArrivalPlace = new System.Windows.Forms.Label();
            this.tbDeparturePlace = new System.Windows.Forms.TextBox();
            this.lbDeparturePlace = new System.Windows.Forms.Label();
            this.dtpDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.lDepartureDate = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.lTrips = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.btnBuyTicket = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbTripFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTrips
            // 
            this.lbTrips.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrips.FormattingEnabled = true;
            this.lbTrips.ItemHeight = 21;
            this.lbTrips.Location = new System.Drawing.Point(386, 37);
            this.lbTrips.Name = "lbTrips";
            this.lbTrips.Size = new System.Drawing.Size(243, 193);
            this.lbTrips.TabIndex = 0;
            // 
            // gbTripFilters
            // 
            this.gbTripFilters.Controls.Add(this.tbArrivalPlace);
            this.gbTripFilters.Controls.Add(this.ArrivalPlace);
            this.gbTripFilters.Controls.Add(this.lbDeparturePlace);
            this.gbTripFilters.Controls.Add(this.dtpDepartureDate);
            this.gbTripFilters.Controls.Add(this.tbDeparturePlace);
            this.gbTripFilters.Controls.Add(this.lDepartureDate);
            this.gbTripFilters.Controls.Add(this.btnClear);
            this.gbTripFilters.Controls.Add(this.btnApply);
            this.gbTripFilters.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTripFilters.Location = new System.Drawing.Point(11, 37);
            this.gbTripFilters.Name = "gbTripFilters";
            this.gbTripFilters.Size = new System.Drawing.Size(369, 235);
            this.gbTripFilters.TabIndex = 2;
            this.gbTripFilters.TabStop = false;
            this.gbTripFilters.Text = "Trips\' filters";
            // 
            // tbArrivalPlace
            // 
            this.tbArrivalPlace.Location = new System.Drawing.Point(170, 72);
            this.tbArrivalPlace.Name = "tbArrivalPlace";
            this.tbArrivalPlace.Size = new System.Drawing.Size(190, 28);
            this.tbArrivalPlace.TabIndex = 1;
            // 
            // ArrivalPlace
            // 
            this.ArrivalPlace.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrivalPlace.Location = new System.Drawing.Point(6, 72);
            this.ArrivalPlace.Name = "ArrivalPlace";
            this.ArrivalPlace.Size = new System.Drawing.Size(158, 28);
            this.ArrivalPlace.TabIndex = 0;
            this.ArrivalPlace.Text = "Arrival Place:";
            this.ArrivalPlace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbDeparturePlace
            // 
            this.tbDeparturePlace.Location = new System.Drawing.Point(170, 28);
            this.tbDeparturePlace.Name = "tbDeparturePlace";
            this.tbDeparturePlace.Size = new System.Drawing.Size(190, 28);
            this.tbDeparturePlace.TabIndex = 1;
            // 
            // lbDeparturePlace
            // 
            this.lbDeparturePlace.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeparturePlace.Location = new System.Drawing.Point(6, 28);
            this.lbDeparturePlace.Name = "lbDeparturePlace";
            this.lbDeparturePlace.Size = new System.Drawing.Size(158, 28);
            this.lbDeparturePlace.TabIndex = 0;
            this.lbDeparturePlace.Text = "Departure Place:";
            this.lbDeparturePlace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpDepartureDate
            // 
            this.dtpDepartureDate.CustomFormat = "dd.MM.yyyy";
            this.dtpDepartureDate.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDepartureDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepartureDate.Location = new System.Drawing.Point(170, 116);
            this.dtpDepartureDate.Name = "dtpDepartureDate";
            this.dtpDepartureDate.Size = new System.Drawing.Size(190, 32);
            this.dtpDepartureDate.TabIndex = 2;
            this.dtpDepartureDate.ValueChanged += new System.EventHandler(this.dtpDepartureDate_ValueChanged);
            // 
            // lDepartureDate
            // 
            this.lDepartureDate.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDepartureDate.Location = new System.Drawing.Point(6, 116);
            this.lDepartureDate.Name = "lDepartureDate";
            this.lDepartureDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lDepartureDate.Size = new System.Drawing.Size(158, 32);
            this.lDepartureDate.TabIndex = 0;
            this.lDepartureDate.Text = "Departure Date:";
            this.lDepartureDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(274, 195);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(89, 34);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
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
            this.btnView.Location = new System.Drawing.Point(386, 238);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(99, 34);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnBuyTicket
            // 
            this.btnBuyTicket.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyTicket.Location = new System.Drawing.Point(530, 238);
            this.btnBuyTicket.Name = "btnBuyTicket";
            this.btnBuyTicket.Size = new System.Drawing.Size(99, 34);
            this.btnBuyTicket.TabIndex = 3;
            this.btnBuyTicket.Text = "Buy ticket";
            this.btnBuyTicket.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(6, 195);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 34);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ChooseTripWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 282);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbTrips;
        private System.Windows.Forms.GroupBox gbTripFilters;
        private System.Windows.Forms.TextBox tbDeparturePlace;
        private System.Windows.Forms.Label lbDeparturePlace;
        private System.Windows.Forms.DateTimePicker dtpDepartureDate;
        private System.Windows.Forms.Label lDepartureDate;
        private System.Windows.Forms.TextBox tbArrivalPlace;
        private System.Windows.Forms.Label ArrivalPlace;
        private System.Windows.Forms.Label lTrips;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnBuyTicket;
        private System.Windows.Forms.Button btnClear;
    }
}