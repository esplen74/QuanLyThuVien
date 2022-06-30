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
    public partial class frmQLTheLoai : Form
    {
        public frmQLTheLoai()
        {
            InitializeComponent();
        }
        LOPDUNGCHUNG lopdungchung = new LOPDUNGCHUNG();
        public void LoadTheLoai()
        {
            string sql = "Select * from theloai";
            dgvTheLoai.DataSource = lopdungchung.LoadBang(sql);
        }
        private void frmQLTheLoai_Load(object sender, EventArgs e)
        {
            LoadTheLoai();
        }

        private void dgvTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text= dgvTheLoai.CurrentRow.Cells["matheloai"].Value.ToString();
            txtTen.Text= dgvTheLoai.CurrentRow.Cells["tentheloai"].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = "Insert into theloai values (N'" + txtMa.Text + "',N'" + txtTen.Text + "')";
            int kq = lopdungchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Thêm thành công");
            else MessageBox.Show("Thêm thất bại");
            LoadTheLoai();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sql = "update theloai set tentheloai = N'" + txtTen.Text + "' where matheloai =N'" + txtMa.Text + "'";
            int kq = lopdungchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Sửa thành công");
            else MessageBox.Show("Sửa thất bại");
            LoadTheLoai();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = "Delete theloai where matheloai = '" + txtMa.Text + "'";
           
            var result = MessageBox.Show("bạn có thật sự muốn xóa không", "thông báo",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int kq = lopdungchung.ThemXoaSua(sql);
                if (kq >= 1) MessageBox.Show("Xóa sinh viên thành công");
                else MessageBox.Show("Xóa sinh viên thất bại");
            }
            LoadTheLoai();
        }

        private void tdbMa_CheckedChanged(object sender, EventArgs e)
        {

            string sql = "Select * from theloai where matheloai = '"+txtFind.Text+"'";
            if(txtFind.Text.Length == 0)
            {
                LoadTheLoai();
            }else
            dgvTheLoai.DataSource = lopdungchung.LoadBang(sql);
        }

        private void rdbTheLoai_CheckedChanged(object sender, EventArgs e)
        {
            string sql = "Select * from theloai where tentheloai = N'" + txtFind.Text + "'";
            if (txtFind.Text.Length == 0)
            {
                LoadTheLoai();
            }
            else
                dgvTheLoai.DataSource = lopdungchung.LoadBang(sql);
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

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Bạn có thực sự muốn thoát không ?";
            string title = "Thoát";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           if( tdbMa.Checked)
            {
                string sql = "Select * from theloai where matheloai = '" + txtFind.Text + "'";
                if (txtFind.Text.Length == 0)
                {
                    LoadTheLoai();
                }
                else
                    dgvTheLoai.DataSource = lopdungchung.LoadBang(sql);
            }
           if(rdbTheLoai.Checked)
            {
                string sql = "Select * from theloai where tentheloai = N'" + txtFind.Text + "'";
                if (txtFind.Text.Length == 0)
                {
                    LoadTheLoai();
                }
                else
                    dgvTheLoai.DataSource = lopdungchung.LoadBang(sql);
            }
            
        }
    }
}
