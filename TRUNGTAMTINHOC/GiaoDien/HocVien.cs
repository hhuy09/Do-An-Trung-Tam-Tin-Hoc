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
    public partial class HocVien : Form
    {
        string MaHV;
        string HoTen;

        public HocVien()
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
            HoTen = "abc";
            label2.Text = HoTen;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HocVien_DKKHCD dk = new HocVien_DKKHCD();
            dk.MaHV = MaHV;
            dk.HoTen = HoTen;
            dk.Show();
            
        }
    }
}
