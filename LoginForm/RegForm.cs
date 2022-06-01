using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class RegForm : Form
    {
        Registration_Class Obj_Reg = new Registration_Class();
        public RegForm()
        {
            InitializeComponent();
            tb_Privacy.Text = "This is a company Privacy Policy, Please read it Carefully";
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if(cb_Privacy.Checked)
            {
                string message = Obj_Reg.Registration(txt_UserName.Text, txt_Email.Text, txt_Password.Text);
                MessageBox.Show(message);
                txt_UserName.Text = "";
                txt_Email.Text = "";
                txt_Password.Text = "";
            }
            else
            {
                MessageBox.Show("Please accept the Privacy Policy");
            }

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            var LoginForm_Obj = new LoginForm();
            LoginForm_Obj.Closed += (s, args) => this.Close();
            LoginForm_Obj.Show();
        }

        private void cb_Privacy_CheckedChanged(object sender, EventArgs e)
        {
            //if (cb_Privacy.Checked)
            //{
            //    btn_Submit.Enabled = true;
            //}
            //else if (cb_Privacy.Checked == false)
            //{
            //    MessageBox.Show("Please accept the Privacy Policy");
            //    btn_Submit.Enabled = false;
            //}
        }
    }
}
