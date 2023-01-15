using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_megah_Prisya.model
{
    class m_user
    {
        string nama, password, username, email;
        int id;
        public m_user()
        {

        }

        public m_user(string nama, string password, string username, string email, int id)
        {
            this.Nama = nama;
            this.Password = password;
            this.Username = username;
            this.Email = email;
            this.Id = id;
        }

        public string Nama { get => nama; set => nama = value; }
        public string Password { get => password; set => password = value; }
        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public int Id { get => id; set => id = value; }
    }
}
