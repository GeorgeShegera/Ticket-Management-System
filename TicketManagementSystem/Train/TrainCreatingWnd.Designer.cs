namespace TicketManagementSystem
{
    partial class AddingTrainWnd
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
            this.lbTrainName = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbModel = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.lbEconomyClass = new System.Windows.Forms.Label();
            this.gbCapacity = new System.Windows.Forms.GroupBox();
            this.numBusinessTick = new System.Windows.Forms.NumericUpDown();
            this.numMiddleTick = new System.Windows.Forms.NumericUpDown();
            this.lbBusinessClass = new System.Windows.Forms.Label();
            this.lbMiddleClass = new System.Windows.Forms.Label();
            this.numEconomyTick = new System.Windows.Forms.NumericUpDown();
            this.gbTrainInfo = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbCapacity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBusinessTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMiddleTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEconomyTick)).BeginInit();
            this.gbTrainInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTrainName
            // 
            this.lbTrainName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrainName.Location = new System.Drawing.Point(13, 34);
            this.lbTrainName.Name = "lbTrainName";
            this.lbTrainName.Size = new System.Drawing.Size(90, 32);
            this.lbTrainName.TabIndex = 0;
            this.lbTrainName.Text = "Name:";
            this.lbTrainName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Microsoft New Tai Lue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(439, 34);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Train Creating";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorProvider.SetIconPadding(this.tbName, 2);
            this.tbName.Location = new System.Drawing.Point(109, 34);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(320, 32);
            this.tbName.TabIndex = 2;
            this.tbName.Tag = "";
            // 
            // lbModel
            // 
            this.lbModel.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModel.Location = new System.Drawing.Point(13, 88);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(90, 32);
            this.lbModel.TabIndex = 0;
            this.lbModel.Text = "Model:";
            this.lbModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbModel
            // 
            this.tbModel.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModel.Location = new System.Drawing.Point(109, 88);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(320, 32);
            this.tbModel.TabIndex = 2;
            // 
            // lbEconomyClass
            // 
            this.lbEconomyClass.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEconomyClass.Location = new System.Drawing.Point(13, 38);
            this.lbEconomyClass.Name = "lbEconomyClass";
            this.lbEconomyClass.Size = new System.Drawing.Size(210, 32);
            this.lbEconomyClass.TabIndex = 0;
            this.lbEconomyClass.Text = "Economy class tickets:";
            this.lbEconomyClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbCapacity
            // 
            this.gbCapacity.Controls.Add(this.numBusinessTick);
            this.gbCapacity.Controls.Add(this.numMiddleTick);
            this.gbCapacity.Controls.Add(this.lbBusinessClass);
            this.gbCapacity.Controls.Add(this.lbMiddleClass);
            this.gbCapacity.Controls.Add(this.numEconomyTick);
            this.gbCapacity.Controls.Add(this.lbEconomyClass);
            this.gbCapacity.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCapacity.Location = new System.Drawing.Point(10, 200);
            this.gbCapacity.Name = "gbCapacity";
            this.gbCapacity.Size = new System.Drawing.Size(445, 185);
            this.gbCapacity.TabIndex = 3;
            this.gbCapacity.TabStop = false;
            this.gbCapacity.Text = "Capacity";
            // 
            // numBusinessTick
            // 
            this.numBusinessTick.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBusinessTick.Location = new System.Drawing.Point(229, 135);
            this.numBusinessTick.Name = "numBusinessTick";
            this.numBusinessTick.Size = new System.Drawing.Size(46, 32);
            this.numBusinessTick.TabIndex = 1;
            // 
            // numMiddleTick
            // 
            this.numMiddleTick.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMiddleTick.Location = new System.Drawing.Point(229, 86);
            this.numMiddleTick.Name = "numMiddleTick";
            this.numMiddleTick.Size = new System.Drawing.Size(46, 32);
            this.numMiddleTick.TabIndex = 1;
            // 
            // lbBusinessClass
            // 
            this.lbBusinessClass.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBusinessClass.Location = new System.Drawing.Point(13, 135);
            this.lbBusinessClass.Name = "lbBusinessClass";
            this.lbBusinessClass.Size = new System.Drawing.Size(210, 32);
            this.lbBusinessClass.TabIndex = 0;
            this.lbBusinessClass.Text = "Business class tickets:";
            this.lbBusinessClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbMiddleClass
            // 
            this.lbMiddleClass.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMiddleClass.Location = new System.Drawing.Point(13, 86);
            this.lbMiddleClass.Name = "lbMiddleClass";
            this.lbMiddleClass.Size = new System.Drawing.Size(210, 32);
            this.lbMiddleClass.TabIndex = 0;
            this.lbMiddleClass.Text = "Middle class tickets:";
            this.lbMiddleClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numEconomyTick
            // 
            this.numEconomyTick.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEconomyTick.Location = new System.Drawing.Point(229, 38);
            this.numEconomyTick.Name = "numEconomyTick";
            this.numEconomyTick.Size = new System.Drawing.Size(46, 32);
            this.numEconomyTick.TabIndex = 1;
            // 
            // gbTrainInfo
            // 
            this.gbTrainInfo.Controls.Add(this.tbModel);
            this.gbTrainInfo.Controls.Add(this.tbName);
            this.gbTrainInfo.Controls.Add(this.lbModel);
            this.gbTrainInfo.Controls.Add(this.lbTrainName);
            this.gbTrainInfo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTrainInfo.Location = new System.Drawing.Point(10, 49);
            this.gbTrainInfo.Name = "gbTrainInfo";
            this.gbTrainInfo.Size = new System.Drawing.Size(445, 139);
            this.gbTrainInfo.TabIndex = 4;
            this.gbTrainInfo.TabStop = false;
            this.gbTrainInfo.Text = "Information";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(353, 391);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 34);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 0;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // AddingTrainWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 432);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbTrainInfo);
            this.Controls.Add(this.gbCapacity);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddingTrainWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Train Creating";
            this.gbCapacity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numBusinessTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMiddleTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEconomyTick)).EndInit();
            this.gbTrainInfo.ResumeLayout(false);
            this.gbTrainInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTrainName;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label lbEconomyClass;
        private System.Windows.Forms.GroupBox gbCapacity;
        private System.Windows.Forms.NumericUpDown numMiddleTick;
        private System.Windows.Forms.Label lbMiddleClass;
        private System.Windows.Forms.NumericUpDown numEconomyTick;
        private System.Windows.Forms.GroupBox gbTrainInfo;
        private System.Windows.Forms.NumericUpDown numBusinessTick;
        private System.Windows.Forms.Label lbBusinessClass;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}