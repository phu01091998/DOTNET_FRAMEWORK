namespace ContactManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatecolumn : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contacts", "contactName", c => c.String(maxLength: 100));
            AlterColumn("dbo.Contacts", "phoneNumber", c => c.String(maxLength: 100));
            AlterColumn("dbo.Contacts", "email", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "email", c => c.String());
            AlterColumn("dbo.Contacts", "phoneNumber", c => c.String());
            AlterColumn("dbo.Contacts", "contactName", c => c.String());
        }
    }
}
