namespace TicketManagementSystem
{
    partial class BalanceReplenishmentWnd
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
            this.LbCurBalace = new System.Windows.Forms.Label();
            this.LbReplenishment = new System.Windows.Forms.Label();
            this.GbReplenishment = new System.Windows.Forms.GroupBox();
            this.NudSum = new System.Windows.Forms.NumericUpDown();
            this.BtnReplenishment = new System.Windows.Forms.Button();
            this.GbReplenishment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudSum)).BeginInit();
            this.SuspendLayout();
            // 
            // LbCurBalace
            // 
            this.LbCurBalace.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCurBalace.Location = new System.Drawing.Point(10, 21);
            this.LbCurBalace.Name = "LbCurBalace";
            this.LbCurBalace.Size = new System.Drawing.Size(274, 32);
            this.LbCurBalace.TabIndex = 0;
            this.LbCurBalace.Text = "Current Balace: ";
            this.LbCurBalace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbReplenishment
            // 
            this.LbReplenishment.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbReplenishment.Location = new System.Drawing.Point(6, 26);
            this.LbReplenishment.Name = "LbReplenishment";
            this.LbReplenishment.Size = new System.Drawing.Size(71, 32);
            this.LbReplenishment.TabIndex = 0;
            this.LbReplenishment.Text = "Sum:";
            this.LbReplenishment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GbReplenishment
            // 
            this.GbReplenishment.Controls.Add(this.BtnReplenishment);
            this.GbReplenishment.Controls.Add(this.NudSum);
            this.GbReplenishment.Controls.Add(this.LbReplenishment);
            this.GbReplenishment.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbReplenishment.Location = new System.Drawing.Point(15, 66);
            this.GbReplenishment.Name = "GbReplenishment";
            this.GbReplenishment.Size = new System.Drawing.Size(269, 106);
            this.GbReplenishment.TabIndex = 2;
            this.GbReplenishment.TabStop = false;
            this.GbReplenishment.Text = "Replenishment";
            // 
            // NudSum
            // 
            this.NudSum.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NudSum.Location = new System.Drawing.Point(83, 26);
            this.NudSum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NudSum.Name = "NudSum";
            this.NudSum.Size = new System.Drawing.Size(175, 32);
            this.NudSum.TabIndex = 1;
            // 
            // BtnReplenishment
            // 
            this.BtnReplenishment.Location = new System.Drawing.Point(173, 70);
            this.BtnReplenishment.Name = "BtnReplenishment";
            this.BtnReplenishment.Size = new System.Drawing.Size(85, 32);
            this.BtnReplenishment.TabIndex = 2;
            this.BtnReplenishment.Text = "Replenish";
            this.BtnReplenishment.UseVisualStyleBackColor = true;
            this.BtnReplenishment.Click += new System.EventHandler(this.BtnReplenishment_Click);
            // 
            // BalanceReplenishmentWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 180);
            this.Controls.Add(this.GbReplenishment);
            this.Controls.Add(this.LbCurBalace);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BalanceReplenishmentWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balance Replenishment";
            this.GbReplenishment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NudSum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LbCurBalace;
        private System.Windows.Forms.Label LbReplenishment;
        private System.Windows.Forms.GroupBox GbReplenishment;
        private System.Windows.Forms.Button BtnReplenishment;
        private System.Windows.Forms.NumericUpDown NudSum;
    }
}