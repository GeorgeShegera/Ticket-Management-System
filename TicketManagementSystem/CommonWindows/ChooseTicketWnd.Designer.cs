namespace TicketManagementSystem
{
    partial class ChooseTicketWnd
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
            this.gbTicketsFilters = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.nudMinPrice = new System.Windows.Forms.NumericUpDown();
            this.nudMaxPrice = new System.Windows.Forms.NumericUpDown();
            this.lbMinPrice = new System.Windows.Forms.Label();
            this.cbTicketType = new System.Windows.Forms.ComboBox();
            this.lbMaxPrice = new System.Windows.Forms.Label();
            this.lbTicketType = new System.Windows.Forms.Label();
            this.lTitle = new System.Windows.Forms.Label();
            this.lbTickets = new System.Windows.Forms.ListBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.gbTicketsFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTicketsFilters
            // 
            this.gbTicketsFilters.Controls.Add(this.btnClear);
            this.gbTicketsFilters.Controls.Add(this.btnApply);
            this.gbTicketsFilters.Controls.Add(this.nudMinPrice);
            this.gbTicketsFilters.Controls.Add(this.nudMaxPrice);
            this.gbTicketsFilters.Controls.Add(this.lbMinPrice);
            this.gbTicketsFilters.Controls.Add(this.cbTicketType);
            this.gbTicketsFilters.Controls.Add(this.lbMaxPrice);
            this.gbTicketsFilters.Controls.Add(this.lbTicketType);
            this.gbTicketsFilters.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTicketsFilters.Location = new System.Drawing.Point(12, 46);
            this.gbTicketsFilters.Name = "gbTicketsFilters";
            this.gbTicketsFilters.Size = new System.Drawing.Size(372, 251);
            this.gbTicketsFilters.TabIndex = 0;
            this.gbTicketsFilters.TabStop = false;
            this.gbTicketsFilters.Text = "Tickets\' Filters";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(6, 214);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 31);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(272, 214);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(94, 31);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // nudMinPrice
            // 
            this.nudMinPrice.Location = new System.Drawing.Point(165, 133);
            this.nudMinPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMinPrice.Name = "nudMinPrice";
            this.nudMinPrice.Size = new System.Drawing.Size(87, 28);
            this.nudMinPrice.TabIndex = 3;
            // 
            // nudMaxPrice
            // 
            this.nudMaxPrice.Location = new System.Drawing.Point(165, 86);
            this.nudMaxPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMaxPrice.Name = "nudMaxPrice";
            this.nudMaxPrice.Size = new System.Drawing.Size(87, 28);
            this.nudMaxPrice.TabIndex = 3;
            // 
            // lbMinPrice
            // 
            this.lbMinPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinPrice.Location = new System.Drawing.Point(6, 133);
            this.lbMinPrice.Name = "lbMinPrice";
            this.lbMinPrice.Size = new System.Drawing.Size(153, 28);
            this.lbMinPrice.TabIndex = 1;
            this.lbMinPrice.Text = "Minimum price:";
            this.lbMinPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbTicketType
            // 
            this.cbTicketType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTicketType.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTicketType.FormattingEnabled = true;
            this.cbTicketType.Location = new System.Drawing.Point(165, 42);
            this.cbTicketType.Name = "cbTicketType";
            this.cbTicketType.Size = new System.Drawing.Size(179, 29);
            this.cbTicketType.TabIndex = 2;
            // 
            // lbMaxPrice
            // 
            this.lbMaxPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaxPrice.Location = new System.Drawing.Point(6, 86);
            this.lbMaxPrice.Name = "lbMaxPrice";
            this.lbMaxPrice.Size = new System.Drawing.Size(153, 28);
            this.lbMaxPrice.TabIndex = 1;
            this.lbMaxPrice.Text = "Maximum price:";
            this.lbMaxPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTicketType
            // 
            this.lbTicketType.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTicketType.Location = new System.Drawing.Point(6, 42);
            this.lbTicketType.Name = "lbTicketType";
            this.lbTicketType.Size = new System.Drawing.Size(153, 29);
            this.lbTicketType.TabIndex = 1;
            this.lbTicketType.Text = "Ticket class:";
            this.lbTicketType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lTitle
            // 
            this.lTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.Location = new System.Drawing.Point(12, 9);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(612, 34);
            this.lTitle.TabIndex = 1;
            this.lTitle.Text = "Tickets\' buying ";
            this.lTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTickets
            // 
            this.lbTickets.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTickets.FormattingEnabled = true;
            this.lbTickets.ItemHeight = 21;
            this.lbTickets.Location = new System.Drawing.Point(390, 46);
            this.lbTickets.Name = "lbTickets";
            this.lbTickets.Size = new System.Drawing.Size(234, 214);
            this.lbTickets.TabIndex = 2;
            // 
            // btnBuy
            // 
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.Location = new System.Drawing.Point(530, 266);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(94, 31);
            this.btnBuy.TabIndex = 4;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(390, 266);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(94, 31);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // ChooseTicketWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 310);
            this.Controls.Add(this.lbTickets);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.gbTicketsFilters);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChooseTicketWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ticket Buying";
            this.gbTicketsFilters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTicketsFilters;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Label lbTicketType;
        private System.Windows.Forms.ListBox lbTickets;
        private System.Windows.Forms.NumericUpDown nudMaxPrice;
        private System.Windows.Forms.ComboBox cbTicketType;
        private System.Windows.Forms.Label lbMaxPrice;
        private System.Windows.Forms.NumericUpDown nudMinPrice;
        private System.Windows.Forms.Label lbMinPrice;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnView;
    }
}