namespace AnimalSheletr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdClass = c.Byte(nullable: false),
                        Gender = c.String(),
                        Nickname = c.String(),
                        Photo = c.String(),
                        AppearanceDescr = c.String(),
                        Notes = c.String(),
                        ReceiptDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classifications", t => t.IdClass, cascadeDelete: true)
                .Index(t => t.IdClass);
            
            CreateTable(
                "dbo.Classifications",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Class = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contracts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumContract = c.String(),
                        IdOwner = c.Int(nullable: false),
                        IdAnimal = c.Int(nullable: false),
                        DateOfSigning = c.DateTime(nullable: false),
                        DepartureDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Animals", t => t.IdAnimal, cascadeDelete: true)
                .ForeignKey("dbo.Visitors", t => t.IdOwner, cascadeDelete: true)
                .Index(t => t.IdOwner)
                .Index(t => t.IdAnimal);
            
            CreateTable(
                "dbo.Visitors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Passport = c.String(),
                        PassportRegistr = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Expenses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdExpenseType = c.Short(nullable: false),
                        IdAnimal = c.Int(nullable: false),
                        Count = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Notes = c.String(),
                        DateTimeNote = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Animals", t => t.IdAnimal, cascadeDelete: true)
                .ForeignKey("dbo.ExpenseTypes", t => t.IdExpenseType, cascadeDelete: true)
                .Index(t => t.IdExpenseType)
                .Index(t => t.IdAnimal);
            
            CreateTable(
                "dbo.ExpenseTypes",
                c => new
                    {
                        Id = c.Short(nullable: false, identity: true),
                        NameType = c.String(),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Count = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Expenses", "IdExpenseType", "dbo.ExpenseTypes");
            DropForeignKey("dbo.Expenses", "IdAnimal", "dbo.Animals");
            DropForeignKey("dbo.Contracts", "IdOwner", "dbo.Visitors");
            DropForeignKey("dbo.Contracts", "IdAnimal", "dbo.Animals");
            DropForeignKey("dbo.Animals", "IdClass", "dbo.Classifications");
            DropIndex("dbo.Expenses", new[] { "IdAnimal" });
            DropIndex("dbo.Expenses", new[] { "IdExpenseType" });
            DropIndex("dbo.Contracts", new[] { "IdAnimal" });
            DropIndex("dbo.Contracts", new[] { "IdOwner" });
            DropIndex("dbo.Animals", new[] { "IdClass" });
            DropTable("dbo.ExpenseTypes");
            DropTable("dbo.Expenses");
            DropTable("dbo.Visitors");
            DropTable("dbo.Contracts");
            DropTable("dbo.Classifications");
            DropTable("dbo.Animals");
        }
    }
}
