namespace LoginForm
{
    partial class RegForm
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
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.tb_Privacy = new System.Windows.Forms.TextBox();
            this.cb_Privacy = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(148, 48);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(110, 25);
            this.lbl_UserName.TabIndex = 0;
            this.lbl_UserName.Text = "Username";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(148, 97);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(65, 25);
            this.lbl_Email.TabIndex = 1;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(152, 152);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(106, 25);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "Password";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(330, 48);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(260, 22);
            this.txt_UserName.TabIndex = 3;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(330, 97);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(260, 22);
            this.txt_Email.TabIndex = 4;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(330, 152);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(260, 22);
            this.txt_Password.TabIndex = 5;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(182, 362);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(165, 76);
            this.btn_Submit.TabIndex = 6;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(490, 362);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(151, 76);
            this.btn_Back.TabIndex = 7;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // tb_Privacy
            // 
            this.tb_Privacy.Enabled = false;
            this.tb_Privacy.Location = new System.Drawing.Point(334, 206);
            this.tb_Privacy.Multiline = true;
            this.tb_Privacy.Name = "tb_Privacy";
            this.tb_Privacy.Size = new System.Drawing.Size(256, 89);
            this.tb_Privacy.TabIndex = 8;
            // 
            // cb_Privacy
            // 
            this.cb_Privacy.AutoSize = true;
            this.cb_Privacy.Location = new System.Drawing.Point(277, 325);
            this.cb_Privacy.Name = "cb_Privacy";
            this.cb_Privacy.Size = new System.Drawing.Size(18, 17);
            this.cb_Privacy.TabIndex = 9;
            this.cb_Privacy.UseVisualStyleBackColor = true;
            this.cb_Privacy.CheckedChanged += new System.EventHandler(this.cb_Privacy_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Privacy Policy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "I agree the Privacy Policy";
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Privacy);
            this.Controls.Add(this.tb_Privacy);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_UserName);
            this.Name = "RegForm";
            this.Text = "Registration Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.TextBox tb_Privacy;
        private System.Windows.Forms.CheckBox cb_Privacy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

