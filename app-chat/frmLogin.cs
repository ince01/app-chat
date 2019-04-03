using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace app_chat
{
    public partial class frmLogin : MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public User UserInfo { get; set; }

        private static frmLogin _instance;

        public static frmLogin Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmLogin();
                return _instance;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Plz insert user name & password !",
                    "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUser.Focus();
                return;
            }
            try
            {
                using (Entities db = new Entities())
                {
                    var query = from User in db.Users
                                where User.username == txtUser.Text && User.password == txtPass.Text
                                select User;
                    if (query.SingleOrDefault() != null)
                    {
                        UserInfo = query.SingleOrDefault();
                        this.Hide();
                        frmMain frm = new frmMain();
                        frm.ShowDialog();
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Invail username or password!",
                    "Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUser.Focus();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

       

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult close = MetroFramework.MetroMessageBox.Show(this, "Close this application?", "Quit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (close == DialogResult.Yes)
                Application.Exit();
        }

        private void txtUser_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPass.Focus();
            }
        }

        private void txtPass_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            _instance = this;
        }
    }
}
