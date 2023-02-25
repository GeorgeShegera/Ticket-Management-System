namespace TicketManagementSystem
{
    partial class TripSettings
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
            this.lbSettings = new System.Windows.Forms.Label();
            this.gbTripData = new System.Windows.Forms.GroupBox();
            this.pbState = new System.Windows.Forms.PictureBox();
            this.pbName = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbState = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.gbDepartureData = new System.Windows.Forms.GroupBox();
            this.dtpDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.lbDepartureTime = new System.Windows.Forms.Label();
            this.lbDeparturePlace = new System.Windows.Forms.Label();
            this.tbDeparturePlace = new System.Windows.Forms.TextBox();
            this.pbDeparturePlace = new System.Windows.Forms.PictureBox();
            this.pbDepartureTime = new System.Windows.Forms.PictureBox();
            this.gbTripData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbName)).BeginInit();
            this.gbDepartureData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeparturePlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartureTime)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSettings
            // 
            this.lbSettings.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSettings.Location = new System.Drawing.Point(12, 9);
            this.lbSettings.Name = "lbSettings";
            this.lbSettings.Size = new System.Drawing.Size(381, 31);
            this.lbSettings.TabIndex = 0;
            this.lbSettings.Text = "Settings";
            this.lbSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbTripData
            // 
            this.gbTripData.Controls.Add(this.pbState);
            this.gbTripData.Controls.Add(this.pbName);
            this.gbTripData.Controls.Add(this.comboBox1);
            this.gbTripData.Controls.Add(this.tbName);
            this.gbTripData.Controls.Add(this.lbState);
            this.gbTripData.Controls.Add(this.lbName);
            this.gbTripData.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTripData.Location = new System.Drawing.Point(12, 55);
            this.gbTripData.Name = "gbTripData";
            this.gbTripData.Size = new System.Drawing.Size(395, 115);
            this.gbTripData.TabIndex = 1;
            this.gbTripData.TabStop = false;
            this.gbTripData.Text = "Trip Data";
            // 
            // pbState
            // 
            this.pbState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbState.Image = global::TicketManagementSystem.Properties.Resources.EditImg;
            this.pbState.Location = new System.Drawing.Point(255, 72);
            this.pbState.Name = "pbState";
            this.pbState.Size = new System.Drawing.Size(31, 31);
            this.pbState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbState.TabIndex = 3;
            this.pbState.TabStop = false;
            // 
            // pbName
            // 
            this.pbName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbName.Image = global::TicketManagementSystem.Properties.Resources.EditImg;
            this.pbName.Location = new System.Drawing.Point(354, 31);
            this.pbName.Name = "pbName";
            this.pbName.Size = new System.Drawing.Size(31, 32);
            this.pbName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbName.TabIndex = 3;
            this.pbName.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(84, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 31);
            this.comboBox1.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(84, 31);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(264, 32);
            this.tbName.TabIndex = 1;
            // 
            // lbState
            // 
            this.lbState.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbState.Location = new System.Drawing.Point(6, 72);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(72, 31);
            this.lbState.TabIndex = 0;
            this.lbState.Text = "State:";
            this.lbState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(6, 31);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(72, 32);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name:";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbDepartureData
            // 
            this.gbDepartureData.Controls.Add(this.dtpDepartureTime);
            this.gbDepartureData.Controls.Add(this.pbDepartureTime);
            this.gbDepartureData.Controls.Add(this.pbDeparturePlace);
            this.gbDepartureData.Controls.Add(this.lbDeparturePlace);
            this.gbDepartureData.Controls.Add(this.lbDepartureTime);
            this.gbDepartureData.Controls.Add(this.tbDeparturePlace);
            this.gbDepartureData.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDepartureData.Location = new System.Drawing.Point(12, 176);
            this.gbDepartureData.Name = "gbDepartureData";
            this.gbDepartureData.Size = new System.Drawing.Size(395, 127);
            this.gbDepartureData.TabIndex = 2;
            this.gbDepartureData.TabStop = false;
            this.gbDepartureData.Text = "Departure Data";
            // 
            // dtpDepartureTime
            // 
            this.dtpDepartureTime.CustomFormat = "HH:mm, dd.MM.yyyy";
            this.dtpDepartureTime.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepartureTime.Location = new System.Drawing.Point(166, 78);
            this.dtpDepartureTime.Name = "dtpDepartureTime";
            this.dtpDepartureTime.Size = new System.Drawing.Size(182, 32);
            this.dtpDepartureTime.TabIndex = 1;
            // 
            // lbDepartureTime
            // 
            this.lbDepartureTime.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartureTime.Location = new System.Drawing.Point(6, 78);
            this.lbDepartureTime.Name = "lbDepartureTime";
            this.lbDepartureTime.Size = new System.Drawing.Size(154, 32);
            this.lbDepartureTime.TabIndex = 0;
            this.lbDepartureTime.Text = "Departure Time:";
            this.lbDepartureTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDeparturePlace
            // 
            this.lbDeparturePlace.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeparturePlace.Location = new System.Drawing.Point(6, 34);
            this.lbDeparturePlace.Name = "lbDeparturePlace";
            this.lbDeparturePlace.Size = new System.Drawing.Size(154, 32);
            this.lbDeparturePlace.TabIndex = 0;
            this.lbDeparturePlace.Text = "Departure Place:";
            this.lbDeparturePlace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbDeparturePlace
            // 
            this.tbDeparturePlace.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDeparturePlace.Location = new System.Drawing.Point(166, 34);
            this.tbDeparturePlace.Name = "tbDeparturePlace";
            this.tbDeparturePlace.Size = new System.Drawing.Size(182, 32);
            this.tbDeparturePlace.TabIndex = 1;
            // 
            // pbDeparturePlace
            // 
            this.pbDeparturePlace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDeparturePlace.Image = global::TicketManagementSystem.Properties.Resources.EditImg;
            this.pbDeparturePlace.Location = new System.Drawing.Point(354, 34);
            this.pbDeparturePlace.Name = "pbDeparturePlace";
            this.pbDeparturePlace.Size = new System.Drawing.Size(31, 32);
            this.pbDeparturePlace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDeparturePlace.TabIndex = 3;
            this.pbDeparturePlace.TabStop = false;
            // 
            // pbDepartureTime
            // 
            this.pbDepartureTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDepartureTime.Image = global::TicketManagementSystem.Properties.Resources.EditImg;
            this.pbDepartureTime.Location = new System.Drawing.Point(354, 78);
            this.pbDepartureTime.Name = "pbDepartureTime";
            this.pbDepartureTime.Size = new System.Drawing.Size(31, 32);
            this.pbDepartureTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDepartureTime.TabIndex = 3;
            this.pbDepartureTime.TabStop = false;
            // 
            // TripSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 496);
            this.Controls.Add(this.gbDepartureData);
            this.Controls.Add(this.gbTripData);
            this.Controls.Add(this.lbSettings);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TripSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.gbTripData.ResumeLayout(false);
            this.gbTripData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbName)).EndInit();
            this.gbDepartureData.ResumeLayout(false);
            this.gbDepartureData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeparturePlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartureTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbSettings;
        private System.Windows.Forms.GroupBox gbTripData;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.PictureBox pbName;
        private System.Windows.Forms.PictureBox pbState;
        private System.Windows.Forms.GroupBox gbDepartureData;
        private System.Windows.Forms.Label lbDepartureTime;
        private System.Windows.Forms.DateTimePicker dtpDepartureTime;
        private System.Windows.Forms.PictureBox pbDeparturePlace;
        private System.Windows.Forms.Label lbDeparturePlace;
        private System.Windows.Forms.TextBox tbDeparturePlace;
        private System.Windows.Forms.PictureBox pbDepartureTime;
    }
}