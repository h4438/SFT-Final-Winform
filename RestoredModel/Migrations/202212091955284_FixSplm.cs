namespace RestoredModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixSplm : DbMigration
    {
        public override void Up()
        {
            //RenameColumn(table: "dbo.Supplements", name: "Category_CatID1", newName: "Category_CatID");
            //RenameIndex(table: "dbo.Supplements", name: "IX_Category_CatID1", newName: "IX_Category_CatID");
            //DropColumn("dbo.Supplements", "CatID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Supplements", "CatID", c => c.Int());
            RenameIndex(table: "dbo.Supplements", name: "IX_Category_CatID", newName: "IX_Category_CatID1");
            RenameColumn(table: "dbo.Supplements", name: "Category_CatID", newName: "Category_CatID1");
        }
    }
}
