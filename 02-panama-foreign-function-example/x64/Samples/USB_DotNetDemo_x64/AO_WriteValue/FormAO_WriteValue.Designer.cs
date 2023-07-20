namespace AO_WriteValue
{
    partial class FormAO_WriteValue
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtBoardID = new System.Windows.Forms.TextBox();
            this.cbxDevID = new System.Windows.Forms.ComboBox();
            this.labBoardID = new System.Windows.Forms.Label();
            this.labDevID = new System.Windows.Forms.Label();
            this.lvInfo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWriteValueDigital = new System.Windows.Forms.Button();
            this.btnWriteChValueDigital = new System.Windows.Forms.Button();
            this.btnWriteChValueAnalog = new System.Windows.Forms.Button();
            this.btnWriteValueAnalog = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWriteDigitalValue = new System.Windows.Forms.TextBox();
            this.txtWriteDigitalCh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWriteAnalogCh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWriteAnalogValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lvExpValue = new System.Windows.Forms.ListBox();
            this.lvCurValue = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(95, 79);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 29);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(7, 79);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(80, 29);
            this.btnOpen.TabIndex = 9;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtBoardID
            // 
            this.txtBoardID.Location = new System.Drawing.Point(81, 46);
            this.txtBoardID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoardID.Name = "txtBoardID";
            this.txtBoardID.Size = new System.Drawing.Size(94, 25);
            this.txtBoardID.TabIndex = 8;
            this.txtBoardID.Text = "1";
            // 
            // cbxDevID
            // 
            this.cbxDevID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDevID.FormattingEnabled = true;
            this.cbxDevID.Items.AddRange(new object[] {
            "USB-2026"});
            this.cbxDevID.Location = new System.Drawing.Point(81, 13);
            this.cbxDevID.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDevID.Name = "cbxDevID";
            this.cbxDevID.Size = new System.Drawing.Size(94, 23);
            this.cbxDevID.TabIndex = 7;
            // 
            // labBoardID
            // 
            this.labBoardID.AutoSize = true;
            this.labBoardID.Location = new System.Drawing.Point(4, 52);
            this.labBoardID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labBoardID.Name = "labBoardID";
            this.labBoardID.Size = new System.Drawing.Size(60, 15);
            this.labBoardID.TabIndex = 5;
            this.labBoardID.Text = "Board ID";
            // 
            // labDevID
            // 
            this.labDevID.AutoSize = true;
            this.labDevID.Location = new System.Drawing.Point(4, 17);
            this.labDevID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labDevID.Name = "labDevID";
            this.labDevID.Size = new System.Drawing.Size(65, 15);
            this.labDevID.TabIndex = 6;
            this.labDevID.Text = "Device ID";
            // 
            // lvInfo
            // 
            this.lvInfo.FormattingEnabled = true;
            this.lvInfo.ItemHeight = 15;
            this.lvInfo.Location = new System.Drawing.Point(3, 138);
            this.lvInfo.Name = "lvInfo";
            this.lvInfo.Size = new System.Drawing.Size(172, 199);
            this.lvInfo.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Information";
            // 
            // btnWriteValueDigital
            // 
            this.btnWriteValueDigital.Location = new System.Drawing.Point(180, 12);
            this.btnWriteValueDigital.Name = "btnWriteValueDigital";
            this.btnWriteValueDigital.Size = new System.Drawing.Size(183, 25);
            this.btnWriteValueDigital.TabIndex = 13;
            this.btnWriteValueDigital.Text = "Write Value Digital";
            this.btnWriteValueDigital.UseVisualStyleBackColor = true;
            this.btnWriteValueDigital.Click += new System.EventHandler(this.btnWriteValueDigital_Click);
            // 
            // btnWriteChValueDigital
            // 
            this.btnWriteChValueDigital.Location = new System.Drawing.Point(180, 47);
            this.btnWriteChValueDigital.Name = "btnWriteChValueDigital";
            this.btnWriteChValueDigital.Size = new System.Drawing.Size(183, 25);
            this.btnWriteChValueDigital.TabIndex = 14;
            this.btnWriteChValueDigital.Text = "Write Channel Value Digital";
            this.btnWriteChValueDigital.UseVisualStyleBackColor = true;
            this.btnWriteChValueDigital.Click += new System.EventHandler(this.btnWriteChValueDigital_Click);
            // 
            // btnWriteChValueAnalog
            // 
            this.btnWriteChValueAnalog.Location = new System.Drawing.Point(369, 46);
            this.btnWriteChValueAnalog.Name = "btnWriteChValueAnalog";
            this.btnWriteChValueAnalog.Size = new System.Drawing.Size(183, 25);
            this.btnWriteChValueAnalog.TabIndex = 16;
            this.btnWriteChValueAnalog.Text = "Write Channel Value Analog";
            this.btnWriteChValueAnalog.UseVisualStyleBackColor = true;
            this.btnWriteChValueAnalog.Click += new System.EventHandler(this.btnWriteChValueAnalog_Click);
            // 
            // btnWriteValueAnalog
            // 
            this.btnWriteValueAnalog.Location = new System.Drawing.Point(369, 11);
            this.btnWriteValueAnalog.Name = "btnWriteValueAnalog";
            this.btnWriteValueAnalog.Size = new System.Drawing.Size(183, 25);
            this.btnWriteValueAnalog.TabIndex = 15;
            this.btnWriteValueAnalog.Text = "Write Value Analog";
            this.btnWriteValueAnalog.UseVisualStyleBackColor = true;
            this.btnWriteValueAnalog.Click += new System.EventHandler(this.btnWriteValueAnalog_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Value 0x";
            // 
            // txtWriteDigitalValue
            // 
            this.txtWriteDigitalValue.Location = new System.Drawing.Point(248, 83);
            this.txtWriteDigitalValue.MaxLength = 4;
            this.txtWriteDigitalValue.Name = "txtWriteDigitalValue";
            this.txtWriteDigitalValue.Size = new System.Drawing.Size(35, 25);
            this.txtWriteDigitalValue.TabIndex = 18;
            // 
            // txtWriteDigitalCh
            // 
            this.txtWriteDigitalCh.Location = new System.Drawing.Point(321, 83);
            this.txtWriteDigitalCh.MaxLength = 4;
            this.txtWriteDigitalCh.Name = "txtWriteDigitalCh";
            this.txtWriteDigitalCh.Size = new System.Drawing.Size(35, 25);
            this.txtWriteDigitalCh.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "CH";
            // 
            // txtWriteAnalogCh
            // 
            this.txtWriteAnalogCh.Location = new System.Drawing.Point(508, 83);
            this.txtWriteAnalogCh.MaxLength = 4;
            this.txtWriteAnalogCh.Name = "txtWriteAnalogCh";
            this.txtWriteAnalogCh.Size = new System.Drawing.Size(35, 25);
            this.txtWriteAnalogCh.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "CH";
            // 
            // txtWriteAnalogValue
            // 
            this.txtWriteAnalogValue.Location = new System.Drawing.Point(435, 83);
            this.txtWriteAnalogValue.MaxLength = 4;
            this.txtWriteAnalogValue.Name = "txtWriteAnalogValue";
            this.txtWriteAnalogValue.Size = new System.Drawing.Size(35, 25);
            this.txtWriteAnalogValue.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Value";
            // 
            // lvExpValue
            // 
            this.lvExpValue.FormattingEnabled = true;
            this.lvExpValue.ItemHeight = 15;
            this.lvExpValue.Location = new System.Drawing.Point(180, 138);
            this.lvExpValue.Name = "lvExpValue";
            this.lvExpValue.Size = new System.Drawing.Size(183, 199);
            this.lvExpValue.TabIndex = 25;
            // 
            // lvCurValue
            // 
            this.lvCurValue.FormattingEnabled = true;
            this.lvCurValue.ItemHeight = 15;
            this.lvCurValue.Location = new System.Drawing.Point(369, 138);
            this.lvCurValue.Name = "lvCurValue";
            this.lvCurValue.Size = new System.Drawing.Size(183, 199);
            this.lvCurValue.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "Expect Value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(421, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "Current Value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 341);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lvCurValue);
            this.Controls.Add(this.lvExpValue);
            this.Controls.Add(this.txtWriteAnalogCh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtWriteAnalogValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtWriteDigitalCh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWriteDigitalValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnWriteChValueAnalog);
            this.Controls.Add(this.btnWriteValueAnalog);
            this.Controls.Add(this.btnWriteChValueDigital);
            this.Controls.Add(this.btnWriteValueDigital);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtBoardID);
            this.Controls.Add(this.cbxDevID);
            this.Controls.Add(this.labBoardID);
            this.Controls.Add(this.labDevID);
            this.Name = "Form1";
            this.Text = "AO_WriteValue";
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
        private System.Windows.Forms.ListBox lvInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWriteValueDigital;
        private System.Windows.Forms.Button btnWriteChValueDigital;
        private System.Windows.Forms.Button btnWriteChValueAnalog;
        private System.Windows.Forms.Button btnWriteValueAnalog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWriteDigitalValue;
        private System.Windows.Forms.TextBox txtWriteDigitalCh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWriteAnalogCh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWriteAnalogValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lvExpValue;
        private System.Windows.Forms.ListBox lvCurValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

