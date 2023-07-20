<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDI_ReadValue
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtWriteDOValue = New System.Windows.Forms.TextBox()
        Me.lab0x2 = New System.Windows.Forms.Label()
        Me.txtReadDOValue = New System.Windows.Forms.TextBox()
        Me.labWriteDOValue = New System.Windows.Forms.Label()
        Me.lab0x = New System.Windows.Forms.Label()
        Me.labReadDOValue = New System.Windows.Forms.Label()
        Me.btnWriteDOValue = New System.Windows.Forms.Button()
        Me.btnReadDOValue = New System.Windows.Forms.Button()
        Me.gbxCntValue = New System.Windows.Forms.GroupBox()
        Me.txtCntClrMsk = New System.Windows.Forms.TextBox()
        Me.labCntClrMsk = New System.Windows.Forms.Label()
        Me.lbCntVal = New System.Windows.Forms.ListBox()
        Me.labCntVal = New System.Windows.Forms.Label()
        Me.btnCntClr = New System.Windows.Forms.Button()
        Me.btnReadCntVal = New System.Windows.Forms.Button()
        Me.btnReadDigiValue = New System.Windows.Forms.Button()
        Me.lbDigitalValue = New System.Windows.Forms.ListBox()
        Me.gbxDigitalValue = New System.Windows.Forms.GroupBox()
        Me.labDigitalValue = New System.Windows.Forms.Label()
        Me.lvInfo = New System.Windows.Forms.ListView()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.txtBoardID = New System.Windows.Forms.TextBox()
        Me.cbxDevID = New System.Windows.Forms.ComboBox()
        Me.labBoardID = New System.Windows.Forms.Label()
        Me.labDevID = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.gbxCntValue.SuspendLayout()
        Me.gbxDigitalValue.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtWriteDOValue
        '
        Me.txtWriteDOValue.Location = New System.Drawing.Point(572, 77)
        Me.txtWriteDOValue.Name = "txtWriteDOValue"
        Me.txtWriteDOValue.Size = New System.Drawing.Size(84, 22)
        Me.txtWriteDOValue.TabIndex = 44
        Me.txtWriteDOValue.Text = "F"
        '
        'lab0x2
        '
        Me.lab0x2.AutoSize = True
        Me.lab0x2.Location = New System.Drawing.Point(549, 82)
        Me.lab0x2.Name = "lab0x2"
        Me.lab0x2.Size = New System.Drawing.Size(17, 12)
        Me.lab0x2.TabIndex = 40
        Me.lab0x2.Text = "0x"
        '
        'txtReadDOValue
        '
        Me.txtReadDOValue.Enabled = False
        Me.txtReadDOValue.Location = New System.Drawing.Point(572, 22)
        Me.txtReadDOValue.Name = "txtReadDOValue"
        Me.txtReadDOValue.Size = New System.Drawing.Size(84, 22)
        Me.txtReadDOValue.TabIndex = 45
        '
        'labWriteDOValue
        '
        Me.labWriteDOValue.AutoSize = True
        Me.labWriteDOValue.Location = New System.Drawing.Point(492, 82)
        Me.labWriteDOValue.Name = "labWriteDOValue"
        Me.labWriteDOValue.Size = New System.Drawing.Size(51, 12)
        Me.labWriteDOValue.TabIndex = 41
        Me.labWriteDOValue.Text = "DO Value"
        '
        'lab0x
        '
        Me.lab0x.AutoSize = True
        Me.lab0x.Location = New System.Drawing.Point(549, 27)
        Me.lab0x.Name = "lab0x"
        Me.lab0x.Size = New System.Drawing.Size(17, 12)
        Me.lab0x.TabIndex = 42
        Me.lab0x.Text = "0x"
        '
        'labReadDOValue
        '
        Me.labReadDOValue.AutoSize = True
        Me.labReadDOValue.Location = New System.Drawing.Point(492, 27)
        Me.labReadDOValue.Name = "labReadDOValue"
        Me.labReadDOValue.Size = New System.Drawing.Size(51, 12)
        Me.labReadDOValue.TabIndex = 43
        Me.labReadDOValue.Text = "DO Value"
        '
        'btnWriteDOValue
        '
        Me.btnWriteDOValue.Location = New System.Drawing.Point(596, 103)
        Me.btnWriteDOValue.Name = "btnWriteDOValue"
        Me.btnWriteDOValue.Size = New System.Drawing.Size(60, 23)
        Me.btnWriteDOValue.TabIndex = 38
        Me.btnWriteDOValue.Text = "Write"
        Me.btnWriteDOValue.UseVisualStyleBackColor = True
        '
        'btnReadDOValue
        '
        Me.btnReadDOValue.Location = New System.Drawing.Point(596, 48)
        Me.btnReadDOValue.Name = "btnReadDOValue"
        Me.btnReadDOValue.Size = New System.Drawing.Size(60, 23)
        Me.btnReadDOValue.TabIndex = 39
        Me.btnReadDOValue.Text = "Read"
        Me.btnReadDOValue.UseVisualStyleBackColor = True
        '
        'gbxCntValue
        '
        Me.gbxCntValue.Controls.Add(Me.txtCntClrMsk)
        Me.gbxCntValue.Controls.Add(Me.labCntClrMsk)
        Me.gbxCntValue.Controls.Add(Me.lbCntVal)
        Me.gbxCntValue.Controls.Add(Me.labCntVal)
        Me.gbxCntValue.Controls.Add(Me.btnCntClr)
        Me.gbxCntValue.Controls.Add(Me.btnReadCntVal)
        Me.gbxCntValue.Location = New System.Drawing.Point(308, 4)
        Me.gbxCntValue.Name = "gbxCntValue"
        Me.gbxCntValue.Size = New System.Drawing.Size(130, 279)
        Me.gbxCntValue.TabIndex = 37
        Me.gbxCntValue.TabStop = False
        Me.gbxCntValue.Text = "Counter Value"
        '
        'txtCntClrMsk
        '
        Me.txtCntClrMsk.Location = New System.Drawing.Point(57, 47)
        Me.txtCntClrMsk.Name = "txtCntClrMsk"
        Me.txtCntClrMsk.Size = New System.Drawing.Size(64, 22)
        Me.txtCntClrMsk.TabIndex = 21
        '
        'labCntClrMsk
        '
        Me.labCntClrMsk.AutoSize = True
        Me.labCntClrMsk.Location = New System.Drawing.Point(9, 50)
        Me.labCntClrMsk.Name = "labCntClrMsk"
        Me.labCntClrMsk.Size = New System.Drawing.Size(45, 12)
        Me.labCntClrMsk.TabIndex = 20
        Me.labCntClrMsk.Text = "Mask 0x"
        '
        'lbCntVal
        '
        Me.lbCntVal.FormattingEnabled = True
        Me.lbCntVal.ItemHeight = 12
        Me.lbCntVal.Location = New System.Drawing.Point(13, 126)
        Me.lbCntVal.Name = "lbCntVal"
        Me.lbCntVal.Size = New System.Drawing.Size(106, 136)
        Me.lbCntVal.TabIndex = 19
        '
        'labCntVal
        '
        Me.labCntVal.AutoSize = True
        Me.labCntVal.Location = New System.Drawing.Point(11, 106)
        Me.labCntVal.Name = "labCntVal"
        Me.labCntVal.Size = New System.Drawing.Size(73, 12)
        Me.labCntVal.TabIndex = 18
        Me.labCntVal.Text = "Counter Value"
        '
        'btnCntClr
        '
        Me.btnCntClr.Enabled = False
        Me.btnCntClr.Location = New System.Drawing.Point(50, 73)
        Me.btnCntClr.Name = "btnCntClr"
        Me.btnCntClr.Size = New System.Drawing.Size(71, 23)
        Me.btnCntClr.TabIndex = 16
        Me.btnCntClr.Text = "Clear"
        Me.btnCntClr.UseVisualStyleBackColor = True
        '
        'btnReadCntVal
        '
        Me.btnReadCntVal.Enabled = False
        Me.btnReadCntVal.Location = New System.Drawing.Point(11, 17)
        Me.btnReadCntVal.Name = "btnReadCntVal"
        Me.btnReadCntVal.Size = New System.Drawing.Size(110, 23)
        Me.btnReadCntVal.TabIndex = 17
        Me.btnReadCntVal.Text = "Read Counter Value"
        Me.btnReadCntVal.UseVisualStyleBackColor = True
        '
        'btnReadDigiValue
        '
        Me.btnReadDigiValue.Enabled = False
        Me.btnReadDigiValue.Location = New System.Drawing.Point(9, 22)
        Me.btnReadDigiValue.Name = "btnReadDigiValue"
        Me.btnReadDigiValue.Size = New System.Drawing.Size(110, 23)
        Me.btnReadDigiValue.TabIndex = 14
        Me.btnReadDigiValue.Text = "Read Digital Value"
        Me.btnReadDigiValue.UseVisualStyleBackColor = True
        '
        'lbDigitalValue
        '
        Me.lbDigitalValue.FormattingEnabled = True
        Me.lbDigitalValue.ItemHeight = 12
        Me.lbDigitalValue.Location = New System.Drawing.Point(11, 107)
        Me.lbDigitalValue.Name = "lbDigitalValue"
        Me.lbDigitalValue.Size = New System.Drawing.Size(106, 160)
        Me.lbDigitalValue.TabIndex = 16
        '
        'gbxDigitalValue
        '
        Me.gbxDigitalValue.Controls.Add(Me.lbDigitalValue)
        Me.gbxDigitalValue.Controls.Add(Me.labDigitalValue)
        Me.gbxDigitalValue.Controls.Add(Me.btnReadDigiValue)
        Me.gbxDigitalValue.Location = New System.Drawing.Point(174, 4)
        Me.gbxDigitalValue.Name = "gbxDigitalValue"
        Me.gbxDigitalValue.Size = New System.Drawing.Size(128, 279)
        Me.gbxDigitalValue.TabIndex = 36
        Me.gbxDigitalValue.TabStop = False
        Me.gbxDigitalValue.Text = "Digital Value"
        '
        'labDigitalValue
        '
        Me.labDigitalValue.AutoSize = True
        Me.labDigitalValue.Location = New System.Drawing.Point(9, 92)
        Me.labDigitalValue.Name = "labDigitalValue"
        Me.labDigitalValue.Size = New System.Drawing.Size(66, 12)
        Me.labDigitalValue.TabIndex = 15
        Me.labDigitalValue.Text = "Digital Value"
        '
        'lvInfo
        '
        Me.lvInfo.Location = New System.Drawing.Point(14, 89)
        Me.lvInfo.Name = "lvInfo"
        Me.lvInfo.Size = New System.Drawing.Size(154, 182)
        Me.lvInfo.TabIndex = 35
        Me.lvInfo.UseCompatibleStateImageBehavior = False
        Me.lvInfo.View = System.Windows.Forms.View.List
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(28, 60)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(60, 23)
        Me.btnOpen.TabIndex = 33
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'txtBoardID
        '
        Me.txtBoardID.Location = New System.Drawing.Point(70, 32)
        Me.txtBoardID.Name = "txtBoardID"
        Me.txtBoardID.Size = New System.Drawing.Size(98, 22)
        Me.txtBoardID.TabIndex = 32
        Me.txtBoardID.Text = "1"
        '
        'cbxDevID
        '
        Me.cbxDevID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDevID.FormattingEnabled = True
        Me.cbxDevID.Items.AddRange(New Object() {"USB-2026", "USB-2051", "USB-2055", "USB-2060", "USB-2051-32", "USB-2055-32", "USB-2068-18"})
        Me.cbxDevID.Location = New System.Drawing.Point(70, 6)
        Me.cbxDevID.Name = "cbxDevID"
        Me.cbxDevID.Size = New System.Drawing.Size(98, 20)
        Me.cbxDevID.TabIndex = 31
        '
        'labBoardID
        '
        Me.labBoardID.AutoSize = True
        Me.labBoardID.Location = New System.Drawing.Point(12, 37)
        Me.labBoardID.Name = "labBoardID"
        Me.labBoardID.Size = New System.Drawing.Size(49, 12)
        Me.labBoardID.TabIndex = 29
        Me.labBoardID.Text = "Board ID"
        '
        'labDevID
        '
        Me.labDevID.AutoSize = True
        Me.labDevID.Location = New System.Drawing.Point(12, 9)
        Me.labDevID.Name = "labDevID"
        Me.labDevID.Size = New System.Drawing.Size(52, 12)
        Me.labDevID.TabIndex = 30
        Me.labDevID.Text = "Device ID"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(94, 60)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(60, 23)
        Me.btnClose.TabIndex = 34
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 302)
        Me.Controls.Add(Me.txtWriteDOValue)
        Me.Controls.Add(Me.lab0x2)
        Me.Controls.Add(Me.txtReadDOValue)
        Me.Controls.Add(Me.labWriteDOValue)
        Me.Controls.Add(Me.lab0x)
        Me.Controls.Add(Me.labReadDOValue)
        Me.Controls.Add(Me.btnWriteDOValue)
        Me.Controls.Add(Me.btnReadDOValue)
        Me.Controls.Add(Me.gbxCntValue)
        Me.Controls.Add(Me.gbxDigitalValue)
        Me.Controls.Add(Me.lvInfo)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.txtBoardID)
        Me.Controls.Add(Me.cbxDevID)
        Me.Controls.Add(Me.labBoardID)
        Me.Controls.Add(Me.labDevID)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbxCntValue.ResumeLayout(False)
        Me.gbxCntValue.PerformLayout()
        Me.gbxDigitalValue.ResumeLayout(False)
        Me.gbxDigitalValue.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents txtWriteDOValue As System.Windows.Forms.TextBox
    Private WithEvents lab0x2 As System.Windows.Forms.Label
    Private WithEvents txtReadDOValue As System.Windows.Forms.TextBox
    Private WithEvents labWriteDOValue As System.Windows.Forms.Label
    Private WithEvents lab0x As System.Windows.Forms.Label
    Private WithEvents labReadDOValue As System.Windows.Forms.Label
    Private WithEvents btnWriteDOValue As System.Windows.Forms.Button
    Private WithEvents btnReadDOValue As System.Windows.Forms.Button
    Private WithEvents gbxCntValue As System.Windows.Forms.GroupBox
    Private WithEvents txtCntClrMsk As System.Windows.Forms.TextBox
    Private WithEvents labCntClrMsk As System.Windows.Forms.Label
    Private WithEvents lbCntVal As System.Windows.Forms.ListBox
    Private WithEvents labCntVal As System.Windows.Forms.Label
    Private WithEvents btnCntClr As System.Windows.Forms.Button
    Private WithEvents btnReadCntVal As System.Windows.Forms.Button
    Private WithEvents btnReadDigiValue As System.Windows.Forms.Button
    Private WithEvents lbDigitalValue As System.Windows.Forms.ListBox
    Private WithEvents gbxDigitalValue As System.Windows.Forms.GroupBox
    Private WithEvents labDigitalValue As System.Windows.Forms.Label
    Private WithEvents lvInfo As System.Windows.Forms.ListView
    Private WithEvents btnOpen As System.Windows.Forms.Button
    Private WithEvents txtBoardID As System.Windows.Forms.TextBox
    Private WithEvents cbxDevID As System.Windows.Forms.ComboBox
    Private WithEvents labBoardID As System.Windows.Forms.Label
    Private WithEvents labDevID As System.Windows.Forms.Label
    Private WithEvents btnClose As System.Windows.Forms.Button

End Class
