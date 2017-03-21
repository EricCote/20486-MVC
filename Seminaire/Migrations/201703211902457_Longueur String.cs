namespace Seminaire.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LongueurString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Conferences", "Nom", c => c.String(maxLength: 50));
            AlterColumn("dbo.Conferences", "Description", c => c.String(maxLength: 1000));
            AlterColumn("dbo.Conferences", "Lieu", c => c.String(maxLength: 30));
            AlterColumn("dbo.Participants", "Nom", c => c.String(maxLength: 50));
            AlterColumn("dbo.Participants", "Courriel", c => c.String(maxLength: 100));
            AlterColumn("dbo.Participants", "Telephone", c => c.String(maxLength: 15));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Participants", "Telephone", c => c.String());
            AlterColumn("dbo.Participants", "Courriel", c => c.String());
            AlterColumn("dbo.Participants", "Nom", c => c.String());
            AlterColumn("dbo.Conferences", "Lieu", c => c.String());
            AlterColumn("dbo.Conferences", "Description", c => c.String());
            AlterColumn("dbo.Conferences", "Nom", c => c.String());
        }
    }
}
