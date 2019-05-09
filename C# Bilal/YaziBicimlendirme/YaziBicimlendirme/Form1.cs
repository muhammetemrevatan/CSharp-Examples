using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YaziBicimlendirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            metin_alani.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(metin_alani.Text);
        }

        private void kalin_CheckedChanged(object sender, EventArgs e)
        {
            metin_alani.Font = new Font(metin_alani.Font.Name, metin_alani.Font.Size, metin_alani.Font.Style ^ FontStyle.Bold);
        }

        private void alti_cizili_CheckedChanged(object sender, EventArgs e)
        {
            metin_alani.Font = new Font(metin_alani.Font.Name, metin_alani.Font.Size, metin_alani.Font.Style ^ FontStyle.Underline);
        }

        private void italik_CheckedChanged(object sender, EventArgs e)
        {
            metin_alani.Font = new Font(metin_alani.Font.Name, metin_alani.Font.Size, metin_alani.Font.Style ^ FontStyle.Italic);
        }

        private void font_arttir_Click(object sender, EventArgs e)
        {
            metin_alani.Font = new Font(metin_alani.Font.Name, metin_alani.Font.Size*2, metin_alani.Font.Style);
        }

        private void sol_CheckedChanged(object sender, EventArgs e)
        {
            metin_alani.TextAlign = HorizontalAlignment.Left;
        }

        private void orta_CheckedChanged(object sender, EventArgs e)
        {
            metin_alani.TextAlign = HorizontalAlignment.Center;
        }

        private void sag_CheckedChanged(object sender, EventArgs e)
        {
            metin_alani.TextAlign = HorizontalAlignment.Right;
        }

        private void kirmizi_Click(object sender, EventArgs e)
        {
            metin_alani.ForeColor = Color.Red;
        }

        private void mavi_Click(object sender, EventArgs e)
        {
            metin_alani.ForeColor = Color.Blue;
        }

        private void pembe_Click(object sender, EventArgs e)
        {
            metin_alani.ForeColor = Color.Pink;
        }

        private void font_azalt_Click(object sender, EventArgs e)
        {
            metin_alani.Font = new Font(metin_alani.Font.Name, metin_alani.Font.Size / 2, metin_alani.Font.Style);
        }
    }
}
