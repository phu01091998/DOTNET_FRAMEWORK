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
    public partial class FormShowContact : Form
    {
        public String Userid;
        public FormShowContact(String userid)
        {
            Userid = userid;
            InitializeComponent();
            dtgContact.AutoGenerateColumns = false;
            List<Contact> lsContact = new List<Contact>();
            lsContact = ContactService.getContacts(Userid);
            bdsContact.DataSource = lsContact;
            dtgContact.DataSource = bdsContact;
            tsslTong.Text = (dtgContact.RowCount-1).ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Contact ct = (Contact)bdsContact.Current;
            if (ct != null)
            {
                ContactService.removeContact(ct.contactID);
                bdsContact.RemoveCurrent();
                MessageBox.Show("đã xóa: "+ct.contactName);
                tsslTong.Text = (dtgContact.RowCount - 1).ToString();
            }
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var f = new FormAddOrUpdate(Userid);
            var rs= f.ShowDialog();
            if(rs== DialogResult.OK)
            {
                bdsContact.DataSource = ContactService.getContacts(Userid);
                dtgContact.DataSource = bdsContact;
                tsslTong.Text = (dtgContact.RowCount - 1).ToString();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var contact = bdsContact.Current as Contact;
            var f = new FormAddOrUpdate(contact);
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                bdsContact.DataSource = ContactService.getContacts(Userid);
                dtgContact.DataSource = bdsContact;
                tsslTong.Text = (dtgContact.RowCount - 1).ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bdsContact.DataSource = ContactService.searchContacts(txtSearch.Text,Userid);
            dtgContact.DataSource = bdsContact;
            tsslTong.Text = (dtgContact.RowCount - 1).ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            bdsContact.DataSource = ContactService.searchContacts(txtSearch.Text,Userid);
            dtgContact.DataSource = bdsContact;
            tsslTong.Text = (dtgContact.RowCount - 1).ToString();
        }
    }
}
