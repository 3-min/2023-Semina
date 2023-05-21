using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 삭제
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int rows = int.Parse(textBox1.Text);

                int i, y;
                label1.Text = "";
                for(i=1; i <= rows; i++)
                {
                    for(y=1; y<=i; y++)
                    {
                        label1.Text += "*";
                    }
                    label1.Text += "\n";
                }
               
            }
            catch(Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int rows = int.Parse(textBox1.Text);

                int i, y;
                label2.Text = "";
                
                for(i = 1; i <= rows; i++)
                {
                    for(y = 1; y <= (rows - i); y++)
                    {
                        label2.Text += " ";
                    }
                    for(y = 1; y <= (i * 2 - 1); y++)
                    {
                        label2.Text += "*";
                    }
                    label2.Text += "\n";
                }
            }
            catch(Exception ex)
            {
                label2.Text = ex.Message;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int rows = int.Parse(textBox1.Text);

                int i, y;
                label4.Text = "";

                for(i = 1; i <= rows; i++)
                {
                    for(y = 1; y <= (rows-i); y++)
                    {
                        label4.Text += " ";
                    }
                    for(y = 1; y <= i; y++)
                    {
                        label4.Text += "*";
                    }
                    label4.Text += "\n";
                }
            }
            catch(Exception ex)
            {
                label3.Text = ex.Message;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int rows = int.Parse(textBox1.Text);
                int i, y;

                label3.Text = "";
                for(i = 1; i <= rows; i++)
                {
                    for(y = 1; y <= rows - i; y++)
                    {
                        label3.Text += " ";
                    }
                    for(y = 1; y <= (i * 2 - 1); y++)
                    {
                        label3.Text += "*";
                    }
                    label3.Text += "\n";
                }
                for(i = 1; i <= rows; i++)//아래 피라미드
                {
                    for(y = 1; y <= i - 1; y++)
                    {
                        label3.Text += " ";
                    }
                    for (y = rows; y >= 1; y--)
                    {
                        label3.Text += "*";
                    }
                    rows = rows - 2;
                    label3.Text += "\n";
                }
            }
            catch(Exception ex)
            {
                label3.Text = ex.Message;
            }
        }
    }
}
