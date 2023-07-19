namespace DI_ReadValue
{
    partial class FormDI_ReadValue
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
            this.gbxDigitalValue = new System.Windows.Forms.GroupBox();
            this.lbDigitalValue = new System.Windows.Forms.ListBox();
            this.labDigitalValue = new System.Windows.Forms.Label();
            this.btnReadDigiValue = new System.Windows.Forms.Button();
            this.gbxCntValue = new System.Windows.Forms.GroupBox();
            this.txtCntClrMsk = new System.Windows.Forms.TextBox();
            this.labCntClrMsk = new System.Windows.Forms.Label();
            this.lbCntVal = new System.Windows.Forms.ListBox();
            this.labCntVal = new System.Windows.Forms.Label();
            this.btnCntClr = new System.Windows.Forms.Button();
            this.btnReadCntVal = new System.Windows.Forms.Button();
            this.txtWriteDOValue = new System.Windows.Forms.TextBox();
            this.lab0x2 = new System.Windows.Forms.Label();
            this.txtReadDOValue = new System.Windows.Forms.TextBox();
            this.labWriteDOValue = new System.Windows.Forms.Label();
            this.lab0x = new System.Windows.Forms.Label();
            this.labReadDOValue = new System.Windows.Forms.Label();
            this.btnWriteDOValue = new System.Windows.Forms.Button();
            this.btnReadDOValue = new System.Windows.Forms.Button();
            this.gbxDigitalValue.SuspendLayout();
            this.gbxCntValue.SuspendLayout();
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
            "USB-2026",
            "USB-2051",
            "USB-2055",
            "USB-2060",
            "USB-2051-32",
            "USB-2055-32",
            "USB-2068-18"});
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
            this.lvInfo.Size = new System.Drawing.Size(154, 182);
            this.lvInfo.TabIndex = 11;
            this.lvInfo.UseCompatibleStateImageBehavior = false;
            this.lvInfo.View = System.Windows.Forms.View.List;
            // 
            // gbxDigitalValue
            // 
            this.gbxDigitalValue.Controls.Add(this.lbDigitalValue);
            this.gbxDigitalValue.Controls.Add(this.labDigitalValue);
            this.gbxDigitalValue.Controls.Add(this.btnReadDigiValue);
            this.gbxDigitalValue.Location = new System.Drawing.Point(172, 10);
            this.gbxDigitalValue.Name = "gbxDigitalValue";
            this.gbxDigitalValue.Size = new System.Drawing.Size(128, 279);
            this.gbxDigitalValue.TabIndex = 16;
            this.gbxDigitalValue.TabStop = false;
            this.gbxDigitalValue.Text = "Digital Value";
            // 
            // lbDigitalValue
            // 
            this.lbDigitalValue.FormattingEnabled = true;
            this.lbDigitalValue.ItemHeight = 12;
            this.lbDigitalValue.Location = new System.Drawing.Point(11, 107);
            this.lbDigitalValue.Name = "lbDigitalValue";
            this.lbDigitalValue.Size = new System.Drawing.Size(106, 160);
            this.lbDigitalValue.TabIndex = 16;
            // 
            // labDigitalValue
            // 
            this.labDigitalValue.AutoSize = true;
            this.labDigitalValue.Location = new System.Drawing.Point(9, 92);
            this.labDigitalValue.Name = "labDigitalValue";
            this.labDigitalValue.Size = new System.Drawing.Size(66, 12);
            this.labDigitalValue.TabIndex = 15;
            this.labDigitalValue.Text = "Digital Value";
            // 
            // btnReadDigiValue
            // 
            this.btnReadDigiValue.Enabled = false;
            this.btnReadDigiValue.Location = new System.Drawing.Point(9, 22);
            this.btnReadDigiValue.Name = "btnReadDigiValue";
            this.btnReadDigiValue.Size = new System.Drawing.Size(110, 23);
            this.btnReadDigiValue.TabIndex = 14;
            this.btnReadDigiValue.Text = "Read Digital Value";
            this.btnReadDigiValue.UseVisualStyleBackColor = true;
            this.btnReadDigiValue.Click += new System.EventHandler(this.btnReadDigiValue_Click_1);
            // 
            // gbxCntValue
            // 
            this.gbxCntValue.Controls.Add(this.txtCntClrMsk);
            this.gbxCntValue.Controls.Add(this.labCntClrMsk);
            this.gbxCntValue.Controls.Add(this.lbCntVal);
            this.gbxCntValue.Controls.Add(this.labCntVal);
            this.gbxCntValue.Controls.Add(this.btnCntClr);
            this.gbxCntValue.Controls.Add(this.btnReadCntVal);
            this.gbxCntValue.Location = new System.Drawing.Point(306, 10);
            this.gbxCntValue.Name = "gbxCntValue";
            this.gbxCntValue.Size = new System.Drawing.Size(130, 279);
            this.gbxCntValue.TabIndex = 17;
            this.gbxCntValue.TabStop = false;
            this.gbxCntValue.Text = "Counter Value";
            // 
            // txtCntClrMsk
            // 
            this.txtCntClrMsk.Location = new System.Drawing.Point(57, 47);
            this.txtCntClrMsk.Name = "txtCntClrMsk";
            this.txtCntClrMsk.Size = new System.Drawing.Size(64, 22);
            this.txtCntClrMsk.TabIndex = 21;
            // 
            // labCntClrMsk
            // 
            this.labCntClrMsk.AutoSize = true;
            this.labCntClrMsk.Location = new System.Drawing.Point(9, 50);
            this.labCntClrMsk.Name = "labCntClrMsk";
            this.labCntClrMsk.Size = new System.Drawing.Size(45, 12);
            this.labCntClrMsk.TabIndex = 20;
            this.labCntClrMsk.Text = "Mask 0x";
            // 
            // lbCntVal
            // 
            this.lbCntVal.FormattingEnabled = true;
            this.lbCntVal.ItemHeight = 12;
            this.lbCntVal.Location = new System.Drawing.Point(13, 126);
            this.lbCntVal.Name = "lbCntVal";
            this.lbCntVal.Size = new System.Drawing.Size(106, 136);
            this.lbCntVal.TabIndex = 19;
            // 
            // labCntVal
            // 
            this.labCntVal.AutoSize = true;
            this.labCntVal.Location = new System.Drawing.Point(11, 106);
            this.labCntVal.Name = "labCntVal";
            this.labCntVal.Size = new System.Drawing.Size(73, 12);
            this.labCntVal.TabIndex = 18;
            this.labCntVal.Text = "Counter Value";
            // 
            // btnCntClr
            // 
            this.btnCntClr.Enabled = false;
            this.btnCntClr.Location = new System.Drawing.Point(50, 73);
            this.btnCntClr.Name = "btnCntClr";
            this.btnCntClr.Size = new System.Drawing.Size(71, 23);
            this.btnCntClr.TabIndex = 16;
            this.btnCntClr.Text = "Clear";
            this.btnCntClr.UseVisualStyleBackColor = true;
            this.btnCntClr.Click += new System.EventHandler(this.btnCntClr_Click);
            // 
            // btnReadCntVal
            // 
            this.btnReadCntVal.Enabled = false;
            this.btnReadCntVal.Location = new System.Drawing.Point(11, 17);
            this.btnReadCntVal.Name = "btnReadCntVal";
            this.btnReadCntVal.Size = new System.Drawing.Size(110, 23);
            this.btnReadCntVal.TabIndex = 17;
            this.btnReadCntVal.Text = "Read Counter Value";
            this.btnReadCntVal.UseVisualStyleBackColor = true;
            this.btnReadCntVal.Click += new System.EventHandler(this.btnReadCntVal_Click);
            // 
            // txtWriteDOValue
            // 
            this.txtWriteDOValue.Location = new System.Drawing.Point(570, 83);
            this.txtWriteDOValue.Name = "txtWriteDOValue";
            this.txtWriteDOValue.Size = new System.Drawing.Size(84, 22);
            this.txtWriteDOValue.TabIndex = 27;
            this.txtWriteDOValue.Text = "F";
            // 
            // lab0x2
            // 
            this.lab0x2.AutoSize = true;
            this.lab0x2.Location = new System.Drawing.Point(547, 88);
            this.lab0x2.Name = "lab0x2";
            this.lab0x2.Size = new System.Drawing.Size(17, 12);
            this.lab0x2.TabIndex = 23;
            this.lab0x2.Text = "0x";
            // 
            // txtReadDOValue
            // 
            this.txtReadDOValue.Enabled = false;
            this.txtReadDOValue.Location = new System.Drawing.Point(570, 28);
            this.txtReadDOValue.Name = "txtReadDOValue";
            this.txtReadDOValue.Size = new System.Drawing.Size(84, 22);
            this.txtReadDOValue.TabIndex = 28;
            // 
            // labWriteDOValue
            // 
            this.labWriteDOValue.AutoSize = true;
            this.labWriteDOValue.Location = new System.Drawing.Point(490, 88);
            this.labWriteDOValue.Name = "labWriteDOValue";
            this.labWriteDOValue.Size = new System.Drawing.Size(51, 12);
            this.labWriteDOValue.TabIndex = 24;
            this.labWriteDOValue.Text = "DO Value";
            // 
            // lab0x
            // 
            this.lab0x.AutoSize = true;
            this.lab0x.Location = new System.Drawing.Point(547, 33);
            this.lab0x.Name = "lab0x";
            this.lab0x.Size = new System.Drawing.Size(17, 12);
            this.lab0x.TabIndex = 25;
            this.lab0x.Text = "0x";
            // 
            // labReadDOValue
            // 
            this.labReadDOValue.AutoSize = true;
            this.labReadDOValue.Location = new System.Drawing.Point(490, 33);
            this.labReadDOValue.Name = "labReadDOValue";
            this.labReadDOValue.Size = new System.Drawing.Size(51, 12);
            this.labReadDOValue.TabIndex = 26;
            this.labReadDOValue.Text = "DO Value";
            // 
            // btnWriteDOValue
            // 
            this.btnWriteDOValue.Location = new System.Drawing.Point(594, 109);
            this.btnWriteDOValue.Name = "btnWriteDOValue";
            this.btnWriteDOValue.Size = new System.Drawing.Size(60, 23);
            this.btnWriteDOValue.TabIndex = 21;
            this.btnWriteDOValue.Text = "Write";
            this.btnWriteDOValue.UseVisualStyleBackColor = true;
            this.btnWriteDOValue.Click += new System.EventHandler(this.btnWriteDOValue_Click);
            // 
            // btnReadDOValue
            // 
            this.btnReadDOValue.Location = new System.Drawing.Point(594, 54);
            this.btnReadDOValue.Name = "btnReadDOValue";
            this.btnReadDOValue.Size = new System.Drawing.Size(60, 23);
            this.btnReadDOValue.TabIndex = 22;
            this.btnReadDOValue.Text = "Read";
            this.btnReadDOValue.UseVisualStyleBackColor = true;
            this.btnReadDOValue.Click += new System.EventHandler(this.btnReadDOValue_Click);
            // 
            // FormDI_ReadValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 295);
            this.Controls.Add(this.txtWriteDOValue);
            this.Controls.Add(this.lab0x2);
            this.Controls.Add(this.txtReadDOValue);
            this.Controls.Add(this.labWriteDOValue);
            this.Controls.Add(this.lab0x);
            this.Controls.Add(this.labReadDOValue);
            this.Controls.Add(this.btnWriteDOValue);
            this.Controls.Add(this.btnReadDOValue);
            this.Controls.Add(this.gbxCntValue);
            this.Controls.Add(this.gbxDigitalValue);
            this.Controls.Add(this.lvInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtBoardID);
            this.Controls.Add(this.cbxDevID);
            this.Controls.Add(this.labBoardID);
            this.Controls.Add(this.labDevID);
            this.Name = "FormDI_ReadValue";
            this.Text = "FormDI_ReadValue";
            this.gbxDigitalValue.ResumeLayout(false);
            this.gbxDigitalValue.PerformLayout();
            this.gbxCntValue.ResumeLayout(false);
            this.gbxCntValue.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbxDigitalValue;
        private System.Windows.Forms.ListBox lbDigitalValue;
        private System.Windows.Forms.Label labDigitalValue;
        private System.Windows.Forms.Button btnReadDigiValue;
        private System.Windows.Forms.GroupBox gbxCntValue;
        private System.Windows.Forms.TextBox txtCntClrMsk;
        private System.Windows.Forms.Label labCntClrMsk;
        private System.Windows.Forms.ListBox lbCntVal;
        private System.Windows.Forms.Label labCntVal;
        private System.Windows.Forms.Button btnCntClr;
        private System.Windows.Forms.Button btnReadCntVal;
        private System.Windows.Forms.TextBox txtWriteDOValue;
        private System.Windows.Forms.Label lab0x2;
        private System.Windows.Forms.TextBox txtReadDOValue;
        private System.Windows.Forms.Label labWriteDOValue;
        private System.Windows.Forms.Label lab0x;
        private System.Windows.Forms.Label labReadDOValue;
        private System.Windows.Forms.Button btnWriteDOValue;
        private System.Windows.Forms.Button btnReadDOValue;
    }
}

