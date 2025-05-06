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
    public partial class FrmDoktorAnaEkran : Form
    {
        public string tc;
        private string id;
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-58V97VL1\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public FrmDoktorAnaEkran()
        {
            InitializeComponent();
        }
        private string doktorAd;
        private void button1_Click(object sender, EventArgs e)
        {
            doktorAd = LblAd.Text + "" + LblSoyad.Text;
            conn.Open();

            DataTable dataTable = new DataTable();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Tbl_Randevu WHERE RandevuDurum = 1 AND RandevuDoktor = @p1", conn);
            cmd.Parameters.AddWithValue("@p1", doktorAd); // replace 'yourParameterValue' with the actual value you want to pass

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

            conn.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void LblSifre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmDoktorSifre frmDoktorSifre=new FrmDoktorSifre();
            frmDoktorSifre.tc2= tc;
            frmDoktorSifre.Show();
            this.Hide();
        }

        private void FrmDoktorAnaEkran_Load(object sender, EventArgs e)
        {
            LblTc.Text = tc;
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT DoktorAd, DoktorSoyad FROM Tbl_Doktorlar WHERE DoktorTC = @p1", conn);
            cmd.Parameters.AddWithValue("@p1", LblTc.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LblAd.Text = dr["DoktorAd"].ToString();
                LblSoyad.Text = dr["DoktorSoyad"].ToString();
            }
            conn.Close();

            doktorAd = LblAd.Text + " " + LblSoyad.Text;
            conn.Open();

            DataTable dataTable = new DataTable();

            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Tbl_Randevu WHERE RandevuDurum = 1 AND RandevuDoktor = @p1", conn);
            cmd2.Parameters.AddWithValue("@p1", doktorAd); // replace 'yourParameterValue' with the actual value you want to pass

            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            da.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

            conn.Close();
        }

        private void LblTc_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();


            LblHastaTC.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            conn.Open();
            SqlCommand hastaCek = new SqlCommand("select HastaAd,HastaSoyad from Tbl_Hastalar where @h1=HastaTC", conn);
            hastaCek.Parameters.AddWithValue("@h1", LblHastaTC.Text);
            SqlDataReader dr1 = hastaCek.ExecuteReader();
            while (dr1.Read())
            {
                LblHastaAd.Text = dr1["HastaAd"].ToString();
                LblHastaSoyad.Text = dr1["HastaSoyad"].ToString();
            }
            conn.Close();

            conn.Open();
            SqlCommand idAl = new SqlCommand("select RandevuId from Tbl_Randevu where HastaTc=@l1 and RandevuDoktor=@l3", conn);
            idAl.Parameters.AddWithValue("@l1", LblHastaTC.Text);
            idAl.Parameters.AddWithValue("@l3", LblAd.Text);
            SqlDataReader rd4 = idAl.ExecuteReader();
            while (rd4.Read())
            {
                id = rd4[0].ToString();
            }
            conn.Close();

            conn.Open();
            SqlCommand sikayetAl = new SqlCommand("select Sikayet from Tbl_Sikayet where RandevuId=@m1", conn);
            sikayetAl.Parameters.AddWithValue("@m1", id);
            SqlDataReader rd1 = sikayetAl.ExecuteReader();
            while (rd1.Read())
            {
                richTextBox1.Text = rd1[0].ToString();
            }
            conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update Tbl_Randevu set RandevuDurum='true'",conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Hasta geliyor.");
            conn.Close();
        }
    }
}
