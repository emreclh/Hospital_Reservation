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
    public partial class FrmHastaAnaEkran : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-58V97VL1\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public FrmHastaAnaEkran()
        {
            InitializeComponent();
        }
        public string tc;
        public string id;

        private void BtnEskiRndv_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FrmHastaAnaEkran_Load(object sender, EventArgs e)
        {
            LblTc.Text = tc;
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT HastaAd, HastaSoyad FROM Tbl_Hastalar WHERE HastaTC = @p1", conn);
            cmd.Parameters.AddWithValue("@p1", LblTc.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LblAd.Text = dr["HastaAd"].ToString();
                LblSoyad.Text = dr["HastaSoyad"].ToString();
            }
            conn.Close();

            DataTable dataTable = new DataTable();
            SqlDataAdapter da= new SqlDataAdapter("Select * from Tbl_Randevu where HastaTc="+tc,conn);
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            conn.Open();
            SqlCommand dr2 = new SqlCommand("select bransAd from Tbl_Branslar", conn);
            SqlDataReader sqlDataReader = dr2.ExecuteReader();
            while (sqlDataReader.Read())
            {
                CmbBrans.Items.Add(sqlDataReader[0]);
            }
            conn.Close();

            
        }

        private void LnkBilgiDuznle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDuzenle frmBilgiDuzenle=new FrmBilgiDuzenle();
            frmBilgiDuzenle.tc2 = tc;
            frmBilgiDuzenle.Show();
            this.Hide();

        }

        private void LblTc_Click(object sender, EventArgs e)
        {

        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDktr.Items.Clear();
            CmbDktr.Text = "";

            conn.Open();
            SqlCommand dr3 = new SqlCommand("select doktorAd,doktorSoyad from Tbl_Doktorlar where DoktorBrans=@d1", conn);
            dr3.Parameters.AddWithValue("@d1", CmbBrans.Text);
            SqlDataReader sqlDataReader3 = dr3.ExecuteReader();
            while (sqlDataReader3.Read())
            {
                CmbDktr.Items.Add(sqlDataReader3[0] + " " + sqlDataReader3[1]);
            }
            conn.Close();
        }

        private void BtnYniRndv_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand randAl = new SqlCommand("insert into Tbl_Randevu (HastaTc,DoktorBrans,RandevuDoktor) values (@k1,@k2,@k3)",conn);
            randAl.Parameters.AddWithValue("@k1",tc);
            randAl.Parameters.AddWithValue("@k2",CmbBrans.Text);
            randAl.Parameters.AddWithValue("@k3", CmbDktr.Text);
            randAl.ExecuteNonQuery();
            conn.Close() ;

            conn.Open();
            SqlCommand idAl = new SqlCommand("SELECT RandevuId FROM Tbl_Randevu WHERE HastaTc=@l1 AND DoktorBrans=@l2 AND RandevuDoktor=@l3", conn);
            idAl.Parameters.AddWithValue("@l1", tc);
            idAl.Parameters.AddWithValue("@l2", CmbBrans.Text);
            idAl.Parameters.AddWithValue("@l3", CmbDktr.Text);
            SqlDataReader rd4= idAl.ExecuteReader();
            while (rd4.Read())
            {
                id = rd4[0].ToString();
            }
            conn.Close();

            conn.Open();
            SqlCommand sikayet = new SqlCommand("insert into Tbl_Sikayet (RandevuId,Sikayet) values(@c1,@c2)", conn);
            sikayet.Parameters.AddWithValue("@c1", id);
            sikayet.Parameters.AddWithValue("@c2", RichTxtSikayet.Text);
            sikayet.ExecuteNonQuery() ;
            conn.Close();
            MessageBox.Show("Randevunuz incelemeye alındı.");

        }

        private void CmbDktr_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from Tbl_Randevu where DoktorBrans='" + CmbBrans.Text+"'", conn);
            da2.Fill(dataTable2);
            dataGridView2.DataSource = dataTable2;
        }
    }
}
