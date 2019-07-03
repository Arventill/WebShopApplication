namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cake",
                c => new
                    {
                        CakeId = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(nullable: false),
                        CakeName = c.String(),
                        CakeMainIngredient = c.String(),
                        CakeDescription = c.String(),
                        isHidden = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CakeId)
                .ForeignKey("dbo.Category", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 100),
                        CategoryDescription = c.String(nullable: false),
                        IconFileName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.OrderPosition",
                c => new
                    {
                        OrderPositionId = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        CakeId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderPositionId)
                .ForeignKey("dbo.Cake", t => t.CakeId, cascadeDelete: true)
                .ForeignKey("dbo.Order", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.CakeId);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 100),
                        Street = c.String(nullable: false, maxLength: 200),
                        City = c.String(nullable: false, maxLength: 100),
                        PostCode = c.String(nullable: false, maxLength: 8),
                        Email = c.String(nullable: false, maxLength: 200),
                        PhoneNumber = c.String(),
                        Comment = c.String(),
                        Date = c.DateTime(nullable: false),
                        OrderStatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderPosition", "OrderId", "dbo.Order");
            DropForeignKey("dbo.OrderPosition", "CakeId", "dbo.Cake");
            DropForeignKey("dbo.Cake", "CategoryId", "dbo.Category");
            DropIndex("dbo.OrderPosition", new[] { "CakeId" });
            DropIndex("dbo.OrderPosition", new[] { "OrderId" });
            DropIndex("dbo.Cake", new[] { "CategoryId" });
            DropTable("dbo.Order");
            DropTable("dbo.OrderPosition");
            DropTable("dbo.Category");
            DropTable("dbo.Cake");
        }
    }
}
