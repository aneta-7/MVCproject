namespace Samoloty.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class startowa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Przelots",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PunktStartowty = c.String(nullable: false, maxLength: 60),
                        Data1 = c.DateTime(nullable: false),
                        Czas1 = c.String(nullable: false),
                        PunktKoncowy = c.String(nullable: false, maxLength: 60),
                        Data2 = c.DateTime(nullable: false),
                        Czas2 = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Samolots",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(nullable: false, maxLength: 20),
                        Typ = c.String(nullable: false, maxLength: 20),
                        Przelot_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Przelots", t => t.Przelot_ID)
                .Index(t => t.Przelot_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Samolots", "Przelot_ID", "dbo.Przelots");
            DropIndex("dbo.Samolots", new[] { "Przelot_ID" });
            DropTable("dbo.Samolots");
            DropTable("dbo.Przelots");
        }
    }
}
