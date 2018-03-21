namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class march20_Initial2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Facility", "Asset_Id", c => c.Int());
            CreateIndex("dbo.Facility", "Asset_Id");
            AddForeignKey("dbo.Facility", "Asset_Id", "dbo.Asset", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Facility", "Asset_Id", "dbo.Asset");
            DropIndex("dbo.Facility", new[] { "Asset_Id" });
            DropColumn("dbo.Facility", "Asset_Id");
        }
    }
}
