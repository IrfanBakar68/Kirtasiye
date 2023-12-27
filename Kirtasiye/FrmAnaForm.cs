using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kirtasiye
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kitaplar fr = new Kitaplar();
            fr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Oyuncaklar fr = new Oyuncaklar();
            fr.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KirtasiyeUrunleri fr = new KirtasiyeUrunleri();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Urunler fr = new Urunler();
            fr.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            IletisimBilgileri fr = new IletisimBilgileri();
            fr.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Kisiler fr = new Kisiler();
            fr.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Personeller fr = new Personeller();
            fr.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Musteriler fr = new Musteriler();
            fr.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Siparisler fr = new Siparisler();
            fr.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Musterics fr = new Musterics();
            fr.Show();
            this.Hide();
        }
    }
    }

