namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig05 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Cars", new[] { "User_Id" });
            DropColumn("dbo.Cars", "UserId");
            RenameColumn(table: "dbo.Cars", name: "User_Id", newName: "UserId");
            AlterColumn("dbo.Cars", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Cars", "UserId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Cars", new[] { "UserId" });
            AlterColumn("dbo.Cars", "UserId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Cars", name: "UserId", newName: "User_Id");
            AddColumn("dbo.Cars", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Cars", "User_Id");
        }
    }
}
