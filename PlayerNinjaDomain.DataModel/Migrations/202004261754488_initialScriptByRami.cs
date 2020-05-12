namespace PlayerNinjaDomain.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialScriptByRami : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PlayerNinjas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        InOlymphics = c.Boolean(nullable: false),
                        StateClanId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StateClans", t => t.StateClanId, cascadeDelete: true)
                .Index(t => t.StateClanId);
            
            CreateTable(
                "dbo.SportsNinjaEquipments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PlayerNinja_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PlayerNinjas", t => t.PlayerNinja_Id, cascadeDelete: true)
                .Index(t => t.PlayerNinja_Id);
            
            CreateTable(
                "dbo.StateClans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StateClanName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PlayerNinjas", "StateClanId", "dbo.StateClans");
            DropForeignKey("dbo.SportsNinjaEquipments", "PlayerNinja_Id", "dbo.PlayerNinjas");
            DropIndex("dbo.SportsNinjaEquipments", new[] { "PlayerNinja_Id" });
            DropIndex("dbo.PlayerNinjas", new[] { "StateClanId" });
            DropTable("dbo.StateClans");
            DropTable("dbo.SportsNinjaEquipments");
            DropTable("dbo.PlayerNinjas");
        }
    }
}
