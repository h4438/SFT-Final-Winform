namespace RestoredModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OutgoingOrders", "Agent_AgentID", "dbo.Agents");
            DropForeignKey("dbo.SupplementBatches", "outgoingOrder_OutOrderID", "dbo.OutgoingOrders");
            DropForeignKey("dbo.SupplementBatches", "incomingOrder_IncomingOrderID", "dbo.IncomingOrders");
            DropForeignKey("dbo.Supplements", "Manufacturer_ManuID", "dbo.Manufacturers");
            DropForeignKey("dbo.SupplementBatches", "supplement_SID", "dbo.Supplements");
            DropForeignKey("dbo.IncomingOrders", "Manufacturer_ManuID", "dbo.Manufacturers");
            DropIndex("dbo.Supplements", new[] { "Manufacturer_ManuID" });
            DropIndex("dbo.IncomingOrders", new[] { "Manufacturer_ManuID" });
            DropIndex("dbo.SupplementBatches", new[] { "supplement_SID" });
            DropIndex("dbo.SupplementBatches", new[] { "outgoingOrder_OutOrderID" });
            DropIndex("dbo.SupplementBatches", new[] { "incomingOrder_IncomingOrderID" });
            DropIndex("dbo.OutgoingOrders", new[] { "Agent_AgentID" });
            DropTable("dbo.Supplements");
            DropTable("dbo.Manufacturers");
            DropTable("dbo.IncomingOrders");
            DropTable("dbo.SupplementBatches");
            DropTable("dbo.OutgoingOrders");
            DropTable("dbo.Agents");
        }
    }
}
