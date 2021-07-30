using SIM_Toko_Bangunan.Static_class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using SIM_Toko_Bangunan.Class;
using SIM_Toko_Bangunan.DAO;

namespace SIM_Toko_Bangunan
{
    public partial class Stok : Form
    {
        private OleDbConnection konn = new OleDbConnection();
        private Connection koneksi = new Connection();
        private OleDbCommand command = new OleDbCommand();
        public Stok()
        {
            InitializeComponent();
        }
        BarangDAO BDO = new BarangDAO();
        JenisDAO JDO = new JenisDAO();
        private void Stok_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Jenis_Bahan' table. You can move, or remove it, as needed.
            this.jenis_BahanTableAdapter.Fill(this.databaseDataSet.Jenis_Bahan);

            // TODO: This line of code loads data into the 'databaseDataSet.Barang' table. You can move, or remove it, as needed.
            this.barangTableAdapter.Fill(this.databaseDataSet.Barang);
            DGVB.Setup_DGVB(dataGridView1, barangBindingSource3);

        }
        private void load_data()
        {
            this.barangTableAdapter.Fill(this.databaseDataSet.Barang);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu f3 = new Menu();
            f3.ShowDialog();
        }
        private void clear_tex()
        {
            textBox2.Text = "";
            textBox1.Text = "";
            textBox3.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox2.Text = row.Cells["nama"].Value.ToString();
                textBox1.Text = row.Cells["id"].Value.ToString();
                textBox3.Text = row.Cells["jumlah"].Value.ToString();
                textBox4.Text = row.Cells["harga"].Value.ToString();
                comboBox1.Text = row.Cells["jenis"].Value.ToString();
                
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void tambahJenisBahanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JenisBarang same = new JenisBarang();
            same.ShowDialog();
            Stok_Load(same,e);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            BDO.delete(textBox1.Text);
            clear_tex();
            load_data();
        }

        private void update_Click(object sender, EventArgs e)
        {
            ClassBarang B = new ClassBarang();
            B.Id = textBox1.Text.ToString();
            B.Nama = textBox2.Text.ToString();
            B.Jumlah = textBox3.Text.ToString();
            B.Harga = textBox4.Text.ToString();
            B.Jenis = JDO.getjenis(comboBox1.Text);
            BDO.update(B);
            clear_tex();
            load_data();
        }

        private void add_Click(object sender, EventArgs e)
        {
            ClassBarang B = new ClassBarang();
            B.Id = textBox1.Text.ToString(); 
            B.Nama = textBox2.Text.ToString();
            B.Jumlah = textBox3.Text.ToString();
            B.Harga = textBox4.Text.ToString();
            B.Jenis = JDO.getjenis(comboBox1.Text);
            BDO.Insert(B);
            clear_tex();
            load_data();
           
        }
    }
}
