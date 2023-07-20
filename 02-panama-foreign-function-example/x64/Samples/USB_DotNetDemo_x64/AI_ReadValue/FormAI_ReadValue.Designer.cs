namespace AI_ReadValue
{
    partial class FormAI_ReadValue
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtBoardID = new System.Windows.Forms.TextBox();
            this.cbxDevID = new System.Windows.Forms.ComboBox();
            this.labBoardID = new System.Windows.Forms.Label();
            this.labDevID = new System.Windows.Forms.Label();
            this.lvInfo = new System.Windows.Forms.ListView();
            this.btnReadDigiValue = new System.Windows.Forms.Button();
            this.btnReadAnalogValue = new System.Windows.Forms.Button();
            this.btnReadDigitalValueWithChStatus = new System.Windows.Forms.Button();
            this.btnReadAnalogValueWithChStatus = new System.Windows.Forms.Button();
            this.labDigitalValue = new System.Windows.Forms.Label();
            this.labAnalogValue = new System.Windows.Forms.Label();
            this.labChStatus = new System.Windows.Forms.Label();
            this.lbDigitalValue = new System.Windows.Forms.ListBox();
            this.lbChannelStatus = new System.Windows.Forms.ListBox();
            this.lbAnalogValue = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(92, 66);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(26, 66);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(60, 23);
            this.btnOpen.TabIndex = 9;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtBoardID
            // 
            this.txtBoardID.Location = new System.Drawing.Point(68, 38);
            this.txtBoardID.Name = "txtBoardID";
            this.txtBoardID.Size = new System.Drawing.Size(98, 22);
            this.txtBoardID.TabIndex = 8;
            this.txtBoardID.Text = "1";
            // 
            // cbxDevID
            // 
            this.cbxDevID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDevID.FormattingEnabled = true;
            this.cbxDevID.Items.AddRange(new object[] {
            "USB-2019"});
            this.cbxDevID.Location = new System.Drawing.Point(68, 12);
            this.cbxDevID.Name = "cbxDevID";
            this.cbxDevID.Size = new System.Drawing.Size(98, 20);
            this.cbxDevID.TabIndex = 7;
            // 
            // labBoardID
            // 
            this.labBoardID.AutoSize = true;
            this.labBoardID.Location = new System.Drawing.Point(10, 43);
            this.labBoardID.Name = "labBoardID";
            this.labBoardID.Size = new System.Drawing.Size(49, 12);
            this.labBoardID.TabIndex = 5;
            this.labBoardID.Text = "Board ID";
            // 
            // labDevID
            // 
            this.labDevID.AutoSize = true;
            this.labDevID.Location = new System.Drawing.Point(10, 15);
            this.labDevID.Name = "labDevID";
            this.labDevID.Size = new System.Drawing.Size(52, 12);
            this.labDevID.TabIndex = 6;
            this.labDevID.Text = "Device ID";
            // 
            // lvInfo
            // 
            this.lvInfo.Location = new System.Drawing.Point(12, 95);
            this.lvInfo.Name = "lvInfo";
            this.lvInfo.Size = new System.Drawing.Size(154, 159);
            this.lvInfo.TabIndex = 11;
            this.lvInfo.UseCompatibleStateImageBehavior = false;
            this.lvInfo.View = System.Windows.Forms.View.List;
            // 
            // btnReadDigiValue
            // 
            this.btnReadDigiValue.Enabled = false;
            this.btnReadDigiValue.Location = new System.Drawing.Point(172, 10);
            this.btnReadDigiValue.Name = "btnReadDigiValue";
            this.btnReadDigiValue.Size = new System.Drawing.Size(110, 23);
            this.btnReadDigiValue.TabIndex = 9;
            this.btnReadDigiValue.Text = "Read Digital Value";
            this.btnReadDigiValue.UseVisualStyleBackColor = true;
            this.btnReadDigiValue.Click += new System.EventHandler(this.btnReadDigiValue_Click);
            // 
            // btnReadAnalogValue
            // 
            this.btnReadAnalogValue.Enabled = false;
            this.btnReadAnalogValue.Location = new System.Drawing.Point(172, 37);
            this.btnReadAnalogValue.Name = "btnReadAnalogValue";
            this.btnReadAnalogValue.Size = new System.Drawing.Size(110, 23);
            this.btnReadAnalogValue.TabIndex = 9;
            this.btnReadAnalogValue.Text = "Read Analog Value";
            this.btnReadAnalogValue.UseVisualStyleBackColor = true;
            this.btnReadAnalogValue.Click += new System.EventHandler(this.btnReadAnalogValue_Click);
            // 
            // btnReadDigitalValueWithChStatus
            // 
            this.btnReadDigitalValueWithChStatus.Enabled = false;
            this.btnReadDigitalValueWithChStatus.Location = new System.Drawing.Point(288, 10);
            this.btnReadDigitalValueWithChStatus.Name = "btnReadDigitalValueWithChStatus";
            this.btnReadDigitalValueWithChStatus.Size = new System.Drawing.Size(180, 23);
            this.btnReadDigitalValueWithChStatus.TabIndex = 9;
            this.btnReadDigitalValueWithChStatus.Text = "Read Digital Value With Ch Status";
            this.btnReadDigitalValueWithChStatus.UseVisualStyleBackColor = true;
            this.btnReadDigitalValueWithChStatus.Click += new System.EventHandler(this.btnReadDigitalValueWithChStatus_Click);
            // 
            // btnReadAnalogValueWithChStatus
            // 
            this.btnReadAnalogValueWithChStatus.Enabled = false;
            this.btnReadAnalogValueWithChStatus.Location = new System.Drawing.Point(288, 37);
            this.btnReadAnalogValueWithChStatus.Name = "btnReadAnalogValueWithChStatus";
            this.btnReadAnalogValueWithChStatus.Size = new System.Drawing.Size(180, 23);
            this.btnReadAnalogValueWithChStatus.TabIndex = 9;
            this.btnReadAnalogValueWithChStatus.Text = "Read Analog Value With Ch Status";
            this.btnReadAnalogValueWithChStatus.UseVisualStyleBackColor = true;
            this.btnReadAnalogValueWithChStatus.Click += new System.EventHandler(this.btnReadAnalogValueWithChStatus_Click);
            // 
            // labDigitalValue
            // 
            this.labDigitalValue.AutoSize = true;
            this.labDigitalValue.Location = new System.Drawing.Point(170, 80);
            this.labDigitalValue.Name = "labDigitalValue";
            this.labDigitalValue.Size = new System.Drawing.Size(66, 12);
            this.labDigitalValue.TabIndex = 12;
            this.labDigitalValue.Text = "Digital Value";
            // 
            // labAnalogValue
            // 
            this.labAnalogValue.AutoSize = true;
            this.labAnalogValue.Location = new System.Drawing.Point(279, 80);
            this.labAnalogValue.Name = "labAnalogValue";
            this.labAnalogValue.Size = new System.Drawing.Size(69, 12);
            this.labAnalogValue.TabIndex = 12;
            this.labAnalogValue.Text = "Analog Value";
            // 
            // labChStatus
            // 
            this.labChStatus.AutoSize = true;
            this.labChStatus.Location = new System.Drawing.Point(388, 80);
            this.labChStatus.Name = "labChStatus";
            this.labChStatus.Size = new System.Drawing.Size(74, 12);
            this.labChStatus.TabIndex = 12;
            this.labChStatus.Text = "Channel Status";
            // 
            // lbDigitalValue
            // 
            this.lbDigitalValue.FormattingEnabled = true;
            this.lbDigitalValue.ItemHeight = 12;
            this.lbDigitalValue.Location = new System.Drawing.Point(172, 95);
            this.lbDigitalValue.Name = "lbDigitalValue";
            this.lbDigitalValue.Size = new System.Drawing.Size(106, 160);
            this.lbDigitalValue.TabIndex = 13;
            // 
            // lbChannelStatus
            // 
            this.lbChannelStatus.FormattingEnabled = true;
            this.lbChannelStatus.ItemHeight = 12;
            this.lbChannelStatus.Location = new System.Drawing.Point(390, 95);
            this.lbChannelStatus.Name = "lbChannelStatus";
            this.lbChannelStatus.Size = new System.Drawing.Size(79, 160);
            this.lbChannelStatus.TabIndex = 13;
            // 
            // lbAnalogValue
            // 
            this.lbAnalogValue.FormattingEnabled = true;
            this.lbAnalogValue.ItemHeight = 12;
            this.lbAnalogValue.Location = new System.Drawing.Point(281, 95);
            this.lbAnalogValue.Name = "lbAnalogValue";
            this.lbAnalogValue.Size = new System.Drawing.Size(106, 160);
            this.lbAnalogValue.TabIndex = 13;
            // 
            // FormAI_ReadValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 264);
            this.Controls.Add(this.lbChannelStatus);
            this.Controls.Add(this.lbAnalogValue);
            this.Controls.Add(this.lbDigitalValue);
            this.Controls.Add(this.labChStatus);
            this.Controls.Add(this.labAnalogValue);
            this.Controls.Add(this.labDigitalValue);
            this.Controls.Add(this.lvInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReadAnalogValueWithChStatus);
            this.Controls.Add(this.btnReadAnalogValue);
            this.Controls.Add(this.btnReadDigitalValueWithChStatus);
            this.Controls.Add(this.btnReadDigiValue);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtBoardID);
            this.Controls.Add(this.cbxDevID);
            this.Controls.Add(this.labBoardID);
            this.Controls.Add(this.labDevID);
            this.Name = "FormAI_ReadValue";
            this.Text = "FormAI_ReadValue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtBoardID;
        private System.Windows.Forms.ComboBox cbxDevID;
        private System.Windows.Forms.Label labBoardID;
        private System.Windows.Forms.Label labDevID;
        private System.Windows.Forms.ListView lvInfo;
        private System.Windows.Forms.Button btnReadDigiValue;
        private System.Windows.Forms.Button btnReadAnalogValue;
        private System.Windows.Forms.Button btnReadDigitalValueWithChStatus;
        private System.Windows.Forms.Button btnReadAnalogValueWithChStatus;
        private System.Windows.Forms.Label labDigitalValue;
        private System.Windows.Forms.Label labAnalogValue;
        private System.Windows.Forms.Label labChStatus;
        private System.Windows.Forms.ListBox lbDigitalValue;
        private System.Windows.Forms.ListBox lbChannelStatus;
        private System.Windows.Forms.ListBox lbAnalogValue;
    }
}

