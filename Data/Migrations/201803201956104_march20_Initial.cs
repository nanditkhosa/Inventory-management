namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class march20_Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Asset",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Description = c.String(nullable: false),
                        InitCount = c.Int(nullable: false),
                        UsedCount = c.Int(nullable: false),
                        UnusedCount = c.Int(nullable: false),
                        CreatedTimeStamp = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        LastModifiedTimeStamp = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        CreatedUser = c.String(),
                        LastModifiedUser = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.User", "EmailId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.User", "EmailId", c => c.String(nullable: false, maxLength: 100));
            DropTable("dbo.Asset");
        }
    }
}
