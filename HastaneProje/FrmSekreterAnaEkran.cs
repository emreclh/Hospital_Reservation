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
    public partial class FrmSekreterAnaEkran : Form
    {
        public string tc;
        private string id;
        private string sikayet;
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-58V97VL1\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        public FrmSekreterAnaEkran()
        {
            InitializeComponent();
        }
        

        private void BtnPrsnlDuznle_Click(object sender, EventArgs e)
        {
            FrmPrsnlGuncelle frmPrsnlGuncelle=new FrmPrsnlGuncelle();
            frmPrsnlGuncelle.Show();
            this.Hide();
        }

        private void LblSifre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSkrtrSifre frmSkrtrSifre = new FrmSkrtrSifre();
            frmSkrtrSifre.tc2 = tc;
            frmSkrtrSifre.Show();
            this.Hide();
        }

        private void LblTc_Click(object sender, EventArgs e)
        {

        }

        private void FrmSekreterAnaEkran_Load(object sender, EventArgs e)
        {
            LblTc.Text = tc;
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT SekreterAd, SekreterSoyad FROM Tbl_Sekreter WHERE SekreterTC = @p1", conn);
            cmd.Parameters.AddWithValue("@p1", LblTc.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LblAd.Text = dr["SekreterAd"].ToString();
                LblSoyad.Text = dr["SekreterSoyad"].ToString();
            }
            conn.Close();

            DataTable dataTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevu ", conn);
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();


            LblHastaTc.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            conn.Open();
            SqlCommand hastaCek = new SqlCommand("select HastaAd,HastaSoyad from Tbl_Hastalar where @h1=HastaTC",conn);
            hastaCek.Parameters.AddWithValue("@h1", LblHastaTc.Text);
            SqlDataReader dr1= hastaCek.ExecuteReader();
            while (dr1.Read())
            {
                LblHastaAd.Text = dr1["HastaAd"].ToString();
                LblHastaSoyad.Text = dr1["HastaSoyad"].ToString() ;
            }

            CmbDktr.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            CmbBrans.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            conn.Close();

            conn.Open();
            SqlCommand idAl = new SqlCommand("select RandevuId from Tbl_Randevu where HastaTc=@l1 and DoktorBrans=@l2 and RandevuDoktor=@l3", conn);
            idAl.Parameters.AddWithValue("@l1", LblHastaTc.Text);
            idAl.Parameters.AddWithValue("@l2", CmbBrans.Text);
            idAl.Parameters.AddWithValue("@l3", CmbDktr.Text);
            SqlDataReader rd4 = idAl.ExecuteReader();
            while (rd4.Read())
            {
                id = rd4[0].ToString();
            }
            conn.Close();
            
            conn.Open();
            SqlCommand sikayetAl = new SqlCommand("select Sikayet from Tbl_Sikayet where RandevuId=@m1", conn);
            sikayetAl.Parameters.AddWithValue("@m1",id);
            SqlDataReader rd1 = sikayetAl.ExecuteReader();
            while (rd1.Read())
            {
                sikayet= rd1[0].ToString();
            }
            conn.Close ();
            MessageBox.Show(sikayet);



        }
        private string x = "true";
        private void BtnRandevuGuncelle_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            SqlCommand randUpd = new SqlCommand("Update Tbl_Randevu SET RandevuSaat = @p1, RandevuTarih = @p2,RandevuDoktor=@p3,DoktorBrans=@p4,RandevuDurum=@p6 WHERE RandevuId= @p5 ", conn);
            randUpd.Parameters.AddWithValue("@p5", id);
            randUpd.Parameters.AddWithValue("@p1",TxtSaat.Text);
            randUpd.Parameters.AddWithValue("@p2", TxtTarih.Text);
            randUpd.Parameters.AddWithValue("@p3", CmbDktr.Text);
            randUpd.Parameters.AddWithValue("@p4", CmbBrans.Text);
            randUpd.Parameters.AddWithValue("@p6", x);
            randUpd.ExecuteNonQuery();
            conn.Close() ;
            MessageBox.Show("Randevu düzenlendi.");
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
