Public Class Form1
    Private Shared ReadOnly USBIO_DID = New UShort() {ICPDAS_USBIO.USB2026, ICPDAS_USBIO.USB2051, ICPDAS_USBIO.USB2055, ICPDAS_USBIO.USB2060, ICPDAS_USBIO.USB2051_32, ICPDAS_USBIO.USB2055_32, ICPDAS_USBIO.USB2068_18}
    Private Shared ReadOnly COMM_TIMEOUT As UInteger = 500
    Private m_USBIO As ICPDAS_USBIO
    Private m_byDITotal As Byte
    Private m_byDOTotal As Byte
    Private m_byAITotal As Byte
    Private m_byAOTotal As Byte
    Private m_byPITotal As Byte
    Private m_byPOTotal As Byte
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        m_USBIO = New ICPDAS_USBIO
        cbxDevID.SelectedIndex = 0
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click

        Dim iErrCode As Integer
        m_USBIO.SetCommTimeout(COMM_TIMEOUT)

        iErrCode = m_USBIO.OpenDevice(USBIO_DID(cbxDevID.SelectedIndex), Convert.ToByte(txtBoardID.Text))
        If CInt(ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR) <> iErrCode Then
            MessageBox.Show("Failed to open device. ErrCode:[" & iErrCode.ToString & "]")
        Else
            Dim dwSoftWDTTimeout As UInteger
            Dim wFWVer As UShort
            Dim byDeviceSN As Byte()
            Dim byDeviceNickName As Byte()
            Dim bySupIOMask As Byte
            m_USBIO.GetSoftWDTTimeout(dwSoftWDTTimeout)
            lvInfo.Items.Add("SoftWDT: " & dwSoftWDTTimeout.ToString)
            m_USBIO.GetFwVer(wFWVer)
            lvInfo.Items.Add("FW ver: " & wFWVer.ToString)
            m_USBIO.GetDeviceNickName(byDeviceNickName)
            lvInfo.Items.Add("Description: " & Encoding.ASCII.GetString(byDeviceNickName))
            m_USBIO.GetDeviceSN(byDeviceSN)
            lvInfo.Items.Add("SN: " & Encoding.ASCII.GetString(byDeviceSN))
            m_USBIO.GetSupportIOMask(bySupIOMask)
            lvInfo.Items.Add("Support IO Mask: 0x" & bySupIOMask.ToString("X02"))

            If ICPDAS_USBIO.SUPPORT_DI(bySupIOMask) Then
                m_USBIO.GetDITotal(m_byDITotal)
                lvInfo.Items.Add("DI channels: " & m_byDITotal.ToString)
            End If

            If ICPDAS_USBIO.SUPPORT_DO(bySupIOMask) Then
                m_USBIO.GetDOTotal(m_byDOTotal)
                lvInfo.Items.Add("DO channels: " & m_byDOTotal.ToString)
            End If

            If ICPDAS_USBIO.SUPPORT_AI(bySupIOMask) Then
                m_USBIO.GetAITotal(m_byAITotal)
                lvInfo.Items.Add("AI channels: " & m_byAITotal.ToString)
            End If

            If ICPDAS_USBIO.SUPPORT_AO(bySupIOMask) Then
                m_USBIO.GetAOTotal(m_byAOTotal)
                lvInfo.Items.Add("AO channels: " & m_byAOTotal.ToString)
            End If

            If ICPDAS_USBIO.SUPPORT_PI(bySupIOMask) Then
                m_USBIO.GetPITotal(m_byPITotal)
                lvInfo.Items.Add("PI channels: " & m_byPITotal.ToString)
            End If

            If ICPDAS_USBIO.SUPPORT_PO(bySupIOMask) Then
                m_USBIO.GetPOTotal(m_byPOTotal)
                lvInfo.Items.Add("PO channels: " & m_byPOTotal.ToString)
            End If
            btnReadDigiValue.Enabled = True
          
            txtWriteDOValue.Enabled = True
            btnWriteDOValue.Enabled = True
            btnReadDOValue.Enabled = True
        End If
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Dim iErrCode As Integer
        lvInfo.Items.Clear()
        txtReadDOValue.Text = ""
        txtWriteDOValue.Text = ""
        iErrCode = m_USBIO.CloseDevice
        If CInt(ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR) <> iErrCode Then
            MessageBox.Show("Failed to close device. ErrCode:[" & iErrCode.ToString & "]")
        End If
        btnReadDigiValue.Enabled = False
        txtWriteDOValue.Enabled = False
        btnWriteDOValue.Enabled = False
        btnReadDOValue.Enabled = False

    End Sub

    Private Sub btnReadDigiValue_Click(sender As Object, e As EventArgs) Handles btnReadDigiValue.Click

        Dim iErrCode As Integer
        Dim byDIValue = New Byte((m_byDITotal + 7) / 8 - 1) {}
        lbDigitalValue.Items.Clear()
        iErrCode = m_USBIO.DI_ReadValue(byDIValue)
        If CInt(ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR) <> iErrCode Then
            MessageBox.Show("Failed to read DI value. ErrCode:[" & iErrCode.ToString & "]")
        Else
            Dim iIdx As Integer

            For iIdx = 0 To (m_byDITotal + 7) / 8 - 1
                lbDigitalValue.Items.Add("Ch" & (iIdx * 8).ToString & "~" & ((iIdx + 1) * 8 - 1).ToString & " : 0x" & byDIValue(iIdx).ToString("X"))
            Next
        End If
    End Sub

   

   

    Private Sub btnReadDOValue_Click(sender As Object, e As EventArgs) Handles btnReadDOValue.Click

        Dim iErrCode As Integer
        Dim byDOValue = New Byte((m_byDOTotal + 7) / 8 - 1) {}
        iErrCode = m_USBIO.DO_ReadValue(byDOValue)
        If CInt(ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR) = iErrCode Then
            txtReadDOValue.Text = ""

            For iIdx As Integer = 0 To (m_byDOTotal + 7) / 8 - 1
                txtReadDOValue.Text = byDOValue(iIdx).ToString("X02") & txtReadDOValue.Text
            Next
        Else
            MessageBox.Show("Failed to read DO value. ErrCode:[" & iErrCode.ToString & "]")
        End If
    End Sub

    Private Sub btnWriteDOValue_Click(sender As Object, e As EventArgs) Handles btnWriteDOValue.Click

        Dim iErrCode As Integer
        Dim totalByte As Byte
        Dim byDOBytes = New Byte((m_byDOTotal + 7) / 8 - 1) {}
        Dim u32DO As UInt32
        totalByte = CByte((m_byDOTotal + 7) / 8 - 1)
        u32DO = Convert.ToUInt32(txtWriteDOValue.Text, 16)
        For i As Integer = 0 To totalByte - 1
            byDOBytes(i) = CByte(u32DO >> 8 * i And &HFF)
        Next

       
        iErrCode = m_USBIO.DO_WriteValue(byDOBytes)
        If CInt(ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR) <> iErrCode Then
            MessageBox.Show("Failed to write DO value. ErrCode:[" & iErrCode.ToString & "]")
        Else
            MessageBox.Show("Success.")
        End If
    End Sub

    Private Function Asc2Hex(ByVal i_byAscCode As Byte) As Byte
        If i_byAscCode >= "0" AndAlso i_byAscCode <= "9" Then
            Return CByte(i_byAscCode - "0")
        ElseIf i_byAscCode >= "a" AndAlso i_byAscCode <= "f" Then
            Return CByte(i_byAscCode - "a" + 10)
        ElseIf i_byAscCode >= "A" AndAlso i_byAscCode <= "F" Then
            Return CByte(i_byAscCode - "A" + 10)
        Else
            Return 0
        End If
    End Function
End Class
