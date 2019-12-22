using ContactManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Service
{
    public class ContactService
    {
       
        public static List<Contact> GetContact1()
        {
            //mock data
            List<Contact> ls = new List<Contact>();
            for (int i = 1; i <= 5; i++)
            {
                var contact = new Contact
                {
                    contactID = "c" + i,
                    contactName = "Mèo " + i,
                    phoneNumber = "000011100" + i,
                    email = "Meo" + i + "@gmail.com"
                };
                ls.Add(contact);
            }
            return ls;
        }
        public static List<Contact> getContacts(String userid)
        {
            return new ContactDBContent().Contacts.Where(e =>e.userID== userid).ToList();
        }
        public static List<Contact> searchContacts(String text, String userID)
        {
            return new ContactDBContent().Contacts.SqlQuery("select * from Contacts where userID= '" +userID+ "' and concat(contactName,phoneNumber,email) like'%" + text + "%'").ToList();
        }
  
        public static void addContact(String contactID, String contactName, String phoneNumber, String email, String userID)
        {
            var content = new ContactDBContent();
            content.Contacts.Add(
                new Contact
                {
                    contactID = contactID,
                    contactName=contactName,
                    phoneNumber=phoneNumber,
                    email=email,
                    userID=userID
                   
              
                });
            content.SaveChanges();
        }
        public static void updateContact(String contactID, String contactName, String phoneNumber, String email)
        {
            var content = new ContactDBContent();
            var updateContact = content.Contacts.Single(e => e.contactID == contactID);
            updateContact.contactName = contactName;
            updateContact.phoneNumber = phoneNumber;
            updateContact.email = email;
            content.SaveChanges();
        }
        public static void removeContact(String contactID)
        {
            var content = new ContactDBContent();
            content.Contacts.Remove(content.Contacts.Find(contactID));
            content.SaveChanges();
        }
    }
}
