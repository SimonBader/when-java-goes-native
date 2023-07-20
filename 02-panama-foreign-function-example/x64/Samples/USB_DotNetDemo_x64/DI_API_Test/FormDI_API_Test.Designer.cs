namespace DI_API_Test
{
    partial class FormDI_API_Test
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該公開 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.lvInfo = new System.Windows.Forms.ListView();
            this.gbxGetCntEdgeTrig = new System.Windows.Forms.GroupBox();
            this.btnGetCntEdgeTrig = new System.Windows.Forms.Button();
            this.gbxSetCntEdgeTrig = new System.Windows.Forms.GroupBox();
            this.rdbtnEdgeFalling = new System.Windows.Forms.RadioButton();
            this.rdbtnEdgeRising = new System.Windows.Forms.RadioButton();
            this.btnSetCntEdgeTrig = new System.Windows.Forms.Button();
            this.gbxSetDigitalFilterWidth = new System.Windows.Forms.GroupBox();
            this.numDigitalFilterWidth = new System.Windows.Forms.NumericUpDown();
            this.labSetFilterWidthUnit = new System.Windows.Forms.Label();
            this.labSetFilterWidthValue = new System.Windows.Forms.Label();
            this.btnSetFilterWidth = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSetBoardID = new System.Windows.Forms.Button();
            this.btnSetWDT = new System.Windows.Forms.Button();
            this.btnSetNickname = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtNickName = new System.Windows.Forms.TextBox();
            this.btnGetDigitalFilterWidth = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbxSettingMethods = new System.Windows.Forms.GroupBox();
            this.gbxSetDIValueInverse = new System.Windows.Forms.GroupBox();
            this.rdbtnDIValueInvDisable = new System.Windows.Forms.RadioButton();
            this.rdbtnDIValueInvEnable = new System.Windows.Forms.RadioButton();
            this.btnSetDIValueInverse = new System.Windows.Forms.Button();
            this.gbxGettingMethod = new System.Windows.Forms.GroupBox();
            this.gbxGetDIValueInverse = new System.Windows.Forms.GroupBox();
            this.btnGetDIValueInverse = new System.Windows.Forms.Button();
            this.gbxGetDigitalFilterWidth = new System.Windows.Forms.GroupBox();
            this.numBoardIDSetting = new System.Windows.Forms.NumericUpDown();
            this.numWDTValue = new System.Windows.Forms.NumericUpDown();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtBoardID = new System.Windows.Forms.TextBox();
            this.cbxDevID = new System.Windows.Forms.ComboBox();
            this.labSettingBoardID = new System.Windows.Forms.Label();
            this.labWDTunit = new System.Windows.Forms.Label();
            this.labWDT = new System.Windows.Forms.Label();
            this.labNickname = new System.Windows.Forms.Label();
            this.labBoardID = new System.Windows.Forms.Label();
            this.labDevID = new System.Windows.Forms.Label();
            this.gbxGetCntEdgeTrig.SuspendLayout();
            this.gbxSetCntEdgeTrig.SuspendLayout();
            this.gbxSetDigitalFilterWidth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDigitalFilterWidth)).BeginInit();
            this.gbxSettingMethods.SuspendLayout();
            this.gbxSetDIValueInverse.SuspendLayout();
            this.gbxGettingMethod.SuspendLayout();
            this.gbxGetDIValueInverse.SuspendLayout();
            this.gbxGetDigitalFilterWidth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBoardIDSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWDTValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lvInfo
            // 
            this.lvInfo.Location = new System.Drawing.Point(9, 290);
            this.lvInfo.Name = "lvInfo";
            this.lvInfo.Size = new System.Drawing.Size(154, 107);
            this.lvInfo.TabIndex = 31;
            this.lvInfo.UseCompatibleStateImageBehavior = false;
            this.lvInfo.View = System.Windows.Forms.View.List;
            // 
            // gbxGetCntEdgeTrig
            // 
            this.gbxGetCntEdgeTrig.Controls.Add(this.btnGetCntEdgeTrig);
            this.gbxGetCntEdgeTrig.Location = new System.Drawing.Point(6, 108);
            this.gbxGetCntEdgeTrig.Name = "gbxGetCntEdgeTrig";
            this.gbxGetCntEdgeTrig.Size = new System.Drawing.Size(122, 45);
            this.gbxGetCntEdgeTrig.TabIndex = 0;
            this.gbxGetCntEdgeTrig.TabStop = false;
            this.gbxGetCntEdgeTrig.Text = "Counter Edge Trig.";
            // 
            // btnGetCntEdgeTrig
            // 
            this.btnGetCntEdgeTrig.Location = new System.Drawing.Point(31, 16);
            this.btnGetCntEdgeTrig.Name = "btnGetCntEdgeTrig";
            this.btnGetCntEdgeTrig.Size = new System.Drawing.Size(60, 23);
            this.btnGetCntEdgeTrig.TabIndex = 0;
            this.btnGetCntEdgeTrig.Text = "Get";
            this.btnGetCntEdgeTrig.UseVisualStyleBackColor = true;
            this.btnGetCntEdgeTrig.Click += new System.EventHandler(this.btnGetCntEdgeTrig_Click);
            // 
            // gbxSetCntEdgeTrig
            // 
            this.gbxSetCntEdgeTrig.Controls.Add(this.rdbtnEdgeFalling);
            this.gbxSetCntEdgeTrig.Controls.Add(this.rdbtnEdgeRising);
            this.gbxSetCntEdgeTrig.Controls.Add(this.btnSetCntEdgeTrig);
            this.gbxSetCntEdgeTrig.Location = new System.Drawing.Point(6, 108);
            this.gbxSetCntEdgeTrig.Name = "gbxSetCntEdgeTrig";
            this.gbxSetCntEdgeTrig.Size = new System.Drawing.Size(315, 45);
            this.gbxSetCntEdgeTrig.TabIndex = 1;
            this.gbxSetCntEdgeTrig.TabStop = false;
            this.gbxSetCntEdgeTrig.Text = "Counter Edge Trig.";
            // 
            // rdbtnEdgeFalling
            // 
            this.rdbtnEdgeFalling.AutoSize = true;
            this.rdbtnEdgeFalling.Checked = true;
            this.rdbtnEdgeFalling.Location = new System.Drawing.Point(8, 19);
            this.rdbtnEdgeFalling.Name = "rdbtnEdgeFalling";
            this.rdbtnEdgeFalling.Size = new System.Drawing.Size(55, 16);
            this.rdbtnEdgeFalling.TabIndex = 3;
            this.rdbtnEdgeFalling.TabStop = true;
            this.rdbtnEdgeFalling.Text = "Falling";
            this.rdbtnEdgeFalling.UseVisualStyleBackColor = true;
            // 
            // rdbtnEdgeRising
            // 
            this.rdbtnEdgeRising.AutoSize = true;
            this.rdbtnEdgeRising.Location = new System.Drawing.Point(81, 19);
            this.rdbtnEdgeRising.Name = "rdbtnEdgeRising";
            this.rdbtnEdgeRising.Size = new System.Drawing.Size(53, 16);
            this.rdbtnEdgeRising.TabIndex = 2;
            this.rdbtnEdgeRising.Text = "Rising";
            this.rdbtnEdgeRising.UseVisualStyleBackColor = true;
            // 
            // btnSetCntEdgeTrig
            // 
            this.btnSetCntEdgeTrig.Location = new System.Drawing.Point(248, 14);
            this.btnSetCntEdgeTrig.Name = "btnSetCntEdgeTrig";
            this.btnSetCntEdgeTrig.Size = new System.Drawing.Size(60, 23);
            this.btnSetCntEdgeTrig.TabIndex = 0;
            this.btnSetCntEdgeTrig.Text = "Set";
            this.btnSetCntEdgeTrig.UseVisualStyleBackColor = true;
            this.btnSetCntEdgeTrig.Click += new System.EventHandler(this.btnSetCounterEdgeTrigger_Click);
            // 
            // gbxSetDigitalFilterWidth
            // 
            this.gbxSetDigitalFilterWidth.Controls.Add(this.numDigitalFilterWidth);
            this.gbxSetDigitalFilterWidth.Controls.Add(this.labSetFilterWidthUnit);
            this.gbxSetDigitalFilterWidth.Controls.Add(this.labSetFilterWidthValue);
            this.gbxSetDigitalFilterWidth.Controls.Add(this.btnSetFilterWidth);
            this.gbxSetDigitalFilterWidth.Location = new System.Drawing.Point(6, 16);
            this.gbxSetDigitalFilterWidth.Name = "gbxSetDigitalFilterWidth";
            this.gbxSetDigitalFilterWidth.Size = new System.Drawing.Size(315, 45);
            this.gbxSetDigitalFilterWidth.TabIndex = 1;
            this.gbxSetDigitalFilterWidth.TabStop = false;
            this.gbxSetDigitalFilterWidth.Text = "Digital Filter Width";
            // 
            // numDigitalFilterWidth
            // 
            this.numDigitalFilterWidth.Location = new System.Drawing.Point(63, 16);
            this.numDigitalFilterWidth.Maximum = new decimal(new int[] {
            6553,
            0,
            0,
            0});
            this.numDigitalFilterWidth.Name = "numDigitalFilterWidth";
            this.numDigitalFilterWidth.Size = new System.Drawing.Size(59, 22);
            this.numDigitalFilterWidth.TabIndex = 3;
            // 
            // labSetFilterWidthUnit
            // 
            this.labSetFilterWidthUnit.AutoSize = true;
            this.labSetFilterWidthUnit.Location = new System.Drawing.Point(130, 21);
            this.labSetFilterWidthUnit.Name = "labSetFilterWidthUnit";
            this.labSetFilterWidthUnit.Size = new System.Drawing.Size(45, 12);
            this.labSetFilterWidthUnit.TabIndex = 1;
            this.labSetFilterWidthUnit.Text = "* 100 us";
            // 
            // labSetFilterWidthValue
            // 
            this.labSetFilterWidthValue.AutoSize = true;
            this.labSetFilterWidthValue.Location = new System.Drawing.Point(6, 21);
            this.labSetFilterWidthValue.Name = "labSetFilterWidthValue";
            this.labSetFilterWidthValue.Size = new System.Drawing.Size(32, 12);
            this.labSetFilterWidthValue.TabIndex = 1;
            this.labSetFilterWidthValue.Text = "Value";
            // 
            // btnSetFilterWidth
            // 
            this.btnSetFilterWidth.Location = new System.Drawing.Point(248, 16);
            this.btnSetFilterWidth.Name = "btnSetFilterWidth";
            this.btnSetFilterWidth.Size = new System.Drawing.Size(60, 23);
            this.btnSetFilterWidth.TabIndex = 0;
            this.btnSetFilterWidth.Text = "Set";
            this.btnSetFilterWidth.UseVisualStyleBackColor = true;
            this.btnSetFilterWidth.Click += new System.EventHandler(this.btnSetDigitalFilterWidth_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(37, 90);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(60, 23);
            this.btnDefault.TabIndex = 23;
            this.btnDefault.Text = "Default";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(103, 62);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 23);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSetBoardID
            // 
            this.btnSetBoardID.Location = new System.Drawing.Point(103, 261);
            this.btnSetBoardID.Name = "btnSetBoardID";
            this.btnSetBoardID.Size = new System.Drawing.Size(60, 23);
            this.btnSetBoardID.TabIndex = 22;
            this.btnSetBoardID.Text = "Set";
            this.btnSetBoardID.UseVisualStyleBackColor = true;
            this.btnSetBoardID.Click += new System.EventHandler(this.btnSetBoardID_Click);
            // 
            // btnSetWDT
            // 
            this.btnSetWDT.Location = new System.Drawing.Point(103, 204);
            this.btnSetWDT.Name = "btnSetWDT";
            this.btnSetWDT.Size = new System.Drawing.Size(60, 23);
            this.btnSetWDT.TabIndex = 21;
            this.btnSetWDT.Text = "Set";
            this.btnSetWDT.UseVisualStyleBackColor = true;
            this.btnSetWDT.Click += new System.EventHandler(this.btnSetWDT_Click);
            // 
            // btnSetNickname
            // 
            this.btnSetNickname.Location = new System.Drawing.Point(103, 147);
            this.btnSetNickname.Name = "btnSetNickname";
            this.btnSetNickname.Size = new System.Drawing.Size(60, 23);
            this.btnSetNickname.TabIndex = 19;
            this.btnSetNickname.Text = "Set";
            this.btnSetNickname.UseVisualStyleBackColor = true;
            this.btnSetNickname.Click += new System.EventHandler(this.btnSetNickname_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(37, 62);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(60, 23);
            this.btnOpen.TabIndex = 20;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtNickName
            // 
            this.txtNickName.Location = new System.Drawing.Point(65, 119);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(98, 22);
            this.txtNickName.TabIndex = 18;
            // 
            // btnGetDigitalFilterWidth
            // 
            this.btnGetDigitalFilterWidth.Location = new System.Drawing.Point(31, 16);
            this.btnGetDigitalFilterWidth.Name = "btnGetDigitalFilterWidth";
            this.btnGetDigitalFilterWidth.Size = new System.Drawing.Size(60, 23);
            this.btnGetDigitalFilterWidth.TabIndex = 0;
            this.btnGetDigitalFilterWidth.Text = "Get";
            this.btnGetDigitalFilterWidth.UseVisualStyleBackColor = true;
            this.btnGetDigitalFilterWidth.Click += new System.EventHandler(this.btnGetDigitalFilterWidth_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(563, 374);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 23);
            this.btnExit.TabIndex = 30;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbxSettingMethods
            // 
            this.gbxSettingMethods.Controls.Add(this.gbxSetDIValueInverse);
            this.gbxSettingMethods.Controls.Add(this.gbxSetCntEdgeTrig);
            this.gbxSettingMethods.Controls.Add(this.gbxSetDigitalFilterWidth);
            this.gbxSettingMethods.Location = new System.Drawing.Point(309, 8);
            this.gbxSettingMethods.Name = "gbxSettingMethods";
            this.gbxSettingMethods.Size = new System.Drawing.Size(324, 160);
            this.gbxSettingMethods.TabIndex = 28;
            this.gbxSettingMethods.TabStop = false;
            this.gbxSettingMethods.Text = "Setting Method";
            // 
            // gbxSetDIValueInverse
            // 
            this.gbxSetDIValueInverse.Controls.Add(this.rdbtnDIValueInvDisable);
            this.gbxSetDIValueInverse.Controls.Add(this.rdbtnDIValueInvEnable);
            this.gbxSetDIValueInverse.Controls.Add(this.btnSetDIValueInverse);
            this.gbxSetDIValueInverse.Location = new System.Drawing.Point(6, 62);
            this.gbxSetDIValueInverse.Name = "gbxSetDIValueInverse";
            this.gbxSetDIValueInverse.Size = new System.Drawing.Size(315, 45);
            this.gbxSetDIValueInverse.TabIndex = 1;
            this.gbxSetDIValueInverse.TabStop = false;
            this.gbxSetDIValueInverse.Text = "DI Value Inverse";
            // 
            // rdbtnDIValueInvDisable
            // 
            this.rdbtnDIValueInvDisable.AutoSize = true;
            this.rdbtnDIValueInvDisable.Checked = true;
            this.rdbtnDIValueInvDisable.Location = new System.Drawing.Point(8, 21);
            this.rdbtnDIValueInvDisable.Name = "rdbtnDIValueInvDisable";
            this.rdbtnDIValueInvDisable.Size = new System.Drawing.Size(57, 16);
            this.rdbtnDIValueInvDisable.TabIndex = 1;
            this.rdbtnDIValueInvDisable.TabStop = true;
            this.rdbtnDIValueInvDisable.Text = "Disable";
            this.rdbtnDIValueInvDisable.UseVisualStyleBackColor = true;
            // 
            // rdbtnDIValueInvEnable
            // 
            this.rdbtnDIValueInvEnable.AutoSize = true;
            this.rdbtnDIValueInvEnable.Location = new System.Drawing.Point(81, 21);
            this.rdbtnDIValueInvEnable.Name = "rdbtnDIValueInvEnable";
            this.rdbtnDIValueInvEnable.Size = new System.Drawing.Size(55, 16);
            this.rdbtnDIValueInvEnable.TabIndex = 1;
            this.rdbtnDIValueInvEnable.Text = "Enable";
            this.rdbtnDIValueInvEnable.UseVisualStyleBackColor = true;
            // 
            // btnSetDIValueInverse
            // 
            this.btnSetDIValueInverse.Location = new System.Drawing.Point(248, 14);
            this.btnSetDIValueInverse.Name = "btnSetDIValueInverse";
            this.btnSetDIValueInverse.Size = new System.Drawing.Size(60, 23);
            this.btnSetDIValueInverse.TabIndex = 0;
            this.btnSetDIValueInverse.Text = "Set";
            this.btnSetDIValueInverse.UseVisualStyleBackColor = true;
            this.btnSetDIValueInverse.Click += new System.EventHandler(this.btnSetDIValueInverse_Click);
            // 
            // gbxGettingMethod
            // 
            this.gbxGettingMethod.Controls.Add(this.gbxGetCntEdgeTrig);
            this.gbxGettingMethod.Controls.Add(this.gbxGetDIValueInverse);
            this.gbxGettingMethod.Controls.Add(this.gbxGetDigitalFilterWidth);
            this.gbxGettingMethod.Location = new System.Drawing.Point(169, 8);
            this.gbxGettingMethod.Name = "gbxGettingMethod";
            this.gbxGettingMethod.Size = new System.Drawing.Size(134, 160);
            this.gbxGettingMethod.TabIndex = 29;
            this.gbxGettingMethod.TabStop = false;
            this.gbxGettingMethod.Text = "Getting Method";
            // 
            // gbxGetDIValueInverse
            // 
            this.gbxGetDIValueInverse.Controls.Add(this.btnGetDIValueInverse);
            this.gbxGetDIValueInverse.Location = new System.Drawing.Point(6, 62);
            this.gbxGetDIValueInverse.Name = "gbxGetDIValueInverse";
            this.gbxGetDIValueInverse.Size = new System.Drawing.Size(122, 45);
            this.gbxGetDIValueInverse.TabIndex = 0;
            this.gbxGetDIValueInverse.TabStop = false;
            this.gbxGetDIValueInverse.Text = "DI Value Inverse";
            // 
            // btnGetDIValueInverse
            // 
            this.btnGetDIValueInverse.Location = new System.Drawing.Point(31, 16);
            this.btnGetDIValueInverse.Name = "btnGetDIValueInverse";
            this.btnGetDIValueInverse.Size = new System.Drawing.Size(60, 23);
            this.btnGetDIValueInverse.TabIndex = 0;
            this.btnGetDIValueInverse.Text = "Get";
            this.btnGetDIValueInverse.UseVisualStyleBackColor = true;
            this.btnGetDIValueInverse.Click += new System.EventHandler(this.btnGetDIValueInverse_Click);
            // 
            // gbxGetDigitalFilterWidth
            // 
            this.gbxGetDigitalFilterWidth.Controls.Add(this.btnGetDigitalFilterWidth);
            this.gbxGetDigitalFilterWidth.Location = new System.Drawing.Point(6, 16);
            this.gbxGetDigitalFilterWidth.Name = "gbxGetDigitalFilterWidth";
            this.gbxGetDigitalFilterWidth.Size = new System.Drawing.Size(122, 45);
            this.gbxGetDigitalFilterWidth.TabIndex = 0;
            this.gbxGetDigitalFilterWidth.TabStop = false;
            this.gbxGetDigitalFilterWidth.Text = "Digital Filter Width";
            // 
            // numBoardIDSetting
            // 
            this.numBoardIDSetting.Location = new System.Drawing.Point(65, 233);
            this.numBoardIDSetting.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numBoardIDSetting.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBoardIDSetting.Name = "numBoardIDSetting";
            this.numBoardIDSetting.Size = new System.Drawing.Size(98, 22);
            this.numBoardIDSetting.TabIndex = 26;
            this.numBoardIDSetting.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numWDTValue
            // 
            this.numWDTValue.Location = new System.Drawing.Point(65, 176);
            this.numWDTValue.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numWDTValue.Name = "numWDTValue";
            this.numWDTValue.Size = new System.Drawing.Size(74, 22);
            this.numWDTValue.TabIndex = 27;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(103, 90);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(60, 23);
            this.btnRefresh.TabIndex = 25;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtBoardID
            // 
            this.txtBoardID.Location = new System.Drawing.Point(65, 34);
            this.txtBoardID.Name = "txtBoardID";
            this.txtBoardID.Size = new System.Drawing.Size(98, 22);
            this.txtBoardID.TabIndex = 17;
            this.txtBoardID.Text = "1";
            // 
            // cbxDevID
            // 
            this.cbxDevID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDevID.FormattingEnabled = true;
            this.cbxDevID.Items.AddRange(new object[] {
            "USB-2026",
            "USB-2051",
            "USB-2055",
            "USB-2060",
            "USB-2051-32",
            "USB-2055-32",
            "USB-2068-18"});
            this.cbxDevID.Location = new System.Drawing.Point(65, 8);
            this.cbxDevID.Name = "cbxDevID";
            this.cbxDevID.Size = new System.Drawing.Size(98, 20);
            this.cbxDevID.TabIndex = 16;
            // 
            // labSettingBoardID
            // 
            this.labSettingBoardID.AutoSize = true;
            this.labSettingBoardID.Location = new System.Drawing.Point(7, 238);
            this.labSettingBoardID.Name = "labSettingBoardID";
            this.labSettingBoardID.Size = new System.Drawing.Size(49, 12);
            this.labSettingBoardID.TabIndex = 14;
            this.labSettingBoardID.Text = "Board ID";
            // 
            // labWDTunit
            // 
            this.labWDTunit.AutoSize = true;
            this.labWDTunit.Location = new System.Drawing.Point(145, 178);
            this.labWDTunit.Name = "labWDTunit";
            this.labWDTunit.Size = new System.Drawing.Size(18, 12);
            this.labWDTunit.TabIndex = 13;
            this.labWDTunit.Text = "ms";
            // 
            // labWDT
            // 
            this.labWDT.AutoSize = true;
            this.labWDT.Location = new System.Drawing.Point(7, 180);
            this.labWDT.Name = "labWDT";
            this.labWDT.Size = new System.Drawing.Size(31, 12);
            this.labWDT.TabIndex = 12;
            this.labWDT.Text = "WDT";
            // 
            // labNickname
            // 
            this.labNickname.AutoSize = true;
            this.labNickname.Location = new System.Drawing.Point(7, 123);
            this.labNickname.Name = "labNickname";
            this.labNickname.Size = new System.Drawing.Size(52, 12);
            this.labNickname.TabIndex = 10;
            this.labNickname.Text = "Nickname";
            // 
            // labBoardID
            // 
            this.labBoardID.AutoSize = true;
            this.labBoardID.Location = new System.Drawing.Point(7, 39);
            this.labBoardID.Name = "labBoardID";
            this.labBoardID.Size = new System.Drawing.Size(49, 12);
            this.labBoardID.TabIndex = 11;
            this.labBoardID.Text = "Board ID";
            // 
            // labDevID
            // 
            this.labDevID.AutoSize = true;
            this.labDevID.Location = new System.Drawing.Point(7, 11);
            this.labDevID.Name = "labDevID";
            this.labDevID.Size = new System.Drawing.Size(52, 12);
            this.labDevID.TabIndex = 15;
            this.labDevID.Text = "Device ID";
            // 
            // FormDI_API_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 404);
            this.Controls.Add(this.lvInfo);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSetBoardID);
            this.Controls.Add(this.btnSetWDT);
            this.Controls.Add(this.btnSetNickname);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtNickName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbxSettingMethods);
            this.Controls.Add(this.gbxGettingMethod);
            this.Controls.Add(this.numBoardIDSetting);
            this.Controls.Add(this.numWDTValue);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtBoardID);
            this.Controls.Add(this.cbxDevID);
            this.Controls.Add(this.labSettingBoardID);
            this.Controls.Add(this.labWDTunit);
            this.Controls.Add(this.labWDT);
            this.Controls.Add(this.labNickname);
            this.Controls.Add(this.labBoardID);
            this.Controls.Add(this.labDevID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormDI_API_Test";
            this.Text = "FormDI_API_Test";
            this.gbxGetCntEdgeTrig.ResumeLayout(false);
            this.gbxSetCntEdgeTrig.ResumeLayout(false);
            this.gbxSetCntEdgeTrig.PerformLayout();
            this.gbxSetDigitalFilterWidth.ResumeLayout(false);
            this.gbxSetDigitalFilterWidth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDigitalFilterWidth)).EndInit();
            this.gbxSettingMethods.ResumeLayout(false);
            this.gbxSetDIValueInverse.ResumeLayout(false);
            this.gbxSetDIValueInverse.PerformLayout();
            this.gbxGettingMethod.ResumeLayout(false);
            this.gbxGetDIValueInverse.ResumeLayout(false);
            this.gbxGetDigitalFilterWidth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numBoardIDSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWDTValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvInfo;
        private System.Windows.Forms.GroupBox gbxGetCntEdgeTrig;
        private System.Windows.Forms.Button btnGetCntEdgeTrig;
        private System.Windows.Forms.GroupBox gbxSetCntEdgeTrig;
        private System.Windows.Forms.Button btnSetCntEdgeTrig;
        private System.Windows.Forms.GroupBox gbxSetDigitalFilterWidth;
        private System.Windows.Forms.Label labSetFilterWidthUnit;
        private System.Windows.Forms.Label labSetFilterWidthValue;
        private System.Windows.Forms.Button btnSetFilterWidth;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSetBoardID;
        private System.Windows.Forms.Button btnSetWDT;
        private System.Windows.Forms.Button btnSetNickname;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtNickName;
        private System.Windows.Forms.Button btnGetDigitalFilterWidth;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbxSettingMethods;
        private System.Windows.Forms.GroupBox gbxGettingMethod;
        private System.Windows.Forms.GroupBox gbxGetDIValueInverse;
        private System.Windows.Forms.Button btnGetDIValueInverse;
        private System.Windows.Forms.GroupBox gbxGetDigitalFilterWidth;
        private System.Windows.Forms.NumericUpDown numBoardIDSetting;
        private System.Windows.Forms.NumericUpDown numWDTValue;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtBoardID;
        private System.Windows.Forms.ComboBox cbxDevID;
        private System.Windows.Forms.Label labSettingBoardID;
        private System.Windows.Forms.Label labWDTunit;
        private System.Windows.Forms.Label labWDT;
        private System.Windows.Forms.Label labNickname;
        private System.Windows.Forms.Label labBoardID;
        private System.Windows.Forms.Label labDevID;
        private System.Windows.Forms.GroupBox gbxSetDIValueInverse;
        private System.Windows.Forms.Button btnSetDIValueInverse;
        private System.Windows.Forms.NumericUpDown numDigitalFilterWidth;
        private System.Windows.Forms.RadioButton rdbtnDIValueInvDisable;
        private System.Windows.Forms.RadioButton rdbtnDIValueInvEnable;
        private System.Windows.Forms.RadioButton rdbtnEdgeFalling;
        private System.Windows.Forms.RadioButton rdbtnEdgeRising;
    }
}

