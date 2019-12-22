namespace ContactManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class khoitao : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        contactID = c.String(nullable: false, maxLength: 128),
                        contactName = c.String(),
                        phoneNumber = c.String(),
                        email = c.String(),
                    })
                .PrimaryKey(t => t.contactID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contacts");
        }
    }
}
