using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void HastaBtn_Click(object sender, EventArgs e)
        {
            FrmHastaGiris frmHastaGiris=new FrmHastaGiris();
            frmHastaGiris.Show();
            this.Hide();
        }

        private void DoktorBtn_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris frmDoktorGiris =new FrmDoktorGiris();
            frmDoktorGiris.Show();
            this.Hide();
        }

        private void SekreterBtn_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris frmSekreterGiris = new FrmSekreterGiris();
            frmSekreterGiris.Show();
            this.Hide();
        }
    }
}
