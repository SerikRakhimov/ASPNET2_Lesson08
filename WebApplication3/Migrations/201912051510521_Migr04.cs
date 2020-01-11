namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migr04 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "UserId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "UserId");
        }
    }
}
