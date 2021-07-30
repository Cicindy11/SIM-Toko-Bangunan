using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using SIM_Toko_Bangunan.Class;

namespace SIM_Toko_Bangunan.DAO
{
    class LoginDAO
    {
        private OleDbConnection konn = new OleDbConnection();
        private Connection koneksi = new Connection();
        private OleDbCommand command = new OleDbCommand();
        public LoginDAO()
        {
            konn = koneksi.getConnection();
        }
        public bool isVaid(ClassLogin CL)
        {
            Boolean Lapp=false;
            konn.Open();
            command.Connection = konn;
            command.CommandText = "select * from Login where username='" + CL.Username + "' and Kata_Sandi='" + CL.Password + "'";
            OleDbDataReader reader = command.ExecuteReader();

            int i = 0;
            while (reader.Read())
            {
                i++;
            }
            if (i == 1)
            {
                konn.Close();
                return true;
            }
            else 
            {
                konn.Close();
                return Lapp;
            }
            
            
           
        }
    }
}
