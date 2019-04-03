namespace app_chat
{
    partial class frmMain
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
            this.txt_msg = new MetroFramework.Controls.MetroTextBox();
            this.btn_send = new MetroFramework.Controls.MetroLink();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.list_msg = new System.Windows.Forms.ListBox();
            this.txt_username = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // txt_msg
            // 
            // 
            // 
            // 
            this.txt_msg.CustomButton.Image = null;
            this.txt_msg.CustomButton.Location = new System.Drawing.Point(323, 2);
            this.txt_msg.CustomButton.Name = "";
            this.txt_msg.CustomButton.Size = new System.Drawing.Size(55, 55);
            this.txt_msg.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_msg.CustomButton.TabIndex = 1;
            this.txt_msg.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_msg.CustomButton.UseSelectable = true;
            this.txt_msg.CustomButton.Visible = false;
            this.txt_msg.Lines = new string[0];
            this.txt_msg.Location = new System.Drawing.Point(23, 210);
            this.txt_msg.MaxLength = 32767;
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.PasswordChar = '\0';
            this.txt_msg.PromptText = "Input massage ...";
            this.txt_msg.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_msg.SelectedText = "";
            this.txt_msg.SelectionLength = 0;
            this.txt_msg.SelectionStart = 0;
            this.txt_msg.ShortcutsEnabled = true;
            this.txt_msg.Size = new System.Drawing.Size(381, 60);
            this.txt_msg.TabIndex = 0;
            this.txt_msg.UseSelectable = true;
            this.txt_msg.WaterMark = "Input massage ...";
            this.txt_msg.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_msg.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_msg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_msg_KeyDown);
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(329, 276);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 1;
            this.btn_send.Text = "Send";
            this.btn_send.UseSelectable = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(397, 11);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(27, 21);
            this.metroLink1.TabIndex = 2;
            this.metroLink1.Text = "X";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // list_msg
            // 
            this.list_msg.FormattingEnabled = true;
            this.list_msg.Location = new System.Drawing.Point(23, 92);
            this.list_msg.Name = "list_msg";
            this.list_msg.Size = new System.Drawing.Size(381, 108);
            this.list_msg.TabIndex = 5;
            // 
            // txt_username
            // 
            this.txt_username.AutoSize = true;
            this.txt_username.Location = new System.Drawing.Point(23, 11);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(66, 19);
            this.txt_username.TabIndex = 6;
            this.txt_username.Text = "username";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 322);
            this.ControlBox = false;
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.list_msg);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_msg);
            this.Name = "frmMain";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_msg;
        private MetroFramework.Controls.MetroLink btn_send;
        private MetroFramework.Controls.MetroLink metroLink1;
        private System.Windows.Forms.ListBox list_msg;
        private MetroFramework.Controls.MetroLabel txt_username;
    }
}

