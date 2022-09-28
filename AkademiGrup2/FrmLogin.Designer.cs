namespace AkademiGrup2
{
    partial class FrmLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chcRememberMe = new System.Windows.Forms.CheckBox();
            this.lnkSifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.chcSifreGoster = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lnkHesapYokMu = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.Location = new System.Drawing.Point(211, 210);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(233, 33);
            this.btnLogin.TabIndex = 30;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.Location = new System.Drawing.Point(211, 158);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(233, 27);
            this.txtPassword.TabIndex = 29;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(128, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Şifreniz :";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserName.Location = new System.Drawing.Point(211, 110);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(233, 27);
            this.txtUserName.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(77, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "Kullanıcı Adınız :";
            // 
            // chcRememberMe
            // 
            this.chcRememberMe.AutoSize = true;
            this.chcRememberMe.Location = new System.Drawing.Point(211, 274);
            this.chcRememberMe.Name = "chcRememberMe";
            this.chcRememberMe.Size = new System.Drawing.Size(105, 23);
            this.chcRememberMe.TabIndex = 33;
            this.chcRememberMe.Text = "Beni Hatırla";
            this.chcRememberMe.UseVisualStyleBackColor = true;
            // 
            // lnkSifremiUnuttum
            // 
            this.lnkSifremiUnuttum.AutoSize = true;
            this.lnkSifremiUnuttum.Location = new System.Drawing.Point(330, 274);
            this.lnkSifremiUnuttum.Name = "lnkSifremiUnuttum";
            this.lnkSifremiUnuttum.Size = new System.Drawing.Size(114, 19);
            this.lnkSifremiUnuttum.TabIndex = 34;
            this.lnkSifremiUnuttum.TabStop = true;
            this.lnkSifremiUnuttum.Text = "Şifremi Unuttum";
            this.lnkSifremiUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(124, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(362, 45);
            this.label3.TabIndex = 35;
            this.label3.Text = "Stok Takip Giriş Formu";
            // 
            // chcSifreGoster
            // 
            this.chcSifreGoster.AutoSize = true;
            this.chcSifreGoster.Location = new System.Drawing.Point(459, 160);
            this.chcSifreGoster.Name = "chcSifreGoster";
            this.chcSifreGoster.Size = new System.Drawing.Size(115, 23);
            this.chcSifreGoster.TabIndex = 36;
            this.chcSifreGoster.Text = "Şifreyi Göster";
            this.chcSifreGoster.UseVisualStyleBackColor = true;
            this.chcSifreGoster.CheckedChanged += new System.EventHandler(this.chcSifreGoster_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(459, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 33);
            this.button1.TabIndex = 37;
            this.button1.Text = "Şifreyi Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lnkHesapYokMu
            // 
            this.lnkHesapYokMu.AutoSize = true;
            this.lnkHesapYokMu.Location = new System.Drawing.Point(330, 328);
            this.lnkHesapYokMu.Name = "lnkHesapYokMu";
            this.lnkHesapYokMu.Size = new System.Drawing.Size(141, 19);
            this.lnkHesapYokMu.TabIndex = 38;
            this.lnkHesapYokMu.TabStop = true;
            this.lnkHesapYokMu.Text = "Bir Hesabın Yok mu?";
            this.lnkHesapYokMu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHesapYokMu_LinkClicked);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(590, 377);
            this.Controls.Add(this.lnkHesapYokMu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chcSifreGoster);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lnkSifremiUnuttum);
            this.Controls.Add(this.chcRememberMe);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLogin";
            this.Text = "Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chcRememberMe;
        private System.Windows.Forms.LinkLabel lnkSifremiUnuttum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chcSifreGoster;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel lnkHesapYokMu;
    }
}