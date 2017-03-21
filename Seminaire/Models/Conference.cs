using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seminaire.Models
{
    public class Conference
    {
        public Conference()
        {
            Participants = new HashSet<Participant>();
        }

        public int ConferenceId { get; set; }

        public string Nom { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Duree { get; set; }
        public string Lieu { get; set; }
        public bool Traduction { get; set; }

        public virtual ICollection<Participant> Participants {
                                                     get; set; }
    }
}