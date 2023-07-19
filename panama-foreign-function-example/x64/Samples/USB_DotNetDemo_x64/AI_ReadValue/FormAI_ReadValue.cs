using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ICPDAS;

namespace AI_ReadValue
{
    public partial class FormAI_ReadValue : Form
    {
        static readonly ushort[] USBIO_DID = new ushort[] { ICPDAS_USBIO.USB2019, ICPDAS_USBIO.USB2026 };
        static readonly UInt32 COMM_TIMEOUT = 500;

        private ICPDAS_USBIO m_USBIO;
        private byte m_byDITotal;
        private byte m_byDOTotal;
        private byte m_byAITotal;
        private byte m_byAOTotal;
        private byte m_byPITotal;
        private byte m_byPOTotal;

        public FormAI_ReadValue()
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
                btnReadDigitalValueWithChStatus.Enabled = true;
                btnReadAnalogValue.Enabled = true;
                btnReadAnalogValueWithChStatus.Enabled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            int iErrCode;

            lvInfo.Items.Clear();

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.CloseDevice()))
                MessageBox.Show("Failed to close device. ErrCode:[" + iErrCode.ToString() + "]");

            lbDigitalValue.Items.Clear();
            lbAnalogValue.Items.Clear();
            lbChannelStatus.Items.Clear();

            btnReadDigiValue.Enabled = true;
            btnReadDigitalValueWithChStatus.Enabled = true;
            btnReadAnalogValue.Enabled = true;
            btnReadAnalogValueWithChStatus.Enabled = true;
        }

        private void btnReadDigiValue_Click(object sender, EventArgs e)
        {
            int iErrCode;
            UInt32[] dwAIValue = new UInt32[m_byAITotal];

            lbDigitalValue.Items.Clear();
            lbAnalogValue.Items.Clear();
            lbChannelStatus.Items.Clear();

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AI_ReadValue(dwAIValue)))
                MessageBox.Show("Failed to read AI value. ErrCode:[" + iErrCode.ToString() + "]");
            else
            {
                int iIdx;

                for (iIdx = 0; iIdx < m_byAITotal; iIdx++)
                {
                    lbDigitalValue.Items.Add("Ch" + iIdx.ToString() + " : 0x" + dwAIValue[iIdx].ToString("X"));
                }
            }
        }

        private void btnReadDigitalValueWithChStatus_Click(object sender, EventArgs e)
        {
            int iErrCode;
            UInt32[] dwAIValue = new UInt32[m_byAITotal];
            byte[] byAIChStatus = new byte[m_byAITotal];

            lbDigitalValue.Items.Clear();
            lbAnalogValue.Items.Clear();
            lbChannelStatus.Items.Clear();

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AI_ReadValue(dwAIValue, byAIChStatus)))
                MessageBox.Show("Failed to read AI value. ErrCode:[" + iErrCode.ToString() + "]");
            else
            {
                int iIdx;

                for (iIdx = 0; iIdx < m_byAITotal; iIdx++)
                {
                    lbDigitalValue.Items.Add("Ch" + iIdx.ToString() + " : 0x" + dwAIValue[iIdx].ToString("X"));
                    lbChannelStatus.Items.Add("Ch" + iIdx.ToString() + " : 0x" + byAIChStatus[iIdx].ToString("X"));
                }
            }
        }

        private void btnReadAnalogValue_Click(object sender, EventArgs e)
        {
            int iErrCode;
            float[] fAIValue = new float[m_byAITotal];

            lbDigitalValue.Items.Clear();
            lbAnalogValue.Items.Clear();
            lbChannelStatus.Items.Clear();

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AI_ReadValue(fAIValue)))
                MessageBox.Show("Failed to read AI value. ErrCode:[" + iErrCode.ToString() + "]");
            else
            {
                int iIdx;

                for (iIdx = 0; iIdx < m_byAITotal; iIdx++)
                {
                    lbAnalogValue.Items.Add("Ch" + iIdx.ToString() + " : " + fAIValue[iIdx].ToString("0.000000"));
                }
            }
        }

        private void btnReadAnalogValueWithChStatus_Click(object sender, EventArgs e)
        {
            int iErrCode;
            float[] fAIValue = new float[m_byAITotal];
            byte[] byAIChStatus = new byte[m_byAITotal];

            lbDigitalValue.Items.Clear();
            lbAnalogValue.Items.Clear();
            lbChannelStatus.Items.Clear();

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AI_ReadValue(fAIValue, byAIChStatus)))
                MessageBox.Show("Failed to read AI value. ErrCode:[" + iErrCode.ToString() + "]");
            else
            {
                int iIdx;

                for (iIdx = 0; iIdx < m_byAITotal; iIdx++)
                {
                    lbAnalogValue.Items.Add("Ch" + iIdx.ToString() + " : " + fAIValue[iIdx].ToString("0.000000"));
                    lbChannelStatus.Items.Add("Ch" + iIdx.ToString() + " : 0x" + byAIChStatus[iIdx].ToString("X"));
                }
            }
        }
    }
}