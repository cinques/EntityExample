namespace EntityExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class str : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Str", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Str");
        }
    }
}
