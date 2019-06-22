namespace DiscordBot
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Se7en.UI.ColorFadeItem colorFadeItem1 = new Se7en.UI.ColorFadeItem();
            Se7en.UI.ColorFadeItem colorFadeItem2 = new Se7en.UI.ColorFadeItem();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.BtLogin = new System.Windows.Forms.Button();
            this.LbError = new System.Windows.Forms.Label();
            this.TxbPassword = new Se7en.UI.TextBox();
            this.BtClose = new Se7en.UI.CloseButton();
            this.TxbEmail = new Se7en.UI.TextBox();
            this.smoothLine1 = new Se7en.UI.SmoothLine();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PicLogo
            // 
            this.PicLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PicLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PicLogo.Image = ((System.Drawing.Image)(resources.GetObject("PicLogo.Image")));
            this.PicLogo.Location = new System.Drawing.Point(0, 2);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(309, 224);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PicLogo.TabIndex = 2;
            this.PicLogo.TabStop = false;
            // 
            // BtLogin
            // 
            this.BtLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtLogin.FlatAppearance.BorderSize = 0;
            this.BtLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtLogin.Location = new System.Drawing.Point(38, 332);
            this.BtLogin.Name = "BtLogin";
            this.BtLogin.Size = new System.Drawing.Size(236, 35);
            this.BtLogin.TabIndex = 2;
            this.BtLogin.Text = "Login";
            this.BtLogin.UseVisualStyleBackColor = false;
            this.BtLogin.Click += new System.EventHandler(this.BtLogin_Click);
            // 
            // LbError
            // 
            this.LbError.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbError.ForeColor = System.Drawing.Color.Red;
            this.LbError.Location = new System.Drawing.Point(0, 226);
            this.LbError.Name = "LbError";
            this.LbError.Size = new System.Drawing.Size(309, 41);
            this.LbError.TabIndex = 5;
            this.LbError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxbPassword
            // 
            this.TxbPassword.AutoScaleByText = false;
            this.TxbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.TxbPassword.CompareWith = null;
            this.TxbPassword.CueText = "Password";
            this.TxbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbPassword.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.TxbPassword.IsntInput = null;
            this.TxbPassword.LineColor = System.Drawing.Color.DeepSkyBlue;
            this.TxbPassword.LineHeight = 2;
            this.TxbPassword.LineMarginHorizontal = 0;
            this.TxbPassword.LineMarginLeft = 0;
            this.TxbPassword.LineMarginRight = 0;
            this.TxbPassword.LineMarginToText = 1;
            this.TxbPassword.Location = new System.Drawing.Point(38, 302);
            this.TxbPassword.Margin = new System.Windows.Forms.Padding(5);
            this.TxbPassword.Multiline = false;
            this.TxbPassword.Name = "TxbPassword";
            this.TxbPassword.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.TxbPassword.PasswortChar = '●';
            this.TxbPassword.Pattern = null;
            this.TxbPassword.PatternError = System.Drawing.Color.Red;
            this.TxbPassword.Size = new System.Drawing.Size(236, 22);
            this.TxbPassword.TabIndex = 1;
            this.TxbPassword.Text = null;
            this.TxbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxbPassword.UseSystemPasswordChar = true;
            // 
            // BtClose
            // 
            this.BtClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtClose.CrossWidth = 4;
            this.BtClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtClose.HoverEffect = System.Drawing.Color.Firebrick;
            this.BtClose.HoverScaleOutWidth = 2;
            this.BtClose.Location = new System.Drawing.Point(280, 9);
            this.BtClose.Margin = new System.Windows.Forms.Padding(0);
            this.BtClose.Name = "BtClose";
            this.BtClose.Padding = new System.Windows.Forms.Padding(4);
            this.BtClose.ScaleOutHoverEffect = false;
            this.BtClose.Size = new System.Drawing.Size(20, 20);
            this.BtClose.TabIndex = 3;
            this.BtClose.Click += new System.EventHandler(this.BtClose_Click);
            // 
            // TxbEmail
            // 
            this.TxbEmail.AutoScaleByText = false;
            this.TxbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.TxbEmail.CompareWith = null;
            this.TxbEmail.CueText = "E-Mail";
            this.TxbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbEmail.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.TxbEmail.IsntInput = null;
            this.TxbEmail.LineColor = System.Drawing.Color.DeepSkyBlue;
            this.TxbEmail.LineHeight = 2;
            this.TxbEmail.LineMarginHorizontal = 0;
            this.TxbEmail.LineMarginLeft = 0;
            this.TxbEmail.LineMarginRight = 0;
            this.TxbEmail.LineMarginToText = 1;
            this.TxbEmail.Location = new System.Drawing.Point(38, 270);
            this.TxbEmail.Margin = new System.Windows.Forms.Padding(5);
            this.TxbEmail.Multiline = false;
            this.TxbEmail.Name = "TxbEmail";
            this.TxbEmail.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.TxbEmail.PasswortChar = '\0';
            this.TxbEmail.Pattern = null;
            this.TxbEmail.PatternError = System.Drawing.Color.Red;
            this.TxbEmail.Size = new System.Drawing.Size(236, 22);
            this.TxbEmail.TabIndex = 0;
            this.TxbEmail.Text = null;
            this.TxbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxbEmail.UseSystemPasswordChar = false;
            this.TxbEmail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxbEmail_KeyUp);
            // 
            // smoothLine1
            // 
            colorFadeItem1.Color = System.Drawing.Color.DodgerBlue;
            colorFadeItem1.Position = 0F;
            colorFadeItem2.Color = System.Drawing.Color.DarkViolet;
            colorFadeItem2.Position = 1F;
            this.smoothLine1.Colors = new Se7en.UI.ColorFadeItem[] {
        colorFadeItem1,
        colorFadeItem2};
            this.smoothLine1.Dock = System.Windows.Forms.DockStyle.Top;
            this.smoothLine1.Location = new System.Drawing.Point(0, 0);
            this.smoothLine1.Name = "smoothLine1";
            this.smoothLine1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.smoothLine1.Size = new System.Drawing.Size(309, 2);
            this.smoothLine1.TabIndex = 6;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(309, 397);
            this.Controls.Add(this.LbError);
            this.Controls.Add(this.BtLogin);
            this.Controls.Add(this.TxbPassword);
            this.Controls.Add(this.BtClose);
            this.Controls.Add(this.TxbEmail);
            this.Controls.Add(this.PicLogo);
            this.Controls.Add(this.smoothLine1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Shown += new System.EventHandler(this.LoginForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private Se7en.UI.TextBox TxbEmail;
        private Se7en.UI.CloseButton BtClose;
        private System.Windows.Forms.PictureBox PicLogo;
        private Se7en.UI.TextBox TxbPassword;
        private System.Windows.Forms.Button BtLogin;
        private System.Windows.Forms.Label LbError;
        private Se7en.UI.SmoothLine smoothLine1;
    }
}

