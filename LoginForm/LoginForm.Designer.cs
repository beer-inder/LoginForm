namespace LoginForm
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
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Captcha = new System.Windows.Forms.TextBox();
            this.btn_RefreshCaptcha = new System.Windows.Forms.Button();
            this.tb_UserCaptcha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(160, 60);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(113, 25);
            this.lbl_UserName.TabIndex = 0;
            this.lbl_UserName.Text = "UserName";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(160, 116);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(106, 25);
            this.lbl_Password.TabIndex = 1;
            this.lbl_Password.Text = "Password";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(573, 350);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(188, 60);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(382, 350);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(150, 61);
            this.btn_Register.TabIndex = 3;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(333, 64);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(218, 22);
            this.txt_UserName.TabIndex = 4;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(333, 120);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(218, 22);
            this.txt_Password.TabIndex = 5;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(190, 350);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(140, 61);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Captcha";
            // 
            // tb_Captcha
            // 
            this.tb_Captcha.Enabled = false;
            this.tb_Captcha.Location = new System.Drawing.Point(333, 170);
            this.tb_Captcha.Name = "tb_Captcha";
            this.tb_Captcha.Size = new System.Drawing.Size(211, 22);
            this.tb_Captcha.TabIndex = 8;
            // 
            // btn_RefreshCaptcha
            // 
            this.btn_RefreshCaptcha.Location = new System.Drawing.Point(586, 173);
            this.btn_RefreshCaptcha.Name = "btn_RefreshCaptcha";
            this.btn_RefreshCaptcha.Size = new System.Drawing.Size(75, 23);
            this.btn_RefreshCaptcha.TabIndex = 9;
            this.btn_RefreshCaptcha.Text = "Refresh";
            this.btn_RefreshCaptcha.UseVisualStyleBackColor = true;
            this.btn_RefreshCaptcha.Click += new System.EventHandler(this.btn_RefreshCaptcha_Click);
            // 
            // tb_UserCaptcha
            // 
            this.tb_UserCaptcha.Location = new System.Drawing.Point(333, 223);
            this.tb_UserCaptcha.Name = "tb_UserCaptcha";
            this.tb_UserCaptcha.Size = new System.Drawing.Size(203, 22);
            this.tb_UserCaptcha.TabIndex = 10;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_UserCaptcha);
            this.Controls.Add(this.btn_RefreshCaptcha);
            this.Controls.Add(this.tb_Captcha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_UserName);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Captcha;
        private System.Windows.Forms.Button btn_RefreshCaptcha;
        private System.Windows.Forms.TextBox tb_UserCaptcha;
    }
}