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
        }

        int l0 = 0, l1 = 0, l2 = 0, l3 = 0, l4 = 0, l5 = 0, l6 = 0;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
                if (l6 == 0)
                {
                    byte[] chr = new byte[] { 24 };
                    serialPort1.Write(chr, 0, 1);
                    l6++;
                }
                else
                {

                    serialPort1.Write("0");
                    l6--;
                }
        }
        private void button4_Click(object sender, EventArgs e)
        {
                if (l0 == 0)
                {
                    serialPort1.Write("2");
                    l0++;
                }
                else
                {
                    serialPort1.Write("0");
                    l0--;
                }   
        }

        private void button5_Click(object sender, EventArgs e)
        {
                if (l1 == 0)
                {
                    serialPort1.Write("4");
                    l1++;
                }
                else
                {
                    serialPort1.Write("0");
                    l1--;
                }
        }

        private void button6_Click(object sender, EventArgs e)
        {
                if (l2 == 0)
                {
                    serialPort1.Write("7");
                    l2++;
                }
                else
                {
                    serialPort1.Write("0");
                    l2--;
                }
        }

        private void button7_Click(object sender, EventArgs e)
        {
                if (l3 == 0)
                {
                    serialPort1.Write("5");
                    l3++;
                }
                else
                {
                    serialPort1.Write("0");
                    l3--;
                }
        }
    }
}
