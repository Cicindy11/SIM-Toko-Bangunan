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
using SIM_Toko_Bangunan.Class;
using SIM_Toko_Bangunan.DAO;

namespace SIM_Toko_Bangunan
{
    public partial class Form1 : Form
    {
        private Connection koneksi = new Connection();
        private OleDbCommand command = new OleDbCommand();
        public Form1()
        {
            InitializeComponent();
        }
        LoginDAO LDA = new LoginDAO();
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Focus();
            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            checkBox1.BackColor = Color.Transparent;
            
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            ClassLogin SARIA = new ClassLogin();
            SARIA.Username = username.Text;
            SARIA.Password=password.Text;
            if (LDA.isVaid(SARIA)==true)
            {
                Menu f2 = new Menu();
                this.ShowInTaskbar = false;
                this.ShowIcon = false;
                MessageBox.Show("Login Sukses");
                this.Hide();
                f2.ShowDialog();
            }
            else MessageBox.Show("Username atau Password Salah");
        }

        private void username_Enter(object sender, EventArgs e)
        {
            if(username.Text == "username")
            {
                username.Text = "";
                username.ForeColor = Color.Black;
            }
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "username";
                username.ForeColor = Color.Silver;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "password")
            {
                password.Text = "";
                password.ForeColor = Color.Black;
                if (checkBox1.Checked == true) password.UseSystemPasswordChar = false;
                else password.UseSystemPasswordChar = true;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "password";
                password.ForeColor = Color.Silver;
                password.UseSystemPasswordChar = false;
            }
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (password.Text != "" && password.Text != "password")
            {
                if (checkBox1.Checked == true) password.UseSystemPasswordChar = false;
                else password.UseSystemPasswordChar = true;
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
