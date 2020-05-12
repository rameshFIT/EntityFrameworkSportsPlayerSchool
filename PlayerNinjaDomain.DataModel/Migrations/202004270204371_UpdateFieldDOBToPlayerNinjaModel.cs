namespace PlayerNinjaDomain.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateFieldDOBToPlayerNinjaModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PlayerNinjas", "DateOfBirth", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PlayerNinjas", "DateOfBirth");
        }
    }
}
