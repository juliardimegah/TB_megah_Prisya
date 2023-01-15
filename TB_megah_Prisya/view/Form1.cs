using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TB_megah_Prisya.view
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.Show();
            Home h = new Home();
            h.ShowDialog();

            InitializeComponent();
        }
    }
}
