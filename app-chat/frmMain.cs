using MetroFramework.Forms;
using Quobject.SocketIoClientDotNet.Client;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace app_chat
{
    public partial class frmMain : MetroForm
    {
        Socket socket = IO.Socket("https://app-chat-server.herokuapp.com/");

        public frmMain()
        {
            InitializeComponent();
            socket.On("chat message", (data) =>
            {
                list_msg.Items.Add(data.ToString());
                //socket.Disconnect();
            });
        }

        string name;

        public void socketManager()
        {
            socket.Emit("chat message", name + ":  " + txt_msg.Text);
            //list_msg.Items.Add(txt_msg.Text);
            //socket.On("chat message", (data) =>
            //{
            //    list_msg.Items.Add(data.ToString());
            //    //socket.Disconnect();

            //});
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            DialogResult close = MetroFramework.MetroMessageBox.Show(this, "Close application?", "Quit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (close == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            socketManager();
            txt_msg.Clear();
            txt_msg.Focus();
        }

        private void txt_msg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_send.PerformClick();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            using (Entities db = new Entities())
            {
                var query = from User in db.Users
                            join Role in db.Roles on User.roleId equals Role.roleId
                            where User.username == frmLogin.Instance.UserInfo.username
                            select new { User.username, Role.roleName };

                name = query.Single().username.ToString();

                txt_username.Text = "Name: " + query.SingleOrDefault().username.ToString() + 
                    ". Role: " + query.SingleOrDefault().roleName.ToString();  ;
            }
        }
    }
}
