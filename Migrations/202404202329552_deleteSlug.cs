namespace StockApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteSlug : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Product", new[] { "Slug" });
            DropColumn("dbo.Product", "Slug");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Product", "Slug", c => c.String(nullable: false, maxLength: 200));
            CreateIndex("dbo.Product", "Slug");
        }
    }
}
