using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seminaire.Models
{
    public class Participant
    {
        public Participant()
        {
            Conferences = new HashSet<Conference>();
        }

        public int ParticipantId { get; set; }
        public string Nom { get; set; }
        public string Courriel { get; set; }
        public string Telephone { get; set; }

        public virtual ICollection<Conference> Conferences {
                                                    get; set; }

    }
}