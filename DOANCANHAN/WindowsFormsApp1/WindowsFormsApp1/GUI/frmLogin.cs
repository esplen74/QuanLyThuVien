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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
  
        }
        int d = 0;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string username= txtUsername.Text;
            string password= txtPassword.Text;
            if (username == "admin" && password == "123")
            {
                frmSystem frmSystem = new frmSystem();
                frmSystem.Show();
                Hide();
            }
            else
            {
                d++;
                MessageBox.Show("bạn đã nhập sai tài khoản lần thứ","Thông Báo");
                if (d == 3)
                {
                    Application.Exit();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string message = "Bạn có thực sự muốn thoát không ?";
            string title = "Thoát";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
                Application.Exit();

        }

       
    }
}
