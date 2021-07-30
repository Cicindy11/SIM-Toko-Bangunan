using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_Toko_Bangunan.Class
{
    class ClassBarang
    {
        private String id;
        private String nama;
        private String jumlah;
        private String harga;
        private String jenis;
        public ClassBarang() { }
        public ClassBarang(String _id,String _nama,String _jumlah,String _harga,String _jenis)
        {
            this.Id = _id;
            this.Jenis = _jenis;
            this.Harga = _harga;
            this.Nama = _nama;
            this.Jumlah = _jumlah;
        }

        public string Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Jumlah { get => jumlah; set => jumlah = value; }
        public string Harga { get => harga; set => harga = value; }
        public string Jenis { get => jenis; set => jenis = value; }
    }
}
