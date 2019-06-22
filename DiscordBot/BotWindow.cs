using DiscordLib;
using Se7en.UI.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordBot {
    public partial class BotWindow : Form
    {

        private Discord _discord;
        public BotWindow() {
            InitializeComponent();
        }
        public BotWindow(Discord discord) : this()
        {
            _discord = discord;
        }
        private void BotWindow_Shown(object sender, EventArgs e) {
            DragAndDroper.Init(this, this);
        }

        private void BtClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e) { 
            _discord.SendMessage(TxbChannelID.Text, TxbMessage.Text);
        }
    }
}
