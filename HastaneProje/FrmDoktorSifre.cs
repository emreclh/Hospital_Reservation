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
    
    public partial class FrmDoktorSifre : Form
    {
        public string tc2;
        public FrmDoktorSifre()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-58V97VL1\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand change = new SqlCommand("update Tbl_Doktorlar set DoktorSifre=@l1 where DoktorTC=@l2 and DoktorSifre@l3", conn);
            change.Parameters.AddWithValue("@l1", TxtYeniSifre.Text);
            change.Parameters.AddWithValue("@l2", TxtTc.Text);
            change.Parameters.AddWithValue("@l3", TxtEskiSifre.Text);

            change.ExecuteNonQuery();
            MessageBox.Show("Kayıt Güncellendi!");
            conn.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmDoktorAnaEkran frmDoktorAnaEkran = new FrmDoktorAnaEkran();
            frmDoktorAnaEkran.tc = tc2;
            frmDoktorAnaEkran.Show();
            this.Hide();
        }
    }
}
