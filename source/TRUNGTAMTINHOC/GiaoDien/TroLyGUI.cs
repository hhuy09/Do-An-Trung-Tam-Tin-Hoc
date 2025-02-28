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
    public partial class TroLy : Form
    {
        public string MaNV;
        public string HoTen;

        public TroLy()
        {
            InitializeComponent();
        }

        private void TroLy_Load(object sender, EventArgs e)
        {
            label2.Text = HoTen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            this.Close();
            dn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GiaoDien.TroLy_QLLTGUI troly = new GiaoDien.TroLy_QLLTGUI();

            troly.MaNV = MaNV;
            troly.HoTen = HoTen;
            troly.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GiaoDien.TroLy_QLLHGUI troly = new GiaoDien.TroLy_QLLHGUI();
            troly.MaNV = MaNV;
            troly.HoTen = HoTen;
            troly.Show();
        }
    }
}
