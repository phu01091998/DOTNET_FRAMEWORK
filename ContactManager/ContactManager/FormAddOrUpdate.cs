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
    public partial class FormAddOrUpdate : Form
    {
        bool add;
        Contact contact;
        String userid;
        public FormAddOrUpdate(String userid)
        {
            //add
            InitializeComponent();
            add = true;
            this.Text = "Add contact";
            this.userid = userid;
        }
        public FormAddOrUpdate(Contact contact)
        {
            //update
            InitializeComponent();
            add = false;
            this.Text = "Update contact";
            this.contact = contact;
            txtName.Text = contact.contactName;
            txtEmail.Text = contact.email;
            txtPhoneNumber.Text = contact.phoneNumber;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if(add)
            {
                ContactService.addContact(Guid.NewGuid().ToString(), txtName.Text, txtPhoneNumber.Text, txtEmail.Text,userid);
                DialogResult = DialogResult.OK;
            }
            else
            {
                ContactService.updateContact(contact.contactID, txtName.Text, txtPhoneNumber.Text, txtEmail.Text);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
