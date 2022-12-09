namespace RestoredModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategory : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Supplements", "Category_CatID", "dbo.Category");
            DropIndex("dbo.Supplements", new[] { "Category_CatID" });
            AddColumn("dbo.Supplements", "Category", c => c.String());
            DropColumn("dbo.Supplements", "Category_CatID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Supplements", "Category_CatID", c => c.Int());
            DropColumn("dbo.Supplements", "Category");
            CreateIndex("dbo.Supplements", "Category_CatID");
            AddForeignKey("dbo.Supplements", "Category_CatID", "dbo.Category", "CatID");
        }
    }
}
