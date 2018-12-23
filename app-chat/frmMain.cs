using MetroFramework.Forms;
using Quobject.SocketIoClientDotNet.Client;
using System;
using System.Windows.Forms;

namespace app_chat
{
    public partial class frmMain : MetroForm
    {
        Socket socket = IO.Socket("http://192.168.1.34:3000");


        public frmMain()
        {
            InitializeComponent();
            socket.On("chat message", (data) =>
            {
                list_msg.Items.Add(data.ToString());
                //socket.Disconnect();

            });
        }

        public void socketManager()
        {
            socket.Emit("chat message", txt_name.Text + ":  " + txt_msg.Text);
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
    }
}
