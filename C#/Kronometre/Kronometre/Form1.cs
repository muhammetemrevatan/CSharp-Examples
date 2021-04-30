using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kronometre
{
   
    public partial class Form1 : Form
    {
        static int saniye2 = 0,
                    dakika2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = saniye2;
            progressBar2.Value = dakika2;

            saniye.Text = saniye2+"";
            dakika.Text = dakika2+"";

            saniye2++;
            if (saniye2 >= 59)
            {
                saniye2 = 0;
                dakika2++;
            }
        }
    }
}
