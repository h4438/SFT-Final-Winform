namespace WinFormDrug.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_SupplementBatch : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SupplementBatches",
                c => new
                    {
                        BatchID = c.Int(nullable: false, identity: true),
                        BatchOriginalCost = c.Single(nullable: false),
                        BatchQuantity = c.Int(nullable: false),
                        BatchExpDate = c.DateTime(nullable: false),
                        BatchManuDate = c.DateTime(nullable: false),
                        incomingOrder_IncomingOrderID = c.Int(),
                        outgoingOrder_OutOrderID = c.Int(),
                        supplement_SID = c.Int(),
                    })
                .PrimaryKey(t => t.BatchID)
                .ForeignKey("dbo.IncomingOrders", t => t.incomingOrder_IncomingOrderID)
                .ForeignKey("dbo.OutgoingOrders", t => t.outgoingOrder_OutOrderID)
                .ForeignKey("dbo.Supplements", t => t.supplement_SID)
                .Index(t => t.incomingOrder_IncomingOrderID)
                .Index(t => t.outgoingOrder_OutOrderID)
                .Index(t => t.supplement_SID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SupplementBatches", "supplement_SID", "dbo.Supplements");
            DropForeignKey("dbo.SupplementBatches", "outgoingOrder_OutOrderID", "dbo.OutgoingOrders");
            DropForeignKey("dbo.SupplementBatches", "incomingOrder_IncomingOrderID", "dbo.IncomingOrders");
            DropIndex("dbo.SupplementBatches", new[] { "supplement_SID" });
            DropIndex("dbo.SupplementBatches", new[] { "outgoingOrder_OutOrderID" });
            DropIndex("dbo.SupplementBatches", new[] { "incomingOrder_IncomingOrderID" });
            DropTable("dbo.SupplementBatches");
        }
    }
}
