using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TB_megah_Prisya.model;

namespace TB_megah_Prisya.controller
{
    internal class pengeluaran
    {
        koneksi kon = new koneksi();

        public bool Insert(m_pengeluaran pengeluaran)
        {
            Boolean status = false;
            try
            {
                kon.OpenConnection();
                kon.ExecuteQuery("INSERT INTO pengeluaran(,idnama, jumlah, sumber) VALUES('" + pengeluaran.Nama + "', '" + pengeluaran.Jumlah + "','" + pengeluaran.Sumber + "')");
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

        public bool Update(m_pengeluaran pengeluaran, string id)
        {
            Boolean status = false;
            try
            {
                kon.OpenConnection();
                kon.ExecuteQuery("UPDATE pengeluaran SET id =" + pengeluaran.Id + "nama='" + pengeluaran.Nama + "'," +
                "jumlah='" + pengeluaran.Jumlah + "'," + "sumber='" + pengeluaran.Sumber+ "',"
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
                kon.ExecuteQuery("DELETE FROM pengeluaran WHERE id= '" + id + "'");
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
