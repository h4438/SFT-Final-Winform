namespace RestoredModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategorySplm : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Supplements", "CatID");
            //AddForeignKey("dbo.Supplements", "CatID", "dbo.Category", "CatID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Supplements", "CatID", "dbo.Category");
            DropIndex("dbo.Supplements", new[] { "CatID" });
        }
    }
}
