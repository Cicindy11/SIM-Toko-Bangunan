using System;
using System.Data.OleDb;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIM_Toko_Bangunan.DAO;
using SIM_Toko_Bangunan.Class;

namespace SIM_Toko_Bangunan
{
    public partial class JenisBarang : Form
    {
        public JenisBarang()
        {
            InitializeComponent();
        }
        private OleDbConnection konn = new OleDbConnection();
        private Connection koneksi = new Connection();
        private OleDbCommand command = new OleDbCommand();
        JenisDAO JJ = new JenisDAO();
        private void button2_Click(object sender, EventArgs e)
        {
            ClassJenis Agre = new ClassJenis();
            Agre.Id = textBox1.Text;
            Agre.Nama = textBox2.Text;
            if (JJ.inset(Agre) == true)
            {
                MessageBox.Show("Sukses");
                this.Close();
            }
            else MessageBox.Show("Failed");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void JenisBarang_Load(object sender, EventArgs e)
        {

        }
    }
}
