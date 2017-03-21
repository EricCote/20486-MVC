namespace Seminaire.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Required : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Participants", "Nom", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Participants", "Courriel", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Participants", "Courriel", c => c.String(maxLength: 100));
            AlterColumn("dbo.Participants", "Nom", c => c.String(maxLength: 50));
        }
    }
}
