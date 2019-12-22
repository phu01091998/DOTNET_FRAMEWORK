namespace ContactManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class taouser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        userID = c.String(nullable: false, maxLength: 128),
                        userName = c.String(maxLength: 100),
                        password = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.userID);
            
            AddColumn("dbo.Contacts", "userID", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contacts", "userID");
            DropTable("dbo.Users");
        }
    }
}
