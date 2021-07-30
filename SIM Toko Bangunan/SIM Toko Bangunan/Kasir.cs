using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIM_Toko_Bangunan.Static_class;
using SIM_Toko_Bangunan.DAO;

namespace SIM_Toko_Bangunan
{
    public partial class Kasir : Form
    {
        public Kasir()
        {
            InitializeComponent();
        }
        private OleDbConnection konn = new OleDbConnection();
        private Connection koneksi = new Connection();
        private OleDbCommand command = new OleDbCommand();
        private void Kasir_Load(object sender, EventArgs e)
        {
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            // TODO: This line of code loads data into the 'databaseDataSet.Barang' table. You can move, or remove it, as needed.
            this.barangTableAdapter.Fill(this.databaseDataSet.Barang);
            // TODO: This line of code loads data into the 'setData.Transaksi' table. You can move, or remove it, as needed.
            this.transaksiTableAdapter.Fill(this.setData.Transaksi);
            DGVC.Setup_DGVC(dataGridView1, barangBindingSource);
            load_data();
        }
        private void load_data()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            DateTime now = DateTime.Now;
            listBox1.Items.Add(now);
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            int jumlah = Convert.ToInt32(numericUpDown1.Value);
            int harga = Convert.ToInt32(textBox3.Text);
            int total = harga * jumlah;
            listBox1.Items.Add(textBox1.Text+"  "+textBox2.Text+"  Rp."+total);
            listBox2.Items.Add(total);
            listBox4.Items.Add(jumlah);
            listBox3.Items.Add(textBox1.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox2.Text = row.Cells["jenis"].Value.ToString();
                textBox1.Text = row.Cells["nama"].Value.ToString();
                textBox3.Text = row.Cells["harga"].Value.ToString();
            }
        }

        private String idbelanja()
        {
            DateTime moment = DateTime.Now;
            int hour = moment.Hour;
            int minute = moment.Minute;
            int second = moment.Second;
            int day = moment.Day;
            String idlan = day.ToString() + hour.ToString() + minute.ToString()+second.ToString();
            return idlan;
        }
        private int countlist()
        {
            return listBox1.Items.Count - 1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
            {
                String idforyou = idbelanja();
                konn = koneksi.getConnection();
                konn.Open();
                command.Connection = konn;
                try
                {
                    command.CommandText = "INSERT INTO Transaksi  (ID_transaksi,tanggal_transaksi,jumlah_transaksi) VALUES ('" + idforyou + "','" + DateTime.Now.ToString() + "','" + countlist().ToString() + "')";
                    command.ExecuteNonQuery();
                    konn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                daftar_elanja(idforyou);
                int bayar = 0;
                int i = 0;
                while (i < listBox2.Items.Count)
                {
                    bayar = bayar + Convert.ToInt32(listBox2.Items[i]);
                    i++;
                }
                MessageBox.Show("Total : Rp." + bayar+ "\n" + DateTime.Now.ToString(), "Silahkan Lakukan Pembayaran!");
            }
            else MessageBox.Show("Jumlah Tidak Boleh 0!!");
        }
        private String get_idbarang(int i)
        {
            konn = koneksi.getConnection();
            konn.Open();
            String number ="";
            command.Connection = konn;
            command.CommandText = "SELECT * FROM Barang WHERE nama_barang='" +listBox3.Items[i].ToString()+ "'";
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read()) number = reader.GetValue(0).ToString();
            reader.Close();
            return number;
        }
        private void daftar_elanja(String id)
        {
            konn = koneksi.getConnection();
            konn.Open();
            command.Connection = konn;
            try
            {
                int i = 0;
                while(i<listBox4.Items.Count)
                {
                    command.CommandText = "INSERT INTO Daftar_Belanjaan  (ID_transaksi,ID_Barang,jumlah_beli) VALUES ('" +id+ "','" + get_idbarang(i).ToString() + "','" + listBox4.Items[i].ToString() + "')";
                    command.ExecuteNonQuery();
                    konn.Close();
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0)
            {
                listBox2.Items.RemoveAt(listBox1.SelectedIndex - 1);
                listBox3.Items.RemoveAt(listBox1.SelectedIndex - 1);
                listBox4.Items.RemoveAt(listBox1.SelectedIndex - 1);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Menu f2 = new Menu();
            this.Close();
            f2.ShowDialog();
        }
    }
}
