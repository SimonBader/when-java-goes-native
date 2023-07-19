<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.gbxDigitalValue = New System.Windows.Forms.GroupBox()
        Me.lbDigitalValue = New System.Windows.Forms.ListBox()
        Me.labDigitalValue = New System.Windows.Forms.Label()
        Me.btnReadDigiValue = New System.Windows.Forms.Button()
        Me.lvInfo = New System.Windows.Forms.ListView()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.txtBoardID = New System.Windows.Forms.TextBox()
        Me.cbxDevID = New System.Windows.Forms.ComboBox()
        Me.labBoardID = New System.Windows.Forms.Label()
        Me.labDevID = New System.Windows.Forms.Label()
        Me.gbxCntValue.SuspendLayout()
        Me.gbxDigitalValue.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtWriteDOValue
        '
        Me.txtWriteDOValue.Location = New System.Drawing.Point(86, 81)
        Me.txtWriteDOValue.Name = "txtWriteDOValue"
        Me.txtWriteDOValue.Size = New System.Drawing.Size(84, 22)
        Me.txtWriteDOValue.TabIndex = 44
        Me.txtWriteDOValue.Text = "F"
        '
        'lab0x2
        '
        Me.lab0x2.AutoSize = True
        Me.lab0x2.Location = New System.Drawing.Point(63, 86)
        Me.lab0x2.Name = "lab0x2"
        Me.lab0x2.Size = New System.Drawing.Size(17, 12)
        Me.lab0x2.TabIndex = 40
        Me.lab0x2.Text = "0x"
        '
        'txtReadDOValue
        '
        Me.txtReadDOValue.Enabled = False
        Me.txtReadDOValue.Location = New System.Drawing.Point(86, 26)
        Me.txtReadDOValue.Name = "txtReadDOValue"
        Me.txtReadDOValue.Size = New System.Drawing.Size(84, 22)
        Me.txtReadDOValue.TabIndex = 45
        '
        'labWriteDOValue
        '
        Me.labWriteDOValue.AutoSize = True
        Me.labWriteDOValue.Location = New System.Drawing.Point(6, 86)
        Me.labWriteDOValue.Name = "labWriteDOValue"
        Me.labWriteDOValue.Size = New System.Drawing.Size(51, 12)
        Me.labWriteDOValue.TabIndex = 41
        Me.labWriteDOValue.Text = "DO Value"
        '
        'lab0x
        '
        Me.lab0x.AutoSize = True
        Me.lab0x.Location = New System.Drawing.Point(63, 31)
        Me.lab0x.Name = "lab0x"
        Me.lab0x.Size = New System.Drawing.Size(17, 12)
        Me.lab0x.TabIndex = 42
        Me.lab0x.Text = "0x"
        '
        'labReadDOValue
        '
        Me.labReadDOValue.AutoSize = True
        Me.labReadDOValue.Location = New System.Drawing.Point(6, 31)
        Me.labReadDOValue.Name = "labReadDOValue"
        Me.labReadDOValue.Size = New System.Drawing.Size(51, 12)
        Me.labReadDOValue.TabIndex = 43
        Me.labReadDOValue.Text = "DO Value"
        '
        'btnWriteDOValue
        '
        Me.btnWriteDOValue.Location = New System.Drawing.Point(110, 107)
        Me.btnWriteDOValue.Name = "btnWriteDOValue"
        Me.btnWriteDOValue.Size = New System.Drawing.Size(60, 23)
        Me.btnWriteDOValue.TabIndex = 38
        Me.btnWriteDOValue.Text = "Write"
        Me.btnWriteDOValue.UseVisualStyleBackColor = True
        '
        'btnReadDOValue
        '
        Me.btnReadDOValue.Location = New System.Drawing.Point(110, 52)
        Me.btnReadDOValue.Name = "btnReadDOValue"
        Me.btnReadDOValue.Size = New System.Drawing.Size(60, 23)
        Me.btnReadDOValue.TabIndex = 39
        Me.btnReadDOValue.Text = "Read"
        Me.btnReadDOValue.UseVisualStyleBackColor = True
        '
        'gbxCntValue
        '
        Me.gbxCntValue.Controls.Add(Me.txtWriteDOValue)
        Me.gbxCntValue.Controls.Add(Me.btnWriteDOValue)
        Me.gbxCntValue.Controls.Add(Me.lab0x2)
        Me.gbxCntValue.Controls.Add(Me.btnReadDOValue)
        Me.gbxCntValue.Controls.Add(Me.txtReadDOValue)
        Me.gbxCntValue.Controls.Add(Me.labReadDOValue)
        Me.gbxCntValue.Controls.Add(Me.labWriteDOValue)
        Me.gbxCntValue.Controls.Add(Me.lab0x)
        Me.gbxCntValue.Location = New System.Drawing.Point(324, 10)
        Me.gbxCntValue.Name = "gbxCntValue"
        Me.gbxCntValue.Size = New System.Drawing.Size(195, 267)
        Me.gbxCntValue.TabIndex = 37
        Me.gbxCntValue.TabStop = False
        Me.gbxCntValue.Text = "DO Value"
        '
        'gbxDigitalValue
        '
        Me.gbxDigitalValue.Controls.Add(Me.lbDigitalValue)
        Me.gbxDigitalValue.Controls.Add(Me.labDigitalValue)
        Me.gbxDigitalValue.Controls.Add(Me.btnReadDigiValue)
        Me.gbxDigitalValue.Location = New System.Drawing.Point(190, 10)
        Me.gbxDigitalValue.Name = "gbxDigitalValue"
        Me.gbxDigitalValue.Size = New System.Drawing.Size(128, 279)
        Me.gbxDigitalValue.TabIndex = 36
        Me.gbxDigitalValue.TabStop = False
        Me.gbxDigitalValue.Text = "DI Value"
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
        'labDigitalValue
        '
        Me.labDigitalValue.AutoSize = True
        Me.labDigitalValue.Location = New System.Drawing.Point(9, 92)
        Me.labDigitalValue.Name = "labDigitalValue"
        Me.labDigitalValue.Size = New System.Drawing.Size(66, 12)
        Me.labDigitalValue.TabIndex = 15
        Me.labDigitalValue.Text = "Digital Value"
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
        'lvInfo
        '
        Me.lvInfo.Location = New System.Drawing.Point(30, 95)
        Me.lvInfo.Name = "lvInfo"
        Me.lvInfo.Size = New System.Drawing.Size(154, 182)
        Me.lvInfo.TabIndex = 35
        Me.lvInfo.UseCompatibleStateImageBehavior = False
        Me.lvInfo.View = System.Windows.Forms.View.List
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(110, 66)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(60, 23)
        Me.btnClose.TabIndex = 34
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(44, 66)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(60, 23)
        Me.btnOpen.TabIndex = 33
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'txtBoardID
        '
        Me.txtBoardID.Location = New System.Drawing.Point(86, 38)
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
        Me.cbxDevID.Location = New System.Drawing.Point(86, 12)
        Me.cbxDevID.Name = "cbxDevID"
        Me.cbxDevID.Size = New System.Drawing.Size(98, 20)
        Me.cbxDevID.TabIndex = 31
        '
        'labBoardID
        '
        Me.labBoardID.AutoSize = True
        Me.labBoardID.Location = New System.Drawing.Point(28, 43)
        Me.labBoardID.Name = "labBoardID"
        Me.labBoardID.Size = New System.Drawing.Size(49, 12)
        Me.labBoardID.TabIndex = 29
        Me.labBoardID.Text = "Board ID"
        '
        'labDevID
        '
        Me.labDevID.AutoSize = True
        Me.labDevID.Location = New System.Drawing.Point(28, 15)
        Me.labDevID.Name = "labDevID"
        Me.labDevID.Size = New System.Drawing.Size(52, 12)
        Me.labDevID.TabIndex = 30
        Me.labDevID.Text = "Device ID"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 425)
        Me.Controls.Add(Me.gbxCntValue)
        Me.Controls.Add(Me.gbxDigitalValue)
        Me.Controls.Add(Me.lvInfo)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.txtBoardID)
        Me.Controls.Add(Me.cbxDevID)
        Me.Controls.Add(Me.labBoardID)
        Me.Controls.Add(Me.labDevID)
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
    Private WithEvents gbxDigitalValue As System.Windows.Forms.GroupBox
    Private WithEvents lbDigitalValue As System.Windows.Forms.ListBox
    Private WithEvents labDigitalValue As System.Windows.Forms.Label
    Private WithEvents btnReadDigiValue As System.Windows.Forms.Button
    Private WithEvents lvInfo As System.Windows.Forms.ListView
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private WithEvents btnOpen As System.Windows.Forms.Button
    Private WithEvents txtBoardID As System.Windows.Forms.TextBox
    Private WithEvents cbxDevID As System.Windows.Forms.ComboBox
    Private WithEvents labBoardID As System.Windows.Forms.Label
    Private WithEvents labDevID As System.Windows.Forms.Label

End Class
