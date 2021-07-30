using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using SIM_Toko_Bangunan.DAO;
using SIM_Toko_Bangunan.Class;

namespace SIM_Toko_Bangunan
{
    public partial class subpegawai : Form
    {
        public subpegawai()
        {
            InitializeComponent();
        }
        JabatanDAO Jb = new JabatanDAO();
        private void button2_Click(object sender, EventArgs e)
        {
            ClassJabatan iri = new ClassJabatan();
            iri.Id = textBox1.Text;
            iri.Jabatan = textBox2.Text;
            iri.Gaji = textBox3.Text;
            if (Jb.newjabat(iri) == true)
            {
                MessageBox.Show("Berhasil Ditambah");
                this.Close();
            }
            else MessageBox.Show("Gagal");
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void subpegawai_Load(object sender, EventArgs e)
        {

        }
    }
}
