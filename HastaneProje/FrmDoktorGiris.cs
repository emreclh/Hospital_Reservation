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
    public partial class FrmDoktorGiris : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-58V97VL1\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }
        public string Tc;

        private void FrmDoktorGiris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtDoktorTC.Text == null || TxtDoktorSifre.Text == null)
            {
                MessageBox.Show("T.C. numaranızı ve şifrenizi giriniz");

            }
            else
            {
                conn.Open();

                SqlCommand komutsekretergiris = new SqlCommand("Select * from Tbl_Doktorlar where @d1=DoktorTC and @d2=DoktorSifre", conn);
                komutsekretergiris.Parameters.AddWithValue("@d1", TxtDoktorTC.Text);
                komutsekretergiris.Parameters.AddWithValue("@d2", TxtDoktorSifre.Text);
                SqlDataReader dr = komutsekretergiris.ExecuteReader();
                if (dr.Read())
                {
                   
                    FrmDoktorAnaEkran frmDoktorAnaEkran =new FrmDoktorAnaEkran();
                    frmDoktorAnaEkran.tc= TxtDoktorTC.Text;
                    frmDoktorAnaEkran.Show();
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
