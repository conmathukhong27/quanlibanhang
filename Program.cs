using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using quanlibanhang;

namespace QuanLyBanHang
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Data Source = huuphuoccao\sqlexpress; Initial Catalog = CSLT2; Integrated Security = True

            Application.Run(new Frmmaincs());
        }
    }
}