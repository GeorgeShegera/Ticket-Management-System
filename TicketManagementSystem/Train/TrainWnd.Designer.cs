namespace TicketManagementSystem
{
    partial class TrainWnd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainWnd));
            this.gbTrain = new System.Windows.Forms.GroupBox();
            this.lbEconomySeats = new System.Windows.Forms.Label();
            this.lbMiddleSeats = new System.Windows.Forms.Label();
            this.lbBusinessSeats = new System.Windows.Forms.Label();
            this.lbModel = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbTrips = new System.Windows.Forms.ListBox();
            this.btnAddTrip = new System.Windows.Forms.Button();
            this.btnCancelTrip = new System.Windows.Forms.Button();
            this.btnEditTrip = new System.Windows.Forms.Button();
            this.pbTrain = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbState = new System.Windows.Forms.Label();
            this.btnTrainSettings = new System.Windows.Forms.Button();
            this.gbTrain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrain)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTrain
            // 
            this.gbTrain.Controls.Add(this.lbState);
            this.gbTrain.Controls.Add(this.lbEconomySeats);
            this.gbTrain.Controls.Add(this.lbMiddleSeats);
            this.gbTrain.Controls.Add(this.lbBusinessSeats);
            this.gbTrain.Controls.Add(this.lbModel);
            this.gbTrain.Controls.Add(this.lbName);
            this.gbTrain.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTrain.Location = new System.Drawing.Point(283, 13);
            this.gbTrain.Margin = new System.Windows.Forms.Padding(4);
            this.gbTrain.Name = "gbTrain";
            this.gbTrain.Padding = new System.Windows.Forms.Padding(4);
            this.gbTrain.Size = new System.Drawing.Size(264, 242);
            this.gbTrain.TabIndex = 10;
            this.gbTrain.TabStop = false;
            this.gbTrain.Text = "Train Data";
            // 
            // lbEconomySeats
            // 
            this.lbEconomySeats.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEconomySeats.Location = new System.Drawing.Point(7, 178);
            this.lbEconomySeats.Name = "lbEconomySeats";
            this.lbEconomySeats.Size = new System.Drawing.Size(250, 25);
            this.lbEconomySeats.TabIndex = 0;
            this.lbEconomySeats.Text = "Economy class seats:";
            this.lbEconomySeats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbMiddleSeats
            // 
            this.lbMiddleSeats.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMiddleSeats.Location = new System.Drawing.Point(7, 144);
            this.lbMiddleSeats.Name = "lbMiddleSeats";
            this.lbMiddleSeats.Size = new System.Drawing.Size(250, 25);
            this.lbMiddleSeats.TabIndex = 0;
            this.lbMiddleSeats.Text = "Middle class seats:";
            this.lbMiddleSeats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbBusinessSeats
            // 
            this.lbBusinessSeats.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBusinessSeats.Location = new System.Drawing.Point(7, 108);
            this.lbBusinessSeats.Name = "lbBusinessSeats";
            this.lbBusinessSeats.Size = new System.Drawing.Size(250, 25);
            this.lbBusinessSeats.TabIndex = 0;
            this.lbBusinessSeats.Text = "Business class seats:";
            this.lbBusinessSeats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbModel
            // 
            this.lbModel.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModel.Location = new System.Drawing.Point(7, 74);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(250, 25);
            this.lbModel.TabIndex = 0;
            this.lbModel.Text = "Model:";
            this.lbModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(7, 39);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(250, 25);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name:";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTrips
            // 
            this.lbTrips.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrips.FormattingEnabled = true;
            this.lbTrips.ItemHeight = 21;
            this.lbTrips.Location = new System.Drawing.Point(12, 305);
            this.lbTrips.Margin = new System.Windows.Forms.Padding(4);
            this.lbTrips.Name = "lbTrips";
            this.lbTrips.Size = new System.Drawing.Size(360, 130);
            this.lbTrips.TabIndex = 6;
            // 
            // btnAddTrip
            // 
            this.btnAddTrip.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTrip.Location = new System.Drawing.Point(376, 341);
            this.btnAddTrip.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTrip.Name = "btnAddTrip";
            this.btnAddTrip.Size = new System.Drawing.Size(167, 26);
            this.btnAddTrip.TabIndex = 7;
            this.btnAddTrip.Text = "Add Trip";
            this.btnAddTrip.UseVisualStyleBackColor = true;
            // 
            // btnCancelTrip
            // 
            this.btnCancelTrip.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelTrip.Location = new System.Drawing.Point(376, 375);
            this.btnCancelTrip.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelTrip.Name = "btnCancelTrip";
            this.btnCancelTrip.Size = new System.Drawing.Size(167, 26);
            this.btnCancelTrip.TabIndex = 7;
            this.btnCancelTrip.Text = "Cancel Trip";
            this.btnCancelTrip.UseVisualStyleBackColor = true;
            // 
            // btnEditTrip
            // 
            this.btnEditTrip.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTrip.Location = new System.Drawing.Point(376, 409);
            this.btnEditTrip.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditTrip.Name = "btnEditTrip";
            this.btnEditTrip.Size = new System.Drawing.Size(167, 26);
            this.btnEditTrip.TabIndex = 7;
            this.btnEditTrip.Text = "Edit Trip";
            this.btnEditTrip.UseVisualStyleBackColor = true;
            // 
            // pbTrain
            // 
            this.pbTrain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbTrain.Image = ((System.Drawing.Image)(resources.GetObject("pbTrain.Image")));
            this.pbTrain.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbTrain.InitialImage")));
            this.pbTrain.Location = new System.Drawing.Point(13, 13);
            this.pbTrain.Margin = new System.Windows.Forms.Padding(4);
            this.pbTrain.Name = "pbTrain";
            this.pbTrain.Size = new System.Drawing.Size(262, 237);
            this.pbTrain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTrain.TabIndex = 0;
            this.pbTrain.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(359, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "List of trips";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbState
            // 
            this.lbState.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbState.Location = new System.Drawing.Point(7, 212);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(250, 25);
            this.lbState.TabIndex = 0;
            this.lbState.Text = "Status:";
            this.lbState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTrainSettings
            // 
            this.btnTrainSettings.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainSettings.Location = new System.Drawing.Point(376, 307);
            this.btnTrainSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnTrainSettings.Name = "btnTrainSettings";
            this.btnTrainSettings.Size = new System.Drawing.Size(167, 26);
            this.btnTrainSettings.TabIndex = 7;
            this.btnTrainSettings.Text = "Train Settings";
            this.btnTrainSettings.UseVisualStyleBackColor = true;
            this.btnTrainSettings.Click += new System.EventHandler(this.btnTrainSettings_Click);
            // 
            // TrainWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 444);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTrainSettings);
            this.Controls.Add(this.btnAddTrip);
            this.Controls.Add(this.btnCancelTrip);
            this.Controls.Add(this.btnEditTrip);
            this.Controls.Add(this.gbTrain);
            this.Controls.Add(this.pbTrain);
            this.Controls.Add(this.lbTrips);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TrainWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Train";
            this.gbTrain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTrain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTrain;
        private System.Windows.Forms.GroupBox gbTrain;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.Label lbEconomySeats;
        private System.Windows.Forms.Label lbMiddleSeats;
        private System.Windows.Forms.Label lbBusinessSeats;
        private System.Windows.Forms.ListBox lbTrips;
        private System.Windows.Forms.Button btnAddTrip;
        private System.Windows.Forms.Button btnCancelTrip;
        private System.Windows.Forms.Button btnEditTrip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.Button btnTrainSettings;
    }
}