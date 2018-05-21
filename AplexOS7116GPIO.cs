using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace InpOut32.CSharp.Net
{
    class AplexOS7116GPIO
    {
        /**
         * 加载dll相关处理函数
         */
        [DllImport("inpout32.dll")]
        public static extern UInt32 IsInpOutDriverOpen();
        [DllImport("inpout32.dll")]
        public static extern void Out32(short PortAddress, short Data);
        [DllImport("inpout32.dll")]
        public static extern char Inp32(short PortAddress);

        [DllImport("inpout32.dll")]
        public static extern void DlPortWritePortUshort(short PortAddress, ushort Data);
        [DllImport("inpout32.dll")]
        public static extern ushort DlPortReadPortUshort(short PortAddress);

        [DllImport("inpout32.dll")]
        public static extern void DlPortWritePortUlong(int PortAddress, uint Data);
        [DllImport("inpout32.dll")]
        public static extern uint DlPortReadPortUlong(int PortAddress);

        [DllImport("inpoutx64.dll")]
        public static extern bool GetPhysLong(ref int PortAddress, ref uint Data);
        [DllImport("inpoutx64.dll")]
        public static extern bool SetPhysLong(ref int PortAddress, ref uint Data);


        [DllImport("inpoutx64.dll", EntryPoint = "IsInpOutDriverOpen")]
        public static extern UInt32 IsInpOutDriverOpen_x64();
        [DllImport("inpoutx64.dll", EntryPoint = "Out32")]
        public static extern void Out32_x64(short PortAddress, short Data);
        [DllImport("inpoutx64.dll", EntryPoint = "Inp32")]
        public static extern char Inp32_x64(short PortAddress);

        [DllImport("inpoutx64.dll", EntryPoint = "DlPortWritePortUshort")]
        public static extern void DlPortWritePortUshort_x64(short PortAddress, ushort Data);
        [DllImport("inpoutx64.dll", EntryPoint = "DlPortReadPortUshort")]
        public static extern ushort DlPortReadPortUshort_x64(short PortAddress);

        [DllImport("inpoutx64.dll", EntryPoint = "DlPortWritePortUlong")]
        public static extern void DlPortWritePortUlong_x64(int PortAddress, uint Data);
        [DllImport("inpoutx64.dll", EntryPoint = "DlPortReadPortUlong")]
        public static extern uint DlPortReadPortUlong_x64(int PortAddress);

        [DllImport("inpoutx64.dll", EntryPoint = "GetPhysLong")]
        public static extern bool GetPhysLong_x64(ref int PortAddress, ref uint Data);
        [DllImport("inpoutx64.dll", EntryPoint = "SetPhysLong")]
        public static extern bool SetPhysLong_x64(ref int PortAddress, ref uint Data);

        private static bool m_bX64 = false;

        public static short OUTPUT = 0;
        public static short INPUT = 1;

        public static short hexStrToNum(string str)
        {
            return Convert.ToInt16(str, 16);
        }

        public static uint initInpOut32Lib()
        {
            uint nResult = 0;

            try
            {
                try
                {
                    // 打开32位驱动，如果失败了，会引发异常，再加载64位驱动
                    nResult = AplexOS7116GPIO.IsInpOutDriverOpen();

                    Console.WriteLine("nResult1: " + nResult);
                }
                catch (BadImageFormatException)
                {
                    Console.WriteLine("nResult2: " + nResult);
                    nResult = AplexOS7116GPIO.IsInpOutDriverOpen_x64();
                    if (nResult != 0)
                        m_bX64 = true;

                    Console.WriteLine("nResult2: " + nResult);

                }

                return nResult;
            }
            catch (DllNotFoundException ex)         // dll查找是失败异常
            {
                return nResult;
            }
        }

        public static char readByte(short iPort)
        {
            char c = (char)0;

            try
            {
                if (m_bX64)
                    c = Inp32_x64(iPort);
                else
                    c = Inp32(iPort);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured:\n" + ex.Message);
            }
            return c;
        }

        public static void writeByte(short iPort, short iData)
        {
            try
            {
                if (m_bX64)
                    Out32_x64(iPort, iData);
                else
                    Out32(iPort, iData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured:\n" + ex.Message);
            }
        }

        public static void initGPIO()
        {
            try
            {
                writeByte(hexStrToNum("2e"), hexStrToNum("87"));
                writeByte(hexStrToNum("2e"), hexStrToNum("87"));

                writeByte(hexStrToNum("2e"), hexStrToNum("07"));
                writeByte(hexStrToNum("2f"), hexStrToNum("07"));

                writeByte(hexStrToNum("2e"), hexStrToNum("1C"));
                writeByte(hexStrToNum("2f"), hexStrToNum("1C"));

                writeByte(hexStrToNum("2e"), hexStrToNum("30"));
                writeByte(hexStrToNum("2f"), hexStrToNum("DF"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("init GPIO, An error occured:\n" + ex.Message);
            }
        }

        public static void freeGPIO()
        {
            try
            {
                writeByte(hexStrToNum("2e"), hexStrToNum("AA"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured:\n" + ex.Message);
            }
        }

        public static void setPinsMode(short iData)
        {
            try
            {
                writeByte(hexStrToNum("2e"), hexStrToNum("E8"));
                writeByte(hexStrToNum("2f"), iData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured:\n" + ex.Message);
            }
        }

        public static char getPinsMode()
        {
            char c = (char)0;
            try
            {
                writeByte(hexStrToNum("2e"), hexStrToNum("E8"));
                c = readByte(hexStrToNum("2f"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured:\n" + ex.Message);
            }

            return c;
        }

        public static char getPinMode(short pin)
        {
            char c = (char)0;
            try
            {
                writeByte(hexStrToNum("2e"), hexStrToNum("E8"));
                c = readByte(hexStrToNum("2f"));

                return (char)((c >> pin) & 0x01);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured:\n" + ex.Message);
            }

            return c;
        }

        public static void setPinMode(short pin, short mode)
        {
            try
            {
                short c = (short)getPinsMode();
                if (mode == OUTPUT)
                {
                    c = (short)(c & (~(1 << pin)));
                }
                else if (mode == INPUT) 
                {
                    c = (short)(c | (1 << pin));
                }
                setPinsMode(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured:\n" + ex.Message);
            }
        }

        public static void setPinsVal(short iData)
        {
            try
            {
                writeByte(hexStrToNum("2e"), hexStrToNum("E9"));
                writeByte(hexStrToNum("2f"), iData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured:\n" + ex.Message);
            }
        }

        public static char getPinsVal()
        {
            char c = (char)0;
            try
            {
                writeByte(hexStrToNum("2e"), hexStrToNum("E9"));
                c = readByte(hexStrToNum("2f"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured:\n" + ex.Message);
            }

            return c;
        }

        public static char getPinVal(short pin)
        {
            char c = (char)0;
            try
            {
                writeByte(hexStrToNum("2e"), hexStrToNum("E9"));
                c = readByte(hexStrToNum("2f"));

                return (char)((c >> pin) & 0x01);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured:\n" + ex.Message);
            }

            return c;
        }

        public static void setPinVal(short pin, short val)
        {
            try
            {
                short c = (short)getPinsVal();
                if (val == 0)
                {
                    c = (short)(c & (~(1 << pin)));
                }
                else if (val == 1)
                {
                    c = (short)(c | (1 << pin));
                }
                setPinsVal(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured:\n" + ex.Message);
            }
        }
    }
}
