namespace CalcLED
{
    partial class fMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMainWindow));
            this.gInitialData = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cStripType = new System.Windows.Forms.ComboBox();
            this.lStripeType = new System.Windows.Forms.Label();
            this.tStripLenght = new System.Windows.Forms.TextBox();
            this.cLedStrip = new System.Windows.Forms.ComboBox();
            this.cVoltage = new System.Windows.Forms.ComboBox();
            this.lUnitA = new System.Windows.Forms.Label();
            this.lUnitW = new System.Windows.Forms.Label();
            this.nCurrent = new System.Windows.Forms.NumericUpDown();
            this.nPower = new System.Windows.Forms.NumericUpDown();
            this.lCurrent = new System.Windows.Forms.Label();
            this.lPower = new System.Windows.Forms.Label();
            this.lVoltage = new System.Windows.Forms.Label();
            this.lSripLenght = new System.Windows.Forms.Label();
            this.cWireType = new System.Windows.Forms.ComboBox();
            this.lWireType = new System.Windows.Forms.Label();
            this.lVoltageDrop = new System.Windows.Forms.Label();
            this.lWireCrossSection = new System.Windows.Forms.Label();
            this.lMaxVoltageDrop = new System.Windows.Forms.Label();
            this.lMaxCrossSection = new System.Windows.Forms.Label();
            this.tVoltageDrop = new System.Windows.Forms.TextBox();
            this.tCrossSection = new System.Windows.Forms.TextBox();
            this.nMaxVoltageDrop = new System.Windows.Forms.NumericUpDown();
            this.gStetting = new System.Windows.Forms.GroupBox();
            this.cMaxCrossSection = new System.Windows.Forms.ComboBox();
            this.lUnitVoltageMax = new System.Windows.Forms.Label();
            this.lUnitVoltageDrop = new System.Windows.Forms.Label();
            this.lUnitMM = new System.Windows.Forms.Label();
            this.gCalculatedData = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nWireLenght = new System.Windows.Forms.NumericUpDown();
            this.lWireLenght = new System.Windows.Forms.Label();
            this.bPrint = new System.Windows.Forms.Button();
            this.gInitialData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxVoltageDrop)).BeginInit();
            this.gStetting.SuspendLayout();
            this.gCalculatedData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nWireLenght)).BeginInit();
            this.SuspendLayout();
            // 
            // gInitialData
            // 
            this.gInitialData.Controls.Add(this.label2);
            this.gInitialData.Controls.Add(this.cStripType);
            this.gInitialData.Controls.Add(this.lStripeType);
            this.gInitialData.Controls.Add(this.tStripLenght);
            this.gInitialData.Controls.Add(this.cLedStrip);
            this.gInitialData.Controls.Add(this.cVoltage);
            this.gInitialData.Controls.Add(this.lUnitA);
            this.gInitialData.Controls.Add(this.lUnitW);
            this.gInitialData.Controls.Add(this.nCurrent);
            this.gInitialData.Controls.Add(this.nPower);
            this.gInitialData.Controls.Add(this.lCurrent);
            this.gInitialData.Controls.Add(this.lPower);
            this.gInitialData.Controls.Add(this.lVoltage);
            this.gInitialData.Controls.Add(this.lSripLenght);
            this.gInitialData.Location = new System.Drawing.Point(10, 10);
            this.gInitialData.Margin = new System.Windows.Forms.Padding(4);
            this.gInitialData.Name = "gInitialData";
            this.gInitialData.Padding = new System.Windows.Forms.Padding(4);
            this.gInitialData.Size = new System.Drawing.Size(285, 234);
            this.gInitialData.TabIndex = 12;
            this.gInitialData.TabStop = false;
            this.gInitialData.Text = "LED strip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "m";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cStripType
            // 
            this.cStripType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cStripType.FormattingEnabled = true;
            this.cStripType.Location = new System.Drawing.Point(159, 60);
            this.cStripType.Name = "cStripType";
            this.cStripType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cStripType.Size = new System.Drawing.Size(100, 28);
            this.cStripType.TabIndex = 38;
            this.cStripType.SelectedIndexChanged += new System.EventHandler(this.CStripType_SelectedIndexChanged);
            // 
            // lStripeType
            // 
            this.lStripeType.AutoSize = true;
            this.lStripeType.Location = new System.Drawing.Point(10, 64);
            this.lStripeType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lStripeType.Name = "lStripeType";
            this.lStripeType.Size = new System.Drawing.Size(50, 20);
            this.lStripeType.TabIndex = 37;
            this.lStripeType.Text = "Type:";
            this.lStripeType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tStripLenght
            // 
            this.tStripLenght.Location = new System.Drawing.Point(159, 200);
            this.tStripLenght.Name = "tStripLenght";
            this.tStripLenght.ReadOnly = true;
            this.tStripLenght.Size = new System.Drawing.Size(100, 27);
            this.tStripLenght.TabIndex = 35;
            this.tStripLenght.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cLedStrip
            // 
            this.cLedStrip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cLedStrip.FormattingEnabled = true;
            this.cLedStrip.Location = new System.Drawing.Point(14, 25);
            this.cLedStrip.Name = "cLedStrip";
            this.cLedStrip.Size = new System.Drawing.Size(246, 28);
            this.cLedStrip.TabIndex = 34;
            this.cLedStrip.SelectedIndexChanged += new System.EventHandler(this.CLedStrip_SelectedIndexChanged);
            // 
            // cVoltage
            // 
            this.cVoltage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cVoltage.FormattingEnabled = true;
            this.cVoltage.Location = new System.Drawing.Point(159, 95);
            this.cVoltage.Name = "cVoltage";
            this.cVoltage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cVoltage.Size = new System.Drawing.Size(100, 28);
            this.cVoltage.TabIndex = 2;
            this.cVoltage.SelectedIndexChanged += new System.EventHandler(this.CVoltage_SelectedIndexChanged);
            // 
            // lUnitA
            // 
            this.lUnitA.AutoSize = true;
            this.lUnitA.Location = new System.Drawing.Point(261, 167);
            this.lUnitA.Name = "lUnitA";
            this.lUnitA.Size = new System.Drawing.Size(20, 20);
            this.lUnitA.TabIndex = 25;
            this.lUnitA.Text = "A";
            this.lUnitA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lUnitW
            // 
            this.lUnitW.AutoSize = true;
            this.lUnitW.Location = new System.Drawing.Point(261, 132);
            this.lUnitW.Name = "lUnitW";
            this.lUnitW.Size = new System.Drawing.Size(25, 20);
            this.lUnitW.TabIndex = 24;
            this.lUnitW.Text = "W";
            this.lUnitW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nCurrent
            // 
            this.nCurrent.DecimalPlaces = 1;
            this.nCurrent.Location = new System.Drawing.Point(159, 165);
            this.nCurrent.Margin = new System.Windows.Forms.Padding(4);
            this.nCurrent.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nCurrent.Name = "nCurrent";
            this.nCurrent.Size = new System.Drawing.Size(100, 27);
            this.nCurrent.TabIndex = 4;
            this.nCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nCurrent.ValueChanged += new System.EventHandler(this.NCurrent_ValueChanged);
            // 
            // nPower
            // 
            this.nPower.DecimalPlaces = 1;
            this.nPower.Location = new System.Drawing.Point(159, 130);
            this.nPower.Margin = new System.Windows.Forms.Padding(4);
            this.nPower.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nPower.Name = "nPower";
            this.nPower.Size = new System.Drawing.Size(100, 27);
            this.nPower.TabIndex = 3;
            this.nPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nPower.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nPower.ValueChanged += new System.EventHandler(this.NPower_ValueChanged);
            // 
            // lCurrent
            // 
            this.lCurrent.AutoSize = true;
            this.lCurrent.Location = new System.Drawing.Point(10, 167);
            this.lCurrent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCurrent.Name = "lCurrent";
            this.lCurrent.Size = new System.Drawing.Size(70, 20);
            this.lCurrent.TabIndex = 17;
            this.lCurrent.Text = "Current:";
            this.lCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lPower
            // 
            this.lPower.AutoSize = true;
            this.lPower.Location = new System.Drawing.Point(10, 132);
            this.lPower.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPower.Name = "lPower";
            this.lPower.Size = new System.Drawing.Size(61, 20);
            this.lPower.TabIndex = 16;
            this.lPower.Text = "Power:";
            this.lPower.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lVoltage
            // 
            this.lVoltage.AutoSize = true;
            this.lVoltage.Location = new System.Drawing.Point(10, 98);
            this.lVoltage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lVoltage.Name = "lVoltage";
            this.lVoltage.Size = new System.Drawing.Size(70, 20);
            this.lVoltage.TabIndex = 15;
            this.lVoltage.Text = "Voltage:";
            this.lVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lSripLenght
            // 
            this.lSripLenght.AutoSize = true;
            this.lSripLenght.Location = new System.Drawing.Point(10, 203);
            this.lSripLenght.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lSripLenght.Name = "lSripLenght";
            this.lSripLenght.Size = new System.Drawing.Size(65, 20);
            this.lSripLenght.TabIndex = 18;
            this.lSripLenght.Text = "Lenght:";
            this.lSripLenght.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cWireType
            // 
            this.cWireType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cWireType.FormattingEnabled = true;
            this.cWireType.Location = new System.Drawing.Point(159, 25);
            this.cWireType.Name = "cWireType";
            this.cWireType.Size = new System.Drawing.Size(100, 28);
            this.cWireType.TabIndex = 1;
            this.cWireType.SelectedIndexChanged += new System.EventHandler(this.CWireType_SelectedIndexChanged);
            // 
            // lWireType
            // 
            this.lWireType.AutoSize = true;
            this.lWireType.Location = new System.Drawing.Point(10, 28);
            this.lWireType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lWireType.Name = "lWireType";
            this.lWireType.Size = new System.Drawing.Size(85, 20);
            this.lWireType.TabIndex = 14;
            this.lWireType.Text = "Wire type:";
            this.lWireType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lVoltageDrop
            // 
            this.lVoltageDrop.AutoSize = true;
            this.lVoltageDrop.Location = new System.Drawing.Point(10, 30);
            this.lVoltageDrop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lVoltageDrop.Name = "lVoltageDrop";
            this.lVoltageDrop.Size = new System.Drawing.Size(108, 20);
            this.lVoltageDrop.TabIndex = 19;
            this.lVoltageDrop.Text = "Voltage drop:";
            this.lVoltageDrop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lWireCrossSection
            // 
            this.lWireCrossSection.AutoSize = true;
            this.lWireCrossSection.Location = new System.Drawing.Point(10, 64);
            this.lWireCrossSection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lWireCrossSection.Name = "lWireCrossSection";
            this.lWireCrossSection.Size = new System.Drawing.Size(155, 20);
            this.lWireCrossSection.TabIndex = 20;
            this.lWireCrossSection.Text = "Wire cross section:";
            this.lWireCrossSection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lMaxVoltageDrop
            // 
            this.lMaxVoltageDrop.AutoSize = true;
            this.lMaxVoltageDrop.Location = new System.Drawing.Point(10, 30);
            this.lMaxVoltageDrop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lMaxVoltageDrop.Name = "lMaxVoltageDrop";
            this.lMaxVoltageDrop.Size = new System.Drawing.Size(141, 20);
            this.lMaxVoltageDrop.TabIndex = 21;
            this.lMaxVoltageDrop.Text = "Max voltage drop:";
            this.lMaxVoltageDrop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lMaxCrossSection
            // 
            this.lMaxCrossSection.AutoSize = true;
            this.lMaxCrossSection.Location = new System.Drawing.Point(10, 64);
            this.lMaxCrossSection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lMaxCrossSection.Name = "lMaxCrossSection";
            this.lMaxCrossSection.Size = new System.Drawing.Size(151, 20);
            this.lMaxCrossSection.TabIndex = 22;
            this.lMaxCrossSection.Text = "Max cross section:";
            this.lMaxCrossSection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tVoltageDrop
            // 
            this.tVoltageDrop.Location = new System.Drawing.Point(159, 25);
            this.tVoltageDrop.Name = "tVoltageDrop";
            this.tVoltageDrop.ReadOnly = true;
            this.tVoltageDrop.Size = new System.Drawing.Size(100, 27);
            this.tVoltageDrop.TabIndex = 8;
            // 
            // tCrossSection
            // 
            this.tCrossSection.Location = new System.Drawing.Point(159, 60);
            this.tCrossSection.Name = "tCrossSection";
            this.tCrossSection.ReadOnly = true;
            this.tCrossSection.Size = new System.Drawing.Size(100, 27);
            this.tCrossSection.TabIndex = 9;
            // 
            // nMaxVoltageDrop
            // 
            this.nMaxVoltageDrop.DecimalPlaces = 1;
            this.nMaxVoltageDrop.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nMaxVoltageDrop.Location = new System.Drawing.Point(160, 25);
            this.nMaxVoltageDrop.Name = "nMaxVoltageDrop";
            this.nMaxVoltageDrop.Size = new System.Drawing.Size(100, 27);
            this.nMaxVoltageDrop.TabIndex = 6;
            this.nMaxVoltageDrop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nMaxVoltageDrop.ValueChanged += new System.EventHandler(this.NMaxVoltageDrop_ValueChanged);
            // 
            // gStetting
            // 
            this.gStetting.Controls.Add(this.cMaxCrossSection);
            this.gStetting.Controls.Add(this.lMaxVoltageDrop);
            this.gStetting.Controls.Add(this.lUnitVoltageMax);
            this.gStetting.Controls.Add(this.lMaxCrossSection);
            this.gStetting.Controls.Add(this.nMaxVoltageDrop);
            this.gStetting.Location = new System.Drawing.Point(11, 353);
            this.gStetting.Name = "gStetting";
            this.gStetting.Size = new System.Drawing.Size(285, 97);
            this.gStetting.TabIndex = 13;
            this.gStetting.TabStop = false;
            this.gStetting.Text = "Settings";
            // 
            // cMaxCrossSection
            // 
            this.cMaxCrossSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cMaxCrossSection.FormattingEnabled = true;
            this.cMaxCrossSection.Location = new System.Drawing.Point(160, 60);
            this.cMaxCrossSection.Name = "cMaxCrossSection";
            this.cMaxCrossSection.Size = new System.Drawing.Size(100, 28);
            this.cMaxCrossSection.TabIndex = 23;
            this.cMaxCrossSection.SelectedIndexChanged += new System.EventHandler(this.CMaxCrossSection_SelectedIndexChanged);
            // 
            // lUnitVoltageMax
            // 
            this.lUnitVoltageMax.AutoSize = true;
            this.lUnitVoltageMax.Location = new System.Drawing.Point(261, 30);
            this.lUnitVoltageMax.Name = "lUnitVoltageMax";
            this.lUnitVoltageMax.Size = new System.Drawing.Size(20, 20);
            this.lUnitVoltageMax.TabIndex = 29;
            this.lUnitVoltageMax.Text = "V";
            this.lUnitVoltageMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lUnitVoltageDrop
            // 
            this.lUnitVoltageDrop.AutoSize = true;
            this.lUnitVoltageDrop.Location = new System.Drawing.Point(260, 30);
            this.lUnitVoltageDrop.Name = "lUnitVoltageDrop";
            this.lUnitVoltageDrop.Size = new System.Drawing.Size(20, 20);
            this.lUnitVoltageDrop.TabIndex = 27;
            this.lUnitVoltageDrop.Text = "V";
            this.lUnitVoltageDrop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lUnitMM
            // 
            this.lUnitMM.AutoSize = true;
            this.lUnitMM.Location = new System.Drawing.Point(260, 64);
            this.lUnitMM.Name = "lUnitMM";
            this.lUnitMM.Size = new System.Drawing.Size(46, 20);
            this.lUnitMM.TabIndex = 28;
            this.lUnitMM.Text = "mm2";
            this.lUnitMM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gCalculatedData
            // 
            this.gCalculatedData.Controls.Add(this.tVoltageDrop);
            this.gCalculatedData.Controls.Add(this.lUnitMM);
            this.gCalculatedData.Controls.Add(this.tCrossSection);
            this.gCalculatedData.Controls.Add(this.lUnitVoltageDrop);
            this.gCalculatedData.Controls.Add(this.lWireCrossSection);
            this.gCalculatedData.Controls.Add(this.lVoltageDrop);
            this.gCalculatedData.Location = new System.Drawing.Point(305, 10);
            this.gCalculatedData.Name = "gCalculatedData";
            this.gCalculatedData.Size = new System.Drawing.Size(306, 96);
            this.gCalculatedData.TabIndex = 31;
            this.gCalculatedData.TabStop = false;
            this.gCalculatedData.Text = "Result";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalcLED.Properties.Resources.calculator;
            this.pictureBox1.Location = new System.Drawing.Point(328, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 251);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nWireLenght);
            this.groupBox1.Controls.Add(this.cWireType);
            this.groupBox1.Controls.Add(this.lWireLenght);
            this.groupBox1.Controls.Add(this.lWireType);
            this.groupBox1.Location = new System.Drawing.Point(10, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 96);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wire";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "m";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nWireLenght
            // 
            this.nWireLenght.DecimalPlaces = 1;
            this.nWireLenght.Location = new System.Drawing.Point(159, 60);
            this.nWireLenght.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nWireLenght.Name = "nWireLenght";
            this.nWireLenght.Size = new System.Drawing.Size(100, 27);
            this.nWireLenght.TabIndex = 27;
            this.nWireLenght.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nWireLenght.ValueChanged += new System.EventHandler(this.NWireLenght_ValueChanged);
            // 
            // lWireLenght
            // 
            this.lWireLenght.AutoSize = true;
            this.lWireLenght.Location = new System.Drawing.Point(10, 62);
            this.lWireLenght.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lWireLenght.Name = "lWireLenght";
            this.lWireLenght.Size = new System.Drawing.Size(65, 20);
            this.lWireLenght.TabIndex = 28;
            this.lWireLenght.Text = "Lenght:";
            this.lWireLenght.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bPrint
            // 
            this.bPrint.Location = new System.Drawing.Point(533, 403);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(75, 43);
            this.bPrint.TabIndex = 35;
            this.bPrint.Text = "Print";
            this.bPrint.UseVisualStyleBackColor = true;
            this.bPrint.Click += new System.EventHandler(this.BPrint_Click);
            // 
            // fMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 458);
            this.Controls.Add(this.bPrint);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gCalculatedData);
            this.Controls.Add(this.gStetting);
            this.Controls.Add(this.gInitialData);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fMainWindow";
            this.Text = "CalcLED";
            this.Load += new System.EventHandler(this.FMainWindow_Load);
            this.gInitialData.ResumeLayout(false);
            this.gInitialData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxVoltageDrop)).EndInit();
            this.gStetting.ResumeLayout(false);
            this.gStetting.PerformLayout();
            this.gCalculatedData.ResumeLayout(false);
            this.gCalculatedData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nWireLenght)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gInitialData;
        private System.Windows.Forms.NumericUpDown nCurrent;
        private System.Windows.Forms.NumericUpDown nPower;
        private System.Windows.Forms.Label lCurrent;
        private System.Windows.Forms.Label lPower;
        private System.Windows.Forms.Label lVoltage;
        private System.Windows.Forms.Label lWireType;
        private System.Windows.Forms.Label lSripLenght;
        private System.Windows.Forms.Label lVoltageDrop;
        private System.Windows.Forms.Label lWireCrossSection;
        private System.Windows.Forms.Label lMaxVoltageDrop;
        private System.Windows.Forms.Label lMaxCrossSection;
        private System.Windows.Forms.TextBox tVoltageDrop;
        private System.Windows.Forms.TextBox tCrossSection;
        private System.Windows.Forms.NumericUpDown nMaxVoltageDrop;
        private System.Windows.Forms.GroupBox gStetting;
        private System.Windows.Forms.Label lUnitA;
        private System.Windows.Forms.Label lUnitW;
        private System.Windows.Forms.Label lUnitVoltageDrop;
        private System.Windows.Forms.Label lUnitMM;
        private System.Windows.Forms.Label lUnitVoltageMax;
        private System.Windows.Forms.ComboBox cVoltage;
        private System.Windows.Forms.ComboBox cWireType;
        private System.Windows.Forms.ComboBox cMaxCrossSection;
        private System.Windows.Forms.GroupBox gCalculatedData;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cLedStrip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nWireLenght;
        private System.Windows.Forms.Label lWireLenght;
        private System.Windows.Forms.TextBox tStripLenght;
        private System.Windows.Forms.Label lStripeType;
        private System.Windows.Forms.ComboBox cStripType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bPrint;
    }
}

