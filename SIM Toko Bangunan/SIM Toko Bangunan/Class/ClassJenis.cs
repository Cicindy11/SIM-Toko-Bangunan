using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_Toko_Bangunan.Class
{
    class ClassJenis
    {
        private String id;
        private String nama;
        public ClassJenis() { }
        public ClassJenis(String _id,String _nama)
        {
            this.Id = _id;
            this.Nama = _nama;
        }

        public string Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
    }
}
