using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using SIM_Toko_Bangunan.Class;
using System.Runtime.InteropServices;

namespace SIM_Toko_Bangunan.DAO
{
    class JabatanDAO
    {
        private OleDbConnection konn = new OleDbConnection();
        private Connection koneksi = new Connection();
        private OleDbCommand command = new OleDbCommand();
        public JabatanDAO()
        {
            konn = koneksi.getConnection();
        }
        public String idgolongan(String Jabatan)
        {
        konn.Open();
        String number ="";
        command.Connection = konn;
        command.CommandText = "SELECT * FROM Golongan WHERE jabatan='"+Jabatan+"'";
        OleDbDataReader reader = command.ExecuteReader();
        while(reader.Read()) number = reader.GetValue(0).ToString();
        konn.Close();
        return number;
        }
        public bool newjabat(ClassJabatan J)
        {
            Boolean exu = false;
            command.Connection = konn;
            try
            {
                konn.Open();
                command.CommandText = "INSERT INTO  Golongan (id_golongan,jabatan,gaji) VALUES ('" + J.Id + "','" + J.Jabatan + "','" + J.Gaji + "')";
                command.ExecuteNonQuery();
                konn.Close();
                exu = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return exu;
        }
    }
}
