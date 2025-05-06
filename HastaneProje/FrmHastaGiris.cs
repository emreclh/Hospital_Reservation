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
    public partial class FrmHastaGiris : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-58V97VL1\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public FrmHastaGiris()
        {
            InitializeComponent();
        }
        public string Tc;
        private void FrmHastaGiris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtHastaTC.Text == null || TxtHastaSifre.Text == null)
            {
                MessageBox.Show("T.C. numaranızı ve şifrenizi giriniz");

            }
            else
            {
                conn.Open();
                SqlCommand komuthastagiris = new SqlCommand("Select * from Tbl_Hastalar where @h1=HastaTC and @h2=HastaSifre", conn);
                komuthastagiris.Parameters.AddWithValue("@h1", TxtHastaTC.Text);
                komuthastagiris.Parameters.AddWithValue("@h2", TxtHastaSifre.Text);
                SqlDataReader dr = komuthastagiris.ExecuteReader();
                if (dr.Read())
                {
                    
                    FrmHastaAnaEkran frmHastaAnaEkran=new FrmHastaAnaEkran();
                    frmHastaAnaEkran.tc= TxtHastaTC.Text;
                    frmHastaAnaEkran.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("T.C. numaranız veya şifre yanlış");
                }
                conn.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FrmHastaKayit frmHastaKayit=new FrmHastaKayit();
            frmHastaKayit.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1=new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
