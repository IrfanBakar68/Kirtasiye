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
    public partial class Siparisler : Form
    {
        public Siparisler()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost;port=5432; User Id = postgres; Password=postgres; Database=Kirtasiye");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtSiparisNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TxtToplamTutar.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TxtFaturaNo.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            TxtMusteriNo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            TxtPersonelNo.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String query = "SELECT * FROM public.siparis";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            String query = "INSERT INTO public.siparis(siparisno,toplamtutar,faturano,musterino,personelno) values(@p1,@p2,@p3,@p4,@p5)";
            NpgsqlCommand cmd = new NpgsqlCommand(query, baglanti);
            cmd.Parameters.AddWithValue("@p1", int.Parse(TxtSiparisNo.Text));
            cmd.Parameters.AddWithValue("@p2", int.Parse(TxtToplamTutar.Text));
            cmd.Parameters.AddWithValue("@p3", int.Parse(TxtFaturaNo.Text));
            cmd.Parameters.AddWithValue("@p4", int.Parse(TxtMusteriNo.Text));
            cmd.Parameters.AddWithValue("@p5", int.Parse(TxtPersonelNo.Text));

            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme Başarılı");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sil = "DELETE FROM public.siparis WHERE siparisno=@p1";
            NpgsqlCommand cmd = new NpgsqlCommand(sil, baglanti);
            cmd.Parameters.AddWithValue("@p1", int.Parse(TxtSiparisNo.Text));
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme Başarılı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string guncelle = "UPDATE public.siparis set toplamtutar=@p1, faturano=@p2,musterino=@p3,personelno=@p4 where siparisno = @p5";


            NpgsqlCommand cmd = new NpgsqlCommand(guncelle, baglanti);

            cmd.Parameters.AddWithValue("@p5", int.Parse(TxtSiparisNo.Text));
            cmd.Parameters.AddWithValue("@p1", int.Parse(TxtToplamTutar.Text));
            cmd.Parameters.AddWithValue("@p2", int.Parse(TxtFaturaNo.Text));
            cmd.Parameters.AddWithValue("@p3", int.Parse(TxtMusteriNo.Text));
            cmd.Parameters.AddWithValue("@p4", int.Parse(TxtPersonelNo.Text));
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme Başarılı");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                // TextBox'tan gelen değeri al
                string arananSiparisNo = TxtSiparisNo.Text;

                // PostgreSQL sorgusu
                string query = "SELECT * FROM public.siparis WHERE siparisno = @arananSiparisNo";

                // NpgsqlCommand ve NpgsqlParameter kullanarak sorguyu oluştur
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, baglanti))
                {
                    cmd.Parameters.AddWithValue("@arananSiparisNo", int.Parse(arananSiparisNo));

                    // NpgsqlDataReader kullanarak verileri oku
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Verileri işleyin veya görüntüleyin
                            string toplamTutar = reader["toplamtutar"].ToString();
                            string faturaNo = reader["faturano"].ToString();
                            string musteriNo = reader["musterino"].ToString();
                            string personelNo = reader["personelno"].ToString();

                            // Verileri kullanarak istediğiniz işlemleri yapabilirsiniz
                            Console.WriteLine($"Toplam Tutar: {toplamTutar}, Fatura No: {faturaNo}, Müşteri No: {musteriNo}, Personel No: {personelNo}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

    }
}
