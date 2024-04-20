namespace StockApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        LastName = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false, maxLength: 10),
                        CreatedAt = c.DateTime(nullable: false),
                        ModifiedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.Email);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Client", new[] { "Email" });
            DropIndex("dbo.Client", new[] { "Id" });
            DropTable("dbo.Client");
        }
    }
}
