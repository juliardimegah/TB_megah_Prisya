using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TB_megah_Prisya.model;

namespace TB_megah_Prisya.controller
{
    internal class pemasukan
    {
        koneksi kon = new koneksi();

        public bool Insert(m_pemasukan pemasukan)
        {
            Boolean status = false;
            try
            {
                kon.OpenConnection();
                kon.ExecuteQuery("INSERT INTO pemasukan (id, nama, jumlah, sumber) VALUES('"+ pemasukan.Id + "','" + pemasukan.Nama + "', '" + pemasukan.Jumlah + "','" + pemasukan.Sumber + "')");
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

        public bool Update(m_pemasukan pemasukan, string id)
        {
            Boolean status = false;
            try
            {
                kon.OpenConnection();
                kon.ExecuteQuery("UPDATE pemasukan SET id =" + pemasukan.Id + "nama='" + pemasukan.Nama + "'," +
                "jumlah='" + pemasukan.Jumlah + "'," + "sumber='" + pemasukan.Sumber + "',"
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

        public bool Delete(string id)
        {
            Boolean status = false;
            try
            {
                kon.OpenConnection();
                kon.ExecuteQuery("DELETE FROM pemasukan WHERE id= '" + id + "'");
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
