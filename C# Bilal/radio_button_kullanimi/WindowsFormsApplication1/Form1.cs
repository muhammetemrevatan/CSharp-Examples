using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            double sayi1 = double.Parse(textBox1.Text);
            double sayi2 = double.Parse(textBox2.Text);
            if(radioButton1.Checked)
            {
                label1.Visible = Visible;
                label1.Text = (sayi1 + sayi2) +"";
            }
            else if (radioButton2.Checked)
            {
                label1.Visible = Visible;
                label1.Text = (sayi1 - sayi2) + "";
            }
            else if (radioButton3.Checked)
            {
                label1.Visible = Visible;
                label1.Text = (sayi1 * sayi2) + "";
            }
            else if (radioButton4.Checked)
            {
                label1.Visible = Visible;
                if (sayi2 != 0)
                {
                    label1.Text = (sayi1 / sayi2) + "";
                }
                else
                {
                    MessageBox.Show("Bölen sıfır olamaz.");
                    textBox2.Text = "";
                }
            }
            else
            {
                label1.Visible = false;
                MessageBox.Show("İşlem seçiniz.");
            }
        }
    }
}
