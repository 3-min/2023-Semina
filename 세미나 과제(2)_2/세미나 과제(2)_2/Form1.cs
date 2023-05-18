using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 세미나_과제_2__2
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
                int num = int.Parse(textBox1.Text);

                label1.Text = "";
                for(int i = 0; i <= num; i++)
                {
                    for(int y = 0; y <= i; y++)
                    {
                        label1.Text += "*";
                    }
                    label1.Text += "\n";
                }
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(textBox1.Text);
                int i, y, k, w;

                label2.Text = "";
                for(i = 1; i <= num; i++)
                {
                    for(y = 1; y <= num - i; y++)
                    {
                        label2.Text += " ";
                    }
                    for(k = 1; k <= 2 * i - 1; k++)
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
    }
}
