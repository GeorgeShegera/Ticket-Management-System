namespace TicketManagementSystem
{
    partial class CompletedTripsWnd
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbCompletedTrips = new System.Windows.Forms.ListBox();
            this.btnViewTrip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(328, 32);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Completed Trips";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCompletedTrips
            // 
            this.lbCompletedTrips.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompletedTrips.FormattingEnabled = true;
            this.lbCompletedTrips.ItemHeight = 21;
            this.lbCompletedTrips.Location = new System.Drawing.Point(12, 57);
            this.lbCompletedTrips.Name = "lbCompletedTrips";
            this.lbCompletedTrips.Size = new System.Drawing.Size(328, 235);
            this.lbCompletedTrips.TabIndex = 1;
            // 
            // btnViewTrip
            // 
            this.btnViewTrip.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTrip.Location = new System.Drawing.Point(146, 298);
            this.btnViewTrip.Name = "btnViewTrip";
            this.btnViewTrip.Size = new System.Drawing.Size(194, 33);
            this.btnViewTrip.TabIndex = 2;
            this.btnViewTrip.Text = "View Details";
            this.btnViewTrip.UseVisualStyleBackColor = true;
            this.btnViewTrip.Click += new System.EventHandler(this.btnViewTrip_Click);
            // 
            // CompletedTripsWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 346);
            this.Controls.Add(this.btnViewTrip);
            this.Controls.Add(this.lbCompletedTrips);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CompletedTripsWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Completed Trips";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ListBox lbCompletedTrips;
        private System.Windows.Forms.Button btnViewTrip;
    }
}