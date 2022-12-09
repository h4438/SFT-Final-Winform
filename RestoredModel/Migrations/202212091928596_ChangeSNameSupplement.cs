namespace RestoredModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeSNameSupplement : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SupplementBatches", "supplement_SID", "dbo.Supplements");
            DropPrimaryKey("dbo.Supplements");
            AlterColumn("dbo.Supplements", "SID", c => c.Int(nullable: false));
            AlterColumn("dbo.Supplements", "SName", c => c.String(unicode: false, storeType: "text"));
            AddPrimaryKey("dbo.Supplements", "SID");
            AddForeignKey("dbo.SupplementBatches", "supplement_SID", "dbo.Supplements", "SID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SupplementBatches", "supplement_SID", "dbo.Supplements");
            DropPrimaryKey("dbo.Supplements");
            AlterColumn("dbo.Supplements", "SName", c => c.String());
            AlterColumn("dbo.Supplements", "SID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Supplements", "SID");
            AddForeignKey("dbo.SupplementBatches", "supplement_SID", "dbo.Supplements", "SID");
        }
    }
}
