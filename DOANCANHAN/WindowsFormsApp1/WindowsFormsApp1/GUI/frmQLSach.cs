using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.connect;

namespace WindowsFormsApp1
{
    public partial class frmQLSach : Form
    {
        public frmQLSach()
        {
            InitializeComponent();
        }
        LOPDUNGCHUNG lopdungchung = new LOPDUNGCHUNG();
       
        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSach.Text = dgvSach.CurrentRow.Cells["masach"].Value.ToString();
            txtMaTheLoai.Text = dgvSach.CurrentRow.Cells["matheloai"].Value.ToString();
            txtTenSach.Text = dgvSach.CurrentRow.Cells["tensach"].Value.ToString();
            txtNhaXuatBan.Text = dgvSach.CurrentRow.Cells["nhaxuatban"].Value.ToString();
            txtNamXuatBan.Text = dgvSach.CurrentRow.Cells["namxuatban"].Value.ToString();
            txtSoLanXuatBan.Text = dgvSach.CurrentRow.Cells["solantaiban"].Value.ToString();
            txtGiaThanh.Text = dgvSach.CurrentRow.Cells["giathanh"].Value.ToString();
            txtTacGia.Text = dgvSach.CurrentRow.Cells["tacgia"].Value.ToString();
            string path = dgvSach.CurrentRow.Cells["hinhanh"].Value.ToString();
            PTBSach.Image = Image.FromFile(@"..\..\Resources\" + path + ".png");
        }

        public void LoadSach()
        {
            string sql = "Select * from sach";
            dgvSach.DataSource = lopdungchung.LoadBang(sql);
        }

        private void frmQLSach_Load(object sender, EventArgs e)
        {
            LoadSach();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
             string sql = "Insert into sach values (N'" + txtMaSach.Text + "',N'" + txtMaTheLoai.Text + "',N'" + txtTenSach.Text + "',N'" + txtNhaXuatBan.Text + "',N'" + txtTacGia.Text + "',Convert(Date,'" + txtNamXuatBan.Text + "',103),N'" + txtSoLanXuatBan.Text + "',N'" + txtGiaThanh.Text + "',N'" + "anh" + "')";
            int kq = lopdungchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Thêm sách thành công");
            else MessageBox.Show("Thêm sách thất bại");
            LoadSach();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sql= "update sach set matheloai = N'" + txtMaTheLoai.Text + "', namxuatban = Convert(Date,'" + txtNamXuatBan.Text + "',103), nhaxuatban = N'" + txtNhaXuatBan.Text + "', solantaiban = N'" + txtSoLanXuatBan.Text + "', tacgia = N'" + txtTacGia.Text + "', giathanh = N'" + txtGiaThanh.Text + "', tensach = N'" + txtTenSach.Text + "' where masach =N'" + txtMaSach.Text + "'";
            int kq = lopdungchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Sửa thành công");
            else MessageBox.Show("Sửa thất bại");
            LoadSach();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = "Delete sach where masach = '" + txtMaSach.Text + "'";
            string sql2="Delete chitietdanhsachmuon where masach = '"+txtMaSach.Text + "'";
            var result = MessageBox.Show("bạn có thật sự muốn xóa không", "thông báo",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                lopdungchung.ThemXoaSua(sql2); 
                int kq = lopdungchung.ThemXoaSua(sql);
                if (kq >= 1) MessageBox.Show("Xóa thành công");
                else MessageBox.Show("Xóa thất bại");
            }
            LoadSach();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("bạn có thật sự muốn thoát không", "thông báo",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
            frmSystem frm = new frmSystem();
            frm.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Bạn có thực sự muốn thoát không ?";
            string title = "Thoát";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
                Application.Exit();.

        }

        private void quảnLýTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLTheLoai frmQLTheLoai = new frmQLTheLoai();
            frmQLTheLoai.Show();
            Hide();
        }

        private void quảnLýĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLSach frmQLSach = new frmQLSach();
            frmQLSach.Show();
            Hide();
        }

        private void quảnLýMượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLMuonTra frmQLMuonTra = new frmQLMuonTra();
            frmQLMuonTra.Show();
            Hide();
        }

        
    }
}
