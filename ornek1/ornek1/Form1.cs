using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ornek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglantim = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Application.StartupPath+"\\sözlük.mdb");


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglantim.Open();

            OleDbCommand eklekomutu = new OleDbCommand("Insert into IngTurk(türkce,ingilizce) values('" + textBox1.Text + "','" + textBox2.Text + "')", baglantim);
            eklekomutu.ExecuteNonQuery();
            baglantim.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglantim.Open();

            OleDbCommand silkomutu = new OleDbCommand("DELETE FROM IngTurk WHERE ingilizce = '" + textBox1.Text + "' " , baglantim);
            silkomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglantim.Open();

            OleDbCommand güncellekomutu = new OleDbCommand("UPDATE IngTurk SET türkce = '"+textBox2.Text+"' WHERE ingilizce like '" + textBox1.Text + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }
    }
}
