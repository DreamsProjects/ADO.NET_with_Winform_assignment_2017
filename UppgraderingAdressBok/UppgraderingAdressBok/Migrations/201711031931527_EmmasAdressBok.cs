
namespace UppgraderingAdressBok.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmmasAdressBok : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adresses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Gatunamn = c.String(maxLength: 150),
                        Postnummer = c.String(),
                        Postort = c.String(maxLength: 150),
                        PersonID_PersonID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.People", t => t.PersonID_PersonID)
                .Index(t => t.PersonID_PersonID);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonID = c.Int(nullable: false, identity: true),
                        Förnamn = c.String(),
                        Efternamn = c.String(),
                        Kontakttyp_ID = c.Int(),
                    })
                .PrimaryKey(t => t.PersonID)
                .ForeignKey("dbo.Kontakts", t => t.Kontakttyp_ID)
                .Index(t => t.Kontakttyp_ID);
            
            CreateTable(
                "dbo.Eposts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Epostaddress = c.String(maxLength: 150),
                        PersonID_PersonID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.People", t => t.PersonID_PersonID)
                .Index(t => t.PersonID_PersonID);
            
            CreateTable(
                "dbo.Kontakts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Namn = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Telefons",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Riktnummer = c.Int(nullable: false),
                        Telefonnummer = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TelefonPersons",
                c => new
                    {
                        Telefon_ID = c.Int(nullable: false),
                        Person_PersonID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Telefon_ID, t.Person_PersonID })
                .ForeignKey("dbo.Telefons", t => t.Telefon_ID, cascadeDelete: true)
                .ForeignKey("dbo.People", t => t.Person_PersonID, cascadeDelete: true)
                .Index(t => t.Telefon_ID)
                .Index(t => t.Person_PersonID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TelefonPersons", "Person_PersonID", "dbo.People");
            DropForeignKey("dbo.TelefonPersons", "Telefon_ID", "dbo.Telefons");
            DropForeignKey("dbo.People", "Kontakttyp_ID", "dbo.Kontakts");
            DropForeignKey("dbo.Eposts", "PersonID_PersonID", "dbo.People");
            DropForeignKey("dbo.Adresses", "PersonID_PersonID", "dbo.People");
            DropIndex("dbo.TelefonPersons", new[] { "Person_PersonID" });
            DropIndex("dbo.TelefonPersons", new[] { "Telefon_ID" });
            DropIndex("dbo.Eposts", new[] { "PersonID_PersonID" });
            DropIndex("dbo.People", new[] { "Kontakttyp_ID" });
            DropIndex("dbo.Adresses", new[] { "PersonID_PersonID" });
            DropTable("dbo.TelefonPersons");
            DropTable("dbo.Telefons");
            DropTable("dbo.Kontakts");
            DropTable("dbo.Eposts");
            DropTable("dbo.People");
            DropTable("dbo.Adresses");
        }
    }
}
