namespace WinFormDrug.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeDateTime_string : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OutgoingOrders", "DeliverDate", c => c.String());
            AlterColumn("dbo.OutgoingOrders", "AcceptDate", c => c.String());
            AlterColumn("dbo.SupplementBatches", "BatchExpDate", c => c.String());
            AlterColumn("dbo.SupplementBatches", "BatchManuDate", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SupplementBatches", "BatchManuDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.SupplementBatches", "BatchExpDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.OutgoingOrders", "AcceptDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.OutgoingOrders", "DeliverDate", c => c.DateTime(nullable: false));
        }
    }
}
