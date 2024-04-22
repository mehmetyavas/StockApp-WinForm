namespace StockApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SaleAmountTotal : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sale", "Total", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.SaleDetail", "Amount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SaleDetail", "Amount");
            DropColumn("dbo.Sale", "Total");
        }
    }
}
