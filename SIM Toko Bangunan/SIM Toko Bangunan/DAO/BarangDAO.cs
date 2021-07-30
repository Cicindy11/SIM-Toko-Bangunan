using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using SIM_Toko_Bangunan.Class;

namespace SIM_Toko_Bangunan.DAO
{
    class BarangDAO
    {
        private OleDbConnection konn = new OleDbConnection();
        private Connection koneksi = new Connection();
        private OleDbCommand command = new OleDbCommand();
        public BarangDAO()
        {
            konn = koneksi.getConnection();
        }
        public bool Insert(ClassBarang B)
        {
            Boolean wai = false;
            command.Connection = konn;
            try
            {
                konn.Open();
                command.CommandText = "INSERT INTO Barang  (ID_barang,nama_barang,jumlah,harga_satuan,id_jenis) VALUES ('" +B.Id+ "','" + B.Nama + "','" + B.Jumlah + "','" + B.Harga + "','" + B.Jenis + "')";
                command.ExecuteNonQuery();
                konn.Close();
                wai = true;
            }
            catch (Exception ex)
            {
               Console.WriteLine(ex.Message);
            }
            return wai;
        }
        public bool update(ClassBarang B)
        {
            Boolean SA=false;
            command.Connection = konn;
            try
            {
                konn.Open();
                command.CommandText = "UPDATE Barang SET nama_barang='"+B.Nama+"',jumlah='"+B.Jumlah+"',harga_satuan='"+B.Harga+"',id_jenis='" +B.Jenis+ "' WHERE ID_barang=" +B.Id;
                command.ExecuteNonQuery();
                konn.Close();
                SA = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return SA;
        }
        public bool delete(String ID)
        {
            Boolean FE=false;
            konn.Open();
            command.Connection = konn;
            try
            {
                command.CommandText = "DELETE FROM Barang WHERE ID_barang=" +ID;
                command.ExecuteNonQuery();
                konn.Close();
                FE = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return FE;
        }
    }
}
