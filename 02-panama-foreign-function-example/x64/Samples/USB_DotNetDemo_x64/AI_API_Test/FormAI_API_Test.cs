using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ICPDAS;

namespace AI_API_Test
{
    public partial class FormAI_API_Test : Form
    {
        static readonly ushort[] USBIO_DID = new ushort[] { ICPDAS_USBIO.USB2019,ICPDAS_USBIO.USB2026 };
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

        public FormAI_API_Test()
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

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AI_GetTotalSupportType(out byTotalSupType)))
            {
                bRet = false;

                MessageBox.Show("Failed to get AI total support type. ErrCode:[" + iErrCode.ToString() + "]");
            }

            bySupTypeCode = new byte[byTotalSupType];
            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AI_GetSupportTypeCode(bySupTypeCode)))
            {
                bRet = false;

                MessageBox.Show("Failed to get AI support types. ErrCode:[" + iErrCode.ToString() + "]");
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
            byte[] byChTypeCode = new byte[m_byAITotal];

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AI_GetTypeCode(byChTypeCode)))
                MessageBox.Show("Failed to get AI channel type code. ErrCode:[" + iErrCode.ToString() + "]");
            else
            {
                string szMessage = "Module current channel type:\n";
                for(int iIdx = 0; iIdx < m_byAITotal; iIdx++)
                    szMessage += "0x" + byChTypeCode[iIdx].ToString("X") + "\n";

                MessageBox.Show(szMessage);
            }
        }

        private void btnGetChOffset_Click(object sender, EventArgs e)
        {
            int iErrCode;
            float[] fChCJCOffset = new float[m_byAITotal];

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AI_GetChCJCOffset(fChCJCOffset)))
                MessageBox.Show("Failed to get AI channel CJC offset. ErrCode:[" + iErrCode.ToString() + "]");
            else
            {
                string szMessage = "Module current channel offset:\n";
                for (int iIdx = 0; iIdx < m_byAITotal; iIdx++)
                    szMessage += "0x" + fChCJCOffset[iIdx].ToString("0.00") + "\n";

                MessageBox.Show(szMessage);
            }
        }

        private void btnGetChEnable_Click(object sender, EventArgs e)
        {
            int iErrCode;
            byte[] byChEnable = new byte[(m_byAITotal + 7) / 8];

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AI_GetChEnable(byChEnable)))
                MessageBox.Show("Failed to get AI channel mask. ErrCode:[" + iErrCode.ToString() + "]");
            else
            {
                string szMessage = "Module current channel mask:\n";
                for (int iIdx = 0; iIdx < (m_byAITotal + 7) / 8; iIdx++)
                    szMessage += "0x" + byChEnable[iIdx].ToString("X");

                MessageBox.Show(szMessage);
            }
        }

        private void btnGetFilterRejection_Click(object sender, EventArgs e)
        {
            int iErrCode;
            byte byFilterRejection;

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AI_GetFilterRejection(out byFilterRejection)))
                MessageBox.Show("Failed to get AI filter rejection. ErrCode:[" + iErrCode.ToString() + "]");
            else
                MessageBox.Show("Module filter rejection: " + byFilterRejection.ToString());
        }

        private void btnGetCJCSetting_Click(object sender, EventArgs e)
        {
            byte byCJCEnable;
            float fCJCOffset;
            float fCJCValue;
            int iErrCode;
            bool bRet = true;

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AI_GetCJCEnable(out byCJCEnable)))
            {
                bRet = false;

                MessageBox.Show("Failed to get AI CJC enable. ErrCode:[" + iErrCode.ToString() + "]");
            }
            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AI_GetCJCOffset(out fCJCOffset)))
            {
                bRet = false;

                MessageBox.Show("Failed to get AI CJC offset. ErrCode:[" + iErrCode.ToString() + "]");
            }
            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AI_ReadCJCValue(out fCJCValue)))
            {
                bRet = false;

                MessageBox.Show("Failed to get AI CJC offset. ErrCode:[" + iErrCode.ToString() + "]");
            }

            if(bRet)
            {
                string szMessage;

                if (byCJCEnable == 1)
                {
                    szMessage = "Enable CJC offset.";
                }
                else
                {
                    szMessage = "Disable CJC offset. ";
                    szMessage += "CJC offset is " + fCJCOffset.ToString();
                }

                MessageBox.Show(szMessage);

                MessageBox.Show("CJC Value is: " + fCJCValue.ToString());

            }
        }

        private void btnGetWireDection_Click(object sender, EventArgs e)
        {
            byte byWireDetectEnable;
            int iErrCode;

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AI_GetWireDetectEnable(out byWireDetectEnable)))
                MessageBox.Show("Failed to get AI wire detection. ErrCode:[" + iErrCode.ToString() + "]");
            else
            {
                if (byWireDetectEnable == 1)
                    MessageBox.Show("Module wire detection enable");
                else
                    MessageBox.Show("Module wire detection disable");
            }
        }

        private void btnGetResolution_Click(object sender, EventArgs e)
        {
            int iErrCode;
            byte[] byResolution = new byte[m_byAITotal];

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AI_GetResolution(byResolution)))
                MessageBox.Show("Failed to get AI resolution. ErrCode:[" + iErrCode.ToString() + "]");
            else
            {
                string szMessage;

                szMessage = "Module resolution for each channel is: ";

                for (int iIdx = 0; iIdx < m_byAITotal; iIdx++)
                    szMessage += "\nCh" + iIdx.ToString() + ": " + byResolution[iIdx].ToString();
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

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AI_SetTypeCode(Convert.ToByte(numSetTypeCodeCh.Value), byTypeCode)))
                MessageBox.Show("Failed to set AI channel type code. ErrCode:[" + iErrCode.ToString() + "]");
            else
                MessageBox.Show("Success.");
        }

        private void btnSetChCJCOffset_Click(object sender, EventArgs e)
        {
            int iErrCode;

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AI_SetChCJCOffset(Convert.ToByte(numChCJCOffsetCh.Value), Convert.ToSingle(numChCJCOffset.Value))))
                MessageBox.Show("Failed to set AI CJC channel offset. ErrCode:[" + iErrCode.ToString() + "]");
            else
                MessageBox.Show("Success.");
        }

        private void btnSetChMask_Click(object sender, EventArgs e)
        {
            int iErrCode;
            byte[] byChMaskStringArray;
            byte[] byChEnable = new byte[(m_byAITotal + 7) / 8];

            byChMaskStringArray = ASCIIEncoding.ASCII.GetBytes(txtChMask.Text);
            if (byChMaskStringArray.Length > (((m_byAITotal + 7) / 8) * 2))
            {
                MessageBox.Show("Channel mask invalid. (Channel mask value over channel number)");
                return;
            }
            Array.Clear(byChEnable, 0, byChEnable.Length);
            for (int iIdx = 0; iIdx < byChMaskStringArray.Length; iIdx++)
                byChEnable[(byChMaskStringArray.Length - 1 - iIdx) / 2] += Convert.ToByte(Asc2Hex(byChMaskStringArray[iIdx]) * (Math.Pow(16, (byChMaskStringArray.Length - 1 - iIdx) % 2)));

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AI_SetChEnable(byChEnable)))
                MessageBox.Show("Failed to set AI channel mask. ErrCode:[" + iErrCode.ToString() + "]");
            else
                MessageBox.Show("Success.");
        }

        private void btnSetFilterRejection_Click(object sender, EventArgs e)
        {
            int iErrCode;

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AI_SetFilterRejection(Convert.ToByte(txtFilterRejection.Text))))
                MessageBox.Show("Failed to set AI filter rejection. ErrCode:[" + iErrCode.ToString() + "]");
            else
                MessageBox.Show("Success.");
        }

        private void btnSetCJC_Click(object sender, EventArgs e)
        {
            int iErrCode;

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AI_SetCJCEnable(Convert.ToByte(chbxCJCEnable.Checked))))
                MessageBox.Show("Failed to set AI CJC enable. ErrCode:[" + iErrCode.ToString() + "]");
            else
                MessageBox.Show("Success.");

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AI_SetCJCOffset(Convert.ToSingle(numCJCOffset.Value))))
                MessageBox.Show("Failed to set AI CJC offset. ErrCode:[" + iErrCode.ToString() + "]");
            else
                MessageBox.Show("Success.");
        }

        private void btnSetWireDetection_Click(object sender, EventArgs e)
        {
            int iErrCode;

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AI_SetWireDetectEnable(Convert.ToByte(chbxWireDetection.Checked))))
                MessageBox.Show("Failed to set AI wire detection. ErrCode:[" + iErrCode.ToString() + "]");
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
    }
}