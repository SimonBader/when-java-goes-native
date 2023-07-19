using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ICPDAS;

namespace DI_API_Test
{
    public partial class FormDI_API_Test : Form
    {
        static readonly ushort[] USBIO_DID = new ushort[] {ICPDAS_USBIO.USB2026, ICPDAS_USBIO.USB2051, ICPDAS_USBIO.USB2055, ICPDAS_USBIO.USB2060, ICPDAS_USBIO.USB2051_32, ICPDAS_USBIO.USB2055_32, ICPDAS_USBIO.USB2068_18 };
        static readonly UInt32 COMM_TIMEOUT = 500;

        private ICPDAS_USBIO m_USBIO;
        private byte m_byDITotal;
        private byte m_byDOTotal;
        private byte m_byAITotal;
        private byte m_byAOTotal;
        private byte m_byPITotal;
        private byte m_byPOTotal;

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

        public FormDI_API_Test()
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
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            int iErrCode;

            lvInfo.Items.Clear();

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.CloseDevice()))
                MessageBox.Show("Failed to close device. ErrCode:[" + iErrCode.ToString() + "]");
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            int iErrCode;

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.LoadDefault()))
                MessageBox.Show("Failed to load default to device. ErrCode:[" + iErrCode.ToString() + "]");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            int iErrCode;

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.RefreshDeviceInfo()))
                MessageBox.Show("Failed to refresh device information. ErrCode:[" + iErrCode.ToString() + "]");
        }

        private void btnSetNickname_Click(object sender, EventArgs e)
        {
            int iErrCode;
            byte[] byNickname;

            byNickname = Encoding.ASCII.GetBytes(txtNickName.Text);

            if (byNickname.Length > ICPDAS_USBIO.MAX_DESCRIPTION_LENGTH)
            {
                byte[] byTmp = new byte[byNickname.Length];
                Array.Copy(byNickname, byTmp, byNickname.Length);

                byNickname = new byte[ICPDAS_USBIO.MAX_DESCRIPTION_LENGTH];

                for (int iIdx = 0; iIdx < byNickname.Length; iIdx++)
                    byNickname[iIdx] = byTmp[iIdx];
            }

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.SetDeviceNickName(byNickname)))
                MessageBox.Show("Failed to set nickname to device. ErrCode:[" + iErrCode.ToString() + "]");
        }

        private void btnSetWDT_Click(object sender, EventArgs e)
        {
            int iErrCode;

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.SetSoftWDTTimeout(Convert.ToUInt32(numWDTValue.Value))))
                MessageBox.Show("Failed to set software WDT timeout to device. ErrCode:[" + iErrCode.ToString() + "]");
        }

        private void btnSetBoardID_Click(object sender, EventArgs e)
        {
            int iErrCode;

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.SetUserDefinedBoardID(Convert.ToByte(numBoardIDSetting.Value))))
                MessageBox.Show("Failed to set user defined board ID to device. ErrCode:[" + iErrCode.ToString() + "]");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            m_USBIO.CloseDevice();

            this.Close();
        }

        private void btnGetDigitalFilterWidth_Click(object sender, EventArgs e)
        {
            int iErrCode;
            ushort usFilterWidth;

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.DI_GetDigitalFilterWidth(out usFilterWidth)))
                MessageBox.Show("Failed to get digital filter width. ErrCode:[" + iErrCode.ToString() + "]");
            else
                MessageBox.Show("Module current digital filter width:" + usFilterWidth.ToString() + " * 100 us");
        }

        private void btnGetDIValueInverse_Click(object sender, EventArgs e)
        {
            int iErrCode;
            uint uiValueInverse;

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.DI_GetDigitalValueInverse(out uiValueInverse)))
                MessageBox.Show("Failed to get DI value inverse. ErrCode:[" + iErrCode.ToString() + "]");
            else
            {
                if (uiValueInverse == 0)
                    MessageBox.Show("Module current DI value inverse setting is false");
                else
                    MessageBox.Show("Module current DI value inverse setting is true");
            }
        }

        private void btnGetCntEdgeTrig_Click(object sender, EventArgs e)
        {
            int iErrCode;
            uint uiCntEdgeTrig;

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.DI_GetCntEdgeTrigger(out uiCntEdgeTrig)))
                MessageBox.Show("Failed to get counter edge trigger. ErrCode:[" + iErrCode.ToString() + "]");
            else
            {
                if (uiCntEdgeTrig == 0)
                    MessageBox.Show("Module current counter edge trigger setting is falling");
                else
                    MessageBox.Show("Module current counter edge trigger setting is rising");
            }
        }

        private void btnSetDigitalFilterWidth_Click(object sender, EventArgs e)
        {
            int iErrCode;
            ushort usFilterWidth;

            usFilterWidth = Convert.ToUInt16(numDigitalFilterWidth.Value);

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.DI_SetDigitalFilterWidth(usFilterWidth)))
                MessageBox.Show("Failed to set digital filter width. ErrCode:[" + iErrCode.ToString() + "]");
            else
                MessageBox.Show("Success.");
        }

        private void btnSetDIValueInverse_Click(object sender, EventArgs e)
        {
            int iErrCode;
            UInt32 uiDIValueInv = 0;

            if (rdbtnDIValueInvDisable.Checked)
                uiDIValueInv = 0;
            if (rdbtnDIValueInvEnable.Checked)
                uiDIValueInv = 1;

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.DI_SetDigitalValueInverse(uiDIValueInv)))
                MessageBox.Show("Failed to set DI value inverse. ErrCode:[" + iErrCode.ToString() + "]");
            else
                MessageBox.Show("Success.");
        }

        private void btnSetCounterEdgeTrigger_Click(object sender, EventArgs e)
        {
            int iErrCode;
            UInt32 uiCntEdge = 0;

            if (rdbtnEdgeFalling.Checked)
                uiCntEdge = 0;
            if (rdbtnEdgeRising.Checked)
                uiCntEdge = 1;

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.DI_SetCntEdgeTrigger(uiCntEdge)))
                MessageBox.Show("Failed to set counter edge trigger. ErrCode:[" + iErrCode.ToString() + "]");
            else
                MessageBox.Show("Success.");
        }
    }
}