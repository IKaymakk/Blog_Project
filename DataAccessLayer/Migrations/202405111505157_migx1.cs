namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migx1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Categories", "BlogCount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "BlogCount", c => c.Int(nullable: false));
        }
    }
}
