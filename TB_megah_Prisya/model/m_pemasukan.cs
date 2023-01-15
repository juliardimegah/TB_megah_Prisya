using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_megah_Prisya.model
{
    internal class m_pemasukan
    {
        string nama, sumber;
        int jumlah, id;
        public m_pemasukan()
        {

        }

        public m_pemasukan(string nama, string sumber, int jumlah, int id)
        {
            this.Nama = nama;
            this.Sumber = sumber;
            this.Jumlah = jumlah;
            this.Id = id;
        }

        public string Nama { get => nama; set => nama = value; }
        public string Sumber { get => sumber; set => sumber = value; }
        public int Jumlah { get => jumlah; set => jumlah = value; }
        public int Id { get => id; set => id = value; }
    }
}
