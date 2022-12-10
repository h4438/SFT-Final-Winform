namespace RestoredModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropNumberOfProducts1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.IncomingOrders", "NumberOfProducts");
        }
        
        public override void Down()
        {
            AddColumn("dbo.IncomingOrders", "NumberOfProducts", c => c.Int(nullable: false));
        }
    }
}
