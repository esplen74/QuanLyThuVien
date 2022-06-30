namespace WindowsFormsApp1
{
    partial class frmSystem
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
            this.quảnLýHệToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐộcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýMượnTrảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hỗTrợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQLSach = new System.Windows.Forms.Button();
            this.btnQLTheLoai = new System.Windows.Forms.Button();
            this.btnQLMuonTra = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýHệToolStripMenuItem,
            this.hỗTrợToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(823, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýHệToolStripMenuItem
            // 
            this.quảnLýHệToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.quảnLýHệToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýĐộcGiảToolStripMenuItem,
            this.quảnLýTácGiảToolStripMenuItem,
            this.quảnLýMượnTrảToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.quảnLýHệToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.menu;
            this.quảnLýHệToolStripMenuItem.Name = "quảnLýHệToolStripMenuItem";
            this.quảnLýHệToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.quảnLýHệToolStripMenuItem.Text = "Hệ Thống";
            this.quảnLýHệToolStripMenuItem.Click += new System.EventHandler(this.quảnLýHệToolStripMenuItem_Click);
            // 
            // quảnLýĐộcGiảToolStripMenuItem
            // 
            this.quảnLýĐộcGiảToolStripMenuItem.Name = "quảnLýĐộcGiảToolStripMenuItem";
            this.quảnLýĐộcGiảToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.quảnLýĐộcGiảToolStripMenuItem.Text = "Quản lý sách";
            this.quảnLýĐộcGiảToolStripMenuItem.Click += new System.EventHandler(this.quảnLýĐộcGiảToolStripMenuItem_Click);
            // 
            // quảnLýTácGiảToolStripMenuItem
            // 
            this.quảnLýTácGiảToolStripMenuItem.Name = "quảnLýTácGiảToolStripMenuItem";
            this.quảnLýTácGiảToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.quảnLýTácGiảToolStripMenuItem.Text = "Quản lý thể loại";
            this.quảnLýTácGiảToolStripMenuItem.Click += new System.EventHandler(this.quảnLýTácGiảToolStripMenuItem_Click);
            // 
            // quảnLýMượnTrảToolStripMenuItem
            // 
            this.quảnLýMượnTrảToolStripMenuItem.Name = "quảnLýMượnTrảToolStripMenuItem";
            this.quảnLýMượnTrảToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.quảnLýMượnTrảToolStripMenuItem.Text = "Quản lý mượn trả";
            this.quảnLýMượnTrảToolStripMenuItem.Click += new System.EventHandler(this.quảnLýMượnTrảToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.thoátToolStripMenuItem.Text = "thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // hỗTrợToolStripMenuItem
            // 
            this.hỗTrợToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.hoi;
            this.hỗTrợToolStripMenuItem.Name = "hỗTrợToolStripMenuItem";
            this.hỗTrợToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.hỗTrợToolStripMenuItem.Text = "Hỗ trợ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(303, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Thư Viện";
            // 
            // btnQLSach
            // 
            this.btnQLSach.BackColor = System.Drawing.Color.Transparent;
            this.btnQLSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnQLSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLSach.ForeColor = System.Drawing.Color.Black;
            this.btnQLSach.Image = global::WindowsFormsApp1.Properties.Resources.Untitled;
            this.btnQLSach.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnQLSach.Location = new System.Drawing.Point(74, 203);
            this.btnQLSach.Name = "btnQLSach";
            this.btnQLSach.Size = new System.Drawing.Size(203, 47);
            this.btnQLSach.TabIndex = 2;
            this.btnQLSach.Text = "Quản lý sách";
            this.btnQLSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLSach.UseMnemonic = false;
            this.btnQLSach.UseVisualStyleBackColor = false;
            this.btnQLSach.Click += new System.EventHandler(this.btnQLSach_Click);
            // 
            // btnQLTheLoai
            // 
            this.btnQLTheLoai.BackColor = System.Drawing.Color.Transparent;
            this.btnQLTheLoai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnQLTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLTheLoai.ForeColor = System.Drawing.Color.Black;
            this.btnQLTheLoai.Image = global::WindowsFormsApp1.Properties.Resources.theloai;
            this.btnQLTheLoai.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnQLTheLoai.Location = new System.Drawing.Point(333, 203);
            this.btnQLTheLoai.Name = "btnQLTheLoai";
            this.btnQLTheLoai.Size = new System.Drawing.Size(203, 47);
            this.btnQLTheLoai.TabIndex = 4;
            this.btnQLTheLoai.Text = "Quản lý thể loại";
            this.btnQLTheLoai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLTheLoai.UseMnemonic = false;
            this.btnQLTheLoai.UseVisualStyleBackColor = false;
            this.btnQLTheLoai.Click += new System.EventHandler(this.btnQLTheLoai_Click);
            // 
            // btnQLMuonTra
            // 
            this.btnQLMuonTra.BackColor = System.Drawing.Color.Transparent;
            this.btnQLMuonTra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnQLMuonTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLMuonTra.ForeColor = System.Drawing.Color.Black;
            this.btnQLMuonTra.Image = global::WindowsFormsApp1.Properties.Resources.muontra;
            this.btnQLMuonTra.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnQLMuonTra.Location = new System.Drawing.Point(586, 203);
            this.btnQLMuonTra.Name = "btnQLMuonTra";
            this.btnQLMuonTra.Size = new System.Drawing.Size(203, 47);
            this.btnQLMuonTra.TabIndex = 5;
            this.btnQLMuonTra.Text = "Quản lý mượn trả";
            this.btnQLMuonTra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLMuonTra.UseMnemonic = false;
            this.btnQLMuonTra.UseVisualStyleBackColor = false;
            this.btnQLMuonTra.Click += new System.EventHandler(this.btnQLMuonTra_Click);
            // 
            // frmSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.anhthuvien2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(823, 454);
            this.Controls.Add(this.btnQLMuonTra);
            this.Controls.Add(this.btnQLTheLoai);
            this.Controls.Add(this.btnQLSach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSystem";
            this.Text = "frmSystem";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHệToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐộcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTácGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýMượnTrảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQLSach;
        private System.Windows.Forms.Button btnQLTheLoai;
        private System.Windows.Forms.ToolStripMenuItem hỗTrợToolStripMenuItem;
        private System.Windows.Forms.Button btnQLMuonTra;
    }
}