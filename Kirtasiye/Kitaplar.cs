using Microsoft.Graph;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Web.Mvc.Controls;
using Nest;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Kirtasiye
{
    public partial class Kitaplar : Form
    {
        public Kitaplar()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost;port=5432; User Id = postgres; Password=postgres; Database=Kirtasiye");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtKitapNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TxtIsbn.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TxtSayfaSayisi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String query = "SELECT * FROM public.kitap";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            String query = "INSERT INTO public.kitap(kitapno,isbn,sayfasayisi) values(@p1,@p2,@p3)";
            NpgsqlCommand cmd = new NpgsqlCommand(query, baglanti);
            cmd.Parameters.AddWithValue("@p1", int.Parse(TxtKitapNo.Text));
            cmd.Parameters.AddWithValue("@p2", TxtIsbn.Text);
            cmd.Parameters.AddWithValue("@p3", TxtSayfaSayisi.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme Başarılı");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sil = "DELETE FROM public.kitap WHERE kitapno=@p1";
            NpgsqlCommand cmd = new NpgsqlCommand(sil, baglanti);
            cmd.Parameters.AddWithValue("@p1", int.Parse(TxtKitapNo.Text));
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme Başarılı");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string guncelle = "UPDATE public.kitap set isbn=@p1, sayfasayisi=@p2 where kitapno = @p3";


   NpgsqlCommand cmd = new NpgsqlCommand(guncelle, baglanti);
            
            cmd.Parameters.AddWithValue("@p1", TxtIsbn.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSayfaSayisi.Text); 
            cmd.Parameters.AddWithValue("@p3", int.Parse(TxtKitapNo.Text));
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme Başarılı");
        }

       
                }
            }
            

        
    

