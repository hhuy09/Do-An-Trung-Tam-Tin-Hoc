﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TRUNGTAMTINHOC.TruyCapDuLieu;

namespace TRUNGTAMTINHOC.NghiepVu
{
    class KhoaDaoTao
    {
        private string MaLopDT;
        private string KhoaHoc;
        private string NamKy;
        private string NVTroLy;
        private string NgayKhaiGiang;
        private string NgayThiTN;
        private string SiSo;
        private string DaDangKy;

        public static DataTable DanhSachThiTotNghiep(string NVChuyenMon)
        {
            return TruyCapDuLieu.KhoaDaoTaoDB.DSThiTotNghiep(NVChuyenMon);
        }
    }
}