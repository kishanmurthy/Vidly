namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedIsBirthDateValid : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsBirthDateValid", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IsBirthDateValid");
        }
    }
}
