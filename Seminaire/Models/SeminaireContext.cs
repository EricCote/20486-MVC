using Seminaire.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seminaire.Models
{
    public class SeminaireContext : DbContext
    {
        public SeminaireContext() : base ("Seminaire")
        {
            Database.SetInitializer(new 
                   MigrateDatabaseToLatestVersion<
                      SeminaireContext,Configuration>() );
        }

        public DbSet<Conference> Conferences { get; set; }
    }
}