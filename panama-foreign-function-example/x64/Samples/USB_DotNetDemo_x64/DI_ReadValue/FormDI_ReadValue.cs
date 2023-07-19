using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ICPDAS;

namespace DI_ReadValue
{
    public partial class FormDI_ReadValue : Form
    {
        static readonly ushort[] USBIO_DID = new ushort[] { ICPDAS_USBIO.USB2026, ICPDAS_USBIO.USB2051, ICPDAS_USBIO.USB2055, ICPDAS_USBIO.USB2060, ICPDAS_USBIO.USB2051_32, ICPDAS_USBIO.USB2055_32, ICPDAS_USBIO.USB2068_18 };
        static readonly UInt32 COMM_TIMEOUT = 500;

        private ICPDAS_USBIO m_USBIO;
        private byte m_byDITotal;
        private byte m_byDOTotal;
        private byte m_byAITotal;
        private byte m_byAOTotal;
        private byte m_byPITotal;
        private byte m_byPOTotal;

        public FormDI_ReadValue()
        {
            InitializeComponent();

            cbxDevID.SelectedIndex = 0;

            m_USBIO = new ICPDAS_USBIO();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            int iErrCode;

            m_USBIO.SetCommTimeout(COMM_TIMEOUT);

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.OpenDevice(USBIO_DID[cbxDevID.SelectedIndex], Convert.ToByte(txtBoardID.Text))))
                MessageBox.Show("Failed to open device. ErrCode:[" + iErrCode.ToString() + "]");
            else
            {
                UInt32 dwSoftWDTTimeout;
                UInt16 wFWVer;
                byte[] byDeviceSN;
                byte[] byDeviceNickName;
                byte bySupIOMask;

                m_USBIO.GetSoftWDTTimeout(out dwSoftWDTTimeout);
                lvInfo.Items.Add("SoftWDT: " + dwSoftWDTTimeout.ToString());

                m_USBIO.GetFwVer(out wFWVer);
                lvInfo.Items.Add("FW ver: " + wFWVer.ToString());

                m_USBIO.GetDeviceNickName(out byDeviceNickName);
                lvInfo.Items.Add("Description: " + Encoding.ASCII.GetString(byDeviceNickName));

                m_USBIO.GetDeviceSN(out byDeviceSN);
                lvInfo.Items.Add("SN: " + Encoding.ASCII.GetString(byDeviceSN));

                m_USBIO.GetSupportIOMask(out bySupIOMask);
                lvInfo.Items.Add("Support IO Mask: 0x" + bySupIOMask.ToString("X02"));

                if (ICPDAS_USBIO.SUPPORT_DI(bySupIOMask))
                {
                    m_USBIO.GetDITotal(out m_byDITotal);
                    lvInfo.Items.Add("DI channels: " + m_byDITotal.ToString());
                }

                if (ICPDAS_USBIO.SUPPORT_DO(bySupIOMask))
                {
                    m_USBIO.GetDOTotal(out m_byDOTotal);
                    lvInfo.Items.Add("DO channels: " + m_byDOTotal.ToString());
                }

                if (ICPDAS_USBIO.SUPPORT_AI(bySupIOMask))
                {
                    m_USBIO.GetAITotal(out m_byAITotal);
                    lvInfo.Items.Add("AI channels: " + m_byAITotal.ToString());
                }

                if (ICPDAS_USBIO.SUPPORT_AO(bySupIOMask))
                {
                    m_USBIO.GetAOTotal(out m_byAOTotal);
                    lvInfo.Items.Add("AO channels: " + m_byAOTotal.ToString());
                }

                if (ICPDAS_USBIO.SUPPORT_PI(bySupIOMask))
                {
                    m_USBIO.GetPITotal(out m_byPITotal);
                    lvInfo.Items.Add("PI channels: " + m_byPITotal.ToString());
                }

                if (ICPDAS_USBIO.SUPPORT_PO(bySupIOMask))
                {
                    m_USBIO.GetPOTotal(out m_byPOTotal);
                    lvInfo.Items.Add("PO channels: " + m_byPOTotal.ToString());
                }

                btnReadDigiValue.Enabled = true;
                btnReadCntVal.Enabled = true;
                btnCntClr.Enabled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            int iErrCode;

            lvInfo.Items.Clear();

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.CloseDevice()))
                MessageBox.Show("Failed to close device. ErrCode:[" + iErrCode.ToString() + "]");

            lbDigitalValue.Items.Clear();
            lbCntVal.Items.Clear();

            btnReadDigiValue.Enabled = false;
            btnReadCntVal.Enabled = false;
            btnCntClr.Enabled = false;
        }

        private void btnReadDigiValue_Click_1(object sender, EventArgs e)
        {
            int iErrCode;
            byte[] byDIValue = new byte[(m_byDITotal + 7) / 8];

            lbDigitalValue.Items.Clear();

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.DI_ReadValue(byDIValue)))
                MessageBox.Show("Failed to read DI value. ErrCode:[" + iErrCode.ToString() + "]");
            else
            {
                int iIdx;

                for (iIdx = 0; iIdx < ((m_byDITotal + 7) / 8); iIdx++)
                {
                    lbDigitalValue.Items.Add("Ch" + (iIdx * 8).ToString() + "~" + ((iIdx + 1) * 8 - 1).ToString() + " : 0x" + byDIValue[iIdx].ToString("X"));
                }
            }
        }

        private void btnReadCntVal_Click(object sender, EventArgs e)
        {
            int iErrCode;
            UInt32[] dwDIValue = new UInt32[m_byDITotal];

            lbCntVal.Items.Clear();

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.DI_ReadCounterValue(dwDIValue)))
                MessageBox.Show("Failed to read DI counter value. ErrCode:[" + iErrCode.ToString() + "]");
            else
            {
                int iIdx;

                for (iIdx = 0; iIdx < m_byDITotal; iIdx++)
                {
                    lbCntVal.Items.Add("Ch" + iIdx.ToString() + " :" + dwDIValue[iIdx].ToString());
                }
            }
        }

        private void btnCntClr_Click(object sender, EventArgs e)
        {
            int iErrCode;
            UInt32 uiCntClr;

            if (txtCntClrMsk.Text.Length > (((m_byDITotal + 7) / 8) * 2))
            {
                MessageBox.Show("Channel mask invalid. (Channel mask value over channel number)");
                return;
            }

            uiCntClr = Convert.ToUInt32(txtCntClrMsk.Text, 16);

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.DI_WriteClearCounter(uiCntClr)))
                MessageBox.Show("Failed to set AI channel mask. ErrCode:[" + iErrCode.ToString() + "]");
            else
                MessageBox.Show("Success.");
        }

        private void btnReadDOValue_Click(object sender, EventArgs e)
        {
            int iErrCode;
            byte[] byDOValue = new byte[(m_byDOTotal + 7) / 8];

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR == (iErrCode = m_USBIO.DO_ReadValue(byDOValue)))
            {
                txtReadDOValue.Text = "";

                for (int iIdx = 0; iIdx < ((m_byDOTotal + 7) / 8); iIdx++)
                    txtReadDOValue.Text = byDOValue[iIdx].ToString("X02") + txtReadDOValue.Text;
            }
            else
                MessageBox.Show("Failed to read DO value. ErrCode:[" + iErrCode.ToString() + "]");
        }

        private void btnWriteDOValue_Click(object sender, EventArgs e)
        {
            int iErrCode;
            byte[] byDOValueStringArray;
            byte[] byDOValue = new byte[(m_byDOTotal + 7) / 8];

            byDOValueStringArray = ASCIIEncoding.ASCII.GetBytes(txtWriteDOValue.Text);
            if (byDOValueStringArray.Length > (((m_byDOTotal + 7) / 8) * 2))
            {
                MessageBox.Show("DO output invalid. (Do output over channel number)");
                return;
            }
            Array.Clear(byDOValue, 0, byDOValue.Length);
            for (int iIdx = 0; iIdx < byDOValueStringArray.Length; iIdx++)
                byDOValue[(byDOValueStringArray.Length - 1 - iIdx) / 2] += Convert.ToByte(Asc2Hex(byDOValueStringArray[iIdx]) * (Math.Pow(16, (byDOValueStringArray.Length - 1 - iIdx) % 2)));

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.DO_WriteValue(byDOValue)))
                MessageBox.Show("Failed to write DO value. ErrCode:[" + iErrCode.ToString() + "]");
            else
                MessageBox.Show("Success.");
        }

        private byte Asc2Hex(byte i_byAscCode)
        {
            if (i_byAscCode >= '0' && i_byAscCode <= '9')
                return (byte)(i_byAscCode - '0');
            else if (i_byAscCode >= 'a' && i_byAscCode <= 'f')
                return (byte)(i_byAscCode - 'a' + 10);
            else if (i_byAscCode >= 'A' && i_byAscCode <= 'F')
                return (byte)(i_byAscCode - 'A' + 10);
            else
                return 0;
        }
    }
}