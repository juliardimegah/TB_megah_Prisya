using MySql.Data.MySqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TB_megah_Prisya
{
    public partial class Konfirmasi_hpsAkun : Form
    {
        ceklogin login = new ceklogin();
        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string password;

       public Konfirmasi_hpsAkun()
        {
            server = "localhost";
            database = "tubespbo";
            uid = "root";
            password = "";

            string connString;
            connString = "Server=localhost;Database=tubespbo;Uid=root;Pwd=;";

            conn = new MySqlConnection(connString);
            InitializeComponent();
        }
        public bool HPS(string nama)
        {
            string query = $"DELETE FROM user WHERE nama= '" + nama + "';";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        reader.Close();
                        conn.Close();
                        return true;
                    }
                    else
                    {
                        reader.Close();
                        conn.Close();
                        return false;
                    }
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }
        }

        private bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Connection to server failed");
                        break;
                    case 1045:
                        MessageBox.Show("Server username or password is incorrect");
                        break;
                }
                return false;
            }
        }

        private void btnTidak_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnYA_Click(object sender, EventArgs e)
        {
           if(HPS=true)
            {
                
                bool status = login.cek_login(username, password);
                if (status)
                {
                    MessageBox.Show("Login Berhasil", "Berhasil");
                    Home pform = new Home();
                    pform.Show();
                    this.Hide();
                }

            }
    }
}
