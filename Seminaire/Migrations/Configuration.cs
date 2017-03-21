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
                Nom = "C# expliqu� aux gestionnaires",
                Description = "Ce s�minaire explique � des gestionnaires comment utiliser C# pour que les d�veloppeurs soient plus productifs. Nous allons parler du langage C#, le comparer au langage VB.  Nous parlerons de compilation et de d�ploiement.",
                Lieu = "Salle 102",
                Date = new DateTime(2017, 04, 12, 13, 00, 00),
                Duree = new TimeSpan(1, 0, 0)
            };
            Conference conf2 = new Conference()
            {
                ConferenceId = 2,
                Nom = "Comment d�tecter un fraudeur",
                Description = "Les fraudeurs sont parmis nous. Ils nous font du tord. Ils nous font mal. Il faut donc les �viter. Mais pour cela, il faut les reconnaitre.  Nous allons donc �num�rer toutes les caract�ristiques pour que l'on puisse identifier les fraudeurs parmi nous.",
                Lieu = "Salle 103",
                Date = new DateTime(2017, 04, 13, 13, 00, 00),
                Duree = new TimeSpan(1, 0, 0)
            };
            Conference conf3 = new Conference()
            {
                ConferenceId = 3,
                Nom = "Les nouvelles r�gles fiscales",
                Description = "Les r�gles fiscales changent � chaque ann�e.  Connaissez-vous les nouvelles r�gles fiscales de l'ann�e 2017? Nous allons �numerer les �l�ments de la derni�re mise � jour des r�gles fiscales du gouvernement du Qu�bec. Ce sera tr�s int�ressant.",
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
