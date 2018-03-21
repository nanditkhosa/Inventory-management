namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class march20_Initial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Asset", "FacilityId", c => c.Int());
            CreateIndex("dbo.Asset", "FacilityId");
            AddForeignKey("dbo.Asset", "FacilityId", "dbo.Facility", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Asset", "FacilityId", "dbo.Facility");
            DropIndex("dbo.Asset", new[] { "FacilityId" });
            DropColumn("dbo.Asset", "FacilityId");
        }
    }
}
