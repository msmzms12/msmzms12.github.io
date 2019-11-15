using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVien
{
     static class Connect
    {
        private static string sqlConnect = @"Data Source=PHAMVANTAI\SQLEXPRESS;Initial Catalog=quanlysinhvien;Integrated Security=True";

        public static SqlConnection taoketnoi()
        {
            return new SqlConnection(sqlConnect);
        }


        public static DataTable LayBang(string sql)
        {
            SqlConnection ketnoi = taoketnoi();
            ketnoi.Open();
            SqlDataAdapter ad = new SqlDataAdapter(sql, ketnoi);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            ketnoi.Close();
            ad.Dispose();
            return dt;
        }

        public static void ThemXuaXoa(string sql)
        {
            SqlConnection ketnoi = taoketnoi();
            ketnoi.Open();
            SqlCommand lenh = new SqlCommand(sql, ketnoi);
            lenh.ExecuteNonQuery();
            ketnoi.Close();
            lenh.Dispose();
        }




    }
   
    }

