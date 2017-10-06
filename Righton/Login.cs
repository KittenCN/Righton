using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Righton
{
    public partial class form_Login : Form
    {
        public form_Login()
        {
            InitializeComponent();
        }

        private void form_Login_Load(object sender, EventArgs e)
        {

        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            Application.Exit(e);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "admin" && txtPWD.Text == "admin")
            {
                form_Report fr = new form_Report();
                fr.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("账号密码错误!");
            }
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
        }
        private void txtPWD_Click(object sender, EventArgs e)
        {
            txtPWD.Text = "";
        }
    }
}
