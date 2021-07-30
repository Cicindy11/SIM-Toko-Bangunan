namespace SIM_Toko_Bangunan
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Kasir = new System.Windows.Forms.Button();
            this.Pegawai = new System.Windows.Forms.Button();
            this.Stok = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.hour = new System.Windows.Forms.Label();
            this.minute = new System.Windows.Forms.Label();
            this.second = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Kasir
            // 
            this.Kasir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Kasir.BackColor = System.Drawing.Color.MistyRose;
            this.Kasir.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kasir.Image = ((System.Drawing.Image)(resources.GetObject("Kasir.Image")));
            this.Kasir.Location = new System.Drawing.Point(669, 136);
            this.Kasir.Name = "Kasir";
            this.Kasir.Size = new System.Drawing.Size(495, 163);
            this.Kasir.TabIndex = 0;
            this.Kasir.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Kasir.UseVisualStyleBackColor = false;
            this.Kasir.Click += new System.EventHandler(this.Kasir_Click);
            // 
            // Pegawai
            // 
            this.Pegawai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pegawai.BackColor = System.Drawing.Color.Tomato;
            this.Pegawai.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pegawai.Image = ((System.Drawing.Image)(resources.GetObject("Pegawai.Image")));
            this.Pegawai.Location = new System.Drawing.Point(962, 305);
            this.Pegawai.Name = "Pegawai";
            this.Pegawai.Size = new System.Drawing.Size(202, 162);
            this.Pegawai.TabIndex = 1;
            this.Pegawai.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Pegawai.UseVisualStyleBackColor = false;
            this.Pegawai.Click += new System.EventHandler(this.Pegawai_Click);
            // 
            // Stok
            // 
            this.Stok.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Stok.BackColor = System.Drawing.Color.PaleGreen;
            this.Stok.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stok.Image = ((System.Drawing.Image)(resources.GetObject("Stok.Image")));
            this.Stok.Location = new System.Drawing.Point(669, 305);
            this.Stok.Name = "Stok";
            this.Stok.Size = new System.Drawing.Size(287, 163);
            this.Stok.TabIndex = 2;
            this.Stok.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Stok.UseVisualStyleBackColor = false;
            this.Stok.Click += new System.EventHandler(this.Stok_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(1043, 473);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(121, 113);
            this.Exit.TabIndex = 4;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton1.BackColor = System.Drawing.Color.Aquamarine;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconSize = 100;
            this.iconButton1.Location = new System.Drawing.Point(669, 473);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(368, 113);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // hour
            // 
            this.hour.AutoSize = true;
            this.hour.BackColor = System.Drawing.Color.Transparent;
            this.hour.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hour.Location = new System.Drawing.Point(1122, 50);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(42, 31);
            this.hour.TabIndex = 6;
            this.hour.Text = "00";
            // 
            // minute
            // 
            this.minute.AutoSize = true;
            this.minute.BackColor = System.Drawing.Color.Transparent;
            this.minute.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minute.Location = new System.Drawing.Point(1189, 50);
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(42, 31);
            this.minute.TabIndex = 7;
            this.minute.Text = "00";
            // 
            // second
            // 
            this.second.AutoSize = true;
            this.second.BackColor = System.Drawing.Color.Transparent;
            this.second.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.second.Location = new System.Drawing.Point(1249, 50);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(42, 31);
            this.second.TabIndex = 8;
            this.second.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1164, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1228, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = ":";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1313, 647);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.second);
            this.Controls.Add(this.minute);
            this.Controls.Add(this.hour);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Pegawai);
            this.Controls.Add(this.Kasir);
            this.Controls.Add(this.Stok);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Kasir;
        private System.Windows.Forms.Button Pegawai;
        private System.Windows.Forms.Button Stok;
        private System.Windows.Forms.Button Exit;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.Label hour;
        private System.Windows.Forms.Label minute;
        private System.Windows.Forms.Label second;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
    }
}