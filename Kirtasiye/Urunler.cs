using Npgsql;
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
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost;port=5432; User Id = postgres; Password=postgres; Database=Kirtasiye");

        private void button1_Click(object sender, EventArgs e)
        {
            String query = "SELECT * FROM public.urunler";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtUrunNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TxtUrunTipi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TxtStok.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            TxtFytSatis.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            TxtFytAlis.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            TxtUrunAdedi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            TxtRafNo.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            String query = "INSERT INTO public.urunler(urunno,uruntipi,stok,fiyatsatis,fiyatalis,urunadedi,rafno) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)";

            NpgsqlCommand cmd = new NpgsqlCommand(query, baglanti);
            cmd.Parameters.AddWithValue("@p1", int.Parse(TxtUrunNo.Text));
            cmd.Parameters.AddWithValue("@p2", TxtUrunTipi.Text);
            cmd.Parameters.AddWithValue("@p3", int.Parse(TxtStok.Text));
            cmd.Parameters.AddWithValue("@p4", int.Parse(TxtFytSatis.Text));
            cmd.Parameters.AddWithValue("@p5", int.Parse(TxtFytAlis.Text));
            cmd.Parameters.AddWithValue("@p6", int.Parse(TxtUrunAdedi.Text));
            cmd.Parameters.AddWithValue("@p7", int.Parse(TxtRafNo.Text));

            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme Başarılı");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sil = "DELETE FROM public.urunler WHERE urunno=@p1";
            NpgsqlCommand cmd = new NpgsqlCommand(sil, baglanti);
            cmd.Parameters.AddWithValue("@p1", int.Parse(TxtUrunNo.Text));
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme Başarılı");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string guncelle = "UPDATE public.urunler set uruntipi=@p2, stok=@p3,fiyatsatis=@p4,fiyatalis=@p5,urunadedi=@p6,rafno=@p7" +
                " where urunno = @p1";


            NpgsqlCommand cmd = new NpgsqlCommand(guncelle, baglanti);

            cmd.Parameters.AddWithValue("@p1", int.Parse(TxtUrunNo.Text));
            cmd.Parameters.AddWithValue("@p2", TxtUrunTipi.Text);
            cmd.Parameters.AddWithValue("@p3", int.Parse(TxtStok.Text));
            cmd.Parameters.AddWithValue("@p4", int.Parse(TxtFytSatis.Text));
            cmd.Parameters.AddWithValue("@p5", int.Parse(TxtFytAlis.Text));
            cmd.Parameters.AddWithValue("@p6", int.Parse(TxtUrunAdedi.Text));
            cmd.Parameters.AddWithValue("@p7", int.Parse(TxtRafNo.Text));
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme Başarılı");
        }
    }
}
