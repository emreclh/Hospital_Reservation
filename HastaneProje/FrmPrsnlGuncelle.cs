using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace HastaneProje
{
    public partial class FrmPrsnlGuncelle : Form
    {
        public FrmPrsnlGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-58V97VL1\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSkrtrList_Click(object sender, EventArgs e)
        {
            this.tbl_SekreterTableAdapter1.Fill(this.hastaneProjeDataSet1.Tbl_Sekreter);
            
            
        }

        private void FrmPrsnlGuncelle_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand dr2 = new SqlCommand("select bransAd from Tbl_Branslar", conn);
            SqlDataReader sqlDataReader = dr2.ExecuteReader();
            while (sqlDataReader.Read())
            {
                CmbDktrBrns.Items.Add(sqlDataReader[0]);
            }
            conn.Close();

        }

        private void BtnDktrList_Click(object sender, EventArgs e)
        {
            this.tbl_DoktorlarTableAdapter1.Fill(this.hastaneProjeDataSet1.Tbl_Doktorlar);
        }

        private void BtnDktrGunc_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open(); // Open the connection before executing the command

                SqlCommand komutguncelle = new SqlCommand("UPDATE Tbl_Doktorlar SET DoktorAd=@a1, DoktorSoyad=@a2, DoktorBrans=@a3 WHERE DoktorTC=@a7", conn);
                komutguncelle.Parameters.AddWithValue("@a1", TxtDktrAd.Text);
                komutguncelle.Parameters.AddWithValue("@a2", TxtDktrSoyad.Text);
                komutguncelle.Parameters.AddWithValue("@a3", CmbDktrBrns.Text);
                komutguncelle.Parameters.AddWithValue("@a7", TxtDktrTc.Text);

                int rowsAffected = komutguncelle.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Kayıt güncellendi");
                }
                else
                {
                    MessageBox.Show("Kayıt güncellenemedi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private int a;
        private void BtnDktrEkle_Click(object sender, EventArgs e)
        {
            
            
                try
                {
                    using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-58V97VL1\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                    {
                        conn.Open();

                        SqlCommand kayitkomut = new SqlCommand("INSERT INTO Tbl_Doktorlar (DoktorAd, DoktorSoyad, DoktorTC, DoktorBrans,DoktorSifre) VALUES (@p1, @p2, @p3, @p4,@p5)", conn);
                        kayitkomut.Parameters.AddWithValue("@p1", TxtDktrAd.Text);
                        kayitkomut.Parameters.AddWithValue("@p2", TxtDktrSoyad.Text);
                        kayitkomut.Parameters.AddWithValue("@p3", TxtDktrTc.Text);
                        kayitkomut.Parameters.AddWithValue("@p4", CmbDktrBrns.Text);
                        kayitkomut.Parameters.AddWithValue("@p5", "123456");
                        kayitkomut.ExecuteNonQuery();


                        conn.Close();

                    conn.Open();
                    SqlCommand branskayit = new SqlCommand("SELECT BransAd FROM Tbl_Branslar WHERE BransAd=@r1", conn);
                    branskayit.Parameters.AddWithValue("@r1", CmbDktrBrns.Text);
                    SqlDataReader dataReader = branskayit.ExecuteReader();
                    if (dataReader.Read())
                        {
                        a = 1;
                        }
                        else
                        {
                        a = 0;
                        }
                    dataReader.Close();
                        if (a == 0) 
                        {
                        SqlCommand branskayit2 = new SqlCommand("INSERT INTO Tbl_Branslar (BransAd) VALUES (@e1)", conn);
                        branskayit2.Parameters.AddWithValue("@e1", CmbDktrBrns.Text);
                        branskayit2.ExecuteNonQuery();
                    }
                        conn.Close() ;

                    MessageBox.Show("Kayıt oluşturuldu");

                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }

            
        }

        private void BtnSkrtrEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-58V97VL1\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    conn.Open();

                    SqlCommand kayitkomut = new SqlCommand("INSERT INTO Tbl_Sekreter (SekreterAd, SekreterSoyad, SekreterTC,SekreterSifre) VALUES (@p1, @p2, @p3,@p4)", conn);
                    kayitkomut.Parameters.AddWithValue("@p1", TxtSkrtrAd.Text);
                    kayitkomut.Parameters.AddWithValue("@p2", TxtSkrtrSoyad.Text);
                    kayitkomut.Parameters.AddWithValue("@p3", TxtSkrtrTc.Text);
                    kayitkomut.Parameters.AddWithValue("@p4", "123456");

                    kayitkomut.ExecuteNonQuery();

                    MessageBox.Show("Kayıt oluşturuldu");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void BtnSkrtrGnc_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open(); // Open the connection before executing the command

                SqlCommand komutguncelle = new SqlCommand("UPDATE Tbl_Sekreter SET SekreterAd=@a1, SekreterSoyad=@a2 WHERE SekreterTC=@a7", conn);
                komutguncelle.Parameters.AddWithValue("@a1", TxtSkrtrAd.Text);
                komutguncelle.Parameters.AddWithValue("@a2", TxtSkrtrSoyad.Text);
                komutguncelle.Parameters.AddWithValue("@a7", TxtSkrtrTc.Text);

                int rowsAffected = komutguncelle.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Kayıt güncellendi");
                }
                else
                {
                    MessageBox.Show("Kayıt güncellenemedi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void BtnDktrSil_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Doktorlar Where DoktorTC=@k1", conn);
            komutsil.Parameters.AddWithValue("@k1", TxtDktrTc.Text);
            komutsil.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kayıt silindi");
        }

        private void BtnSkrtrSil_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Sekreter Where SekreterTC=@k1", conn);
            komutsil.Parameters.AddWithValue("@k1", TxtSkrtrTc.Text);
            komutsil.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kayıt silindi");
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;

            TxtSkrtrAd.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
            TxtSkrtrSoyad.Text = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
            TxtSkrtrTc.Text = dataGridView2.Rows[secilen].Cells[3].Value.ToString();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            TxtDktrAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtDktrSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbDktrBrns.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtDktrTc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

        }

        private void CmbDktrBrns_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
