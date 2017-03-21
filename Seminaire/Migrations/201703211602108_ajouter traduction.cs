namespace Seminaire.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajoutertraduction : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Conferences", "Traduction", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Conferences", "Traduction");
        }
    }
}
