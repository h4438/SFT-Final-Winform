namespace RestoredModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropOutOrder : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.SupplementBatches", new[] { "outgoingOrder_OutOrderID" });
            CreateIndex("dbo.SupplementBatches", "OutgoingOrder_OutOrderID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.SupplementBatches", new[] { "OutgoingOrder_OutOrderID" });
            CreateIndex("dbo.SupplementBatches", "outgoingOrder_OutOrderID");
        }
    }
}
