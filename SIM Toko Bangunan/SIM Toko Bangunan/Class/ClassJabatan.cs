using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_Toko_Bangunan.Class
{
    class ClassJabatan
    {
        private String id;
        private String jabatan;
        private String gaji;
        public ClassJabatan() { }
        public ClassJabatan(String _id,String _jabat,String _gaji)
        {
            this.Id = _id;
            this.Gaji = _gaji;
            this.Jabatan = _jabat;
        }

        public string Id { get => id; set => id = value; }
        public string Jabatan { get => jabatan; set => jabatan = value; }
        public string Gaji { get => gaji; set => gaji = value; }
    }
}
