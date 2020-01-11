namespace WebApplication3.MigrationsOwn
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBikes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bikes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Brand = c.String(),
                        BikeType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Bikes");
        }
    }
}
