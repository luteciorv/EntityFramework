namespace RelationshipBetweenObjects.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TabelasRelacionadas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarModels",
                c => new
                    {
                        CarModelId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CarModelId);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        CarId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Year = c.Int(nullable: false),
                        CarModelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CarId)
                .ForeignKey("dbo.CarModels", t => t.CarModelId, cascadeDelete: true)
                .Index(t => t.CarModelId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "CarModelId", "dbo.CarModels");
            DropIndex("dbo.Cars", new[] { "CarModelId" });
            DropTable("dbo.Cars");
            DropTable("dbo.CarModels");
        }
    }
}
