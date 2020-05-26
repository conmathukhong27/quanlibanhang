using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Data.Sql;


namespace QuanLyBanHang
{
    public partial class FrmChatlieu : Form
    {
        public FrmChatlieu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadformCL();
        }
        private void loadformCL()
        {
            try
            {
                DAO.OpenConnection();
                string sql = "select * from tblChatLieu";
                SqlDataAdapter adap = new SqlDataAdapter(sql, DAO.conn);
                DataTable table = new DataTable();
                adap.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DAO.CloseConnection();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMa.Text = dataGridView1.CurrentRow.Cells["MaChatLieu"].Value.ToString();
            textBoxten.Text = dataGridView1.CurrentRow.Cells["TenChatLieu"].Value.ToString();
            textBoxMa.Visible = true;
        }

        

        
        

        private void btnSua_Click(object sender, EventArgs e)
        {
            string Sql = "Update tblChatLieu set TenChatLieu = N'" + textBoxten.Text.Trim() +
               "' where MaChatLieu = '" + textBoxMa.Text + "'";
            DAO.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = Sql;
            cmd.Connection = DAO.conn;
            cmd.ExecuteNonQuery();
            DAO.CloseConnection();
            loadformCL();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            textBoxMa.Enabled = true;
            textBoxten.Enabled = true;
            textBoxMa.Text = "";
            textBoxten.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql = "delete from tblChatlieu where MaChatLieu = '" + textBoxMa.Text + "'";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = DAO.conn;
                cmd.ExecuteNonQuery();
                DAO.CloseConnection();
                loadformCL();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(textBoxMa.Text=="")
            {
                MessageBox.Show("bạn chưa điền mã");
                textBoxMa.Focus();
                return;

            } 
            if(textBoxten.Text=="")
            {
                MessageBox.Show("Bạn chưa điền tên");
                textBoxten.Focus();
                return;
            }
            string sqlcheckkey = "select * from tblChatLieu where MaChatLieu= '" + textBoxMa.Text.Trim() + "'";
            DAO.OpenConnection();
            if(DAO.checkKeyexit(sqlcheckkey))
            {
                MessageBox.Show("ma chat lieu da ton tai");
                DAO.CloseConnection();
                textBoxMa.Focus();
                return;
            }
            else
            {
                string sql = "insert into tblChatLieu(MaChatLieu,TenChatLieu)values('" + textBoxMa.Text.Trim() + "',N'" + textBoxten.Text.Trim() + "')";
                DAO.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = DAO.conn;
                cmd.ExecuteNonQuery();
                DAO.CloseConnection();
                loadformCL();

            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}