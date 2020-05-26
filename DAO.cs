﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Windows;
using System.Windows.Forms;
using System.Data;

namespace QuanLyBanHang
{
    class DAO
    {
        public static SqlConnection conn;
        public static string connectionString = "Data Source=welcome-pc\\sqlexpress;Initial Catalog=quanlibanhag;Integrated Security=True";
        public static void OpenConnection()
        {
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            if (conn.State == System.Data.ConnectionState.Closed)
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
        }
        public static void CloseConnection()
        {
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            if (conn.State == System.Data.ConnectionState.Open)
                try
                {
                    conn.Close();
                    MessageBox.Show("Đóng kết nối thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
        }
        public static bool checkKeyexit(string sql)
        {
            bool kq = false;
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                kq = true;
            return kq;


        }    
    }
}