namespace WinFormDrug.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSupplementImgLink : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Supplements", "SLink", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Supplements", "SLink");
        }
    }
}
