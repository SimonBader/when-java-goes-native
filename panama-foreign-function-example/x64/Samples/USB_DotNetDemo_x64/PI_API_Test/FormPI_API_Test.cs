using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ICPDAS;

namespace PI_API_Test
{
    public partial class FormPI_API_Test : Form
    {
        static readonly ushort[] USBIO_DID = new ushort[] { ICPDAS_USBIO.USB2084 };
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

        public FormPI_API_Test()
        {
            InitializeComponent();

            cbxDevID.SelectedIndex = 0;

            m_USBIO = new ICPDAS_USBIO();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            m_USBIO.CloseDevice();

            this.Close();
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

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.PI_GetTotalSupportType(out byTotalSupType)))
            {
                bRet = false;

                MessageBox.Show("Failed to get PI total support type. ErrCode:[" + iErrCode.ToString() + "]");
            }

            bySupTypeCode = new byte[byTotalSupType];
            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.PI_GetSupportTypeCode(bySupTypeCode)))
            {
                bRet = false;

                MessageBox.Show("Failed to get PI support types. ErrCode:[" + iErrCode.ToString() + "]");
            }

            if(bRet)
            {
                string szMessage = byTotalSupType + " supported types for this module.\n";

                if(byTotalSupType > 0)
                {
                    szMessage += "Support types is:\n";
                    for(int iIdx = 0; iIdx < byTotalSupType; iIdx++)
                        szMessage += "0x" + bySupTypeCode[iIdx].ToString("X") + "\n";
                }

                MessageBox.Show(szMessage);
            }
        }

        private void btnGetTypeCode_Click(object sender, EventArgs e)
        {
            int iErrCode;
            byte[] byChTypeCode = new byte[m_byPITotal];

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.PI_GetTypeCode(byChTypeCode)))
                MessageBox.Show("Failed to get PI channel type code. ErrCode:[" + iErrCode.ToString() + "]");
            else
            {
                string szMessage = "Module current channel type:\n";
                for(int iIdx = 0; iIdx < m_byPITotal; iIdx++)
                    szMessage += "0x" + byChTypeCode[iIdx].ToString("X") + "\n";

                MessageBox.Show(szMessage);
            }
        }

        private void btnGetLPFEnable_Click(object sender, EventArgs e)
        {
            int iErrCode;
            byte[] byLPFEnable = new byte[(m_byPITotal + 7) / 8];

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.PI_GetLPFilterEnable(byLPFEnable)))
                MessageBox.Show("Failed to get PI channel LP filter enable. ErrCode:[" + iErrCode.ToString() + "]");
            else
            {
                string szMessage = "Module current channel LP filter enable: 0x";
                for (int iIdx = 0; iIdx < (m_byPITotal + 7) / 8; iIdx++)
                    szMessage += byLPFEnable[iIdx].ToString("X");

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

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.PI_SetTypeCode(Convert.ToByte(numSetTypeCodeCh.Value), byTypeCode)))
                MessageBox.Show("Failed to set PI channel type code. ErrCode:[" + iErrCode.ToString() + "]");
            else
                MessageBox.Show("Success.");
        }

        private void btnChClr_Click(object sender, EventArgs e)
        {
            int iErrCode;
            byte[] byChClrStringArray;
            byte[] byChClr = new byte[(m_byPITotal + 7) / 8];

            byChClrStringArray = ASCIIEncoding.ASCII.GetBytes(txtChClr.Text);
            if (byChClrStringArray.Length > (((m_byPITotal + 7) / 8) * 2))
            {
                MessageBox.Show("Clear mask invalid. (Clear mask value over channel number)");
                return;
            }
            Array.Clear(byChClr, 0, byChClr.Length);
            for (int iIdx = 0; iIdx < byChClrStringArray.Length; iIdx++)
                byChClr[(byChClrStringArray.Length - 1 - iIdx) / 2] += Convert.ToByte(Asc2Hex(byChClrStringArray[iIdx]) * (Math.Pow(16, (byChClrStringArray.Length - 1 - iIdx) % 2)));

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.PI_ClearChCount(byChClr)))
                MessageBox.Show("Failed to clear PI channel count. ErrCode:[" + iErrCode.ToString() + "]");
            else
                MessageBox.Show("Success.");
        }

        private bool nonValidKeyEntered = false;

        private void HexFieldInputCheck(object sender, KeyEventArgs e)
        {
            nonValidKeyEntered = false;

            if (e.KeyCode < Keys.A || e.KeyCode > Keys.F)
            {
                if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
                {
                    if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                    {
                        if (e.KeyCode != Keys.Back)
                        {
                            nonValidKeyEntered = true;
                        }
                    }
                }
            }
        }

        private void HexFieldInputPress(object sender, KeyPressEventArgs e)
        {
            if (nonValidKeyEntered == true)
                e.Handled = true;
        }

        private void btnGetChIsolated_Click(object sender, EventArgs e)
        {
            int iErrCode;
            byte[] byChIsolated = new byte[(m_byPITotal + 7) / 8];

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.PI_GetChIsolatedFlag(byChIsolated)))
                MessageBox.Show("Failed to get ch isolated flag. ErrCode:[" + iErrCode.ToString() + "]");
            else
            {
                string szMessage = "Module current channel isolated flag: 0x";
                for (int iIdx = 0; iIdx < (m_byPITotal + 7) / 8; iIdx++)
                    szMessage += byChIsolated[iIdx].ToString("X");

                MessageBox.Show(szMessage);
            }
        }

        private void btnGetTriggerMode_Click(object sender, EventArgs e)
        {
            int iErrCode;
            byte[] byTriggerMode = new byte[m_byPITotal];

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.PI_GetTriggerMode(byTriggerMode)))
                MessageBox.Show("Failed to get PI channel trigger mode. ErrCode:[" + iErrCode.ToString() + "]");
            else
            {
                string szMessage = "Module current channel trigger mode:";
                for (int iIdx = 0; iIdx < m_byPITotal; iIdx++)
                    szMessage += "\nCh" + iIdx.ToString() + ": " + byTriggerMode[iIdx].ToString();

                MessageBox.Show(szMessage);
            }
        }

        private void btnGetLPFWidth_Click(object sender, EventArgs e)
        {
            int iErrCode;
            ushort[] byLPFWidth = new ushort[m_byPITotal];

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.PI_GetLPFilterWidth(byLPFWidth)))
                MessageBox.Show("Failed to get PI LP filter width. ErrCode:[" + iErrCode.ToString() + "]");
            else
            {
                string szMessage = "Module current channel LP filter width:";
                for (int iIdx = 0; iIdx < m_byPITotal; iIdx++)
                    szMessage += "\nCh" + iIdx.ToString() + ": " + byLPFWidth[iIdx].ToString();

                MessageBox.Show(szMessage);
            }
        }

        private void btnSetChIsolated_Click(object sender, EventArgs e)
        {
            int iErrCode;
            byte[] byChChIsolatedStringArray;
            byte[] byChChIsolated = new byte[(m_byPITotal + 7) / 8];

            byChChIsolatedStringArray = ASCIIEncoding.ASCII.GetBytes(txtChIsolated.Text);
            if (byChChIsolatedStringArray.Length > (((m_byPITotal + 7) / 8) * 2))
            {
                MessageBox.Show("Channel isolated invalid. (Channel isolated value over channel number)");
                return;
            }
            Array.Clear(byChChIsolated, 0, byChChIsolated.Length);
            for (int iIdx = 0; iIdx < byChChIsolatedStringArray.Length; iIdx++)
                byChChIsolated[(byChChIsolatedStringArray.Length - 1 - iIdx) / 2] += Convert.ToByte(Asc2Hex(byChChIsolatedStringArray[iIdx]) * (Math.Pow(16, (byChChIsolatedStringArray.Length - 1 - iIdx) % 2)));

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.PI_SetChIsolatedFlag(byChChIsolated)))
                MessageBox.Show("Failed to set channel isolated flag. ErrCode:[" + iErrCode.ToString() + "]");
            else
                MessageBox.Show("Success.");
        }

        private void btnSetTriggerMode_Click(object sender, EventArgs e)
        {
            int iErrCode;
            byte byTriggerMode = 0;

            byTriggerMode = Convert.ToByte(txtTriggerMode.Text);

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.PI_SetTriggerMode(Convert.ToByte(numSetTriggerModeCh.Value), byTriggerMode)))
                MessageBox.Show("Failed to set PI channel trigger mode. ErrCode:[" + iErrCode.ToString() + "]");
            else
                MessageBox.Show("Success.");
        }

        private void btnSetLPFEnable_Click(object sender, EventArgs e)
        {
            int iErrCode;
            byte[] byLPFEnableStringArray;
            byte[] byLPFEnable = new byte[(m_byPITotal + 7) / 8];

            byLPFEnableStringArray = ASCIIEncoding.ASCII.GetBytes(txtLPFEnable.Text);
            if (byLPFEnableStringArray.Length > (((m_byPITotal + 7) / 8) * 2))
            {
                MessageBox.Show("LP filter enable invalid. (LP filter enable value over channel number)");
                return;
            }
            Array.Clear(byLPFEnable, 0, byLPFEnable.Length);
            for (int iIdx = 0; iIdx < byLPFEnableStringArray.Length; iIdx++)
                byLPFEnable[(byLPFEnableStringArray.Length - 1 - iIdx) / 2] += Convert.ToByte(Asc2Hex(byLPFEnableStringArray[iIdx]) * (Math.Pow(16, (byLPFEnableStringArray.Length - 1 - iIdx) % 2)));

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.PI_SetLPFilterEnable(byLPFEnable)))
                MessageBox.Show("Failed to set PI channel LP filter enable. ErrCode:[" + iErrCode.ToString() + "]");
            else
                MessageBox.Show("Success.");
        }

        private void btnSetLPFWidth_Click(object sender, EventArgs e)
        {
            int iErrCode;
            ushort wLPFWidth = 0;

            wLPFWidth = Convert.ToUInt16(txtLPFWidth.Text);

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.PI_SetLPFilterWidth(Convert.ToByte(numSetLPFWidthCh.Value), wLPFWidth)))
                MessageBox.Show("Failed to set PI channel LP filter width. ErrCode:[" + iErrCode.ToString() + "]");
            else
                MessageBox.Show("Success.");
        }
    }
}