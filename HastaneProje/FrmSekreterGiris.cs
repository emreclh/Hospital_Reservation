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
    public partial class FrmSekreterGiris : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-58V97VL1\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }
        public string Tc;

        private void FrmSekreterGiris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(TxtSekreterTC==null||TxtSekreterSifre==null) 
            {
                MessageBox.Show("T.C. numaranızı ve şifrenizi giriniz");

            }
            else
            {
                conn.Open();
                SqlCommand komutsekretergiris = new SqlCommand("Select * from Tbl_Sekreter where @s1=SekreterTC and @s2=SekreterSifre", conn);
                komutsekretergiris.Parameters.AddWithValue("@s1", TxtSekreterTC.Text);
                komutsekretergiris.Parameters.AddWithValue("@s2", TxtSekreterSifre.Text);
                SqlDataReader dr = komutsekretergiris.ExecuteReader();
                if (dr.Read())
                {
                    FrmSekreterAnaEkran frmSekreterAnaEkran =new FrmSekreterAnaEkran();
                    frmSekreterAnaEkran.tc=TxtSekreterTC.Text;
                    frmSekreterAnaEkran.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("T.C. numaranız veya şifre yanlış");
                }
                conn.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
