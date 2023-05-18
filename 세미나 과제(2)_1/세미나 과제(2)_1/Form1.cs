using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 세미나_과제_2__1
{
    public partial class Form1 : Form
    {
        int[] A = new int[10];

        System.Random Rannum = new System.Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for(int i = 0; i < 10; i++)
                {
                    A[i] = Rannum.Next(1, 100);
                    label1.Text += A[i] + ", ";
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
                int max = A.Max();
                label2.Text = "가장 큰 수 : " + max;
            }
            catch(Exception ex)
            {
                label2.Text = ex.Message;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Array.Sort(A);
                label1.Text = String.Join(", ", A);
            }
            catch(Exception ex)
            {
                label2.Text = ex.Message;
            }
        }
    }
}
