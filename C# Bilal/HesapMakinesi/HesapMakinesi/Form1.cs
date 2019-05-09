using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        int sayi = 0;
        string islem = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            inp.Text += "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            inp.Text += "1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            inp.Text += "2";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            inp.Text += "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            inp.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            inp.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            inp.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inp.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inp.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inp.Text += "9";
        }

        private void toplama(object sender, EventArgs e)
        {
            int s = int.Parse(inp.Text);
            sayi = s;
            islem = "+";
            inp.Text = "";
        }

        private void cikarma(object sender, EventArgs e)
        {
            int s = int.Parse(inp.Text);
            sayi = s;
            islem = "-";
            inp.Text = "";
        }

        private void carpma(object sender, EventArgs e)
        {
            int s = int.Parse(inp.Text);
            sayi = s;
            islem = "*";
            inp.Text = "";
        }

        private void bolme(object sender, EventArgs e)
        {
            int s = int.Parse(inp.Text);
            sayi = s;
            islem = "/";
            inp.Text = "";
        }

        private void esittir(object sender, EventArgs e)
        {
            int s = int.Parse(inp.Text);
            int sonuc = 0;
            switch (islem)
            {
                case "+":
                    sonuc = s + sayi;
                    break;
                case "-":
                    sonuc = s - sayi;
                    break;
                case "*":
                    sonuc = s * sayi;
                    break;
                case "/":
                    if (s != 0)
                    {
                        sonuc = s / sayi;
                    }
                    break;
                default:
                    break;
            }
            inp.Text = sonuc+"";
        }

        private void temizle(object sender, EventArgs e)
        {
            inp.Text = "";
            sayi = 0;
            islem = "";
        }
    }
}
