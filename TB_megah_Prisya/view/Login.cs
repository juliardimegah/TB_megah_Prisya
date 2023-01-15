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
using TB_megah_Prisya.view;

namespace TB_megah_Prisya
{
    public partial class Login : Form
    {
        ceklogin login = new ceklogin();
        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Login()
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

        public bool IsLogin(string username, string password)
        {
            string query = $"SELECT * FROM login WHERE username = '{username}' AND password = '{password}';";

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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Username dan Password tidak boleh kosong !!!!");
            }
            else
            {
                string username = tbUsername.Text;
                string password = tbPassword.Text;

                bool status = login.cek_login(username, password);
                if (status)
                {
                    MessageBox.Show("Login Berhasil", "Berhasil");
                    Home pform = new Home();
                    pform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Gagal Login", "Gagal");
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            view.Form1 pform = new view.Form1();
            pform.Show();
            this.Hide();
        }
    }
}
