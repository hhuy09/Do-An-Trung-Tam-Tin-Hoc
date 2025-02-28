﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRUNGTAMTINHOC
{
    public partial class LopHoc : Form
    {
        public string MaHV;
        public string HoTen;

        public string NamKy { get; internal set; }

        public LopHoc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            this.Close();
            dn.Show();
        }

        private void HocVien_Load(object sender, EventArgs e)
        {
            label2.Text = HoTen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HocVien_DKKHCD dk = new HocVien_DKKHCD();
            dk.MaHV = MaHV;
            dk.HoTen = HoTen;
            dk.Show();           
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HocVien_DKHP dk = new HocVien_DKHP();
            dk.MaHV = MaHV;
            dk.HoTen = HoTen;
            dk.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HocVien_TTHV tt = new HocVien_TTHV();
            tt.MaHV = MaHV;
            tt.HoTen = HoTen;
            tt.Show();
        }
    }
}
