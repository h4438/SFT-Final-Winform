namespace WinFormDrug.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateManu : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Manufacturers", "ManuPhone", c => c.String());
            AddColumn("dbo.Manufacturers", "ManuEmail", c => c.String());
            AddColumn("dbo.Manufacturers", "ManuCountry", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Manufacturers", "ManuCountry");
            DropColumn("dbo.Manufacturers", "ManuEmail");
            DropColumn("dbo.Manufacturers", "ManuPhone");
        }
    }
}
