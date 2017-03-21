namespace Seminaire.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajouterParticipants : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Participants",
                c => new
                    {
                        ParticipantId = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Courriel = c.String(),
                        Telephone = c.String(),
                    })
                .PrimaryKey(t => t.ParticipantId);
            
            CreateTable(
                "dbo.Inscription",
                c => new
                    {
                        ConferenceId = c.Int(nullable: false),
                        ParticipantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ConferenceId, t.ParticipantId })
                .ForeignKey("dbo.Conferences", t => t.ConferenceId, cascadeDelete: true)
                .ForeignKey("dbo.Participants", t => t.ParticipantId, cascadeDelete: true)
                .Index(t => t.ConferenceId)
                .Index(t => t.ParticipantId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Inscription", "ParticipantId", "dbo.Participants");
            DropForeignKey("dbo.Inscription", "ConferenceId", "dbo.Conferences");
            DropIndex("dbo.Inscription", new[] { "ParticipantId" });
            DropIndex("dbo.Inscription", new[] { "ConferenceId" });
            DropTable("dbo.Inscription");
            DropTable("dbo.Participants");
        }
    }
}
