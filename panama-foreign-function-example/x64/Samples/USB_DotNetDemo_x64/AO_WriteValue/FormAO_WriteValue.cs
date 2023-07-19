using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ICPDAS;

namespace AO_WriteValue
{
    public partial class FormAO_WriteValue : Form
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


        public FormAO_WriteValue()
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
            lvExpValue.Items.Clear();
            lvCurValue.Items.Clear();

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.CloseDevice()))
                MessageBox.Show("Failed to close device. ErrCode:[" + iErrCode.ToString() + "]");
        }

        private void btnWriteValueDigital_Click(object sender, EventArgs e)
        {
            int iErrCode;
            uint[] dwValue = new uint[m_byAOTotal];

            if (txtWriteDigitalValue.Text != "")
            {
                for (int idx = 0; idx < m_byAOTotal; idx++)
                    dwValue[idx] = Convert.ToUInt32(txtWriteDigitalValue.Text, 16);

                if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AO_WriteValue(dwValue)))
                        MessageBox.Show("Failed to write AO value. ErrCode:[" + iErrCode.ToString() + "]");
                    else
                    {
                        ShowValue();
                        MessageBox.Show("Success");
                    }
            }
            else
                MessageBox.Show("Please enter AO value");

            
        }        

        private void btnWriteChValueDigital_Click(object sender, EventArgs e)
        {
            int iErrCode;

            if (txtWriteDigitalValue.Text != "" & txtWriteDigitalCh.Text != "")
            {

                if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AO_WriteValue(Convert.ToByte(txtWriteDigitalCh.Text), Convert.ToUInt32(txtWriteDigitalValue.Text, 16))))
                    MessageBox.Show("Failed to write AO value. ErrCode:[" + iErrCode.ToString() + "]");
                else
                {
                    ShowValue();
                    MessageBox.Show("Success");
                }
            }
            else
                MessageBox.Show("Please enter AO channel and value");
        }

        private void btnWriteChValueAnalog_Click(object sender, EventArgs e)
        {
            int iErrCode;

            if (txtWriteAnalogValue.Text != "" & txtWriteAnalogCh.Text != "")
            {

                if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AO_WriteValue(Convert.ToByte(txtWriteAnalogCh.Text), Convert.ToSingle(txtWriteAnalogValue.Text))))
                    MessageBox.Show("Failed to write AO value. ErrCode:[" + iErrCode.ToString() + "]");
                else
                {
                    ShowValue();
                    MessageBox.Show("Success");
                }
            }
            else
                MessageBox.Show("Please enter AO channel and value");
        }

        private void btnWriteValueAnalog_Click(object sender, EventArgs e)
        {
            int iErrCode;
            float[] fValue = new float[m_byAOTotal];

            if (txtWriteAnalogValue.Text != "")
            {
                for (int idx = 0; idx < m_byAOTotal; idx++)
                    fValue[idx] = Convert.ToSingle(txtWriteAnalogValue.Text);

                if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AO_WriteValue(fValue)))
                    MessageBox.Show("Failed to write AO value. ErrCode:[" + iErrCode.ToString() + "]");
                else
                {
                    ShowValue();
                    MessageBox.Show("Success");
                }
            }
            else
                MessageBox.Show("Please enter AO value");
        }

        private void ShowValue()
        {
            int iErrCode;
            uint[] dwExpValue = new uint[m_byAOTotal];
            uint[] dwCurValue = new uint[m_byAOTotal];
            float[] fExpValue = new float[m_byAOTotal];
            float[] fCurValue = new float[m_byAOTotal];

            lvExpValue.Items.Clear();
            lvCurValue.Items.Clear();

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AO_ReadExpValue(dwExpValue)))
                MessageBox.Show("Failed to read AO expect value. ErrCode:[" + iErrCode.ToString() + "]");
            else
            {
                if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AO_ReadExpValue(fExpValue)))
                    MessageBox.Show("Failed to read AO expect value(float). ErrCode:[" + iErrCode.ToString() + "]");
                else
                {
                    for(int idx = 0; idx < m_byAOTotal; idx ++)
                        lvExpValue.Items.Add("0x" + dwExpValue[idx].ToString("x4") + "/" + fExpValue[idx].ToString("f3"));
                } 
            }

            if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AO_ReadExpValue(dwCurValue)))
                MessageBox.Show("Failed to read AO current value. ErrCode:[" + iErrCode.ToString() + "]");
            else
            {
                if ((int)ICPDAS_USBIO.ERR_CODE.ERR_NO_ERR != (iErrCode = m_USBIO.AO_ReadExpValue(fCurValue)))
                    MessageBox.Show("Failed to read AO current value(float). ErrCode:[" + iErrCode.ToString() + "]");
                else
                {
                    for (int idx = 0; idx < m_byAOTotal; idx++)
                        lvCurValue.Items.Add("0x" + dwCurValue[idx].ToString("x4") + "/" + fCurValue[idx].ToString("f3"));
                }
            }
        

        }
        
    }
}