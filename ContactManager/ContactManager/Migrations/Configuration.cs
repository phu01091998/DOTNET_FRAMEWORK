namespace ContactManager.Migrations
{
    using ContactManager.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ContactManager.Model.ContactDBContent>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ContactManager.Model.ContactDBContent context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            for (int i = 1; i <= 5; i++)
            {
                context.Contacts.AddOrUpdate(
                    new Contact { 
                    contactID = "c" + i,
                    contactName = "Mèo " + i,
                    phoneNumber = "000011100" + i,
                    email = "Meo" + i + "@gmail.com"
                    }
            
                );
                context.SaveChanges();
            }
        }
    }
}
