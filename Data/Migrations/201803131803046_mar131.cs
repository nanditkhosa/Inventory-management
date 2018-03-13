namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mar131 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.User", "PasswordHash", c => c.String());
            AlterColumn("dbo.User", "PasswordSalt", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.User", "PasswordSalt", c => c.String(nullable: false));
            AlterColumn("dbo.User", "PasswordHash", c => c.String(nullable: false));
        }
    }
}
