namespace StockApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SaleSaleDetailProductTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sale",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ClientId = c.Guid(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        ModifiedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Client", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.Id)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.SaleDetail",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        SaleId = c.Long(nullable: false),
                        ProductId = c.Guid(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        ModifiedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Sale", t => t.SaleId, cascadeDelete: true)
                .Index(t => t.Id)
                .Index(t => t.SaleId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        Slug = c.String(nullable: false, maxLength: 200),
                        Description = c.String(nullable: false, maxLength: 150),
                        StockAmount = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BarcodeNo = c.String(nullable: false, maxLength: 20),
                        CreatedAt = c.DateTime(nullable: false),
                        ModifiedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.Name)
                .Index(t => t.Slug)
                .Index(t => t.BarcodeNo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SaleDetail", "SaleId", "dbo.Sale");
            DropForeignKey("dbo.SaleDetail", "ProductId", "dbo.Product");
            DropForeignKey("dbo.Sale", "ClientId", "dbo.Client");
            DropIndex("dbo.Product", new[] { "BarcodeNo" });
            DropIndex("dbo.Product", new[] { "Slug" });
            DropIndex("dbo.Product", new[] { "Name" });
            DropIndex("dbo.Product", new[] { "Id" });
            DropIndex("dbo.SaleDetail", new[] { "ProductId" });
            DropIndex("dbo.SaleDetail", new[] { "SaleId" });
            DropIndex("dbo.SaleDetail", new[] { "Id" });
            DropIndex("dbo.Sale", new[] { "ClientId" });
            DropIndex("dbo.Sale", new[] { "Id" });
            DropTable("dbo.Product");
            DropTable("dbo.SaleDetail");
            DropTable("dbo.Sale");
        }
    }
}
