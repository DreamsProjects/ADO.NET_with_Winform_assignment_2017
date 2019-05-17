namespace UppgraderingAdressBok.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _201711031931527_EmmasAdressBok : DbMigration
    {
        public override void Up()
        {
      //      DropForeignKey("dbo.Adresses", "Person_PersonID1", "dbo.People");
      //      DropIndex("dbo.Adresses", new[] { "Person_PersonID" });
       //     DropIndex("dbo.Adresses", new[] { "Person_PersonID1" });
            DropColumn("dbo.Adresses", "PersonID_PersonID");
        //    RenameColumn(table: "dbo.Adresses", name: "Person_PersonID", newName: "PersonID_PersonID");
        //    DropColumn("dbo.Adresses", "Person_PersonID1");
        }

        public override void Down()
        {
        //    AddColumn("dbo.Adresses", "Person_PersonID1", c => c.Int());
        //    RenameColumn(table: "dbo.Adresses", name: "PersonID_PersonID", newName: "Person_PersonID");
            AddColumn("dbo.Adresses", "PersonID_PersonID", c => c.Int());
        //    CreateIndex("dbo.Adresses", "Person_PersonID1");
            CreateIndex("dbo.Adresses", "Person_PersonID");
         //   AddForeignKey("dbo.Adresses", "Person_PersonID1", "dbo.People", "PersonID");
        }
    }
}
