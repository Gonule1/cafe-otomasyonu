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
    public partial class Adisyon : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["PBCafe"].ConnectionString;
        SqlConnection baglanti;
        SqlDataAdapter da;
        SqlCommand komut;
        DataSet ds;
        public Adisyon()
        {
            InitializeComponent();
        }

        public void masa_doldur()
        {
            //masalar
            baglanti = new SqlConnection(connectionString);
            SqlCommand cmd_masa = new SqlCommand();
            cmd_masa.CommandText = "SELECT *FROM tbl_Masa";
            cmd_masa.Connection = baglanti;
            cmd_masa.CommandType = CommandType.Text;
            SqlDataReader dr_masa;
            baglanti.Open();
            dr_masa = cmd_masa.ExecuteReader();
            while (dr_masa.Read())
            {
                cb_masaAd.Items.Add(dr_masa["masaAd"]);
            }
            baglanti.Close();
        }

        public void getir()
        {
            string sorgu = "Select * From tbl_Adisyon";
            baglanti = new SqlConnection(connectionString);
            baglanti.Open();
            da = new SqlDataAdapter(sorgu, baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void btn_adisyon_Click(object sender, EventArgs e)
        {
            //seçili adisyon butona basıldığında seçili satır adisyon tablosundan silinecek, Kasa tablosuna eklenecek.
            string sorgu = "Delete From tbl_Adisyon Where Id=@id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            getir();
        }

        private void Adisyon_Load(object sender, EventArgs e)
        {
            getir();
            masa_doldur();
        }

        private void cb_masaAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(connectionString);
            baglanti.Open();
            DataTable dt = new DataTable();
            string sorgu = "select * from tbl_Adisyon where masaAd like '%" + cb_masaAd.SelectedItem.ToString() + "%' ";
            SqlDataAdapter ara = new SqlDataAdapter(sorgu, baglanti);
            ara.Fill(dt);
            baglanti.Close();
            dataGridView1.DataSource = dt;
        }
    }
}
