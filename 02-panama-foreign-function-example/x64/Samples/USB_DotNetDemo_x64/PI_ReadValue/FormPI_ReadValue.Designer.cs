namespace PI_ReadValue
{
    partial class FormPI_ReadValue
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
            this.btnReadValue = new System.Windows.Forms.Button();
            this.labReadingValue = new System.Windows.Forms.Label();
            this.lbReadingValue = new System.Windows.Forms.ListBox();
            this.labChStatus = new System.Windows.Forms.Label();
            this.lbChannelStatus = new System.Windows.Forms.ListBox();
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
            "USB-2084"});
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
            // btnReadValue
            // 
            this.btnReadValue.Enabled = false;
            this.btnReadValue.Location = new System.Drawing.Point(172, 10);
            this.btnReadValue.Name = "btnReadValue";
            this.btnReadValue.Size = new System.Drawing.Size(110, 23);
            this.btnReadValue.TabIndex = 9;
            this.btnReadValue.Text = "Read Value";
            this.btnReadValue.UseVisualStyleBackColor = true;
            this.btnReadValue.Click += new System.EventHandler(this.btnReadDigiValue_Click);
            // 
            // labReadingValue
            // 
            this.labReadingValue.AutoSize = true;
            this.labReadingValue.Location = new System.Drawing.Point(170, 55);
            this.labReadingValue.Name = "labReadingValue";
            this.labReadingValue.Size = new System.Drawing.Size(74, 12);
            this.labReadingValue.TabIndex = 12;
            this.labReadingValue.Text = "Reading Value";
            // 
            // lbReadingValue
            // 
            this.lbReadingValue.FormattingEnabled = true;
            this.lbReadingValue.ItemHeight = 12;
            this.lbReadingValue.Location = new System.Drawing.Point(172, 70);
            this.lbReadingValue.Name = "lbReadingValue";
            this.lbReadingValue.Size = new System.Drawing.Size(110, 184);
            this.lbReadingValue.TabIndex = 13;
            // 
            // labChStatus
            // 
            this.labChStatus.AutoSize = true;
            this.labChStatus.Location = new System.Drawing.Point(286, 55);
            this.labChStatus.Name = "labChStatus";
            this.labChStatus.Size = new System.Drawing.Size(74, 12);
            this.labChStatus.TabIndex = 12;
            this.labChStatus.Text = "Channel Status";
            // 
            // lbChannelStatus
            // 
            this.lbChannelStatus.FormattingEnabled = true;
            this.lbChannelStatus.ItemHeight = 12;
            this.lbChannelStatus.Location = new System.Drawing.Point(288, 70);
            this.lbChannelStatus.Name = "lbChannelStatus";
            this.lbChannelStatus.Size = new System.Drawing.Size(110, 184);
            this.lbChannelStatus.TabIndex = 13;
            // 
            // FormPI_ReadValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 264);
            this.Controls.Add(this.lbChannelStatus);
            this.Controls.Add(this.labChStatus);
            this.Controls.Add(this.lbReadingValue);
            this.Controls.Add(this.labReadingValue);
            this.Controls.Add(this.lvInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReadValue);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtBoardID);
            this.Controls.Add(this.cbxDevID);
            this.Controls.Add(this.labBoardID);
            this.Controls.Add(this.labDevID);
            this.Name = "FormPI_ReadValue";
            this.Text = "FormPI_ReadValue";
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
        private System.Windows.Forms.Button btnReadValue;
        private System.Windows.Forms.Label labReadingValue;
        private System.Windows.Forms.ListBox lbReadingValue;
        private System.Windows.Forms.Label labChStatus;
        private System.Windows.Forms.ListBox lbChannelStatus;
    }
}

