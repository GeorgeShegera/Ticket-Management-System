namespace TicketManagementSystem
{
    partial class TripCreatingWnd
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
            this.components = new System.ComponentModel.Container();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.gbTripData = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numMiddlePrice = new System.Windows.Forms.NumericUpDown();
            this.numEconomyPrice = new System.Windows.Forms.NumericUpDown();
            this.lbBusinessPrice = new System.Windows.Forms.Label();
            this.lbMiddlePrice = new System.Windows.Forms.Label();
            this.lbEconomyPrice = new System.Windows.Forms.Label();
            this.gbDepartureData = new System.Windows.Forms.GroupBox();
            this.dtpDepatureTime = new System.Windows.Forms.DateTimePicker();
            this.tbDepaturePlace = new System.Windows.Forms.TextBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbDeparturePlace = new System.Windows.Forms.Label();
            this.gbArrivalData = new System.Windows.Forms.GroupBox();
            this.dtpArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.tbArrivalPlace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbTripData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMiddlePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEconomyPrice)).BeginInit();
            this.gbDepartureData.SuspendLayout();
            this.gbArrivalData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(199, 31);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(276, 32);
            this.tbName.TabIndex = 0;
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(6, 31);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(187, 32);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name:";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(487, 33);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Trip Creating";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbTripData
            // 
            this.gbTripData.Controls.Add(this.numericUpDown1);
            this.gbTripData.Controls.Add(this.numMiddlePrice);
            this.gbTripData.Controls.Add(this.numEconomyPrice);
            this.gbTripData.Controls.Add(this.lbBusinessPrice);
            this.gbTripData.Controls.Add(this.lbMiddlePrice);
            this.gbTripData.Controls.Add(this.lbEconomyPrice);
            this.gbTripData.Controls.Add(this.lbName);
            this.gbTripData.Controls.Add(this.tbName);
            this.gbTripData.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTripData.Location = new System.Drawing.Point(12, 45);
            this.gbTripData.Name = "gbTripData";
            this.gbTripData.Size = new System.Drawing.Size(481, 204);
            this.gbTripData.TabIndex = 2;
            this.gbTripData.TabStop = false;
            this.gbTripData.Text = "Trip Data";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(199, 162);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(61, 32);
            this.numericUpDown1.TabIndex = 2;
            // 
            // numMiddlePrice
            // 
            this.numMiddlePrice.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMiddlePrice.Location = new System.Drawing.Point(199, 115);
            this.numMiddlePrice.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.numMiddlePrice.Name = "numMiddlePrice";
            this.numMiddlePrice.Size = new System.Drawing.Size(61, 32);
            this.numMiddlePrice.TabIndex = 2;
            // 
            // numEconomyPrice
            // 
            this.numEconomyPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEconomyPrice.Location = new System.Drawing.Point(199, 74);
            this.numEconomyPrice.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.numEconomyPrice.Name = "numEconomyPrice";
            this.numEconomyPrice.Size = new System.Drawing.Size(61, 32);
            this.numEconomyPrice.TabIndex = 2;
            // 
            // lbBusinessPrice
            // 
            this.lbBusinessPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBusinessPrice.Location = new System.Drawing.Point(6, 159);
            this.lbBusinessPrice.Name = "lbBusinessPrice";
            this.lbBusinessPrice.Size = new System.Drawing.Size(187, 32);
            this.lbBusinessPrice.TabIndex = 1;
            this.lbBusinessPrice.Text = "Business class price:";
            this.lbBusinessPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbMiddlePrice
            // 
            this.lbMiddlePrice.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMiddlePrice.Location = new System.Drawing.Point(6, 115);
            this.lbMiddlePrice.Name = "lbMiddlePrice";
            this.lbMiddlePrice.Size = new System.Drawing.Size(187, 32);
            this.lbMiddlePrice.TabIndex = 1;
            this.lbMiddlePrice.Text = "Middle class price:";
            this.lbMiddlePrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbEconomyPrice
            // 
            this.lbEconomyPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEconomyPrice.Location = new System.Drawing.Point(6, 74);
            this.lbEconomyPrice.Name = "lbEconomyPrice";
            this.lbEconomyPrice.Size = new System.Drawing.Size(187, 32);
            this.lbEconomyPrice.TabIndex = 1;
            this.lbEconomyPrice.Text = "Economy class price:";
            this.lbEconomyPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbDepartureData
            // 
            this.gbDepartureData.Controls.Add(this.dtpDepatureTime);
            this.gbDepartureData.Controls.Add(this.tbDepaturePlace);
            this.gbDepartureData.Controls.Add(this.lbTime);
            this.gbDepartureData.Controls.Add(this.lbDeparturePlace);
            this.gbDepartureData.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDepartureData.Location = new System.Drawing.Point(12, 255);
            this.gbDepartureData.Name = "gbDepartureData";
            this.gbDepartureData.Size = new System.Drawing.Size(481, 124);
            this.gbDepartureData.TabIndex = 3;
            this.gbDepartureData.TabStop = false;
            this.gbDepartureData.Text = "Departure Data";
            // 
            // dtpDepatureTime
            // 
            this.dtpDepatureTime.CustomFormat = "hh:mm, dd.MM.yyyy";
            this.dtpDepatureTime.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDepatureTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepatureTime.Location = new System.Drawing.Point(199, 80);
            this.dtpDepatureTime.Name = "dtpDepatureTime";
            this.dtpDepatureTime.Size = new System.Drawing.Size(188, 32);
            this.dtpDepatureTime.TabIndex = 2;
            // 
            // tbDepaturePlace
            // 
            this.tbDepaturePlace.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDepaturePlace.Location = new System.Drawing.Point(199, 35);
            this.tbDepaturePlace.Name = "tbDepaturePlace";
            this.tbDepaturePlace.Size = new System.Drawing.Size(276, 32);
            this.tbDepaturePlace.TabIndex = 0;
            // 
            // lbTime
            // 
            this.lbTime.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(6, 80);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(187, 32);
            this.lbTime.TabIndex = 1;
            this.lbTime.Text = "Time:";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDeparturePlace
            // 
            this.lbDeparturePlace.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeparturePlace.Location = new System.Drawing.Point(6, 35);
            this.lbDeparturePlace.Name = "lbDeparturePlace";
            this.lbDeparturePlace.Size = new System.Drawing.Size(187, 32);
            this.lbDeparturePlace.TabIndex = 1;
            this.lbDeparturePlace.Text = "Place:";
            this.lbDeparturePlace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbArrivalData
            // 
            this.gbArrivalData.Controls.Add(this.dtpArrivalDate);
            this.gbArrivalData.Controls.Add(this.tbArrivalPlace);
            this.gbArrivalData.Controls.Add(this.label1);
            this.gbArrivalData.Controls.Add(this.label2);
            this.gbArrivalData.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbArrivalData.Location = new System.Drawing.Point(12, 385);
            this.gbArrivalData.Name = "gbArrivalData";
            this.gbArrivalData.Size = new System.Drawing.Size(481, 124);
            this.gbArrivalData.TabIndex = 3;
            this.gbArrivalData.TabStop = false;
            this.gbArrivalData.Text = "Arrival Data";
            // 
            // dtpArrivalDate
            // 
            this.dtpArrivalDate.CustomFormat = "hh:mm, dd.MM.yyyy";
            this.dtpArrivalDate.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpArrivalDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpArrivalDate.Location = new System.Drawing.Point(199, 80);
            this.dtpArrivalDate.Name = "dtpArrivalDate";
            this.dtpArrivalDate.Size = new System.Drawing.Size(188, 32);
            this.dtpArrivalDate.TabIndex = 2;
            // 
            // tbArrivalPlace
            // 
            this.tbArrivalPlace.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbArrivalPlace.Location = new System.Drawing.Point(199, 35);
            this.tbArrivalPlace.Name = "tbArrivalPlace";
            this.tbArrivalPlace.Size = new System.Drawing.Size(276, 32);
            this.tbArrivalPlace.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Place:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(342, 515);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(151, 43);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // TripCreatingWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 565);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbArrivalData);
            this.Controls.Add(this.gbDepartureData);
            this.Controls.Add(this.gbTripData);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TripCreatingWnd";
            this.Text = "Trip Creating";
            this.gbTripData.ResumeLayout(false);
            this.gbTripData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMiddlePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEconomyPrice)).EndInit();
            this.gbDepartureData.ResumeLayout(false);
            this.gbDepartureData.PerformLayout();
            this.gbArrivalData.ResumeLayout(false);
            this.gbArrivalData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox gbTripData;
        private System.Windows.Forms.Label lbEconomyPrice;
        private System.Windows.Forms.NumericUpDown numEconomyPrice;
        private System.Windows.Forms.Label lbMiddlePrice;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numMiddlePrice;
        private System.Windows.Forms.Label lbBusinessPrice;
        private System.Windows.Forms.GroupBox gbDepartureData;
        private System.Windows.Forms.TextBox tbDepaturePlace;
        private System.Windows.Forms.Label lbDeparturePlace;
        private System.Windows.Forms.DateTimePicker dtpDepatureTime;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.GroupBox gbArrivalData;
        private System.Windows.Forms.DateTimePicker dtpArrivalDate;
        private System.Windows.Forms.TextBox tbArrivalPlace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}