using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TB_megah_Prisya
{
    public partial class Profil : Form
    {
        public Profil()
        {
            InitializeComponent();
        }

        private void btnUP_Click(object sender, EventArgs e)
        {

        }

        private void btnHA_Click(object sender, EventArgs e)
        {
            Konfirmasi_hpsAkun konf = new Konfirmasi_hpsAkun();
            konf.ShowDialog();
        }
    }
}
