using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TB_megah_Prisya.controller
{
    internal class ceklogin
    {
        koneksi kon = new koneksi();
        public bool cek_login(string username, string password)
        {
            try
            {
                kon.OpenConnection();
                MySqlDataReader reader = kon.reader("SELECT * FROM login WHERE username='" +
                    username + "' AND password='" + password + "'");
                if (reader.Read())
                {
                    kon.CloseConnection();
                    return true;
                }
                else
                {
                    kon.CloseConnection();
                    return false;
                }
            }
            catch (Exception e)
            {
                kon.CloseConnection();
                MessageBox.Show(e.Message, "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            kon.CloseConnection();
            return false;
        }
    }
}
