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
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1
{
    public partial class frmQLMuonTra : Form
    {
        public frmQLMuonTra()
        {
            InitializeComponent();
        }
        LOPDUNGCHUNG lopdungchung = new LOPDUNGCHUNG();
        MuonTra muontra;
        public void LoadMuonTra()
        {
            string sql = "SELECT danhsachmuon.mamuon, danhsachmuon.mathe, danhsachmuon.ngaymuon, danhsachmuon.ngaytra, dbo.chitietdanhsachmuon.soluongsach, dbo.sach.masach,sach.tensach FROM dbo.chitietdanhsachmuon INNER JOIN dbo.danhsachmuon ON chitietdanhsachmuon.mamuon = danhsachmuon.mamuon INNER JOIN sach ON chitietdanhsachmuon.masach = sach.masach";
            dgvMuonSach.DataSource = lopdungchung.LoadBang(sql);
        }

        private void frmQLMuonTra_Load_1(object sender, EventArgs e)
        {
            LoadMuonTra();
        }

        private void dgvMuonSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMuon.Text = dgvMuonSach.CurrentRow.Cells["mamuon"].Value.ToString();
            txtMaThe.Text = dgvMuonSach.CurrentRow.Cells["mathe"].Value.ToString();
            txtSoLuong.Text = dgvMuonSach.CurrentRow.Cells["soluongsach"].Value.ToString();
            txtMaSach.Text = dgvMuonSach.CurrentRow.Cells["masach"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            muontra = new MuonTra(txtMaMuon.Text,txtMaThe.Text, txtMaSach.Text,txtSoLuong.Text,dtMuonTra.Text,null); 
 


             string sql = "insert into danhsachmuon values(N'" + muontra.MaMuon + "', N'" + muontra.MaThe + "',Convert(Date,'" + muontra.NgayMuon + "',103),'" + muontra.NgayTra + "')";
            string sql1 = "Insert into chitietdanhsachmuon values(N'" + muontra.MaMuon + "',N'" + muontra.MaSach + "'," + muontra.SoLuong + ")";
            int kq = lopdungchung.ThemXoaSua(sql);
            int t=lopdungchung.ThemXoaSua(sql1);
            if (kq >= 1) MessageBox.Show("Mượn thành công");
            else MessageBox.Show("Mượn thất bại");
            LoadMuonTra();
        }

        private void quảnLýĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLSach frmQLSach = new frmQLSach();
            frmQLSach.Show();
            Hide();
        }

        private void quảnLýTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLTheLoai frmQLTheLoai = new frmQLTheLoai();
            frmQLTheLoai.Show();
            Hide();
        }

        private void quảnLýMượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLMuonTra frmQLMuonTra = new frmQLMuonTra();
            frmQLMuonTra.Show();
            Hide();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Bạn có thực sự muốn thoát không ?";
            string title = "Thoát";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            string sql = "update danhsachmuon set ngaytra = Convert(Date,'" + dtMuonTra.Value + "',103) where mamuon = '"+txtMaMuon.Text+"'";
            int kq = lopdungchung.ThemXoaSua(sql);
            
            if (kq >= 1) MessageBox.Show("Trả thành công");
            else MessageBox.Show("Trả thất bại");
            LoadMuonTra();
        }

       
    }
}
