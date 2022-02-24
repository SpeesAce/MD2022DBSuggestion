using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MD2022DBExperiment.Entities
{
    public class SpeakerAllocations
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        [Required]
        public Speakers Speaker { get; set; }   //User

        public Timeslots Timeslot { get; set; }
    }
}
