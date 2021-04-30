using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelOrnegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult yazdir;
            yazdir = printDialog1.ShowDialog();
            if (yazdir == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void yeniFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form();

            form.Text = "Yeni Form";
            form.Show();
        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void içerikDüzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
        }

        private void renkdegis(object sender, EventArgs e)
        {
            switch (toolStripComboBox1.SelectedIndex)
            {
                case 0:
                    textBox1.ForeColor = Color.Red;
                    break;
                case 1:
                    textBox1.ForeColor = Color.Green;
                    break;
                case 2:
                    textBox1.ForeColor = Color.Blue;
                    break;
            }
        }

        private void sitildegis(object sender, EventArgs e)
        {
            FontStyle font = FontStyle.Regular;
            switch (toolStripComboBox2.SelectedIndex)
            {
                case 0:
                    font = FontStyle.Bold;
                    break;
                case 1:
                    font = FontStyle.Underline;
                    break;
                case 2:
                    font = FontStyle.Italic;
                    break;
            }
            textBox1.Font = new Font(textBox1.Font.Name, textBox1.Font.Size, textBox1.Font.Style ^ font);
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.Name, textBox1.Font.Size*2, textBox1.Font.Style);
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.Name, textBox1.Font.Size/2, textBox1.Font.Style);
        }

        private void gonder_Click(object sender, EventArgs e)
        {
            string adi = ad.Text;
            string telefonu = telefon.Text;
            string mesaji = mesaj.Text;

            if (adi == "")
            {
                MessageBox.Show("Ad alanı boş bırakılamaz");
            }
            else if (telefonu == "")
            {
                MessageBox.Show("Telefon alanı boş bırakılamaz");
            }
            else if (mesaji == "")
            {
                MessageBox.Show("Mesaj alanı boş bırakılamaz");
            }
            else
            {
                MessageBox.Show("Mesaj gönderildi.");
            }
        }
    }
}
