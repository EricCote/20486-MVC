using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seminaire.Models
{
    public class ListeConferences : List<Conference>
    {
        public ListeConferences()
        {
            Conference conf1 = new Conference() {
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

            this.Add(conf1);
            this.Add(conf2);
            this.Add(conf3);
        }



    }
}