namespace RestoredModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        CatID = c.Int(nullable: false),
                        CatName = c.String(unicode: false, storeType: "text"),
                        Description = c.String(unicode: false, storeType: "text"),
                        Thumb = c.String(unicode: false, storeType: "text"),
                        Title = c.String(unicode: false, storeType: "text"),
                    })
                .PrimaryKey(t => t.CatID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Category");
        }
    }
}
