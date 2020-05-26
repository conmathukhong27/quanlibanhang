using QuanLyBanHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlibanhang
{
    public partial class Hang : Form
    {
        public Hang()
        {
            InitializeComponent();
        }

        private void Hang_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            loadformCL();
            filldatatocombo();
            DAO.CloseConnection();
        }
        private void loadformCL()
        {
                string sql = "select * from tblHang";
           SqlDataAdapter adap = new SqlDataAdapter(sql, DAO.conn);
                DataTable table = new DataTable();
                adap.Fill(table);
                GridViewDanhmuchang.DataSource = table;
            }
        public void filldatatocombo()
        {
            string sql = "select * from tblChatLieu";
            SqlDataAdapter adap = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            adap.Fill(table);
            cmbChatLieu.DataSource = table;
            cmbChatLieu.ValueMember = "MaChatLieu";
            cmbChatLieu.DisplayMember = "TenChatLieu";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtTenHang.Text = "";
            txtMaHang.Text = "";
            txtGiaNhap.Text = "";
            txtGiaBan.Text = "";
            lozz.Text = "";
            cmbChatLieu.SelectedIndex = -1;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //ktra dữ liệu
            //các trường k trống
            //mã hàng k trùng
            if(txtMaHang.Text=="")
            {
                MessageBox.Show("không đc để trống mã hàng");
                txtMaHang.Focus();
                return;
            }
            if(txtTenHang.Text=="")
            {
                MessageBox.Show("Không đc để trống tên hàng");
                txtTenHang.Focus();
                return;
            }
            if(cmbChatLieu.SelectedIndex==-1)
            {
                MessageBox.Show("chưa chọn chất liệu");
                return;
            }
            if(txtGiaNhap.Text=="")
            {
                MessageBox.Show("Không để trống giá nhập");
                txtGiaNhap.Focus();
                return;

            }
            if(txtGiaBan.Text=="")
            {
                MessageBox.Show("Không để trống giá bán");
                txtGiaBan.Focus();
                return;
            }
            if(txtSoLuong.Text=="")
            {
                MessageBox.Show("không để trống số lượng");
                txtSoLuong.Focus();
                return;
            }
            string sql = "select * from tblHang where MaHang='" + txtMaHang.Text.Trim() + "'";
            DAO.OpenConnection();
            if(DAO.checkKeyexit(sql))
            {
                MessageBox.Show("Ma hang tồn tại");
                txtMaHang.Focus();
                DAO.CloseConnection();
                return;
            }
            else
            {
                sql = "insert into tblHang (MaHang,TenHang,MaChatLieu,SoLuong,DonGiaNhap,DonGiaBan,GhiChu) " +
                    " values ('" + txtMaHang.Text.Trim() + "',N'" + txtTenHang.Text.Trim() + "','" + cmbChatLieu.SelectedValue.ToString() + "'," + txtSoLuong.Text.Trim() + "," + txtGiaNhap.Text.Trim() + "," + txtGiaBan.Text.Trim() + ",N'" + txtGhiChu.Text.Trim() + "')";
                SqlCommand cmd = new SqlCommand(sql, DAO.conn);
                cmd.ExecuteNonQuery();
                loadformCL();
                filldatatocombo();
  
                DAO.CloseConnection();
                //trang 157,158
                
            }   
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "update tblHang set TenHang = N'" + txtTenHang.Text.Trim() + "' where MaHang = '" + txtMaHang.Text + "';";
            DAO.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO.conn;
            cmd.ExecuteNonQuery();
            DAO.CloseConnection();
            loadformCL();
        }
    }
    }

