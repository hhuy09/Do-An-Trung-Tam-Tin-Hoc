﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace TRUNGTAMTINHOC.TruyCapDuLieu
{
    class KhoaHocDB
    {
        public static DataTable Danhsachkhoahoc(string namky)
        {
            string connectString = ConfigurationManager.ConnectionStrings["TTTH"].ConnectionString.ToString();
            SqlConnection con = new SqlConnection(connectString);
            con.Open();

            try
            {
                string sql = "EXEC sp_danhsachKDT '" + namky + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception error)
            {
                string errorStr = error.ToString();
                string[] arrStr0 = errorStr.Split(':');
                string[] arrStr = arrStr0[1].Split('\n');
                MessageBox.Show(arrStr[0].ToString());
                return null;
            }
        }      
    }
}
