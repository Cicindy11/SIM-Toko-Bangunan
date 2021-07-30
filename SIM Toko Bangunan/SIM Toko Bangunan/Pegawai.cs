using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing.Imaging;
using SIM_Toko_Bangunan.Static_class;
using SIM_Toko_Bangunan.DAO;
using SIM_Toko_Bangunan.Class;
using System.Data.SqlClient;

namespace SIM_Toko_Bangunan
{
    public partial class Pegawai : Form
    {
        private OleDbConnection konn = new OleDbConnection();
        private Connection koneksi = new Connection();
        private OleDbCommand command = new OleDbCommand();
        public Pegawai()
        {
            InitializeComponent();
            
         }
        PegawaiDAO pg = new PegawaiDAO();
        JabatanDAO Jb = new JabatanDAO();

        private void Pegawai_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Golongan' table. You can move, or remove it, as needed.
            this.golonganTableAdapter.Fill(this.databaseDataSet.Golongan);
            pegawaiBindingSource1.Filter = null;
            tableLayoutPanel1.BackColor = panel2.BackColor;
            tableLayoutPanel2.BackColor = panel2.BackColor;
            tableLayoutPanel3.BackColor = panel2.BackColor;
            this.pegawaiTableAdapter1.Fill(this.databaseDataSet.Pegawai);
            DGV.Setup_DGVP(dataGridView1, pegawaiBindingSource1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            textBox2.Text = row.Cells["nama"].Value.ToString();
            textBox1.Text = row.Cells["id"].Value.ToString();
            textBox3.Text = row.Cells["telp"].Value.ToString();
            textBox4.Text = row.Cells["alamat"].Value.ToString();
            comboBox1.Text = row.Cells["jabatan"].Value.ToString();
            textBox6.Text = row.Cells["gaji"].Value.ToString();
            }
        }

        private void clear_tex()
        {
            textBox2.Text = "";
            textBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
            textBox6.Text = "";
        
        }
        private void load_data()
        {
            this.pegawaiTableAdapter1.Fill(this.databaseDataSet.Pegawai);
        }
    

        private void button3_Click(object sender, EventArgs e)
        {
            ClassPegawai P = new ClassPegawai();
            
            P.Id = textBox1.Text;
            P.Nama = textBox2.Text;
            P.Alamat = textBox4.Text;
            P.Telp = textBox3.Text;
            P.Golongan = Jb.idgolongan(comboBox1.Text);
            if (pg.update(P) == true) MessageBox.Show("Data Berhasil di Perbaharui");
            else MessageBox.Show("Gagal Memperbaharui Data");
            clear_tex();
            load_data();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu f2 = new Menu();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClassPegawai P = new ClassPegawai();
            P.Id = textBox1.Text;
            P.Nama = textBox2.Text;
            P.Alamat = textBox4.Text;
            P.Telp = textBox3.Text;
            P.Golongan = Jb.idgolongan(comboBox1.Text);
            if (pg.insert(P) == true) MessageBox.Show("Data Berhasil di Tambah");
            else MessageBox.Show("Gagal Menambah Data");
            clear_tex();
            load_data();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pg.delete(textBox1.Text) == true) MessageBox.Show("Data Berhasil Dihapus");
            else MessageBox.Show("Gagal Menghapus");
            clear_tex();
            load_data();
        }
        private String numJabatan()
        {
            return "";
        }
        private void tambahJabatanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            subpegawai baru = new subpegawai();
            baru.ShowDialog();
            Pegawai_Load(baru,e);
        }
    }
}
