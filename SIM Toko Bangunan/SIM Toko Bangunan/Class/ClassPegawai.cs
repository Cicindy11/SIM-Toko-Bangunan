using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_Toko_Bangunan.Class
{
    class ClassPegawai
    {
        private String id;
        private String nama;
        private String telp;
        private String alamat;
        private String golongan;
        public ClassPegawai() { }
        public ClassPegawai(String _id,String _nama,String _telp,String _alamat,String _golongan)
        {
            this.Id = _id;
            this.Nama = _nama;
            this.Telp = _telp;
            this.Alamat = _alamat;
            this.Golongan = _golongan;
        }

        public string Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Telp { get => telp; set => telp = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string Golongan { get => golongan; set => golongan = value; }
    }
}
