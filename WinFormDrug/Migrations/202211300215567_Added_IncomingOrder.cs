namespace WinFormDrug.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_IncomingOrder : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IncomingOrders",
                c => new
                    {
                        IncomingOrderID = c.Int(nullable: false, identity: true),
                        NumberOfProducts = c.Int(nullable: false),
                        DeliverDate = c.DateTime(nullable: false),
                        SignedDate = c.DateTime(nullable: false),
                        ReceivedDate = c.DateTime(nullable: false),
                        Manufacturer_ManuID = c.Int(),
                    })
                .PrimaryKey(t => t.IncomingOrderID)
                .ForeignKey("dbo.Manufacturers", t => t.Manufacturer_ManuID)
                .Index(t => t.Manufacturer_ManuID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IncomingOrders", "Manufacturer_ManuID", "dbo.Manufacturers");
            DropIndex("dbo.IncomingOrders", new[] { "Manufacturer_ManuID" });
            DropTable("dbo.IncomingOrders");
        }
    }
}
