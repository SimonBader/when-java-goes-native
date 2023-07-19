namespace DO_WriteValue
{
    partial class FormDO_WriteValue
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtBoardID = new System.Windows.Forms.TextBox();
            this.cbxDevID = new System.Windows.Forms.ComboBox();
            this.labBoardID = new System.Windows.Forms.Label();
            this.labDevID = new System.Windows.Forms.Label();
            this.labReadDOValue = new System.Windows.Forms.Label();
            this.lab0x = new System.Windows.Forms.Label();
            this.txtReadDOValue = new System.Windows.Forms.TextBox();
            this.btnReadDOValue = new System.Windows.Forms.Button();
            this.btnWriteDOValue = new System.Windows.Forms.Button();
            this.labWriteDOValue = new System.Windows.Forms.Label();
            this.lab0x2 = new System.Windows.Forms.Label();
            this.txtWriteDOValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvInfo
            // 
            this.lvInfo.Location = new System.Drawing.Point(12, 95);
            this.lvInfo.Name = "lvInfo";
            this.lvInfo.Size = new System.Drawing.Size(154, 159);
            this.lvInfo.TabIndex = 18;
            this.lvInfo.UseCompatibleStateImageBehavior = false;
            this.lvInfo.View = System.Windows.Forms.View.List;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(92, 66);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 23);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(26, 66);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(60, 23);
            this.btnOpen.TabIndex = 16;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtBoardID
            // 
            this.txtBoardID.Location = new System.Drawing.Point(68, 38);
            this.txtBoardID.Name = "txtBoardID";
            this.txtBoardID.Size = new System.Drawing.Size(98, 22);
            this.txtBoardID.TabIndex = 15;
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
            this.cbxDevID.Location = new System.Drawing.Point(68, 12);
            this.cbxDevID.Name = "cbxDevID";
            this.cbxDevID.Size = new System.Drawing.Size(98, 20);
            this.cbxDevID.TabIndex = 14;
            // 
            // labBoardID
            // 
            this.labBoardID.AutoSize = true;
            this.labBoardID.Location = new System.Drawing.Point(10, 43);
            this.labBoardID.Name = "labBoardID";
            this.labBoardID.Size = new System.Drawing.Size(49, 12);
            this.labBoardID.TabIndex = 12;
            this.labBoardID.Text = "Board ID";
            // 
            // labDevID
            // 
            this.labDevID.AutoSize = true;
            this.labDevID.Location = new System.Drawing.Point(10, 15);
            this.labDevID.Name = "labDevID";
            this.labDevID.Size = new System.Drawing.Size(52, 12);
            this.labDevID.TabIndex = 13;
            this.labDevID.Text = "Device ID";
            // 
            // labReadDOValue
            // 
            this.labReadDOValue.AutoSize = true;
            this.labReadDOValue.Location = new System.Drawing.Point(179, 15);
            this.labReadDOValue.Name = "labReadDOValue";
            this.labReadDOValue.Size = new System.Drawing.Size(51, 12);
            this.labReadDOValue.TabIndex = 19;
            this.labReadDOValue.Text = "DO Value";
            // 
            // lab0x
            // 
            this.lab0x.AutoSize = true;
            this.lab0x.Location = new System.Drawing.Point(236, 15);
            this.lab0x.Name = "lab0x";
            this.lab0x.Size = new System.Drawing.Size(17, 12);
            this.lab0x.TabIndex = 19;
            this.lab0x.Text = "0x";
            // 
            // txtReadDOValue
            // 
            this.txtReadDOValue.Enabled = false;
            this.txtReadDOValue.Location = new System.Drawing.Point(259, 10);
            this.txtReadDOValue.Name = "txtReadDOValue";
            this.txtReadDOValue.Size = new System.Drawing.Size(84, 22);
            this.txtReadDOValue.TabIndex = 20;
            // 
            // btnReadDOValue
            // 
            this.btnReadDOValue.Enabled = false;
            this.btnReadDOValue.Location = new System.Drawing.Point(283, 36);
            this.btnReadDOValue.Name = "btnReadDOValue";
            this.btnReadDOValue.Size = new System.Drawing.Size(60, 23);
            this.btnReadDOValue.TabIndex = 17;
            this.btnReadDOValue.Text = "Read";
            this.btnReadDOValue.UseVisualStyleBackColor = true;
            this.btnReadDOValue.Click += new System.EventHandler(this.btnReadDOValue_Click);
            // 
            // btnWriteDOValue
            // 
            this.btnWriteDOValue.Enabled = false;
            this.btnWriteDOValue.Location = new System.Drawing.Point(283, 91);
            this.btnWriteDOValue.Name = "btnWriteDOValue";
            this.btnWriteDOValue.Size = new System.Drawing.Size(60, 23);
            this.btnWriteDOValue.TabIndex = 17;
            this.btnWriteDOValue.Text = "Write";
            this.btnWriteDOValue.UseVisualStyleBackColor = true;
            this.btnWriteDOValue.Click += new System.EventHandler(this.btnWriteDOValue_Click);
            // 
            // labWriteDOValue
            // 
            this.labWriteDOValue.AutoSize = true;
            this.labWriteDOValue.Location = new System.Drawing.Point(179, 70);
            this.labWriteDOValue.Name = "labWriteDOValue";
            this.labWriteDOValue.Size = new System.Drawing.Size(51, 12);
            this.labWriteDOValue.TabIndex = 19;
            this.labWriteDOValue.Text = "DO Value";
            // 
            // lab0x2
            // 
            this.lab0x2.AutoSize = true;
            this.lab0x2.Location = new System.Drawing.Point(236, 70);
            this.lab0x2.Name = "lab0x2";
            this.lab0x2.Size = new System.Drawing.Size(17, 12);
            this.lab0x2.TabIndex = 19;
            this.lab0x2.Text = "0x";
            // 
            // txtWriteDOValue
            // 
            this.txtWriteDOValue.Enabled = false;
            this.txtWriteDOValue.Location = new System.Drawing.Point(259, 65);
            this.txtWriteDOValue.Name = "txtWriteDOValue";
            this.txtWriteDOValue.Size = new System.Drawing.Size(84, 22);
            this.txtWriteDOValue.TabIndex = 20;
            // 
            // FormDO_WriteValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 264);
            this.Controls.Add(this.txtWriteDOValue);
            this.Controls.Add(this.lab0x2);
            this.Controls.Add(this.txtReadDOValue);
            this.Controls.Add(this.labWriteDOValue);
            this.Controls.Add(this.lab0x);
            this.Controls.Add(this.labReadDOValue);
            this.Controls.Add(this.btnWriteDOValue);
            this.Controls.Add(this.lvInfo);
            this.Controls.Add(this.btnReadDOValue);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtBoardID);
            this.Controls.Add(this.cbxDevID);
            this.Controls.Add(this.labBoardID);
            this.Controls.Add(this.labDevID);
            this.Name = "FormDO_WriteValue";
            this.Text = "FormDO_WriteValue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtBoardID;
        private System.Windows.Forms.ComboBox cbxDevID;
        private System.Windows.Forms.Label labBoardID;
        private System.Windows.Forms.Label labDevID;
        private System.Windows.Forms.Label labReadDOValue;
        private System.Windows.Forms.Label lab0x;
        private System.Windows.Forms.TextBox txtReadDOValue;
        private System.Windows.Forms.Button btnReadDOValue;
        private System.Windows.Forms.Button btnWriteDOValue;
        private System.Windows.Forms.Label labWriteDOValue;
        private System.Windows.Forms.Label lab0x2;
        private System.Windows.Forms.TextBox txtWriteDOValue;
    }
}

