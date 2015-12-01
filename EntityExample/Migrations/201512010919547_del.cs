namespace EntityExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class del : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "Str");
            DropColumn("dbo.Products", "Str2");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Str2", c => c.String());
            AddColumn("dbo.Products", "Str", c => c.String());
        }
    }
}
