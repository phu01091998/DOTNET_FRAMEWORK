using ContactManager.Model;
using ContactManager.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();
            user = loginService.CheckLogin(txtUN.Text, txtPW.Text);
            if (user != null)
            {
                var f = new FormShowContact(user.userID);
                this.Hide();
                var rs = f.ShowDialog();
                this.Close();
            }
            /*if (txtUN.Text.Equals("quocphu") && txtPW.Text.Equals("123"))
            {
                var f = new FormShowContact("1");
                var rs = f.ShowDialog();
            }
            else if (txtUN.Text.Equals("nguyendung") && txtPW.Text.Equals("123"))
            {
                var f = new FormShowContact("2");
                var rs = f.ShowDialog();
            }*/
            else
            {
                MessageBox.Show("Username hoac password khong chinh xac");
            }
           
        }
    }
}
