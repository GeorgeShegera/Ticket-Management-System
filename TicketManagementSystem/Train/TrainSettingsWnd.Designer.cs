namespace TicketManagementSystem
{
    partial class TrainSettingsWnd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainSettingsWnd));
            this.lbName = new System.Windows.Forms.Label();
            this.lbSettings = new System.Windows.Forms.Label();
            this.gbTrainData = new System.Windows.Forms.GroupBox();
            this.cmState = new System.Windows.Forms.ComboBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbState = new System.Windows.Forms.Label();
            this.lbModel = new System.Windows.Forms.Label();
            this.pbState = new System.Windows.Forms.PictureBox();
            this.pbModel = new System.Windows.Forms.PictureBox();
            this.pbName = new System.Windows.Forms.PictureBox();
            this.gbTrainData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbName)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbName.Location = new System.Drawing.Point(6, 52);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(78, 32);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name:";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSettings
            // 
            this.lbSettings.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbSettings.Location = new System.Drawing.Point(12, 9);
            this.lbSettings.Name = "lbSettings";
            this.lbSettings.Size = new System.Drawing.Size(391, 32);
            this.lbSettings.TabIndex = 0;
            this.lbSettings.Text = "Settings";
            this.lbSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbTrainData
            // 
            this.gbTrainData.Controls.Add(this.pbState);
            this.gbTrainData.Controls.Add(this.pbModel);
            this.gbTrainData.Controls.Add(this.pbName);
            this.gbTrainData.Controls.Add(this.cmState);
            this.gbTrainData.Controls.Add(this.tbModel);
            this.gbTrainData.Controls.Add(this.tbName);
            this.gbTrainData.Controls.Add(this.lbState);
            this.gbTrainData.Controls.Add(this.lbModel);
            this.gbTrainData.Controls.Add(this.lbName);
            this.gbTrainData.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTrainData.Location = new System.Drawing.Point(12, 58);
            this.gbTrainData.Name = "gbTrainData";
            this.gbTrainData.Size = new System.Drawing.Size(391, 194);
            this.gbTrainData.TabIndex = 1;
            this.gbTrainData.TabStop = false;
            this.gbTrainData.Text = "Train Data";
            // 
            // cmState
            // 
            this.cmState.Enabled = false;
            this.cmState.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmState.FormattingEnabled = true;
            this.cmState.Location = new System.Drawing.Point(90, 145);
            this.cmState.Name = "cmState";
            this.cmState.Size = new System.Drawing.Size(145, 31);
            this.cmState.TabIndex = 2;
            this.cmState.Tag = "State";
            this.cmState.SelectedIndexChanged += new System.EventHandler(this.Data_Changed);
            // 
            // tbModel
            // 
            this.tbModel.Enabled = false;
            this.tbModel.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModel.Location = new System.Drawing.Point(90, 99);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(250, 32);
            this.tbModel.TabIndex = 1;
            this.tbModel.Tag = "Model";
            this.tbModel.TextChanged += new System.EventHandler(this.Data_Changed);
            // 
            // tbName
            // 
            this.tbName.Enabled = false;
            this.tbName.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(90, 52);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(250, 32);
            this.tbName.TabIndex = 1;
            this.tbName.Tag = "Name";
            this.tbName.TextChanged += new System.EventHandler(this.Data_Changed);
            // 
            // lbState
            // 
            this.lbState.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbState.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbState.Location = new System.Drawing.Point(6, 145);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(78, 31);
            this.lbState.TabIndex = 0;
            this.lbState.Text = "State:";
            this.lbState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbModel
            // 
            this.lbModel.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbModel.Location = new System.Drawing.Point(6, 99);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(78, 32);
            this.lbModel.TabIndex = 0;
            this.lbModel.Text = "Model:";
            this.lbModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbState
            // 
            this.pbState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbState.Image = ((System.Drawing.Image)(resources.GetObject("pbState.Image")));
            this.pbState.Location = new System.Drawing.Point(241, 145);
            this.pbState.Name = "pbState";
            this.pbState.Size = new System.Drawing.Size(32, 31);
            this.pbState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbState.TabIndex = 3;
            this.pbState.TabStop = false;
            this.pbState.Tag = "State";
            this.pbState.Click += new System.EventHandler(this.Edit_Click);
            // 
            // pbModel
            // 
            this.pbModel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbModel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbModel.Image = ((System.Drawing.Image)(resources.GetObject("pbModel.Image")));
            this.pbModel.Location = new System.Drawing.Point(346, 99);
            this.pbModel.Name = "pbModel";
            this.pbModel.Size = new System.Drawing.Size(32, 32);
            this.pbModel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbModel.TabIndex = 3;
            this.pbModel.TabStop = false;
            this.pbModel.Tag = "Model";
            this.pbModel.Click += new System.EventHandler(this.Edit_Click);
            // 
            // pbName
            // 
            this.pbName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbName.Image = ((System.Drawing.Image)(resources.GetObject("pbName.Image")));
            this.pbName.Location = new System.Drawing.Point(346, 52);
            this.pbName.Name = "pbName";
            this.pbName.Size = new System.Drawing.Size(32, 32);
            this.pbName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbName.TabIndex = 3;
            this.pbName.TabStop = false;
            this.pbName.Tag = "Name";
            this.pbName.Click += new System.EventHandler(this.Edit_Click);
            // 
            // TrainSettingsWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 260);
            this.Controls.Add(this.gbTrainData);
            this.Controls.Add(this.lbSettings);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TrainSettingsWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Train Settings";
            this.gbTrainData.ResumeLayout(false);
            this.gbTrainData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSettings;
        private System.Windows.Forms.GroupBox gbTrainData;
        private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.ComboBox cmState;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.PictureBox pbState;
        private System.Windows.Forms.PictureBox pbModel;
        private System.Windows.Forms.PictureBox pbName;
    }
}