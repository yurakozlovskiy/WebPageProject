namespace LNUProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        City = c.String(),
                        Street_address = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleId = c.Int(nullable: false),
                        Firstname = c.String(),
                        Lastname = c.String(),
                        Date_logup = c.DateTime(),
                        Date_birth = c.DateTime(),
                        Rating = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        SellerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.SellerId)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.SellerId);
            
            CreateTable(
                "dbo.Cartgoods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GoodId = c.Int(nullable: false),
                        CartId = c.Int(nullable: false),
                        Quantity = c.Int(),
                        Date_purchase = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Carts", t => t.CartId)
                .ForeignKey("dbo.Goods", t => t.GoodId)
                .Index(t => t.GoodId)
                .Index(t => t.CartId);
            
            CreateTable(
                "dbo.Goods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CategoryId = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "UserId", "dbo.Users");
            DropForeignKey("dbo.Carts", "UserId", "dbo.Users");
            DropForeignKey("dbo.Carts", "SellerId", "dbo.Users");
            DropForeignKey("dbo.Cartgoods", "GoodId", "dbo.Goods");
            DropForeignKey("dbo.Goods", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Cartgoods", "CartId", "dbo.Carts");
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropIndex("dbo.Goods", new[] { "CategoryId" });
            DropIndex("dbo.Cartgoods", new[] { "CartId" });
            DropIndex("dbo.Cartgoods", new[] { "GoodId" });
            DropIndex("dbo.Carts", new[] { "SellerId" });
            DropIndex("dbo.Carts", new[] { "UserId" });
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.Addresses", new[] { "UserId" });
            DropTable("dbo.Categories");
            DropTable("dbo.Goods");
            DropTable("dbo.Cartgoods");
            DropTable("dbo.Carts");
            DropTable("dbo.Roles");
            DropTable("dbo.Users");
            DropTable("dbo.Addresses");
        }
    }
}
