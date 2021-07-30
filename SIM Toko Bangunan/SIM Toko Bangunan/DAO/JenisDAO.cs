using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using SIM_Toko_Bangunan.Class;

namespace SIM_Toko_Bangunan.DAO
{
    class JenisDAO
    {
        private OleDbConnection konn = new OleDbConnection();
        private Connection koneksi = new Connection();
        private OleDbCommand command = new OleDbCommand();
        public JenisDAO()
        {
            konn = koneksi.getConnection();
        }
        public String getjenis(String J)
        {
            konn.Open();
            String number="";
            command.Connection = konn;
            command.CommandText = "SELECT * FROM Jenis_Bahan WHERE nama_jenis='" +J+ "'";
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read()) number = reader.GetValue(0).ToString();
            konn.Close();
            return number;
            
        }
        public bool inset(ClassJenis JB)
        {
            Boolean Myrn = false;
            command.Connection = konn;
            try
            {
                konn.Open();
                command.CommandText = "INSERT INTO Jenis_Bahan  (id_jenis,nama_jenis) VALUES ('" +JB.Id+ "','" +JB.Nama+ "')";
                command.ExecuteNonQuery();
                konn.Close();
                Myrn = true;
            }
            catch (Exception ex)
            {
               Console.WriteLine(ex.Message);
            }
            return Myrn;
        }
    }
}
