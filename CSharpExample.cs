using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using InpOut32.CSharp.Net;

namespace InpOut32.Net
{
    public partial class CSharpExample : Form
    {
        bool m_bX64 = false;

        public CSharpExample()
        {
            InitializeComponent();
            portAddr.Focus();

            uint nResult = AplexOS7116GPIO.initInpOut32Lib();
            if (nResult == 0)
            {
                lblMessage.Text = "Unable to open InpOut32 driver";
                readByte.Enabled = false;
                writeByte.Enabled = false;
            }

            AplexOS7116GPIO.initGPIO();
        }

        private void readByte_Click(object sender, EventArgs e)
        {
            try
            {
                char c;
                // 字符串转16位short类型整数
                short iPort = Convert.ToInt16(portAddr.Text, 16);

                c = AplexOS7116GPIO.readByte(iPort);
                
                // 将读取的数据显示出来 
                portValue.Text = Convert.ToInt32(c).ToString("X2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured:\n" + ex.Message);
            }
        }

        private void writeByte_Click(object sender, EventArgs e)
        {
            try
            {
                // 字符串转16位short类型整数
                short iPort = Convert.ToInt16(portAddr.Text, 16);
                short iData = Convert.ToInt16(portValue.Text, 16);
                // textBox2.Text = "";
                AplexOS7116GPIO.writeByte(iPort, iData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured:\n" + ex.Message);
            }
        }

        private void CSharpExample_FormClosing(object sender, FormClosingEventArgs e)
        {
            AplexOS7116GPIO.freeGPIO();
        }

        private void readMode_Click(object sender, EventArgs e)
        {
            try
            {
                char c;
                c = AplexOS7116GPIO.getPinsMode();
                
                // 将读取的数据显示出来 
                portValue.Text = Convert.ToInt32(c).ToString("X2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured:\n" + ex.Message);
            }
        }

        private void WriteMode_Click(object sender, EventArgs e)
        {
            try
            {
                short iData = Convert.ToInt16(portValue.Text, 16);
                AplexOS7116GPIO.setPinsMode(iData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured:\n" + ex.Message);
            }

        }

        private void readValue_Click(object sender, EventArgs e)
        {
            try
            {
                char c;
                c = AplexOS7116GPIO.getPinsVal();
                
                // 将读取的数据显示出来 
                portValue.Text = Convert.ToInt32(c).ToString("X2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured:\n" + ex.Message);
            }

        }

        private void writeValue_Click(object sender, EventArgs e)
        {
            try
            {
                short iData = Convert.ToInt16(portValue.Text, 16);
                AplexOS7116GPIO.setPinsVal(iData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured:\n" + ex.Message);
            }

        }

        private void readPin_Click(object sender, EventArgs e)
        {
            try
            {
                char c = (char)0;
                if (pinMode.Text.Trim() == "1")
                {
                    AplexOS7116GPIO.setPinMode(AplexOS7116GPIO.hexStrToNum(pinNum.Text), 1);
                    c = AplexOS7116GPIO.getPinVal(AplexOS7116GPIO.hexStrToNum(pinNum.Text));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured:\n" + ex.Message);
            }

        }

        private void writePin_Click(object sender, EventArgs e)
        {
            try
            {
                char c = (char)0;
                if (pinMode.Text.Trim() == "0")
                {
                    AplexOS7116GPIO.setPinMode(AplexOS7116GPIO.hexStrToNum(pinNum.Text), 0);
                    AplexOS7116GPIO.setPinVal(AplexOS7116GPIO.hexStrToNum(pinNum.Text.Trim()), AplexOS7116GPIO.hexStrToNum(pinValue.Text.Trim()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured:\n" + ex.Message);
            }

        }
    }
}