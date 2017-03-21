namespace Seminaire.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Conferences",
                c => new
                    {
                        ConferenceId = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Description = c.String(),
                        Date = c.DateTime(nullable: false),
                        Duree = c.Time(nullable: false, precision: 7),
                        Lieu = c.String(),
                    })
                .PrimaryKey(t => t.ConferenceId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Conferences");
        }
    }
}
