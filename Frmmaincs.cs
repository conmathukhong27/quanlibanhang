using QuanLyBanHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlibanhang
{
    public partial class Frmmaincs : Form
    {
        public Frmmaincs()
        {
            InitializeComponent();
        }

        

      
        private void chấtLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChatlieu f1 = new FrmChatlieu();
            f1.Show();
        }

        private void hangToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hang f1 = new Hang();
            f1.Show();
        }

        private void Frmmaincs_Load(object sender, EventArgs e)
        {

        }

        private void hoadonbanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHoadonBan f1 = new FrmHoadonBan();
            f1.Show();
        }


        //private void frmChatLieuToolStripMenuItem_Click(object sender, EventArgs e)




        //private void Frmmaincs_Load(object sender, EventArgs e)




        //private void toolStripComboBox1_Click(object sender, EventArgs e)



    }
}
