using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using SIM_Toko_Bangunan.Class;
using SIM_Toko_Bangunan.DAO;

namespace SIM_Toko_Bangunan.DAO
{
    class PegawaiDAO
    {
        private OleDbConnection konn = new OleDbConnection();
        private Connection koneksi = new Connection();
        private OleDbCommand command = new OleDbCommand();
        public PegawaiDAO()
        {
            konn = koneksi.getConnection();
        }

        public bool insert(ClassPegawai P)
        {
            Boolean hs = false;
            command.Connection = konn;
            try
            {
                konn.Open();
                command.CommandText = "INSERT INTO Pegawai  (id_pegawai,nama_pegawai,no_tlp,alamat_pegawai,id_golongan) VALUES ('"+P.Id+"','" + P.Nama + "','" + P.Telp + "','" + P.Alamat + "','" + P.Golongan + "')";
                command.ExecuteNonQuery();
                konn.Close();
                hs = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return hs;
        }
        public bool delete(String id)
        {
            Boolean mai = false;
            command.Connection = konn;
            try
            {
                konn.Open();
                command.CommandText = "DELETE FROM Pegawai WHERE id_pegawai=" +id;
                command.ExecuteNonQuery();
                konn.Close();
                mai = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return mai;
        }
        public bool update(ClassPegawai P)
        {
            Boolean huy=false;
            command.Connection = konn;
            try
            {
                konn.Open();
                command.CommandText = "UPDATE Pegawai SET nama_pegawai='" + P.Nama + "',no_tlp='" + P.Telp + "',alamat_pegawai='" + P.Alamat + "',id_golongan='" + P.Golongan + "' WHERE id_pegawai=" + P.Id;
                command.ExecuteNonQuery();
                konn.Close();
                huy = true;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return huy;
        }
    }
}
