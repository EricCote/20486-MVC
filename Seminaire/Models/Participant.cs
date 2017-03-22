using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required(ErrorMessage ="Le nom est obligatoire!")]
        [StringLength(50)]
        public string Nom { get; set; }
        [Required()]
        [DataType(DataType.EmailAddress)]
        [StringLength(100)]
        public string Courriel { get; set; }
        [StringLength(15)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name ="Téléphone", ShortName = "Tél")]
        public string Telephone { get; set; }

        public virtual ICollection<Conference> Conferences {
                                                    get; set; }

    }
}