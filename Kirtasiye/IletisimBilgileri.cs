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
    public partial class IletisimBilgileri : Form
    {
        public IletisimBilgileri()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost;port=5432; User Id = postgres; Password=postgres; Database=Kirtasiye");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtIletisimNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TxtTelefon.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TxtKisiNo.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String query = "SELECT * FROM public.iletisimbilgi";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            String query = "INSERT INTO public.iletisimbilgi(iletisimno,telefon,kisino) values(@p1,@p2,@p3)";
            NpgsqlCommand cmd = new NpgsqlCommand(query, baglanti);
            cmd.Parameters.AddWithValue("@p1", int.Parse(TxtIletisimNo.Text));
            cmd.Parameters.AddWithValue("@p2", TxtTelefon.Text);
            cmd.Parameters.AddWithValue("@p3", int.Parse(TxtKisiNo.Text));
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme Başarılı");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sil = "DELETE FROM public.iletisimbilgi WHERE iletisimno=@p1";
            NpgsqlCommand cmd = new NpgsqlCommand(sil, baglanti);
            cmd.Parameters.AddWithValue("@p1", int.Parse(TxtIletisimNo.Text));
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme Başarılı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string guncelle = "UPDATE public.iletisimbilgi set telefon=@p1, kisino=@p2 where iletisimno = @p3";


            NpgsqlCommand cmd = new NpgsqlCommand(guncelle, baglanti);

            cmd.Parameters.AddWithValue("@p1", TxtTelefon.Text);
            cmd.Parameters.AddWithValue("@p2", int.Parse(TxtKisiNo.Text));
            cmd.Parameters.AddWithValue("@p3", int.Parse(TxtIletisimNo.Text));
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme Başarılı");
        }
    }
}
