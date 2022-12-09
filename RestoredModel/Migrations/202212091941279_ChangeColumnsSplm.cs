namespace RestoredModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeColumnsSplm : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Supplements", name: "Manufacturer_ManuID", newName: "ManuID");
            AddColumn("dbo.Supplements", "CatID", c => c.Int(defaultValue: 101));
            AddColumn("dbo.Supplements", "price", c => c.Int(defaultValue: 50000));
            AlterColumn("dbo.Supplements", "Uses", c => c.String(unicode: false, storeType: "text"));
            AlterColumn("dbo.Supplements", "Ingredient", c => c.String(unicode: false, storeType: "text"));
            AlterColumn("dbo.Supplements", "Directions", c => c.String(unicode: false, storeType: "text"));
            AlterColumn("dbo.Supplements", "Warnings", c => c.String(unicode: false, storeType: "text"));
            AlterColumn("dbo.Supplements", "OtherInfo", c => c.String(unicode: false, storeType: "text"));
            AlterColumn("dbo.Supplements", "SName", c => c.String(unicode: false, storeType: "text"));
            AlterColumn("dbo.Supplements", "InactiveIngredient", c => c.String(unicode: false, storeType: "text"));
            AlterColumn("dbo.Supplements", "SLink", c => c.String(unicode: false, storeType: "text",defaultValue: "imc-antrivuong225401643.jpg"));
            AddForeignKey("dbo.Supplements", "CatID", "dbo.Category", "CatID");
            DropColumn("dbo.Supplements", "Category");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Supplements", "Category", c => c.String());
            DropForeignKey("dbo.Supplements", "Category_CatID1", "dbo.Category");
            DropIndex("dbo.Supplements", new[] { "Category_CatID1" });
            AlterColumn("dbo.Supplements", "SLink", c => c.String());
            AlterColumn("dbo.Supplements", "InactiveIngredient", c => c.String());
            AlterColumn("dbo.Supplements", "OtherInfo", c => c.String());
            AlterColumn("dbo.Supplements", "Warnings", c => c.String());
            AlterColumn("dbo.Supplements", "Directions", c => c.String());
            AlterColumn("dbo.Supplements", "Ingredient", c => c.String());
            AlterColumn("dbo.Supplements", "Uses", c => c.String());
            DropColumn("dbo.Supplements", "Category_CatID1");
            DropColumn("dbo.Supplements", "price");
            DropColumn("dbo.Supplements", "CatID");
            RenameIndex(table: "dbo.Supplements", name: "IX_ManuID", newName: "IX_Manufacturer_ManuID");
            RenameColumn(table: "dbo.Supplements", name: "ManuID", newName: "Manufacturer_ManuID");
        }
    }
}
