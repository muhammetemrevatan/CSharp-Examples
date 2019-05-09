using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ekle(string tc, string ad, string yas, string ogr_durum, string cinsiyet, string telefon)
        {
            string[] bilgiler = new string[6];

            string nul = "";
            if (
                string.IsNullOrEmpty(tc)
                ||
                string.IsNullOrEmpty(ad)
                ||
                string.IsNullOrEmpty(yas)
                ||
                string.IsNullOrEmpty(ogr_durum)
                ||
                string.IsNullOrEmpty(cinsiyet)
                ||
                string.IsNullOrEmpty(telefon)
                )
            {
                MessageBox.Show("Boş alan bırakmayın!");
            }
            else
            {
                bilgiler[0] = tc;
                bilgiler[1] = ad;
                bilgiler[2] = yas;
                bilgiler[3] = ogr_durum;
                bilgiler[4] = cinsiyet;
                bilgiler[5] = telefon;

                ListViewItem kayit = new ListViewItem(bilgiler);
                listView1.Items.Add(kayit);
            }
        }

        public bool kontrol(string tc)
        {
            bool retVal = false;

            var liste = listView1.Items;
            for (int i = 0; i < liste.Count; i++)
            {
                var item = liste[i];
                if (item.SubItems[0].Text == tc)
                {
                    retVal = true;
                    break;
                }
            }

            return retVal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tc = txt_tc.Text;
            string adSoyad = txt_ad.Text;
            string yas = txt_yas.Text;
            string ogr_durum = cb_durum.SelectedItem?.ToString();
            string cinsiyet = radioButton1.Checked ? "Bay" : "Bayan";
            string tel = txt_tel.Text;

            if (kontrol(tc))
            {
                MessageBox.Show("Aynı eleman eklenmiş.");
            }
            else
            {
                ekle(tc, adSoyad, yas, ogr_durum, cinsiyet, tel);
                kayit_sayi.Text = listView1.Items.Count.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var secilen = listView1.SelectedItems[0];
                listView1.Items.Remove(secilen);

                kayit_sayi.Text = listView1.Items.Count.ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                item.Remove();
            }

            kayit_sayi.Text = listView1.Items.Count.ToString();
        }
    }
}
