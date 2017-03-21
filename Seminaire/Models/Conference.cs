using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [StringLength(50)]
        public string Nom { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Duree { get; set; }
        [StringLength(30)]
        public string Lieu { get; set; }
        public bool Traduction { get; set; }

        public virtual ICollection<Participant> Participants {
                                                     get; set; }
    }
}