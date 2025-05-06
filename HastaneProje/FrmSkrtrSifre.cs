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
    public partial class FrmSkrtrSifre : Form
    {
        public string tc2;
        public FrmSkrtrSifre()
        {
            InitializeComponent();
        }
        
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-58V97VL1\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmSekreterAnaEkran frmSekreterAnaEkran=new FrmSekreterAnaEkran();
            frmSekreterAnaEkran.tc = tc2;
            frmSekreterAnaEkran.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand change = new SqlCommand("update Tbl_Sekteter set SekreterSifre=@l1 where SekreterTC=@l2 and SekreterSifre@l3", conn);
            change.Parameters.AddWithValue("@l1", TxtYeniSifre.Text);
            change.Parameters.AddWithValue("@l2", TxtTc.Text);
            change.Parameters.AddWithValue("@l3", TxtEskiSifre.Text);

            change.ExecuteNonQuery();
            MessageBox.Show("Kayıt Güncellendi!");
            conn.Close();
        }
    }
}
