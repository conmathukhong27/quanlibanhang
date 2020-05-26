namespace quanlibanhang
{
    partial class Frmmaincs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.chấtLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hangToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.frmChatLieuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hoadonbanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HangToolStripMenuItem,
            this.frmChatLieuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HangToolStripMenuItem
            // 
            this.HangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.chấtLiệuToolStripMenuItem,
            this.hangToolStripMenuItem1,
            this.hoadonbanToolStripMenuItem});
            this.HangToolStripMenuItem.Name = "HangToolStripMenuItem";
            this.HangToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.HangToolStripMenuItem.Text = "Hang";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // chấtLiệuToolStripMenuItem
            // 
            this.chấtLiệuToolStripMenuItem.Name = "chấtLiệuToolStripMenuItem";
            this.chấtLiệuToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.chấtLiệuToolStripMenuItem.Text = "Chất Liệu";
            this.chấtLiệuToolStripMenuItem.Click += new System.EventHandler(this.chấtLiệuToolStripMenuItem_Click);
            // 
            // hangToolStripMenuItem1
            // 
            this.hangToolStripMenuItem1.Name = "hangToolStripMenuItem1";
            this.hangToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.hangToolStripMenuItem1.Text = "Hang";
            this.hangToolStripMenuItem1.Click += new System.EventHandler(this.hangToolStripMenuItem1_Click);
            // 
            // frmChatLieuToolStripMenuItem
            // 
            this.frmChatLieuToolStripMenuItem.Name = "frmChatLieuToolStripMenuItem";
            this.frmChatLieuToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // hoadonbanToolStripMenuItem
            // 
            this.hoadonbanToolStripMenuItem.Name = "hoadonbanToolStripMenuItem";
            this.hoadonbanToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.hoadonbanToolStripMenuItem.Text = "Hoadonban";
            this.hoadonbanToolStripMenuItem.Click += new System.EventHandler(this.hoadonbanToolStripMenuItem_Click);
            // 
            // Frmmaincs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frmmaincs";
            this.Text = "Frmmaincs";
            this.Load += new System.EventHandler(this.Frmmaincs_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frmChatLieuToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem chấtLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hangToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hoadonbanToolStripMenuItem;
    }
}