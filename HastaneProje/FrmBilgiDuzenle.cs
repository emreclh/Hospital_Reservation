using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneProje
{
    public partial class FrmBilgiDuzenle : Form
    {
        public string tc2;
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-58V97VL1\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public FrmBilgiDuzenle()
        {
            InitializeComponent();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (TxtSifre.Text != TxtSifre2.Text)
            {
                MessageBox.Show("Şifreler farklı.");
            }
            else
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-58V97VL1\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                    {
                        conn.Open();

                        SqlCommand kayitkomut = new SqlCommand("UPDATE Tbl_Hastalar SET HastaTel = @p4, HastaSifre = @p6 WHERE HastaTC = @p3", conn);
                        kayitkomut.Parameters.AddWithValue("@p3", LblTc.Text);
                        kayitkomut.Parameters.AddWithValue("@p4", TxtTel.Text);
                        kayitkomut.Parameters.AddWithValue("@p6", TxtSifre.Text);
                        kayitkomut.ExecuteNonQuery();

                        MessageBox.Show("Kayıt oluşturuldu");

                        // Clear text fields
                        TxtTel.Text = "";
                        TxtSifre.Text = "";

                        FrmHastaAnaEkran frmHastaAnaEkran =new FrmHastaAnaEkran();
                        frmHastaAnaEkran.tc = tc2;
                        frmHastaAnaEkran.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            conn.Open();
            LblTc.Text = tc2;
            SqlCommand cmd = new SqlCommand("SELECT HastaAd, HastaSoyad,HastaCinsiyet,HastaTel FROM Tbl_Hastalar WHERE HastaTC = @p1", conn);
            cmd.Parameters.AddWithValue("@p1", LblTc.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TxtTel.Text = dr["HastaTel"].ToString();
                LblAd.Text = dr["HastaAd"].ToString();
                LblSoyad.Text = dr["HastaSoyad"].ToString();
                LblCins.Text = dr["HastaCinsiyet"].ToString();
            }
            conn.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmHastaAnaEkran frmHastaAnaEkran = new FrmHastaAnaEkran();
            frmHastaAnaEkran.tc = tc2;
            frmHastaAnaEkran.Show();
            this.Hide();
        }
    }
}
