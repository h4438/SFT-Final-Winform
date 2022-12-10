namespace RestoredModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgentTransaction : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AgentTransactions",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        AgentOrder_OutOrderID = c.Int(),
                        Supplement_SID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AgentOrders", t => t.AgentOrder_OutOrderID)
                .ForeignKey("dbo.Supplement", t => t.Supplement_SID)
                .Index(t => t.AgentOrder_OutOrderID)
                .Index(t => t.Supplement_SID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AgentTransactions", "Supplement_SID", "dbo.Supplement");
            DropForeignKey("dbo.AgentTransactions", "AgentOrder_OutOrderID", "dbo.AgentOrders");
            DropIndex("dbo.AgentTransactions", new[] { "Supplement_SID" });
            DropIndex("dbo.AgentTransactions", new[] { "AgentOrder_OutOrderID" });
            DropTable("dbo.AgentTransactions");
        }
    }
}
