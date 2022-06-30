using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmSystem : Form
    {
        public frmSystem()
        {
            InitializeComponent();
        }

        private void btnQLSach_Click(object sender, EventArgs e)
        {
            frmQLSach frmQLSach = new frmQLSach();
            frmQLSach.Show();
            Hide();
        }

        private void btnQLTheLoai_Click(object sender, EventArgs e)
        {
            frmQLTheLoai frmQLTheLoai = new frmQLTheLoai();
            frmQLTheLoai.Show();
            Hide();
        }

        private void btnQLMuonTra_Click(object sender, EventArgs e)
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

        private void quảnLýHệToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
