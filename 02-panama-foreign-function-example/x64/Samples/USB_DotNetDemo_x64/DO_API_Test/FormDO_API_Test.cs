using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ICPDAS;

namespace DO_API_Test
{
    public partial class FormDO_API_Test : Form
    {
        static readonly ushort[] USBIO_DID = new ushort[] { ICPDAS_USBIO.USB2026, ICPDAS_USBIO.USB2045, ICPDAS_USBIO.USB2055, ICPDAS_USBIO.USB2064, ICPDAS_USBIO.USB2045_32, ICPDAS_USBIO.USB2055_32, ICPDAS_USBIO.USB2064_16, ICPDAS_USBIO.USB2068_18 };
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

        public FormDO_API_Test()
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

        private void btnGetPwrOnEnable_Click(object sender, EventArgs e)
        {
            int iErrCode;
            byte[] byPwrOnEnable = new byte[m_byDOTotal];

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.DO_GetPowerOnEnable(byPwrOnEnable)))
                MessageBox.Show("Failed to get DO power-on eanble. ErrCode:[" + iErrCode.ToString() + "]");
            else
            {
                string szMessage = "Module current power-on enable:\n";
                for (int iIdx = 0; iIdx < m_byDOTotal; iIdx++)
                    szMessage += "0x" + byPwrOnEnable[iIdx].ToString("X") + "\n";

                MessageBox.Show(szMessage);
            }
        }

        private void btnGetSafetyEnable_Click(object sender, EventArgs e)
        {
            int iErrCode;
            byte[] bySafetyEnable = new byte[(m_byDOTotal + 7) / 8];

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.DO_GetSafetyEnable(bySafetyEnable)))
                MessageBox.Show("Failed to get DO safety enable. ErrCode:[" + iErrCode.ToString() + "]");
            else
            {
                string szMessage = "Module current safety enable:\n";
                for (int iIdx = 0; iIdx < (m_byDOTotal + 7) / 8; iIdx++)
                    szMessage += "0x" + bySafetyEnable[iIdx].ToString("X");

                MessageBox.Show(szMessage);
            }
        }

        private void btnGetSafetyValue_Click(object sender, EventArgs e)
        {
            int iErrCode;
            byte[] bySafetyValue = new byte[(m_byDOTotal + 7) / 8];

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.DO_GetSafetyValue(bySafetyValue)))
                MessageBox.Show("Failed to get DO safety value. ErrCode:[" + iErrCode.ToString() + "]");
            else
            {
                string szMessage = "Module current safety value:\n";
                for (int iIdx = 0; iIdx < (m_byDOTotal + 7) / 8; iIdx++)
                    szMessage += "0x" + bySafetyValue[iIdx].ToString("X");

                MessageBox.Show(szMessage);
            }
        }

        private void btnSetPwrOnEnable_Click(object sender, EventArgs e)
        {
            int iErrCode;
            byte[] byPwrOnEnableStringArray;
            byte byPwrOnEnable = 0;

            byPwrOnEnableStringArray = ASCIIEncoding.ASCII.GetBytes(txtSetPwrOnEnable.Text);
            for (int idx = 0; idx < byPwrOnEnableStringArray.Length; idx++)
                byPwrOnEnable += Convert.ToByte(Asc2Hex(byPwrOnEnableStringArray[idx]) * (Math.Pow(16, byPwrOnEnableStringArray.Length - 1 - idx)));

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.DO_SetPowerOnEnable(Convert.ToByte(numSetPwrOnEnableCh.Value), byPwrOnEnable)))
                MessageBox.Show("Failed to set DO power-on enable. ErrCode:[" + iErrCode.ToString() + "]");
            else
                MessageBox.Show("Success.");
        }

        private void btnSetSafetyEnable_Click(object sender, EventArgs e)
        {
            int iErrCode;
            byte[] bySafetyEnableStringArray;
            byte[] bySafetyEnable = new byte[(m_byDOTotal + 7) / 8];

            bySafetyEnableStringArray = ASCIIEncoding.ASCII.GetBytes(txtSetSafetyEnable.Text);
            if (bySafetyEnableStringArray.Length > (((m_byDOTotal + 7) / 8) * 2))
            {
                MessageBox.Show("Safety enable invalid. (Safety enable over channel number)");
                return;
            }
            Array.Clear(bySafetyEnable, 0, bySafetyEnable.Length);
            for (int iIdx = 0; iIdx < bySafetyEnableStringArray.Length; iIdx++)
                bySafetyEnable[(bySafetyEnableStringArray.Length - 1 - iIdx) / 2] += Convert.ToByte(Asc2Hex(bySafetyEnableStringArray[iIdx]) * (Math.Pow(16, (bySafetyEnableStringArray.Length - 1 - iIdx) % 2)));

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.DO_SetSafetyEnable(bySafetyEnable)))
                MessageBox.Show("Failed to set DO safety enable. ErrCode:[" + iErrCode.ToString() + "]");
            else
                MessageBox.Show("Success.");
        }

        private void btnSetSafetyValue_Click(object sender, EventArgs e)
        {
            int iErrCode;
            byte[] bySafetyValueStringArray;
            byte[] bySafetyValue = new byte[(m_byDOTotal + 7) / 8];

            bySafetyValueStringArray = ASCIIEncoding.ASCII.GetBytes(txtSetSafetyValue.Text);
            if (bySafetyValueStringArray.Length > (((m_byDOTotal + 7) / 8) * 2))
            {
                MessageBox.Show("Safety value invalid. (Safety value over channel number)");
                return;
            }
            Array.Clear(bySafetyValue, 0, bySafetyValue.Length);
            for (int iIdx = 0; iIdx < bySafetyValueStringArray.Length; iIdx++)
                bySafetyValue[(bySafetyValueStringArray.Length - 1 - iIdx) / 2] += Convert.ToByte(Asc2Hex(bySafetyValueStringArray[iIdx]) * (Math.Pow(16, (bySafetyValueStringArray.Length - 1 - iIdx) % 2)));

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.DO_SetSafetyValue(bySafetyValue)))
                MessageBox.Show("Failed to set DO safety enable. ErrCode:[" + iErrCode.ToString() + "]");
            else
                MessageBox.Show("Success.");
        }
    }
}