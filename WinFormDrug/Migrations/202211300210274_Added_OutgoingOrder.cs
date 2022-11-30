namespace WinFormDrug.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_OutgoingOrder : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OutgoingOrders",
                c => new
                    {
                        OutOrderID = c.Int(nullable: false, identity: true),
                        NumberOfProducts = c.Int(nullable: false),
                        DeliverDate = c.DateTime(nullable: false),
                        AcceptDate = c.DateTime(nullable: false),
                        Address = c.String(),
                        Agent_AgentID = c.Int(),
                    })
                .PrimaryKey(t => t.OutOrderID)
                .ForeignKey("dbo.Agents", t => t.Agent_AgentID)
                .Index(t => t.Agent_AgentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OutgoingOrders", "Agent_AgentID", "dbo.Agents");
            DropIndex("dbo.OutgoingOrders", new[] { "Agent_AgentID" });
            DropTable("dbo.OutgoingOrders");
        }
    }
}
