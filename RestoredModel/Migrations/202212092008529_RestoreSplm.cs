namespace RestoredModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RestoreSplm : DbMigration
    {
        public override void Up()
        {
           
        }
        
        public override void Down()
        {
            AddColumn("dbo.Supplements", "Category_CatID1", c => c.Int());
            DropForeignKey("dbo.SupplementBatches", "Supplement_SID", "dbo.Supplements");
            DropIndex("dbo.SupplementBatches", new[] { "Supplement_SID" });
            DropPrimaryKey("dbo.Supplements");
            AlterColumn("dbo.Supplements", "price", c => c.Int(nullable: false));
            AlterColumn("dbo.Supplements", "SID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Supplements", "SID");
            CreateIndex("dbo.Supplements", "Category_CatID1");
            CreateIndex("dbo.SupplementBatches", "supplement_SID");
            AddForeignKey("dbo.SupplementBatches", "supplement_SID", "dbo.Supplements", "SID");
            AddForeignKey("dbo.Supplements", "Category_CatID1", "dbo.Category", "CatID");
        }
    }
}
