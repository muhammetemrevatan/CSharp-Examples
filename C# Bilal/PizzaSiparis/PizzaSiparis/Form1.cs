using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaSiparis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = ad_edt.Text;
            string telefon = telefon_edt.Text;
            string adres = adres_edt.Text;

            string secim = "";

            if (ad == "")
            {
                MessageBox.Show("Ad alanı boş geçilemez!");
            }
            else if (telefon == "")
            {
                MessageBox.Show("Telefon alanı boş geçilemez!");
            }
            else if (adres == "")
            {
                MessageBox.Show("Adres alanı boş geçilemez!");
            }
            else if (boy_secim.SelectedItem == null)
            {
                MessageBox.Show("Boy seçimi boş geçilemez!");
            }
            else
            {
                secim = boy_secim.SelectedItem.ToString();

                sayin.Text = "Sayın: " + ad;
                pizza_boyutu.Text = secim;

                string items = "";
                foreach (var item in liste.Items)
                {
                    items += item + " ";
                }
                ekstralar.Text = "Ekstralar: " + items;

                panel2.Visible = true;

            }
        }

        public void listeEkle(CheckBox e)
        {
            if (e.Checked)
            {
                liste.Items.Add(e.Text);
            }
            else
            {
                liste.Items.Remove(e.Text);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            listeEkle(checkBox2);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            listeEkle(checkBox4);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            listeEkle(checkBox3);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            listeEkle(checkBox5);
        }
    }
}
