namespace RestoredModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAgentTransaction : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AgentTransactions", "Supplement_SID", "dbo.Supplement");
            DropIndex("dbo.AgentTransactions", new[] { "Supplement_SID" });
            AddColumn("dbo.AgentTransactions", "SupplementBatch_BatchID", c => c.Int());
            CreateIndex("dbo.AgentTransactions", "SupplementBatch_BatchID");
            AddForeignKey("dbo.AgentTransactions", "SupplementBatch_BatchID", "dbo.SupplementBatches", "BatchID");
            DropColumn("dbo.AgentTransactions", "Supplement_SID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AgentTransactions", "Supplement_SID", c => c.Int());
            DropForeignKey("dbo.AgentTransactions", "SupplementBatch_BatchID", "dbo.SupplementBatches");
            DropIndex("dbo.AgentTransactions", new[] { "SupplementBatch_BatchID" });
            DropColumn("dbo.AgentTransactions", "SupplementBatch_BatchID");
            CreateIndex("dbo.AgentTransactions", "Supplement_SID");
            AddForeignKey("dbo.AgentTransactions", "Supplement_SID", "dbo.Supplement", "SID");
        }
    }
}
