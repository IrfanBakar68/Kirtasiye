using Nest;
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
    public partial class Kisiler : Form
    {
        public Kisiler()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost;port=5432; User Id = postgres; Password=postgres; Database=Kirtasiye");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtKisiNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TxtAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            TxtKisiTur.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            TxtCinsiyet.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String query = "SELECT * FROM public.kisi";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            String query = "INSERT INTO public.kisi(kisino,ad,soyad,kisitur,cinsiyet) values(@p1,@p2,@p3,@p4,@p5)";
            NpgsqlCommand cmd = new NpgsqlCommand(query, baglanti);
            cmd.Parameters.AddWithValue("@p1", int.Parse(TxtKisiNo.Text));
            cmd.Parameters.AddWithValue("@p2", TxtAdi.Text);
            cmd.Parameters.AddWithValue("@p3", TxtSoyad.Text);
            cmd.Parameters.AddWithValue("@p4", TxtKisiTur.Text);
            cmd.Parameters.AddWithValue("@p5", TxtCinsiyet.Text);

            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme Başarılı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sil = "DELETE FROM public.kisi WHERE kisino=@p1";
            NpgsqlCommand cmd = new NpgsqlCommand(sil, baglanti);
            cmd.Parameters.AddWithValue("@p1", int.Parse(TxtKisiNo.Text));
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme Başarılı");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string guncelle = "UPDATE public.kisi set ad=@p1, soyad=@p2 ,kisitur=@p3,cinsiyet=@p4 where kisino = @p1";


            NpgsqlCommand cmd = new NpgsqlCommand(guncelle, baglanti);

            cmd.Parameters.AddWithValue("@p1", int.Parse(TxtKisiNo.Text));
            cmd.Parameters.AddWithValue("@p2", TxtAdi.Text);
            cmd.Parameters.AddWithValue("@p3", TxtSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", TxtKisiTur.Text);
            cmd.Parameters.AddWithValue("@p4", TxtCinsiyet.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme Başarılı");
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
                try
                {
                    baglanti.Open();

                    // PostgreSQL sorgusu
                    string query = "SELECT ad, soyad, kisitur, cinsiyet FROM public.kisi WHERE kisino = @arananKisiNo";

                    // NpgsqlCommand ve NpgsqlParameter kullanarak sorguyu oluştur
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, baglanti))
                    {
                        cmd.Parameters.AddWithValue("@arananKisiNo", int.Parse(TxtKisiNo.Text));

                        // NpgsqlDataReader kullanarak verileri oku
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                // Verileri işleyin veya görüntüleyin
                                while (reader.Read())
                                {
                                    TxtAdi.Text = reader["ad"].ToString();
                                    TxtSoyad.Text = reader["soyad"].ToString();
                                    TxtKisiTur.Text = reader["kisitur"].ToString();
                                    TxtCinsiyet.Text = reader["cinsiyet"].ToString();

                                    // Verileri kullanarak istediğiniz işlemleri yapabilirsiniz
                                    MessageBox.Show($"Ad: {TxtAdi.Text}, Soyad: {TxtSoyad.Text}, Tür: {TxtKisiTur.Text}, Cinsiyet: {TxtCinsiyet.Text}");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Belirtilen kisino ile eşleşen veri bulunamadı.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
            }

        }
    }

    


