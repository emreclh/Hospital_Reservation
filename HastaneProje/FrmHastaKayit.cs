using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneProje
{
    public partial class FrmHastaKayit : Form
    {
        
        public FrmHastaKayit()
        {
            InitializeComponent();
        }

        private void BtnKayit_Click(object sender, EventArgs e)
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

                        SqlCommand kayitkomut = new SqlCommand("INSERT INTO Tbl_Hastalar (HastaAd, HastaSoyad, HastaTC, HastaTel, HastaCinsiyet, HastaSifre) VALUES (@p1, @p2, @p3, @p4, @p5, @p6)", conn);
                        kayitkomut.Parameters.AddWithValue("@p1", TxtAd.Text);
                        kayitkomut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
                        kayitkomut.Parameters.AddWithValue("@p3", TxtTC.Text);
                        kayitkomut.Parameters.AddWithValue("@p4", TxtTel.Text);
                        kayitkomut.Parameters.AddWithValue("@p5", comboBox1.Text);
                        kayitkomut.Parameters.AddWithValue("@p6", TxtSifre.Text);
                        kayitkomut.ExecuteNonQuery();

                        MessageBox.Show("Kayıt oluşturuldu");

                        // Clear text fields
                        TxtAd.Text = "";
                        TxtSoyad.Text = "";
                        TxtTC.Text = "";
                        TxtTel.Text = "";
                        comboBox1.SelectedIndex = -1;
                        TxtSifre.Text = "";

                        FrmHastaGiris frmHastaGiris = new FrmHastaGiris();
                        frmHastaGiris.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmHastaGiris frmHastaGiris = new FrmHastaGiris();
            frmHastaGiris.Show();
            this.Hide();
        }
    }
}
