namespace RestoredModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropMoneyBatches : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.SupplementBatches", "BatchOriginalCost");
            DropColumn("dbo.SupplementBatches", "BatchInitPrice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SupplementBatches", "BatchInitPrice", c => c.Double(nullable: false));
            AddColumn("dbo.SupplementBatches", "BatchOriginalCost", c => c.Double(nullable: false));
        }
    }
}
