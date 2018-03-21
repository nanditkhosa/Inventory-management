namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class march20_Initial3 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Facility", name: "Asset_Id", newName: "AssetId");
            RenameIndex(table: "dbo.Facility", name: "IX_Asset_Id", newName: "IX_AssetId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Facility", name: "IX_AssetId", newName: "IX_Asset_Id");
            RenameColumn(table: "dbo.Facility", name: "AssetId", newName: "Asset_Id");
        }
    }
}
