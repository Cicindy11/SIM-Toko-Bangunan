using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace SIM_Toko_Bangunan.DAO
{
    class Connection
    {
        public OleDbConnection getConnection()
        {
            // return new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DatabaseTOBA.accdb");
            return new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source =|DataDirectory|\database.mdb");
        }
        public void closeConnection(OleDbConnection _conn)
        {
            _conn.Close();
        }
    }
}
