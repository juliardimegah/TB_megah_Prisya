using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TB_megah_Prisya.controller;

namespace TB_megah_Prisya
{
    public partial class Home : Form
    {
        koneksi kon = new koneksi();

        public void tampil()
        {
            datauser.DataSource = kon.ShowData("SELECT pemasukan.id, pemasukan.jumlah, pengeluaran.jumlah FROM pemasukan INNER JOIN (pengeluaran) ON (pemasukan.id=pengeluaran.id);");
        }
        public Home()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profil profil = new Profil();
            profil.ShowDialog();
            
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            this.Hide();
            view.Inputdata indat  = new view.Inputdata();
            indat.ShowDialog();
        }
private void Home_Load(object sender, EventArgs e)
        {
            tampil();
        }
    }
}
