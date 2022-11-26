namespace WinFormDrug.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        ManuID = c.Int(nullable: false, identity: true),
                        ManuName = c.String(),
                        ManuAddress = c.String(),
                    })
                .PrimaryKey(t => t.ManuID);
            
            CreateTable(
                "dbo.Supplements",
                c => new
                    {
                        SID = c.Int(nullable: false, identity: true),
                        SName = c.String(),
                        Category = c.String(),
                        Uses = c.String(),
                        Ingredient = c.String(),
                        Directions = c.String(),
                        Warnings = c.String(),
                        OtherInfo = c.String(),
                        InactiveIngredient = c.String(),
                        Manufacturer_ManuID = c.Int(),
                    })
                .PrimaryKey(t => t.SID)
                .ForeignKey("dbo.Manufacturers", t => t.Manufacturer_ManuID)
                .Index(t => t.Manufacturer_ManuID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Supplements", "Manufacturer_ManuID", "dbo.Manufacturers");
            DropIndex("dbo.Supplements", new[] { "Manufacturer_ManuID" });
            DropTable("dbo.Supplements");
            DropTable("dbo.Manufacturers");
        }
    }
}
