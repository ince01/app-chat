using MetroFramework.Forms;
using Quobject.SocketIoClientDotNet.Client;
using System;
using System.Windows.Forms;

namespace app_chat
{
    public partial class frmMain : MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
            socket.On("chat message", (data) =>
             {
                 list_msg.Items.Add(data.ToString());
             });
        }

        Socket socket = IO.Socket("http://localhost:3000");


        private void metroLink1_Click(object sender, EventArgs e)
        {
            DialogResult close = MetroFramework.MetroMessageBox.Show(this, "Close application?", "Quit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (close == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            socket.Emit("chat message", txt_msg.Text);
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
