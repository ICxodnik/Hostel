namespace DbLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(unicode: false),
                        Address = c.String(unicode: false),
                        Passport = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.orderedrooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TotalCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        InDate = c.DateTime(nullable: false, precision: 0),
                        OutDate = c.DateTime(nullable: false, precision: 0),
                        Client_Id = c.Int(),
                        Room_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.clients", t => t.Client_Id)
                .ForeignKey("dbo.rooms", t => t.Room_Id)
                .Index(t => t.Client_Id)
                .Index(t => t.Room_Id);
            
            CreateTable(
                "dbo.rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        Number = c.String(unicode: false),
                        CostPerDay = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.serviceorders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProvidedDate = c.DateTime(nullable: false, precision: 0),
                        CashPaid = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Client_Id = c.Int(),
                        Service_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.clients", t => t.Client_Id)
                .ForeignKey("dbo.services", t => t.Service_Id)
                .Index(t => t.Client_Id)
                .Index(t => t.Service_Id);
            
            CreateTable(
                "dbo.services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        Title = c.String(unicode: false),
                        Time = c.String(unicode: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SourceImage = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.serviceorders", "Service_Id", "dbo.services");
            DropForeignKey("dbo.serviceorders", "Client_Id", "dbo.clients");
            DropForeignKey("dbo.orderedrooms", "Room_Id", "dbo.rooms");
            DropForeignKey("dbo.orderedrooms", "Client_Id", "dbo.clients");
            DropIndex("dbo.serviceorders", new[] { "Service_Id" });
            DropIndex("dbo.serviceorders", new[] { "Client_Id" });
            DropIndex("dbo.orderedrooms", new[] { "Room_Id" });
            DropIndex("dbo.orderedrooms", new[] { "Client_Id" });
            DropTable("dbo.services");
            DropTable("dbo.serviceorders");
            DropTable("dbo.rooms");
            DropTable("dbo.orderedrooms");
            DropTable("dbo.clients");
        }
    }
}
