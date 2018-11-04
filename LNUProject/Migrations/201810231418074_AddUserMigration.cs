namespace LNUProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Email", c => c.String());
            AddColumn("dbo.Users", "Password", c => c.String());
            AddColumn("dbo.Users", "Image", c => c.String());
            AddColumn("dbo.Users", "Imagename", c => c.String());
            AddColumn("dbo.Users", "Email_confirmed", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Email_confirmed");
            DropColumn("dbo.Users", "Imagename");
            DropColumn("dbo.Users", "Image");
            DropColumn("dbo.Users", "Password");
            DropColumn("dbo.Users", "Email");
        }
    }
}
