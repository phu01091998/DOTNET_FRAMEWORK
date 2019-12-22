using System.Data.Entity;

namespace ContactManager.Model
{
    public class ContactDBContent : DbContext
    {
        public ContactDBContent() : base(@"Data Source=DESKTOP-E754EJE;Initial Catalog=ContactManager;User ID=sa;Password=123")
        {
            //
            // TODO: Add constructor logic here
            //
        }
       
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}