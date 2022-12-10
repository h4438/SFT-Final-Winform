namespace RestoredModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropNumberOfProducts : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AgentOrders", "NumberOfProducts");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AgentOrders", "NumberOfProducts", c => c.Int(nullable: false));
        }
    }
}
