namespace RestoredModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSupplement : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Supplements", "Category_CatID", c => c.Int(defaultValue:101)) ;
            CreateIndex("dbo.Supplements", "Category_CatID");
            AddForeignKey("dbo.Supplements", "Category_CatID", "dbo.Category", "CatID");
            DropColumn("dbo.Supplements", "Category");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Supplements", "Category", c => c.String());
            DropForeignKey("dbo.Supplements", "Category_CatID", "dbo.Category");
            DropIndex("dbo.Supplements", new[] { "Category_CatID" });
            DropColumn("dbo.Supplements", "Category_CatID");
        }
    }
}
