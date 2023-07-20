using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ICPDAS;

namespace AO_API_Test
{
    public partial class FormAO_API_Test : Form
    {
        static readonly ushort[] USBIO_DID = new ushort[] { ICPDAS_USBIO.USB2026 };
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

        public FormAO_API_Test()
        {
            InitializeComponent();

            cbxDevID.SelectedIndex = 0;
            m_USBIO = new ICPDAS_USBIO();
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            btnEnable.Enabled = false;
            btnDisable.Enabled = true;
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            btnEnable.Enabled = true;
            btnDisable.Enabled = false;
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
                    m_USBIO.GetDITotal(out m_byDOTotal);
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

        private void btnGetSupportTypeCode_Click(object sender, EventArgs e)
        {
            byte byTotalSupType;
            byte[] bySupTypeCode;
            int iErrCode;
            bool bRet = true;

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AO_GetTotalSupportType(out byTotalSupType)))
            {
                bRet = false;

                MessageBox.Show("Failed to get AO total support type. ErrCode:[" + iErrCode.ToString() + "]");
            }

            bySupTypeCode = new byte[byTotalSupType];
            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AO_GetSupportTypeCode(bySupTypeCode)))
            {
                bRet = false;

                MessageBox.Show("Failed to get AO support types. ErrCode:[" + iErrCode.ToString() + "]");
            }

            if (bRet)
            {
                string szMessage = byTotalSupType + " supported types for this module.\n";

                if (byTotalSupType > 0)
                {
                    szMessage += "Support types is:\n";
                    for (int iIdx = 0; iIdx < byTotalSupType; iIdx++)
                        szMessage += "0x" + bySupTypeCode[iIdx].ToString("X") + "\n";
                }

                MessageBox.Show(szMessage);
            }
        }

        private void btnGetTypeCode_Click(object sender, EventArgs e)
        {
            int iErrCode;
            byte[] byChTypeCode = new byte[m_byAOTotal];

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AO_GetTypeCode(byChTypeCode)))
                MessageBox.Show("Failed to get AO channel type code. ErrCode:[" + iErrCode.ToString() + "]");
            else
            {
                string szMessage = "Module current channel type:\n";
                for (int iIdx = 0; iIdx < m_byAOTotal; iIdx++)
                    szMessage += "0x" + byChTypeCode[iIdx].ToString("X") + "\n";

                MessageBox.Show(szMessage);
            }
        }

        private void btnGetChEnable_Click(object sender, EventArgs e)
        {
            int iErrCode;
            byte[] byChEnable = new byte[(m_byAOTotal + 7) / 8];

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AO_GetChEnable(byChEnable)))
                MessageBox.Show("Failed to get AO channel mask. ErrCode:[" + iErrCode.ToString() + "]");
            else
            {
                string szMessage = "Module current channel mask:\n";
                for (int iIdx = 0; iIdx < (m_byAOTotal + 7) / 8; iIdx++)
                    szMessage += "0x" + byChEnable[iIdx].ToString("X");

                MessageBox.Show(szMessage);
            }
        }

        private void btnGetResolution_Click(object sender, EventArgs e)
        {
            int iErrCode;
            byte[] byResolution = new byte[m_byAOTotal];

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AO_GetResolution(byResolution)))
                MessageBox.Show("Failed to get AO resolution. ErrCode:[" + iErrCode.ToString() + "]");
            else
            {
                string szMessage;

                szMessage = "Module resolution for each channel is: ";

                for (int iIdx = 0; iIdx < m_byAOTotal; iIdx++)
                    szMessage += "\nCh" + iIdx.ToString() + ": " + byResolution[iIdx].ToString();
                MessageBox.Show(szMessage);
            }
        }

        private void btnPwrOnEnable_Click(object sender, EventArgs e)
        {
            int iErrCode;
            byte[] byPwrOnEnable = new byte[m_byAOTotal];

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AO_GetPowerOnEnable(byPwrOnEnable)))
                MessageBox.Show("Failed to get AO Power-On Enable. ErrCode:[" + iErrCode.ToString() + "]");
            else
            {
                string szMessage = "Module current Power-On Enable:\n";
                for (int iIdx = 0; iIdx < m_byAOTotal; iIdx++)
                    szMessage += "0x" + byPwrOnEnable[iIdx].ToString("X") + "\n";

                MessageBox.Show(szMessage);
            }
        }

        private void btnSafetyEnable_Click(object sender, EventArgs e)
        {
            int iErrCode;
            byte[] bySafetyEnable = new byte[(m_byAOTotal + 7) / 8];

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AO_GetSafetyEnable(bySafetyEnable)))
                MessageBox.Show("Failed to get AO Safety Enable. ErrCode:[" + iErrCode.ToString() + "]");
            else
            {
                string szMessage = "Module current Safety Enable:\n";
                for (int iIdx = 0; iIdx < (m_byAOTotal + 7) / 8; iIdx++)
                    szMessage += "0x" + bySafetyEnable[iIdx].ToString("X");

                MessageBox.Show(szMessage);
            }
        }

        private void btnPwrOnValue_Click(object sender, EventArgs e)
        {
            int iErrCode;
            uint[] dwPwrOnValue = new uint[m_byAOTotal];
            float[] fPwrOnValue = new float[m_byAOTotal];

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AO_GetPowerOnValue(dwPwrOnValue)))
                MessageBox.Show("Failed to get AO Power-On Value. ErrCode:[" + iErrCode.ToString() + "]");
            else
            {
                string szMessage = "Module current Power-On Value:\n";
                for (int iIdx = 0; iIdx < m_byAOTotal; iIdx++)
                    szMessage += "0x" + dwPwrOnValue[iIdx].ToString("X") + "\n";

                MessageBox.Show(szMessage);
            }

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AO_GetPowerOnValue(fPwrOnValue)))
                MessageBox.Show("Failed to get AO Power-On Value. ErrCode:[" + iErrCode.ToString() + "]");
            else
            {
                string szMessage = "Module current Power-On Value(float):\n";
                for (int iIdx = 0; iIdx < m_byAOTotal; iIdx++)
                    szMessage +=  fPwrOnValue[iIdx].ToString("0.000") + "\n";

                MessageBox.Show(szMessage);
            }


        }

        private void btnSafetyValue_Click(object sender, EventArgs e)
        {
            int iErrCode;
            uint[] dwSafetyValue = new uint[m_byAOTotal];
            float[] fSafetyValue = new float[m_byAOTotal];

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AO_GetSafetyValue(dwSafetyValue)))
                MessageBox.Show("Failed to get AO Safety Value. ErrCode:[" + iErrCode.ToString() + "]");
            else
            {
                string szMessage = "Module current Safety Value:\n";
                for (int iIdx = 0; iIdx < m_byAOTotal; iIdx++)
                    szMessage += "0x" + dwSafetyValue[iIdx].ToString("X") + "\n";

                MessageBox.Show(szMessage);
            }

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AO_GetSafetyValue(fSafetyValue)))
                MessageBox.Show("Failed to get AO Safety Value. ErrCode:[" + iErrCode.ToString() + "]");
            else
            {
                string szMessage = "Module current Safety Value(float):\n";
                for (int iIdx = 0; iIdx < m_byAOTotal; iIdx++)
                    szMessage += fSafetyValue[iIdx].ToString("0.000") + "\n";

                MessageBox.Show(szMessage);
            }
        }

        private void btnSetTypeCode_Click(object sender, EventArgs e)
        {
            int iErrCode;
            byte[] byTypeCodeStringArray;
            byte byTypeCode = 0;

            byTypeCodeStringArray = ASCIIEncoding.ASCII.GetBytes(txtTypeCode.Text);
            for (int idx = 0; idx < byTypeCodeStringArray.Length; idx++)
                byTypeCode += Convert.ToByte(Asc2Hex(byTypeCodeStringArray[idx]) * (Math.Pow(16, byTypeCodeStringArray.Length - 1 - idx)));

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AO_SetTypeCode(Convert.ToByte(numSetTypeCodeCh.Value), byTypeCode)))
                MessageBox.Show("Failed to set AO channel type code. ErrCode:[" + iErrCode.ToString() + "]");
            else
                MessageBox.Show("Success.");
        }

        private void btnSetChMask_Click(object sender, EventArgs e)
        {
            int iErrCode;
            byte[] byChMaskStringArray;
            byte[] byChEnable = new byte[(m_byAOTotal + 7) / 8];

            byChMaskStringArray = ASCIIEncoding.ASCII.GetBytes(txtChMask.Text);
            if (byChMaskStringArray.Length > (((m_byAOTotal + 7) / 8) * 2))
            {
                MessageBox.Show("Channel mask invalid. (Channel mask value over channel number)");
                return;
            }
            Array.Clear(byChEnable, 0, byChEnable.Length);
            for (int iIdx = 0; iIdx < byChMaskStringArray.Length; iIdx++)
                byChEnable[(byChMaskStringArray.Length - 1 - iIdx) / 2] += Convert.ToByte(Asc2Hex(byChMaskStringArray[iIdx]) * (Math.Pow(16, (byChMaskStringArray.Length - 1 - iIdx) % 2)));

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AO_SetChEnable(byChEnable)))
                MessageBox.Show("Failed to set AO channel mask. ErrCode:[" + iErrCode.ToString() + "]");
            else
                MessageBox.Show("Success.");
        }

        private void btnSetPwrOnEnable_Click(object sender, EventArgs e)
        {
            int iErrCode;
            byte[] byPwrOnEnable = new byte[m_byAOTotal];
            if (numPwrOnEnableCh.Value < m_byAOTotal)
            {
                if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AO_GetPowerOnEnable(byPwrOnEnable)))
                    MessageBox.Show("Failed to get AO Power-On Enable. ErrCode:[" + iErrCode.ToString() + "]");
                else
                {
                    byPwrOnEnable[(int)(numPwrOnEnableCh.Value)] = Convert.ToByte(btnDisable.Enabled);

                    if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AO_SetPowerOnEnable(byPwrOnEnable)))
                        MessageBox.Show("Failed to set AO Power-On Enable. ErrCode:[" + iErrCode.ToString() + "]");
                    else
                        MessageBox.Show("Success");
                }
            }
            else
            {
                MessageBox.Show("Please select the channel in the range of AO channels");
            }
            
            
       
        }

        private void btnSetPwrOnValue_Click(object sender, EventArgs e)
        {
            int iErrCode;
            uint dwPwrOnValue;

            dwPwrOnValue = Convert.ToUInt32(txtPwrOnValue.Text, 16);
            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AO_SetPowerOnValue(Convert.ToByte(numPwrOnValueCh.Value), dwPwrOnValue)))
                MessageBox.Show("Failed to set AO channel Power-On Value. ErrCode:[" + iErrCode.ToString() + "]");
            else
                MessageBox.Show("Success.");
              
        }

        private void btnSetSafetyEnable_Click(object sender, EventArgs e)
        {
            int iErrCode;
            byte[] bySafetyMaskStringArray;
            byte[] bySafetyEnable = new byte[(m_byAOTotal + 7) / 8];

            bySafetyMaskStringArray = ASCIIEncoding.ASCII.GetBytes(txtSafetyEnableMask.Text);
            if (bySafetyMaskStringArray.Length > (((m_byAOTotal + 7) / 8) * 2))
            {
                MessageBox.Show("Safety enable mask invalid. (Safety mask value over channel number)");
                return;
            }
            Array.Clear(bySafetyEnable, 0, bySafetyEnable.Length);
            for (int iIdx = 0; iIdx < bySafetyMaskStringArray.Length; iIdx++)
                bySafetyEnable[(bySafetyMaskStringArray.Length - 1 - iIdx) / 2] += Convert.ToByte(Asc2Hex(bySafetyMaskStringArray[iIdx]) * (Math.Pow(16, (bySafetyMaskStringArray.Length - 1 - iIdx) % 2)));

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AO_SetSafetyEnable(bySafetyEnable)))
                MessageBox.Show("Failed to set AO channel mask. ErrCode:[" + iErrCode.ToString() + "]");
            else
                MessageBox.Show("Success.");
        }

        private void btnSetPwrOnValue_Float_Click(object sender, EventArgs e)
        {
            int iErrCode;
            float fPwrOnValue;

            fPwrOnValue = Convert.ToSingle(txtPwrOnValue_Float.Text);
            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AO_SetPowerOnValue(Convert.ToByte(numPwrOnValueCh_Float.Value), fPwrOnValue)))
                MessageBox.Show("Failed to set AO channel Power-On Value. ErrCode:[" + iErrCode.ToString() + "]");
            else
                MessageBox.Show("Success.");
        }

        private void btnSetSafetyValue_Click(object sender, EventArgs e)
        {
            int iErrCode;
            uint dwSafetyValue;

            dwSafetyValue = Convert.ToUInt32(txtSafetyValue.Text, 16);
            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AO_SetSafetyValue(Convert.ToByte(numSafetyValueCh.Value), dwSafetyValue)))
                MessageBox.Show("Failed to set AO channel Safety Value. ErrCode:[" + iErrCode.ToString() + "]");
            else
                MessageBox.Show("Success.");
        }

        private void btnSetSafetyValue_Float_Click(object sender, EventArgs e)
        {
            int iErrCode;
            float fSafetyValue;

            fSafetyValue = Convert.ToSingle(txtSafetyValue_Float.Text);
            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AO_SetSafetyValue(Convert.ToByte(numSafetyValueCh_Float.Value), fSafetyValue)))
                MessageBox.Show("Failed to set AO channel Power-On Value. ErrCode:[" + iErrCode.ToString() + "]");
            else
                MessageBox.Show("Success.");
        }
        

        
    }
}