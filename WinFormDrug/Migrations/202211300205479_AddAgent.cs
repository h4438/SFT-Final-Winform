namespace WinFormDrug.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAgent : DbMigration
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Agents");
        }
    }
}
