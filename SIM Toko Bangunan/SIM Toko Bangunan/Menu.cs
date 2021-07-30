using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM_Toko_Bangunan
{
    public partial class Menu : Form
    {
        public Menu()
        {
           InitializeComponent();
           this.ShowInTaskbar = true;
           this.ShowIcon = true;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Kasir_Click(object sender, EventArgs e)
        {
            Kasir f3 = new Kasir();
            this.Hide();
            f3.ShowDialog();
            this.Close();
        }

        private void Pegawai_Click(object sender, EventArgs e)
        {
            Pegawai f4 = new Pegawai();
            this.Hide();
            f4.ShowDialog();
            this.Close();
        }

        private void Stok_Click(object sender, EventArgs e)
        {
            Stok f5 = new Stok();
            this.Hide();
            f5.ShowDialog();
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            this.ShowIcon = true;
            toolTip1.SetToolTip(Kasir,"Kasir");
            toolTip2.SetToolTip(Stok,"Barang");
            toolTip3.SetToolTip(Pegawai,"Pegawai");
            toolTip4.SetToolTip(iconButton1,"About");
            toolTip5.SetToolTip(Exit,"Tutup Program");
            timeadjst();
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            About myinfo = new About();
            myinfo.ShowDialog();
        }
        private void timeadjst()
        {
            DateTime ima = DateTime.Now;
            if (ima.Hour < 10) hour.Text = "0" + ima.Hour.ToString();
            else hour.Text = ima.Hour.ToString();
            if(ima.Minute<10) minute.Text = "0"+ima.Minute.ToString();
            else minute.Text = ima.Minute.ToString();
            if(ima.Second<10) second.Text = "0"+ima.Second.ToString();
            else second.Text = ima.Second.ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeadjst();
        }
    }
}
