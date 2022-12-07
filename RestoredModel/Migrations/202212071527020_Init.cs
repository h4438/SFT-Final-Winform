namespace RestoredModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Agents",
                c => new
                    {
                        AgentID = c.Int(nullable: false, identity: true),
                        AgentName = c.String(),
                        AgentAddress = c.String(),
                        AgentEmail = c.String(),
                        AgentPhone = c.String(),
                    })
                .PrimaryKey(t => t.AgentID);
            
            CreateTable(
                "dbo.OutgoingOrders",
                c => new
                    {
                        OutOrderID = c.Int(nullable: false, identity: true),
                        NumberOfProducts = c.Int(nullable: false),
                        DeliverDate = c.String(),
                        AcceptDate = c.String(),
                        Address = c.String(),
                        Agent_AgentID = c.Int(),
                    })
                .PrimaryKey(t => t.OutOrderID)
                .ForeignKey("dbo.Agents", t => t.Agent_AgentID)
                .Index(t => t.Agent_AgentID);
            
            CreateTable(
                "dbo.SupplementBatches",
                c => new
                    {
                        BatchID = c.Int(nullable: false, identity: true),
                        BatchOriginalCost = c.Double(nullable: false),
                        BatchQuantity = c.Int(nullable: false),
                        BatchExpDate = c.String(),
                        BatchManuDate = c.String(),
                        incomingOrder_IncomingOrderID = c.Int(),
                        outgoingOrder_OutOrderID = c.Int(),
                        supplement_SID = c.Int(),
                        BatchInitPrice = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.BatchID)
                .ForeignKey("dbo.Supplements", t => t.supplement_SID)
                .ForeignKey("dbo.IncomingOrders", t => t.incomingOrder_IncomingOrderID)
                .ForeignKey("dbo.OutgoingOrders", t => t.outgoingOrder_OutOrderID)
                .Index(t => t.incomingOrder_IncomingOrderID)
                .Index(t => t.outgoingOrder_OutOrderID)
                .Index(t => t.supplement_SID);
            
            CreateTable(
                "dbo.IncomingOrders",
                c => new
                    {
                        IncomingOrderID = c.Int(nullable: false, identity: true),
                        NumberOfProducts = c.Int(nullable: false),
                        DeliverDate = c.String(),
                        SignedDate = c.String(),
                        ReceivedDate = c.String(),
                        Manufacturer_ManuID = c.Int(),
                    })
                .PrimaryKey(t => t.IncomingOrderID)
                .ForeignKey("dbo.Manufacturers", t => t.Manufacturer_ManuID)
                .Index(t => t.Manufacturer_ManuID);
            
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        ManuID = c.Int(nullable: false, identity: true),
                        ManuName = c.String(),
                        ManuAddress = c.String(),
                        ManuPhone = c.String(),
                        ManuEmail = c.String(),
                        ManuCountry = c.String(),
                    })
                .PrimaryKey(t => t.ManuID);
            
            CreateTable(
                "dbo.Supplements",
                c => new
                    {
                        SID = c.Int(nullable: false, identity: true),
                        SName = c.String(),
                        Category = c.String(),
                        Uses = c.String(),
                        Ingredient = c.String(),
                        Directions = c.String(),
                        Warnings = c.String(),
                        OtherInfo = c.String(),
                        InactiveIngredient = c.String(),
                        Manufacturer_ManuID = c.Int(),
                        SLink = c.String(),
                    })
                .PrimaryKey(t => t.SID)
                .ForeignKey("dbo.Manufacturers", t => t.Manufacturer_ManuID)
                .Index(t => t.Manufacturer_ManuID);
            
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
