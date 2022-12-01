namespace WinFormDrug.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeDateToString_InOrder : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.IncomingOrders", "DeliverDate", c => c.String());
            AlterColumn("dbo.IncomingOrders", "SignedDate", c => c.String());
            AlterColumn("dbo.IncomingOrders", "ReceivedDate", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.IncomingOrders", "ReceivedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.IncomingOrders", "SignedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.IncomingOrders", "DeliverDate", c => c.DateTime(nullable: false));
        }
    }
}
