using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Data.SqlTypes;

namespace ConsoleApp3
{
    public partial class FormĐkXeRobot : Form
    {
        public FormĐkXeRobot()
        {
            InitializeComponent();
            string[] Baudrate = { "1200", "2400", "4800", "9600", "115200" };
            comboBox2.Items.AddRange(Baudrate);
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        int l0 = 0, l2 = 0, l4 = 0, l5 = 0, l7 = 0, l9 = 0, l10 = 0;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGoAhead_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (l2 == 0)
                {
                    serialPort1.Write("2");
                    l2++;
                }
                else
                {
                    serialPort1.Write("0");
                    l2--;
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa kết nối cổng Port");
            }
        }

        private void btnGoRight_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (l5 == 0)
                {
                    serialPort1.Write("5");
                    l5++;
                }
                else
                {
                    serialPort1.Write("0");
                    l5--;
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa kết nối cổng Port");
            }
        }


        private void btnGoLeft_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (l4 == 0)
                {
                    serialPort1.Write("4");
                    l4++;
                }
                else
                {
                    serialPort1.Write("0");
                    l4--;
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa kết nối cổng Port");
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (l7 == 0)
                {
                    serialPort1.Write("7");
                    l7++;
                }
                else
                {
                    serialPort1.Write("0");
                    l7--;
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa kết nối cổng Port");
            }
        }

        private void btnXoayPhai_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (l10 == 0)
                {
                    byte[] chr = new byte[] { 10 };
                    serialPort1.Write(chr, 0, 1);
                    l10++;
                }
                else
                {

                    serialPort1.Write("0");
                    l10--;
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa kết nối cổng Port");
            }
        }

        private void btnXoayTrai_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (l9 == 0)
                {
                    serialPort1.Write("9");
                    l9++;
                }
                else
                {
                    serialPort1.Write("0");
                    l9--;
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa kết nối cổng Port");
            }
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (l24 == 0)
                {
                    byte[] chr = new byte[] { 24 };
                    serialPort1.Write(chr, 0, 1);
                    l24++;
                }
                else
                {

                    serialPort1.Write("0");
                    l24--;
                }


            }
            else
            {
                MessageBox.Show("Bạn chưa kết nối cổng Port");
            }
        }

        private void btnUltra_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (l26 == 0)
                {
                    byte[] chr = new byte[] { 26 };
                    serialPort1.Write(chr, 0, 1);
                    l26++;
                }
                else
                {
                    serialPort1.Write("0");
                    l26--;
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa kết nối cổng Port");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            luu++;
            lblSave.Text = luu.ToString();
        }

        private void btnnReset_Click(object sender, EventArgs e)
        {
            lblSave.Text = "0";
        }

        private void btnS1Trai_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (l16 == 0)
                {
                    byte[] chr = new byte[] { 16 };
                    serialPort1.Write(chr, 0, 1);
                    l16++;
                }
                else
                {
                    byte[] chr = new byte[] { 0 };
                    serialPort1.Write(chr, 0, 1);
                    l16--;
                }


            }
            else
            {
                MessageBox.Show("Bạn chưa kết nối cổng Port");
            }
        }

        private void btnS1Phai_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (l17 == 0)
                {
                    byte[] chr = new byte[] { 17 };
                    serialPort1.Write(chr, 0, 1);
                    l17++;
                }
                else
                {
                    byte[] chr = new byte[] { 0 };
                    serialPort1.Write(chr, 0, 1);
                    l17--;
                }


            }
            else
            {
                MessageBox.Show("Bạn chưa kết nối cổng Port");
            }
        }

        private void btnS2Trai_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (l18 == 0)
                {
                    byte[] chr = new byte[] { 18 };
                    serialPort1.Write(chr, 0, 1);
                    l18++;
                }
                else
                {
                    byte[] chr = new byte[] { 0 };
                    serialPort1.Write(chr, 0, 1);
                    l18--;
                }


            }
            else
            {
                MessageBox.Show("Bạn chưa kết nối cổng Port");
            }
        }

        private void btnS2Phai_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (l19 == 0)
                {
                    byte[] chr = new byte[] { 19 };
                    serialPort1.Write(chr, 0, 1);
                    l19++;
                }
                else
                {
                    byte[] chr = new byte[] { 0 };
                    serialPort1.Write(chr, 0, 1);
                    l19--;
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa kết nối cổng Port");
            }
        }

        private void btnS3Trai_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (l20 == 0)
                {
                    byte[] chr = new byte[] { 20 };
                    serialPort1.Write(chr, 0, 1);
                    l20++;
                }
                else
                {
                    byte[] chr = new byte[] { 0 };
                    serialPort1.Write(chr, 0, 1);
                    l20--;
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa kết nối cổng Port");
            }
        }

        private void btnS3Phai_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (l21 == 0)
                {
                    byte[] chr = new byte[] { 21 };
                    serialPort1.Write(chr, 0, 1);
                    l21++;
                }
                else
                {
                    byte[] chr = new byte[] { 0 };
                    serialPort1.Write(chr, 0, 1);
                    l21--;
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa kết nối cổng Port");
            }
        }

        private void btnS4Trai_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (l22 == 0)
                {
                    byte[] chr = new byte[] { 22 };
                    serialPort1.Write(chr, 0, 1);
                    l22++;
                }
                else
                {
                    byte[] chr = new byte[] { 0 };
                    serialPort1.Write(chr, 0, 1);
                    l22--;
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa kết nối cổng Port");
            }
        }

        private void btnS4Phai_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (l23 == 0)
                {
                    byte[] chr = new byte[] { 23 };
                    serialPort1.Write(chr, 0, 1);
                    l23++;
                }
                else
                {
                    byte[] chr = new byte[] { 0 };
                    serialPort1.Write(chr, 0, 1);
                    l23--;
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa kết nối cổng Port");
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                btnConnect.Text = "DISCONNECT";
                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
                serialPort1.Open();
                lblKetNoi.ForeColor = Color.Blue;
                btnConnect.BackColor = Color.Blue;
                lblKetNoi.Text = "Đã kết nối";
            }
            else
            {
                btnConnect.Text = "CONNECT";
                serialPort1.Close();
                lblKetNoi.ForeColor = Color.Red;
                btnConnect.BackColor = Color.Red;
                lblKetNoi.Text = "Chưa kết nối";
            }
        }

        int l16 = 0, l17 = 0, l18 = 0, l19 = 0, l20 = 0, l21 = 0, l22 = 0, l23 = 0;
        int l24 = 0, l25 = 0, l26 = 0, l27 = 0;
        int luu = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormĐkXeRobot_Load_1(object sender, EventArgs e)
        {
            comboBox1.DataSource = SerialPort.GetPortNames();
            comboBox2.Text = "9600";
        }
    }
}
