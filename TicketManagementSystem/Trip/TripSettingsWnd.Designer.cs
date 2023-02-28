namespace TicketManagementSystem
{
    partial class TripSettingsWnd
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
            this.cbState = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbState = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.gbDepartureData = new System.Windows.Forms.GroupBox();
            this.dtpDepartureDateTime = new System.Windows.Forms.DateTimePicker();
            this.pbDepartureTime = new System.Windows.Forms.PictureBox();
            this.pbDeparturePlace = new System.Windows.Forms.PictureBox();
            this.lbDeparturePlace = new System.Windows.Forms.Label();
            this.lbDepartureTime = new System.Windows.Forms.Label();
            this.tbDeparturePlace = new System.Windows.Forms.TextBox();
            this.gbArrivalData = new System.Windows.Forms.GroupBox();
            this.dtpArrivalDateTime = new System.Windows.Forms.DateTimePicker();
            this.pbArrivalTime = new System.Windows.Forms.PictureBox();
            this.lbArrivalDate = new System.Windows.Forms.Label();
            this.lbArrivalPlace = new System.Windows.Forms.Label();
            this.tbArrivalPlace = new System.Windows.Forms.TextBox();
            this.pbArrivalPlace = new System.Windows.Forms.PictureBox();
            this.lbEconomyPrice = new System.Windows.Forms.Label();
            this.gbPrices = new System.Windows.Forms.GroupBox();
            this.nudBusinessPrice = new System.Windows.Forms.NumericUpDown();
            this.pbBusinessPrice = new System.Windows.Forms.PictureBox();
            this.pbMiddlePrice = new System.Windows.Forms.PictureBox();
            this.pbEconomyPrice = new System.Windows.Forms.PictureBox();
            this.nudMiddlePrice = new System.Windows.Forms.NumericUpDown();
            this.nudEconomyPrice = new System.Windows.Forms.NumericUpDown();
            this.lbBusinessPrice = new System.Windows.Forms.Label();
            this.lbMiddlePrice = new System.Windows.Forms.Label();
            this.gbTripData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbName)).BeginInit();
            this.gbDepartureData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartureTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeparturePlace)).BeginInit();
            this.gbArrivalData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrivalTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrivalPlace)).BeginInit();
            this.gbPrices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBusinessPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBusinessPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiddlePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEconomyPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiddlePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEconomyPrice)).BeginInit();
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
            this.gbTripData.Controls.Add(this.cbState);
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
            this.pbState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbState.Image = global::TicketManagementSystem.Properties.Resources.EditImg;
            this.pbState.Location = new System.Drawing.Point(255, 72);
            this.pbState.Name = "pbState";
            this.pbState.Size = new System.Drawing.Size(31, 31);
            this.pbState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbState.TabIndex = 3;
            this.pbState.TabStop = false;
            this.pbState.Tag = "State";
            this.pbState.Click += new System.EventHandler(this.Edit_Click);
            // 
            // pbName
            // 
            this.pbName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbName.Image = global::TicketManagementSystem.Properties.Resources.EditImg;
            this.pbName.Location = new System.Drawing.Point(354, 31);
            this.pbName.Name = "pbName";
            this.pbName.Size = new System.Drawing.Size(31, 32);
            this.pbName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbName.TabIndex = 3;
            this.pbName.TabStop = false;
            this.pbName.Tag = "Name";
            this.pbName.Click += new System.EventHandler(this.Edit_Click);
            // 
            // cbState
            // 
            this.cbState.Enabled = false;
            this.cbState.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbState.FormattingEnabled = true;
            this.cbState.Location = new System.Drawing.Point(84, 72);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(165, 31);
            this.cbState.TabIndex = 2;
            this.cbState.Tag = "State";
            this.cbState.SelectedIndexChanged += new System.EventHandler(this.DataChange);
            // 
            // tbName
            // 
            this.tbName.Enabled = false;
            this.tbName.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(84, 31);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(264, 32);
            this.tbName.TabIndex = 1;
            this.tbName.Tag = "Name";
            this.tbName.TextChanged += new System.EventHandler(this.DataChange);
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
            this.gbDepartureData.Controls.Add(this.dtpDepartureDateTime);
            this.gbDepartureData.Controls.Add(this.pbDepartureTime);
            this.gbDepartureData.Controls.Add(this.pbDeparturePlace);
            this.gbDepartureData.Controls.Add(this.lbDeparturePlace);
            this.gbDepartureData.Controls.Add(this.lbDepartureTime);
            this.gbDepartureData.Controls.Add(this.tbDeparturePlace);
            this.gbDepartureData.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDepartureData.Location = new System.Drawing.Point(12, 176);
            this.gbDepartureData.Name = "gbDepartureData";
            this.gbDepartureData.Size = new System.Drawing.Size(395, 125);
            this.gbDepartureData.TabIndex = 2;
            this.gbDepartureData.TabStop = false;
            this.gbDepartureData.Text = "Departure Data";
            // 
            // dtpDepartureDateTime
            // 
            this.dtpDepartureDateTime.CustomFormat = "HH:mm, dd.MM.yyyy";
            this.dtpDepartureDateTime.Enabled = false;
            this.dtpDepartureDateTime.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDepartureDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepartureDateTime.Location = new System.Drawing.Point(166, 83);
            this.dtpDepartureDateTime.Name = "dtpDepartureDateTime";
            this.dtpDepartureDateTime.Size = new System.Drawing.Size(182, 32);
            this.dtpDepartureDateTime.TabIndex = 1;
            this.dtpDepartureDateTime.Tag = "DepartTime";
            this.dtpDepartureDateTime.ValueChanged += new System.EventHandler(this.DataChange);
            // 
            // pbDepartureTime
            // 
            this.pbDepartureTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDepartureTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDepartureTime.Image = global::TicketManagementSystem.Properties.Resources.EditImg;
            this.pbDepartureTime.Location = new System.Drawing.Point(354, 83);
            this.pbDepartureTime.Name = "pbDepartureTime";
            this.pbDepartureTime.Size = new System.Drawing.Size(31, 32);
            this.pbDepartureTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDepartureTime.TabIndex = 3;
            this.pbDepartureTime.TabStop = false;
            this.pbDepartureTime.Tag = "DepartTime";
            this.pbDepartureTime.Click += new System.EventHandler(this.Edit_Click);
            // 
            // pbDeparturePlace
            // 
            this.pbDeparturePlace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDeparturePlace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDeparturePlace.Image = global::TicketManagementSystem.Properties.Resources.EditImg;
            this.pbDeparturePlace.Location = new System.Drawing.Point(354, 35);
            this.pbDeparturePlace.Name = "pbDeparturePlace";
            this.pbDeparturePlace.Size = new System.Drawing.Size(31, 32);
            this.pbDeparturePlace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDeparturePlace.TabIndex = 3;
            this.pbDeparturePlace.TabStop = false;
            this.pbDeparturePlace.Tag = "DepartPlace";
            this.pbDeparturePlace.Click += new System.EventHandler(this.Edit_Click);
            // 
            // lbDeparturePlace
            // 
            this.lbDeparturePlace.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeparturePlace.Location = new System.Drawing.Point(6, 35);
            this.lbDeparturePlace.Name = "lbDeparturePlace";
            this.lbDeparturePlace.Size = new System.Drawing.Size(154, 32);
            this.lbDeparturePlace.TabIndex = 0;
            this.lbDeparturePlace.Text = "Departure Place:";
            this.lbDeparturePlace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDepartureTime
            // 
            this.lbDepartureTime.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartureTime.Location = new System.Drawing.Point(6, 83);
            this.lbDepartureTime.Name = "lbDepartureTime";
            this.lbDepartureTime.Size = new System.Drawing.Size(154, 32);
            this.lbDepartureTime.TabIndex = 0;
            this.lbDepartureTime.Text = "Departure Time:";
            this.lbDepartureTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbDeparturePlace
            // 
            this.tbDeparturePlace.Enabled = false;
            this.tbDeparturePlace.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDeparturePlace.Location = new System.Drawing.Point(166, 35);
            this.tbDeparturePlace.Name = "tbDeparturePlace";
            this.tbDeparturePlace.Size = new System.Drawing.Size(182, 32);
            this.tbDeparturePlace.TabIndex = 1;
            this.tbDeparturePlace.Tag = "DepartPlace";
            this.tbDeparturePlace.TextChanged += new System.EventHandler(this.DataChange);
            // 
            // gbArrivalData
            // 
            this.gbArrivalData.Controls.Add(this.dtpArrivalDateTime);
            this.gbArrivalData.Controls.Add(this.pbArrivalTime);
            this.gbArrivalData.Controls.Add(this.lbArrivalDate);
            this.gbArrivalData.Controls.Add(this.lbArrivalPlace);
            this.gbArrivalData.Controls.Add(this.tbArrivalPlace);
            this.gbArrivalData.Controls.Add(this.pbArrivalPlace);
            this.gbArrivalData.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbArrivalData.Location = new System.Drawing.Point(12, 307);
            this.gbArrivalData.Name = "gbArrivalData";
            this.gbArrivalData.Size = new System.Drawing.Size(395, 125);
            this.gbArrivalData.TabIndex = 3;
            this.gbArrivalData.TabStop = false;
            this.gbArrivalData.Text = "Arrival Data";
            // 
            // dtpArrivalDateTime
            // 
            this.dtpArrivalDateTime.CustomFormat = "HH:mm, dd.MM.yyyy";
            this.dtpArrivalDateTime.Enabled = false;
            this.dtpArrivalDateTime.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpArrivalDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpArrivalDateTime.Location = new System.Drawing.Point(166, 83);
            this.dtpArrivalDateTime.Name = "dtpArrivalDateTime";
            this.dtpArrivalDateTime.Size = new System.Drawing.Size(182, 32);
            this.dtpArrivalDateTime.TabIndex = 1;
            this.dtpArrivalDateTime.Tag = "ArrivalTime";
            this.dtpArrivalDateTime.ValueChanged += new System.EventHandler(this.DataChange);
            // 
            // pbArrivalTime
            // 
            this.pbArrivalTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbArrivalTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbArrivalTime.Image = global::TicketManagementSystem.Properties.Resources.EditImg;
            this.pbArrivalTime.Location = new System.Drawing.Point(354, 83);
            this.pbArrivalTime.Name = "pbArrivalTime";
            this.pbArrivalTime.Size = new System.Drawing.Size(31, 32);
            this.pbArrivalTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArrivalTime.TabIndex = 3;
            this.pbArrivalTime.TabStop = false;
            this.pbArrivalTime.Tag = "ArrivalTime";
            this.pbArrivalTime.Click += new System.EventHandler(this.Edit_Click);
            // 
            // lbArrivalDate
            // 
            this.lbArrivalDate.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArrivalDate.Location = new System.Drawing.Point(6, 83);
            this.lbArrivalDate.Name = "lbArrivalDate";
            this.lbArrivalDate.Size = new System.Drawing.Size(154, 32);
            this.lbArrivalDate.TabIndex = 0;
            this.lbArrivalDate.Text = "Arrival Time:";
            this.lbArrivalDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbArrivalPlace
            // 
            this.lbArrivalPlace.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArrivalPlace.Location = new System.Drawing.Point(6, 35);
            this.lbArrivalPlace.Name = "lbArrivalPlace";
            this.lbArrivalPlace.Size = new System.Drawing.Size(154, 32);
            this.lbArrivalPlace.TabIndex = 0;
            this.lbArrivalPlace.Text = "Arrival Place:";
            this.lbArrivalPlace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbArrivalPlace
            // 
            this.tbArrivalPlace.Enabled = false;
            this.tbArrivalPlace.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbArrivalPlace.Location = new System.Drawing.Point(166, 35);
            this.tbArrivalPlace.Name = "tbArrivalPlace";
            this.tbArrivalPlace.Size = new System.Drawing.Size(182, 32);
            this.tbArrivalPlace.TabIndex = 1;
            this.tbArrivalPlace.Tag = "ArrivalPlace";
            this.tbArrivalPlace.TextChanged += new System.EventHandler(this.DataChange);
            // 
            // pbArrivalPlace
            // 
            this.pbArrivalPlace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbArrivalPlace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbArrivalPlace.Image = global::TicketManagementSystem.Properties.Resources.EditImg;
            this.pbArrivalPlace.Location = new System.Drawing.Point(354, 35);
            this.pbArrivalPlace.Name = "pbArrivalPlace";
            this.pbArrivalPlace.Size = new System.Drawing.Size(31, 32);
            this.pbArrivalPlace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArrivalPlace.TabIndex = 3;
            this.pbArrivalPlace.TabStop = false;
            this.pbArrivalPlace.Tag = "ArrivalPlace";
            this.pbArrivalPlace.Click += new System.EventHandler(this.Edit_Click);
            // 
            // lbEconomyPrice
            // 
            this.lbEconomyPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEconomyPrice.Location = new System.Drawing.Point(6, 32);
            this.lbEconomyPrice.Name = "lbEconomyPrice";
            this.lbEconomyPrice.Size = new System.Drawing.Size(197, 32);
            this.lbEconomyPrice.TabIndex = 0;
            this.lbEconomyPrice.Text = "Economy class price:";
            this.lbEconomyPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbPrices
            // 
            this.gbPrices.Controls.Add(this.nudBusinessPrice);
            this.gbPrices.Controls.Add(this.pbBusinessPrice);
            this.gbPrices.Controls.Add(this.pbMiddlePrice);
            this.gbPrices.Controls.Add(this.pbEconomyPrice);
            this.gbPrices.Controls.Add(this.nudMiddlePrice);
            this.gbPrices.Controls.Add(this.nudEconomyPrice);
            this.gbPrices.Controls.Add(this.lbBusinessPrice);
            this.gbPrices.Controls.Add(this.lbMiddlePrice);
            this.gbPrices.Controls.Add(this.lbEconomyPrice);
            this.gbPrices.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrices.Location = new System.Drawing.Point(12, 438);
            this.gbPrices.Name = "gbPrices";
            this.gbPrices.Size = new System.Drawing.Size(395, 159);
            this.gbPrices.TabIndex = 4;
            this.gbPrices.TabStop = false;
            this.gbPrices.Text = "Prices";
            // 
            // nudBusinessPrice
            // 
            this.nudBusinessPrice.Enabled = false;
            this.nudBusinessPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBusinessPrice.Location = new System.Drawing.Point(209, 118);
            this.nudBusinessPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudBusinessPrice.Name = "nudBusinessPrice";
            this.nudBusinessPrice.Size = new System.Drawing.Size(77, 32);
            this.nudBusinessPrice.TabIndex = 1;
            this.nudBusinessPrice.Tag = "BusinessPrice";
            this.nudBusinessPrice.ValueChanged += new System.EventHandler(this.DataChange);
            // 
            // pbBusinessPrice
            // 
            this.pbBusinessPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbBusinessPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBusinessPrice.Image = global::TicketManagementSystem.Properties.Resources.EditImg;
            this.pbBusinessPrice.Location = new System.Drawing.Point(292, 118);
            this.pbBusinessPrice.Name = "pbBusinessPrice";
            this.pbBusinessPrice.Size = new System.Drawing.Size(31, 32);
            this.pbBusinessPrice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBusinessPrice.TabIndex = 3;
            this.pbBusinessPrice.TabStop = false;
            this.pbBusinessPrice.Tag = "BusinessPrice";
            this.pbBusinessPrice.Click += new System.EventHandler(this.Edit_Click);
            // 
            // pbMiddlePrice
            // 
            this.pbMiddlePrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbMiddlePrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMiddlePrice.Image = global::TicketManagementSystem.Properties.Resources.EditImg;
            this.pbMiddlePrice.Location = new System.Drawing.Point(292, 77);
            this.pbMiddlePrice.Name = "pbMiddlePrice";
            this.pbMiddlePrice.Size = new System.Drawing.Size(31, 32);
            this.pbMiddlePrice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMiddlePrice.TabIndex = 3;
            this.pbMiddlePrice.TabStop = false;
            this.pbMiddlePrice.Tag = "MiddlePrice";
            this.pbMiddlePrice.Click += new System.EventHandler(this.Edit_Click);
            // 
            // pbEconomyPrice
            // 
            this.pbEconomyPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbEconomyPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEconomyPrice.Image = global::TicketManagementSystem.Properties.Resources.EditImg;
            this.pbEconomyPrice.Location = new System.Drawing.Point(292, 32);
            this.pbEconomyPrice.Name = "pbEconomyPrice";
            this.pbEconomyPrice.Size = new System.Drawing.Size(31, 32);
            this.pbEconomyPrice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEconomyPrice.TabIndex = 3;
            this.pbEconomyPrice.TabStop = false;
            this.pbEconomyPrice.Tag = "EconomyPrice";
            this.pbEconomyPrice.Click += new System.EventHandler(this.Edit_Click);
            // 
            // nudMiddlePrice
            // 
            this.nudMiddlePrice.Enabled = false;
            this.nudMiddlePrice.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMiddlePrice.Location = new System.Drawing.Point(209, 77);
            this.nudMiddlePrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMiddlePrice.Name = "nudMiddlePrice";
            this.nudMiddlePrice.Size = new System.Drawing.Size(77, 32);
            this.nudMiddlePrice.TabIndex = 1;
            this.nudMiddlePrice.Tag = "MiddlePrice";
            this.nudMiddlePrice.ValueChanged += new System.EventHandler(this.DataChange);
            // 
            // nudEconomyPrice
            // 
            this.nudEconomyPrice.Enabled = false;
            this.nudEconomyPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudEconomyPrice.Location = new System.Drawing.Point(209, 32);
            this.nudEconomyPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudEconomyPrice.Name = "nudEconomyPrice";
            this.nudEconomyPrice.Size = new System.Drawing.Size(77, 32);
            this.nudEconomyPrice.TabIndex = 1;
            this.nudEconomyPrice.Tag = "EconomyPrice";
            this.nudEconomyPrice.ValueChanged += new System.EventHandler(this.DataChange);
            // 
            // lbBusinessPrice
            // 
            this.lbBusinessPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBusinessPrice.Location = new System.Drawing.Point(6, 118);
            this.lbBusinessPrice.Name = "lbBusinessPrice";
            this.lbBusinessPrice.Size = new System.Drawing.Size(197, 32);
            this.lbBusinessPrice.TabIndex = 0;
            this.lbBusinessPrice.Text = "Business class price:";
            this.lbBusinessPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbMiddlePrice
            // 
            this.lbMiddlePrice.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMiddlePrice.Location = new System.Drawing.Point(6, 77);
            this.lbMiddlePrice.Name = "lbMiddlePrice";
            this.lbMiddlePrice.Size = new System.Drawing.Size(197, 32);
            this.lbMiddlePrice.TabIndex = 0;
            this.lbMiddlePrice.Text = "Middle class price:";
            this.lbMiddlePrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TripSettingsWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 604);
            this.Controls.Add(this.gbPrices);
            this.Controls.Add(this.gbArrivalData);
            this.Controls.Add(this.gbDepartureData);
            this.Controls.Add(this.gbTripData);
            this.Controls.Add(this.lbSettings);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TripSettingsWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.gbTripData.ResumeLayout(false);
            this.gbTripData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbName)).EndInit();
            this.gbDepartureData.ResumeLayout(false);
            this.gbDepartureData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartureTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeparturePlace)).EndInit();
            this.gbArrivalData.ResumeLayout(false);
            this.gbArrivalData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrivalTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrivalPlace)).EndInit();
            this.gbPrices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudBusinessPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBusinessPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiddlePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEconomyPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiddlePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEconomyPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbSettings;
        private System.Windows.Forms.GroupBox gbTripData;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.PictureBox pbName;
        private System.Windows.Forms.GroupBox gbDepartureData;
        private System.Windows.Forms.Label lbDepartureTime;
        private System.Windows.Forms.DateTimePicker dtpDepartureDateTime;
        private System.Windows.Forms.PictureBox pbDeparturePlace;
        private System.Windows.Forms.Label lbDeparturePlace;
        private System.Windows.Forms.TextBox tbDeparturePlace;
        private System.Windows.Forms.PictureBox pbDepartureTime;
        private System.Windows.Forms.GroupBox gbArrivalData;
        private System.Windows.Forms.DateTimePicker dtpArrivalDateTime;
        private System.Windows.Forms.PictureBox pbArrivalTime;
        private System.Windows.Forms.Label lbArrivalDate;
        private System.Windows.Forms.Label lbArrivalPlace;
        private System.Windows.Forms.TextBox tbArrivalPlace;
        private System.Windows.Forms.PictureBox pbArrivalPlace;
        private System.Windows.Forms.Label lbEconomyPrice;
        private System.Windows.Forms.GroupBox gbPrices;
        private System.Windows.Forms.NumericUpDown nudEconomyPrice;
        private System.Windows.Forms.NumericUpDown nudBusinessPrice;
        private System.Windows.Forms.PictureBox pbBusinessPrice;
        private System.Windows.Forms.PictureBox pbMiddlePrice;
        private System.Windows.Forms.PictureBox pbEconomyPrice;
        private System.Windows.Forms.NumericUpDown nudMiddlePrice;
        private System.Windows.Forms.Label lbBusinessPrice;
        private System.Windows.Forms.Label lbMiddlePrice;
        private System.Windows.Forms.PictureBox pbState;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.Label lbState;
    }
}