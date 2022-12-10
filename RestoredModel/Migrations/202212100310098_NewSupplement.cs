namespace RestoredModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewSupplement : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Supplements", newName: "Supplement");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Supplement", newName: "Supplements");
        }
    }
}
