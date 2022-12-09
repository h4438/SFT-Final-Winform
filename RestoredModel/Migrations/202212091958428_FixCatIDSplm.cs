namespace RestoredModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixCatIDSplm : DbMigration
    {
        public override void Up()
        {
            //RenameColumn(table: "dbo.Supplements", name: "Category_CatID", newName: "Category_CatID1");
            //RenameIndex(table: "dbo.Supplements", name: "IX_Category_CatID", newName: "IX_Category_CatID1");
            //AddColumn("dbo.Supplements", "CatID", c => c.Int(defaultValue:101));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Supplements", "CatID");
            RenameIndex(table: "dbo.Supplements", name: "IX_Category_CatID1", newName: "IX_Category_CatID");
            RenameColumn(table: "dbo.Supplements", name: "Category_CatID1", newName: "Category_CatID");
        }
    }
}
