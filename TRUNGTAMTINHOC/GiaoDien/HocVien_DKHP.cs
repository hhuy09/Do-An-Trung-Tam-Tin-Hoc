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
    public partial class HocVien_DKHP : Form
    {
        public string HoTen;
        public string MaHV;
        public HocVien_DKHP()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
            }
        }

        private void HocVien_DKHP_Load(object sender, EventArgs e)
        {
            label2.Text = HoTen;

            DataTable dt1 = NghiepVu.LopHoc.DanhSachLopHocPhan(MaHV,"2021-1");
            dataGridView1.DataSource = dt1;

            DataTable dt2 = NghiepVu.DangKyHocPhan.DanhSachDKHP(MaHV, "2021-1");
            dataGridView2.DataSource = dt2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
