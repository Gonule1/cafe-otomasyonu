using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace PB_Cafe
{
    public partial class Kampanya : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["PBCafe"].ConnectionString;
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataReader dr;
        SqlDataAdapter da;
        public Kampanya()
        {
            InitializeComponent();
        }

        public void getir()
        {
            string sorgu = "Select * From tbl_Kampanya";
            baglanti = new SqlConnection(connectionString);
            baglanti.Open();
            da = new SqlDataAdapter(sorgu, baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void Kampanya_Load(object sender, EventArgs e)
        {
            getir();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                string sql = "insert into tbl_Kampanya ";
                sql += "values(@ad, @baslangic, @bitis, @fiyat, @maliyet, @resim)";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@ad", tb_kampanyaAd.Text);
                cmd.Parameters.AddWithValue("@baslangic", (dateTimePicker1.Value.Date));
                cmd.Parameters.AddWithValue("@bitis", (dateTimePicker2.Value.Date));
                cmd.Parameters.AddWithValue("@fiyat", tb_kampanyaFiyat.Text);
                cmd.Parameters.AddWithValue("@maliyet", tb_kampanyaMaliyet.Text);
                cmd.Parameters.AddWithValue("@resim", tb_resimYol.Text);
                cmd.Connection = baglanti;
                baglanti.Open();
                cmd.ExecuteNonQuery();
                baglanti.Close();
                getir();
            }
        }

        private void btn_düzenle_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                string sql = "Update tbl_Kampanya ";
                sql += "Set kampanyaAd=@ad, kampanyaBaslangic=@baslangic, kampanyaBitis=@bitis, " +
                "kampanyaFiyat=@fiyat, kampanyaMaliyet=@maliyet, kampanyaResim=@resim Where Id=@id";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                cmd.Parameters.AddWithValue("@ad", tb_kampanyaAd.Text);
                cmd.Parameters.AddWithValue("@baslangic", (dateTimePicker1.Value.Date));
                cmd.Parameters.AddWithValue("@bitis", (dateTimePicker2.Value.Date));
                cmd.Parameters.AddWithValue("@fiyat", tb_kampanyaFiyat.Text);
                cmd.Parameters.AddWithValue("@maliyet", tb_kampanyaMaliyet.Text);
                cmd.Parameters.AddWithValue("@resim", tb_resimYol.Text);
                cmd.Connection = baglanti;
                baglanti.Open();
                cmd.ExecuteNonQuery();
                baglanti.Close();
                getir();
            }      
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete From tbl_Kampanya Where Id=@id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            getir();
        }

        private void btn_anaMenu_Click(object sender, EventArgs e)
        {
            Home frm = new Home();
            frm.Show();
            this.Close();
        }

        
    
}
