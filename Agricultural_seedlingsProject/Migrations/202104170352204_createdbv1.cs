namespace Agricultural_seedlingsProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdbv1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Forests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ForestName = c.String(),
                        Price = c.Int(nullable: false),
                        Image = c.String(),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Fruits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FruitName = c.String(),
                        Price = c.Int(nullable: false),
                        Image = c.String(),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contactus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(nullable: false),
                        Message = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        User_Id = c.Int(nullable: false),
                        nursaryName = c.String(),
                        ProductName = c.String(),
                        Reservation_Date = c.DateTime(nullable: false),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Greens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GreenName = c.String(),
                        Price = c.Int(nullable: false),
                        Image = c.String(),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ornamentals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrnamentalName = c.String(),
                        Price = c.Int(nullable: false),
                        Image = c.String(),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        LastName = c.String(nullable: false, maxLength: 30),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false, maxLength: 100),
                        BirthDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Ornamentals");
            DropTable("dbo.Greens");
            DropTable("dbo.Sales");
            DropTable("dbo.Contactus");
            DropTable("dbo.Fruits");
            DropTable("dbo.Forests");
        }
    }
}
