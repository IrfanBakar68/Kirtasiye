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
    public partial class KirtasiyeUrunleri : Form
    {
        public KirtasiyeUrunleri()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost;port=5432; User Id = postgres; Password=postgres; Database=Kirtasiye");

        private void button1_Click(object sender, EventArgs e)
        {
            String query = "SELECT * FROM public.kirtasiyeurun";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            String query = "INSERT INTO public.kirtasiyeurun(kirtasiyeurunno,kirtasiyeurunebat) values(@p1,@p2)";
            NpgsqlCommand cmd = new NpgsqlCommand(query, baglanti);
            cmd.Parameters.AddWithValue("@p1", int.Parse(TxtKirtasiyeNo.Text));
            cmd.Parameters.AddWithValue("@p2",int.Parse(TxtKirtasiyeEbad.Text));
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme Başarılı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sil = "DELETE FROM public.kirtasiyeurun WHERE kirtasiyeurunno=@p1";
            NpgsqlCommand cmd = new NpgsqlCommand(sil, baglanti);
            cmd.Parameters.AddWithValue("@p1", int.Parse(TxtKirtasiyeNo.Text));
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme Başarılı");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string guncelle = "UPDATE public.kirtasiyeurun set kirtasiyeurunebat=@p1 where kirtasiyeurunno = @p2";


            NpgsqlCommand cmd = new NpgsqlCommand(guncelle, baglanti);

            cmd.Parameters.AddWithValue("@p1", int.Parse(TxtKirtasiyeEbad.Text));
            cmd.Parameters.AddWithValue("@p2", int.Parse(TxtKirtasiyeNo.Text));
           
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme Başarılı");
        }
    }
}
