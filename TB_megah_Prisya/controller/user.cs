using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TB_megah_Prisya.model;

namespace TB_megah_Prisya.controller
{
    internal class user
    {
        koneksi kon = new koneksi();

        public bool Insert(m_user user)
        {
            Boolean status = false;
            try
            {
                kon.OpenConnection();
                kon.ExecuteQuery("INSERT INTO user(id, nama, username, password, email) VALUES('" + user.Id + "', '"  + user.Username + "','" + user.Password+ "','" +  user.Email + "')");
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kon.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
         }

        public bool Update(m_user user, string id)
        {
            Boolean status = false;
            try
            {
                kon.OpenConnection();
                kon.ExecuteQuery("UPDATE user SET id ='" + user.Id + "nama='" + user.Nama + "'," +
                "username='" + user.Username+ "'," + "password='" + user.Password+ "',"
                +"'," + "email='" + user.Email + "',"
                + "WHERE id='" + id + "'");
                status = true;
                MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kon.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        public bool Delete(string nama)
        {
            Boolean status = false;
            try
            {
                kon.OpenConnection();
                kon.ExecuteQuery("DELETE FROM user WHERE nama= '" + nama + "'");
                status = true;
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kon.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
