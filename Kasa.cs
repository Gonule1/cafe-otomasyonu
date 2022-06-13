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
    public partial class Kasa : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["PBCafe"].ConnectionString;
        SqlConnection baglanti;
        SqlDataAdapter da;
        SqlCommand komut;
        public Kasa()
        {
            InitializeComponent();
        }

        public void getir()
        {
            string sorgu = "Select * From tbl_Kasa";
            baglanti = new SqlConnection(connectionString);
            baglanti.Open();
            da = new SqlDataAdapter(sorgu, baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void btn_hesabiKapat_Click(object sender, EventArgs e)
        {
            //seçili satır kasa tablosundan silinecek raporlar tablosuna eklenecek.
            string sorgu = "Delete From tbl_Kasa Where Id=@id";
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

        private void Kasa_Load(object sender, EventArgs e)
        {
            getir();
        }
    }
}
