namespace TicketManagementSystem
{
    partial class ApplicationInfoWnd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationInfoWnd));
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbRailWayStation = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbRailWayStation)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(321, 12);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(410, 39);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Application Information";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbText
            // 
            this.lbText.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.Location = new System.Drawing.Point(322, 78);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(409, 114);
            this.lbText.TabIndex = 0;
            this.lbText.Text = resources.GetString("lbText.Text");
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(719, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // pbRailWayStation
            // 
            this.pbRailWayStation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbRailWayStation.Image = global::TicketManagementSystem.Properties.Resources.railwayStation;
            this.pbRailWayStation.Location = new System.Drawing.Point(12, 12);
            this.pbRailWayStation.Name = "pbRailWayStation";
            this.pbRailWayStation.Size = new System.Drawing.Size(291, 219);
            this.pbRailWayStation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRailWayStation.TabIndex = 1;
            this.pbRailWayStation.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(719, 115);
            this.label2.TabIndex = 0;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // ApplicationInfoWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 441);
            this.Controls.Add(this.pbRailWayStation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ApplicationInfoWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Info";
            ((System.ComponentModel.ISupportInitialize)(this.pbRailWayStation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbRailWayStation;
        private System.Windows.Forms.Label label2;
    }
}