namespace DiscordBot {
    partial class BotWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            Se7en.UI.ColorFadeItem colorFadeItem5 = new Se7en.UI.ColorFadeItem();
            Se7en.UI.ColorFadeItem colorFadeItem6 = new Se7en.UI.ColorFadeItem();
            this.smoothLine1 = new Se7en.UI.SmoothLine();
            this.BtClose = new Se7en.UI.CloseButton();
            this.toggleButton1 = new Se7en.UI.ToggleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxbMessage = new Se7en.UI.TextBox();
            this.TxbChannelID = new Se7en.UI.TextBox();
            this.TxbServerID = new Se7en.UI.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // smoothLine1
            // 
            colorFadeItem5.Color = System.Drawing.Color.DodgerBlue;
            colorFadeItem5.Position = 0F;
            colorFadeItem6.Color = System.Drawing.Color.DarkViolet;
            colorFadeItem6.Position = 1F;
            this.smoothLine1.Colors = new Se7en.UI.ColorFadeItem[] {
        colorFadeItem5,
        colorFadeItem6};
            this.smoothLine1.Dock = System.Windows.Forms.DockStyle.Top;
            this.smoothLine1.Location = new System.Drawing.Point(0, 0);
            this.smoothLine1.Name = "smoothLine1";
            this.smoothLine1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.smoothLine1.Size = new System.Drawing.Size(855, 2);
            this.smoothLine1.TabIndex = 7;
            // 
            // BtClose
            // 
            this.BtClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtClose.CrossWidth = 4;
            this.BtClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtClose.HoverEffect = System.Drawing.Color.Firebrick;
            this.BtClose.HoverScaleOutWidth = 2;
            this.BtClose.Location = new System.Drawing.Point(826, 9);
            this.BtClose.Margin = new System.Windows.Forms.Padding(0);
            this.BtClose.Name = "BtClose";
            this.BtClose.Padding = new System.Windows.Forms.Padding(4);
            this.BtClose.ScaleOutHoverEffect = false;
            this.BtClose.Size = new System.Drawing.Size(20, 20);
            this.BtClose.TabIndex = 8;
            this.BtClose.Click += new System.EventHandler(this.BtClose_Click);
            // 
            // toggleButton1
            // 
            this.toggleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toggleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toggleButton1.Location = new System.Drawing.Point(230, 21);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.OffColor = System.Drawing.Color.DimGray;
            this.toggleButton1.OnColor = System.Drawing.Color.DeepSkyBlue;
            this.toggleButton1.Size = new System.Drawing.Size(35, 20);
            this.toggleButton1.TabIndex = 9;
            this.toggleButton1.ToggleColor = System.Drawing.Color.White;
            this.toggleButton1.ToggleState = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toggleButton1);
            this.groupBox1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox1.Location = new System.Drawing.Point(572, 365);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 177);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nickname";
            // 
            // TxbMessage
            // 
            this.TxbMessage.AutoScaleByText = false;
            this.TxbMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.TxbMessage.CompareWith = null;
            this.TxbMessage.CueText = "Message";
            this.TxbMessage.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxbMessage.IsntInput = null;
            this.TxbMessage.LineColor = System.Drawing.Color.DodgerBlue;
            this.TxbMessage.LineHeight = 2;
            this.TxbMessage.LineMarginHorizontal = 0;
            this.TxbMessage.LineMarginLeft = 0;
            this.TxbMessage.LineMarginRight = 0;
            this.TxbMessage.LineMarginToText = 1;
            this.TxbMessage.Location = new System.Drawing.Point(14, 67);
            this.TxbMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxbMessage.Multiline = true;
            this.TxbMessage.Name = "TxbMessage";
            this.TxbMessage.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.TxbMessage.PasswortChar = '\0';
            this.TxbMessage.Pattern = null;
            this.TxbMessage.PatternError = System.Drawing.Color.Red;
            this.TxbMessage.Size = new System.Drawing.Size(139, 133);
            this.TxbMessage.TabIndex = 10;
            this.TxbMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxbMessage.UseSystemPasswordChar = false;
            // 
            // TxbChannelID
            // 
            this.TxbChannelID.AutoScaleByText = false;
            this.TxbChannelID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.TxbChannelID.CompareWith = null;
            this.TxbChannelID.CueText = "ChannelID";
            this.TxbChannelID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxbChannelID.IsntInput = null;
            this.TxbChannelID.LineColor = System.Drawing.Color.DodgerBlue;
            this.TxbChannelID.LineHeight = 2;
            this.TxbChannelID.LineMarginHorizontal = 0;
            this.TxbChannelID.LineMarginLeft = 0;
            this.TxbChannelID.LineMarginRight = 0;
            this.TxbChannelID.LineMarginToText = 1;
            this.TxbChannelID.Location = new System.Drawing.Point(13, 13);
            this.TxbChannelID.Margin = new System.Windows.Forms.Padding(4);
            this.TxbChannelID.Multiline = false;
            this.TxbChannelID.Name = "TxbChannelID";
            this.TxbChannelID.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.TxbChannelID.PasswortChar = '\0';
            this.TxbChannelID.Pattern = null;
            this.TxbChannelID.PatternError = System.Drawing.Color.Red;
            this.TxbChannelID.Size = new System.Drawing.Size(140, 18);
            this.TxbChannelID.TabIndex = 12;
            this.TxbChannelID.Text = null;
            this.TxbChannelID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxbChannelID.UseSystemPasswordChar = false;
            // 
            // TxbServerID
            // 
            this.TxbServerID.AutoScaleByText = false;
            this.TxbServerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.TxbServerID.CompareWith = null;
            this.TxbServerID.CueText = "ServerID";
            this.TxbServerID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxbServerID.IsntInput = null;
            this.TxbServerID.LineColor = System.Drawing.Color.DodgerBlue;
            this.TxbServerID.LineHeight = 2;
            this.TxbServerID.LineMarginHorizontal = 0;
            this.TxbServerID.LineMarginLeft = 0;
            this.TxbServerID.LineMarginRight = 0;
            this.TxbServerID.LineMarginToText = 1;
            this.TxbServerID.Location = new System.Drawing.Point(14, 40);
            this.TxbServerID.Margin = new System.Windows.Forms.Padding(5);
            this.TxbServerID.Multiline = false;
            this.TxbServerID.Name = "TxbServerID";
            this.TxbServerID.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.TxbServerID.PasswortChar = '\0';
            this.TxbServerID.Pattern = null;
            this.TxbServerID.PatternError = System.Drawing.Color.Red;
            this.TxbServerID.Size = new System.Drawing.Size(139, 18);
            this.TxbServerID.TabIndex = 13;
            this.TxbServerID.Text = null;
            this.TxbServerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxbServerID.UseSystemPasswordChar = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BotWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(855, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxbMessage);
            this.Controls.Add(this.TxbServerID);
            this.Controls.Add(this.TxbChannelID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtClose);
            this.Controls.Add(this.smoothLine1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BotWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BotWindow";
            this.Shown += new System.EventHandler(this.BotWindow_Shown);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Se7en.UI.SmoothLine smoothLine1;
        private Se7en.UI.CloseButton BtClose;
        private Se7en.UI.ToggleButton toggleButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Se7en.UI.TextBox TxbMessage;
        private Se7en.UI.TextBox TxbChannelID;
        private Se7en.UI.TextBox TxbServerID;
        private System.Windows.Forms.Button button1;
    }
}