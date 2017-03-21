namespace Seminaire.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Seminaire.Models.SeminaireContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Seminaire.Models.SeminaireContext";
        }

        protected override void Seed(Seminaire.Models.SeminaireContext context)
        {
            Conference conf1 = new Conference()
            {
                ConferenceId = 1,
                Nom = "C# expliqué aux gestionnaires",
                Description = "jkl lflasjfl asldfj jkl;dfj l;asdj l;fjasdlfj asdl;jksdlfjsdklfjlsdfjoifjowefj lsdk ",
                Lieu = "Salle 102",
                Date = new DateTime(2017, 04, 12, 13, 00, 00),
                Duree = new TimeSpan(1, 0, 0)
            };
            Conference conf2 = new Conference()
            {
                ConferenceId = 2,
                Nom = "Comment détecter un fraudeur",
                Description = "jkl lflasjfl asldfj jkl;dfj l;asdj l;fjasdlfj asdl;jksdlfjsdklfjlsdfjoifjowefj lsdk ",
                Lieu = "Salle 103",
                Date = new DateTime(2017, 04, 13, 13, 00, 00),
                Duree = new TimeSpan(1, 0, 0)
            };
            Conference conf3 = new Conference()
            {
                ConferenceId = 3,
                Nom = "Les nouvelles règles fiscales",
                Description = "jkl lflasjfl asldfj jkl;dfj l;asdj l;fjasdlfj asdl;jksdlfjsdklfjlsdfjoifjowefj lsdk ",
                Lieu = "Salle 104",
                Date = new DateTime(2017, 04, 3, 13, 00, 00),
                Duree = new TimeSpan(2, 0, 0)
            };

            context.Conferences.AddOrUpdate(conf1);
            context.Conferences.AddOrUpdate(conf2);
            context.Conferences.AddOrUpdate(conf3);

            base.Seed(context);



            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
