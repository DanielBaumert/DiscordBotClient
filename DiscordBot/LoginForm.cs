using DiscordLib;
using Se7en;
using Se7en.UI.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordBot {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        private void LoginForm_Shown(object sender, EventArgs e) {
            DragAndDroper.Init(this, PicLogo);
            DragAndDroper.Init(this, this);
        }

        private void BtClose_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void BtLogin_Click(object sender, EventArgs e) {
            UiLogin();
        }

        private void TxbEmail_KeyUp(object sender, KeyEventArgs e) {

            if (e.KeyCode == Keys.Enter)
                if (string.IsNullOrEmpty(TxbPassword.Text))
                    TxbPassword.Select();
                else
                    UiLogin();
        }

        private void MainWindow_Closed(object sender, EventArgs e) 
            => Show();


        private void UiLogin() {
            try {
                Discord discord = Login(TxbEmail.Text, TxbPassword.Text);
                BotWindow mainWindow = new BotWindow(discord);
                mainWindow.Closed += MainWindow_Closed;
                mainWindow.Show();
                Hide();
            } catch (Exception exception) {
                LbError.Text = exception.Message;
            }
        }

        private Discord Login(string email, string password) {
            if (!Validator.IsEmail(email))
                throw new Exception("Invalidate email address format");
            if (!Validator.IsPassword(password, ranged: false))
                throw new Exception("Invalidate password format");

            return Discord.Connect(email, password) ?? throw new Exception("Invalidate password or mail");
        }
    }
}
