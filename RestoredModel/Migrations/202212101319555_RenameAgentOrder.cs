namespace RestoredModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameAgentOrder : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.OutgoingOrders", newName: "AgentOrders");
            RenameColumn(table: "dbo.SupplementBatches", name: "OutgoingOrder_OutOrderID", newName: "AgentOrder_OutOrderID");
            RenameIndex(table: "dbo.SupplementBatches", name: "IX_OutgoingOrder_OutOrderID", newName: "IX_AgentOrder_OutOrderID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.SupplementBatches", name: "IX_AgentOrder_OutOrderID", newName: "IX_OutgoingOrder_OutOrderID");
            RenameColumn(table: "dbo.SupplementBatches", name: "AgentOrder_OutOrderID", newName: "OutgoingOrder_OutOrderID");
            RenameTable(name: "dbo.AgentOrders", newName: "OutgoingOrders");
        }
    }
}
