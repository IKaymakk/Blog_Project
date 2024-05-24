namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig15 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Categories", "CategoryImg");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "CategoryImg", c => c.String());
        }
    }
}
