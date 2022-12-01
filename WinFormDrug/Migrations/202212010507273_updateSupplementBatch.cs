namespace WinFormDrug.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateSupplementBatch : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SupplementBatches", "BatchInitPrice", c => c.Double(nullable: false));
            AlterColumn("dbo.SupplementBatches", "BatchOriginalCost", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SupplementBatches", "BatchOriginalCost", c => c.Single(nullable: false));
            DropColumn("dbo.SupplementBatches", "BatchInitPrice");
        }
    }
}
