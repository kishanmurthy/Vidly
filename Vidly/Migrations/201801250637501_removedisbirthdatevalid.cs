namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedisbirthdatevalid : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "IsBirthDateValid");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "IsBirthDateValid", c => c.Boolean(nullable: false));
        }
    }
}
