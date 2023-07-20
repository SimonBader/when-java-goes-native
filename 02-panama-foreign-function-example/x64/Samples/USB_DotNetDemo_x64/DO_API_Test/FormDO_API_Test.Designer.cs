namespace DO_API_Test
{
    partial class FormDO_API_Test
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
            this.gbxGetSafetyValue = new System.Windows.Forms.GroupBox();
            this.btnGetSafetyValue = new System.Windows.Forms.Button();
            this.gbxSetSafetyValue = new System.Windows.Forms.GroupBox();
            this.txtSetSafetyValue = new System.Windows.Forms.TextBox();
            this.lab0X = new System.Windows.Forms.Label();
            this.labSetSafetyValue = new System.Windows.Forms.Label();
            this.btnSetSafetyValue = new System.Windows.Forms.Button();
            this.gbxSetPwrOnEnable = new System.Windows.Forms.GroupBox();
            this.lab0x2 = new System.Windows.Forms.Label();
            this.numSetPwrOnEnableCh = new System.Windows.Forms.NumericUpDown();
            this.txtSetPwrOnEnable = new System.Windows.Forms.TextBox();
            this.labSetTypeCodeCh = new System.Windows.Forms.Label();
            this.labSetPwrOnEnable = new System.Windows.Forms.Label();
            this.btnSetPwrOnEnable = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSetBoardID = new System.Windows.Forms.Button();
            this.btnSetWDT = new System.Windows.Forms.Button();
            this.btnSetNickname = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtNickName = new System.Windows.Forms.TextBox();
            this.btnGetPwrOnEnable = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbxSettingMethods = new System.Windows.Forms.GroupBox();
            this.gbxSetSafetyEnable = new System.Windows.Forms.GroupBox();
            this.txtSetSafetyEnable = new System.Windows.Forms.TextBox();
            this.lab0x3 = new System.Windows.Forms.Label();
            this.labSetSafetyEnable = new System.Windows.Forms.Label();
            this.btnSetSafetyEnable = new System.Windows.Forms.Button();
            this.gbxGettingMethod = new System.Windows.Forms.GroupBox();
            this.gbxGetSafetyEnable = new System.Windows.Forms.GroupBox();
            this.btnGetSafetyEnable = new System.Windows.Forms.Button();
            this.gbxGetPwrOnEnable = new System.Windows.Forms.GroupBox();
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
            this.gbxGetSafetyValue.SuspendLayout();
            this.gbxSetSafetyValue.SuspendLayout();
            this.gbxSetPwrOnEnable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSetPwrOnEnableCh)).BeginInit();
            this.gbxSettingMethods.SuspendLayout();
            this.gbxSetSafetyEnable.SuspendLayout();
            this.gbxGettingMethod.SuspendLayout();
            this.gbxGetSafetyEnable.SuspendLayout();
            this.gbxGetPwrOnEnable.SuspendLayout();
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
            // gbxGetSafetyValue
            // 
            this.gbxGetSafetyValue.Controls.Add(this.btnGetSafetyValue);
            this.gbxGetSafetyValue.Location = new System.Drawing.Point(6, 108);
            this.gbxGetSafetyValue.Name = "gbxGetSafetyValue";
            this.gbxGetSafetyValue.Size = new System.Drawing.Size(122, 45);
            this.gbxGetSafetyValue.TabIndex = 0;
            this.gbxGetSafetyValue.TabStop = false;
            this.gbxGetSafetyValue.Text = "Safety Value";
            // 
            // btnGetSafetyValue
            // 
            this.btnGetSafetyValue.Location = new System.Drawing.Point(31, 16);
            this.btnGetSafetyValue.Name = "btnGetSafetyValue";
            this.btnGetSafetyValue.Size = new System.Drawing.Size(60, 23);
            this.btnGetSafetyValue.TabIndex = 0;
            this.btnGetSafetyValue.Text = "Get";
            this.btnGetSafetyValue.UseVisualStyleBackColor = true;
            this.btnGetSafetyValue.Click += new System.EventHandler(this.btnGetSafetyValue_Click);
            // 
            // gbxSetSafetyValue
            // 
            this.gbxSetSafetyValue.Controls.Add(this.txtSetSafetyValue);
            this.gbxSetSafetyValue.Controls.Add(this.lab0X);
            this.gbxSetSafetyValue.Controls.Add(this.labSetSafetyValue);
            this.gbxSetSafetyValue.Controls.Add(this.btnSetSafetyValue);
            this.gbxSetSafetyValue.Location = new System.Drawing.Point(6, 108);
            this.gbxSetSafetyValue.Name = "gbxSetSafetyValue";
            this.gbxSetSafetyValue.Size = new System.Drawing.Size(315, 45);
            this.gbxSetSafetyValue.TabIndex = 1;
            this.gbxSetSafetyValue.TabStop = false;
            this.gbxSetSafetyValue.Text = "Safety Value";
            // 
            // txtSetSafetyValue
            // 
            this.txtSetSafetyValue.Location = new System.Drawing.Point(63, 16);
            this.txtSetSafetyValue.MaxLength = 10;
            this.txtSetSafetyValue.Name = "txtSetSafetyValue";
            this.txtSetSafetyValue.Size = new System.Drawing.Size(59, 22);
            this.txtSetSafetyValue.TabIndex = 6;
            // 
            // lab0X
            // 
            this.lab0X.AutoSize = true;
            this.lab0X.Location = new System.Drawing.Point(43, 21);
            this.lab0X.Name = "lab0X";
            this.lab0X.Size = new System.Drawing.Size(17, 12);
            this.lab0X.TabIndex = 5;
            this.lab0X.Text = "0x";
            // 
            // labSetSafetyValue
            // 
            this.labSetSafetyValue.AutoSize = true;
            this.labSetSafetyValue.Location = new System.Drawing.Point(6, 21);
            this.labSetSafetyValue.Name = "labSetSafetyValue";
            this.labSetSafetyValue.Size = new System.Drawing.Size(32, 12);
            this.labSetSafetyValue.TabIndex = 1;
            this.labSetSafetyValue.Text = "Value";
            // 
            // btnSetSafetyValue
            // 
            this.btnSetSafetyValue.Location = new System.Drawing.Point(248, 14);
            this.btnSetSafetyValue.Name = "btnSetSafetyValue";
            this.btnSetSafetyValue.Size = new System.Drawing.Size(60, 23);
            this.btnSetSafetyValue.TabIndex = 0;
            this.btnSetSafetyValue.Text = "Set";
            this.btnSetSafetyValue.UseVisualStyleBackColor = true;
            this.btnSetSafetyValue.Click += new System.EventHandler(this.btnSetSafetyValue_Click);
            // 
            // gbxSetPwrOnEnable
            // 
            this.gbxSetPwrOnEnable.Controls.Add(this.lab0x2);
            this.gbxSetPwrOnEnable.Controls.Add(this.numSetPwrOnEnableCh);
            this.gbxSetPwrOnEnable.Controls.Add(this.txtSetPwrOnEnable);
            this.gbxSetPwrOnEnable.Controls.Add(this.labSetTypeCodeCh);
            this.gbxSetPwrOnEnable.Controls.Add(this.labSetPwrOnEnable);
            this.gbxSetPwrOnEnable.Controls.Add(this.btnSetPwrOnEnable);
            this.gbxSetPwrOnEnable.Location = new System.Drawing.Point(6, 16);
            this.gbxSetPwrOnEnable.Name = "gbxSetPwrOnEnable";
            this.gbxSetPwrOnEnable.Size = new System.Drawing.Size(315, 45);
            this.gbxSetPwrOnEnable.TabIndex = 1;
            this.gbxSetPwrOnEnable.TabStop = false;
            this.gbxSetPwrOnEnable.Text = "Power-On Enable";
            // 
            // lab0x2
            // 
            this.lab0x2.AutoSize = true;
            this.lab0x2.Location = new System.Drawing.Point(43, 21);
            this.lab0x2.Name = "lab0x2";
            this.lab0x2.Size = new System.Drawing.Size(17, 12);
            this.lab0x2.TabIndex = 6;
            this.lab0x2.Text = "0x";
            // 
            // numSetPwrOnEnableCh
            // 
            this.numSetPwrOnEnableCh.Location = new System.Drawing.Point(180, 16);
            this.numSetPwrOnEnableCh.Name = "numSetPwrOnEnableCh";
            this.numSetPwrOnEnableCh.Size = new System.Drawing.Size(62, 22);
            this.numSetPwrOnEnableCh.TabIndex = 3;
            // 
            // txtSetPwrOnEnable
            // 
            this.txtSetPwrOnEnable.Location = new System.Drawing.Point(63, 16);
            this.txtSetPwrOnEnable.MaxLength = 2;
            this.txtSetPwrOnEnable.Name = "txtSetPwrOnEnable";
            this.txtSetPwrOnEnable.Size = new System.Drawing.Size(59, 22);
            this.txtSetPwrOnEnable.TabIndex = 2;
            // 
            // labSetTypeCodeCh
            // 
            this.labSetTypeCodeCh.AutoSize = true;
            this.labSetTypeCodeCh.Location = new System.Drawing.Point(130, 21);
            this.labSetTypeCodeCh.Name = "labSetTypeCodeCh";
            this.labSetTypeCodeCh.Size = new System.Drawing.Size(44, 12);
            this.labSetTypeCodeCh.TabIndex = 1;
            this.labSetTypeCodeCh.Text = "Channel";
            // 
            // labSetPwrOnEnable
            // 
            this.labSetPwrOnEnable.AutoSize = true;
            this.labSetPwrOnEnable.Location = new System.Drawing.Point(6, 21);
            this.labSetPwrOnEnable.Name = "labSetPwrOnEnable";
            this.labSetPwrOnEnable.Size = new System.Drawing.Size(32, 12);
            this.labSetPwrOnEnable.TabIndex = 1;
            this.labSetPwrOnEnable.Text = "Value";
            // 
            // btnSetPwrOnEnable
            // 
            this.btnSetPwrOnEnable.Location = new System.Drawing.Point(248, 16);
            this.btnSetPwrOnEnable.Name = "btnSetPwrOnEnable";
            this.btnSetPwrOnEnable.Size = new System.Drawing.Size(60, 23);
            this.btnSetPwrOnEnable.TabIndex = 0;
            this.btnSetPwrOnEnable.Text = "Set";
            this.btnSetPwrOnEnable.UseVisualStyleBackColor = true;
            this.btnSetPwrOnEnable.Click += new System.EventHandler(this.btnSetPwrOnEnable_Click);
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
            // btnGetPwrOnEnable
            // 
            this.btnGetPwrOnEnable.Location = new System.Drawing.Point(31, 16);
            this.btnGetPwrOnEnable.Name = "btnGetPwrOnEnable";
            this.btnGetPwrOnEnable.Size = new System.Drawing.Size(60, 23);
            this.btnGetPwrOnEnable.TabIndex = 0;
            this.btnGetPwrOnEnable.Text = "Get";
            this.btnGetPwrOnEnable.UseVisualStyleBackColor = true;
            this.btnGetPwrOnEnable.Click += new System.EventHandler(this.btnGetPwrOnEnable_Click);
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
            this.gbxSettingMethods.Controls.Add(this.gbxSetSafetyEnable);
            this.gbxSettingMethods.Controls.Add(this.gbxSetSafetyValue);
            this.gbxSettingMethods.Controls.Add(this.gbxSetPwrOnEnable);
            this.gbxSettingMethods.Location = new System.Drawing.Point(309, 8);
            this.gbxSettingMethods.Name = "gbxSettingMethods";
            this.gbxSettingMethods.Size = new System.Drawing.Size(324, 160);
            this.gbxSettingMethods.TabIndex = 28;
            this.gbxSettingMethods.TabStop = false;
            this.gbxSettingMethods.Text = "Setting Method";
            // 
            // gbxSetSafetyEnable
            // 
            this.gbxSetSafetyEnable.Controls.Add(this.txtSetSafetyEnable);
            this.gbxSetSafetyEnable.Controls.Add(this.lab0x3);
            this.gbxSetSafetyEnable.Controls.Add(this.labSetSafetyEnable);
            this.gbxSetSafetyEnable.Controls.Add(this.btnSetSafetyEnable);
            this.gbxSetSafetyEnable.Location = new System.Drawing.Point(6, 62);
            this.gbxSetSafetyEnable.Name = "gbxSetSafetyEnable";
            this.gbxSetSafetyEnable.Size = new System.Drawing.Size(315, 45);
            this.gbxSetSafetyEnable.TabIndex = 1;
            this.gbxSetSafetyEnable.TabStop = false;
            this.gbxSetSafetyEnable.Text = "Safety Enable";
            // 
            // txtSetSafetyEnable
            // 
            this.txtSetSafetyEnable.Location = new System.Drawing.Point(63, 16);
            this.txtSetSafetyEnable.MaxLength = 10;
            this.txtSetSafetyEnable.Name = "txtSetSafetyEnable";
            this.txtSetSafetyEnable.Size = new System.Drawing.Size(59, 22);
            this.txtSetSafetyEnable.TabIndex = 6;
            // 
            // lab0x3
            // 
            this.lab0x3.AutoSize = true;
            this.lab0x3.Location = new System.Drawing.Point(43, 21);
            this.lab0x3.Name = "lab0x3";
            this.lab0x3.Size = new System.Drawing.Size(17, 12);
            this.lab0x3.TabIndex = 5;
            this.lab0x3.Text = "0x";
            // 
            // labSetSafetyEnable
            // 
            this.labSetSafetyEnable.AutoSize = true;
            this.labSetSafetyEnable.Location = new System.Drawing.Point(6, 21);
            this.labSetSafetyEnable.Name = "labSetSafetyEnable";
            this.labSetSafetyEnable.Size = new System.Drawing.Size(30, 12);
            this.labSetSafetyEnable.TabIndex = 1;
            this.labSetSafetyEnable.Text = "Mask";
            // 
            // btnSetSafetyEnable
            // 
            this.btnSetSafetyEnable.Location = new System.Drawing.Point(248, 14);
            this.btnSetSafetyEnable.Name = "btnSetSafetyEnable";
            this.btnSetSafetyEnable.Size = new System.Drawing.Size(60, 23);
            this.btnSetSafetyEnable.TabIndex = 0;
            this.btnSetSafetyEnable.Text = "Set";
            this.btnSetSafetyEnable.UseVisualStyleBackColor = true;
            this.btnSetSafetyEnable.Click += new System.EventHandler(this.btnSetSafetyEnable_Click);
            // 
            // gbxGettingMethod
            // 
            this.gbxGettingMethod.Controls.Add(this.gbxGetSafetyValue);
            this.gbxGettingMethod.Controls.Add(this.gbxGetSafetyEnable);
            this.gbxGettingMethod.Controls.Add(this.gbxGetPwrOnEnable);
            this.gbxGettingMethod.Location = new System.Drawing.Point(169, 8);
            this.gbxGettingMethod.Name = "gbxGettingMethod";
            this.gbxGettingMethod.Size = new System.Drawing.Size(134, 160);
            this.gbxGettingMethod.TabIndex = 29;
            this.gbxGettingMethod.TabStop = false;
            this.gbxGettingMethod.Text = "Getting Method";
            // 
            // gbxGetSafetyEnable
            // 
            this.gbxGetSafetyEnable.Controls.Add(this.btnGetSafetyEnable);
            this.gbxGetSafetyEnable.Location = new System.Drawing.Point(6, 62);
            this.gbxGetSafetyEnable.Name = "gbxGetSafetyEnable";
            this.gbxGetSafetyEnable.Size = new System.Drawing.Size(122, 45);
            this.gbxGetSafetyEnable.TabIndex = 0;
            this.gbxGetSafetyEnable.TabStop = false;
            this.gbxGetSafetyEnable.Text = "Safety Enable";
            // 
            // btnGetSafetyEnable
            // 
            this.btnGetSafetyEnable.Location = new System.Drawing.Point(31, 16);
            this.btnGetSafetyEnable.Name = "btnGetSafetyEnable";
            this.btnGetSafetyEnable.Size = new System.Drawing.Size(60, 23);
            this.btnGetSafetyEnable.TabIndex = 0;
            this.btnGetSafetyEnable.Text = "Get";
            this.btnGetSafetyEnable.UseVisualStyleBackColor = true;
            this.btnGetSafetyEnable.Click += new System.EventHandler(this.btnGetSafetyEnable_Click);
            // 
            // gbxGetPwrOnEnable
            // 
            this.gbxGetPwrOnEnable.Controls.Add(this.btnGetPwrOnEnable);
            this.gbxGetPwrOnEnable.Location = new System.Drawing.Point(6, 16);
            this.gbxGetPwrOnEnable.Name = "gbxGetPwrOnEnable";
            this.gbxGetPwrOnEnable.Size = new System.Drawing.Size(122, 45);
            this.gbxGetPwrOnEnable.TabIndex = 0;
            this.gbxGetPwrOnEnable.TabStop = false;
            this.gbxGetPwrOnEnable.Text = "Power-On Enable";
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
            "USB-2045",
            "USB-2055",
            "USB-2064",
            "USB-2045-32",
            "USB-2055-32",
            "USB-2064-32",
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
            // FormDO_API_Test
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
            this.Name = "FormDO_API_Test";
            this.Text = "FormDO_API_Test";
            this.gbxGetSafetyValue.ResumeLayout(false);
            this.gbxSetSafetyValue.ResumeLayout(false);
            this.gbxSetSafetyValue.PerformLayout();
            this.gbxSetPwrOnEnable.ResumeLayout(false);
            this.gbxSetPwrOnEnable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSetPwrOnEnableCh)).EndInit();
            this.gbxSettingMethods.ResumeLayout(false);
            this.gbxSetSafetyEnable.ResumeLayout(false);
            this.gbxSetSafetyEnable.PerformLayout();
            this.gbxGettingMethod.ResumeLayout(false);
            this.gbxGetSafetyEnable.ResumeLayout(false);
            this.gbxGetPwrOnEnable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numBoardIDSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWDTValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvInfo;
        private System.Windows.Forms.GroupBox gbxGetSafetyValue;
        private System.Windows.Forms.Button btnGetSafetyValue;
        private System.Windows.Forms.GroupBox gbxSetSafetyValue;
        private System.Windows.Forms.TextBox txtSetSafetyValue;
        private System.Windows.Forms.Label lab0X;
        private System.Windows.Forms.Label labSetSafetyValue;
        private System.Windows.Forms.Button btnSetSafetyValue;
        private System.Windows.Forms.GroupBox gbxSetPwrOnEnable;
        private System.Windows.Forms.Label lab0x2;
        private System.Windows.Forms.NumericUpDown numSetPwrOnEnableCh;
        private System.Windows.Forms.TextBox txtSetPwrOnEnable;
        private System.Windows.Forms.Label labSetTypeCodeCh;
        private System.Windows.Forms.Label labSetPwrOnEnable;
        private System.Windows.Forms.Button btnSetPwrOnEnable;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSetBoardID;
        private System.Windows.Forms.Button btnSetWDT;
        private System.Windows.Forms.Button btnSetNickname;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtNickName;
        private System.Windows.Forms.Button btnGetPwrOnEnable;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbxSettingMethods;
        private System.Windows.Forms.GroupBox gbxGettingMethod;
        private System.Windows.Forms.GroupBox gbxGetSafetyEnable;
        private System.Windows.Forms.Button btnGetSafetyEnable;
        private System.Windows.Forms.GroupBox gbxGetPwrOnEnable;
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
        private System.Windows.Forms.GroupBox gbxSetSafetyEnable;
        private System.Windows.Forms.TextBox txtSetSafetyEnable;
        private System.Windows.Forms.Label lab0x3;
        private System.Windows.Forms.Label labSetSafetyEnable;
        private System.Windows.Forms.Button btnSetSafetyEnable;
    }
}

