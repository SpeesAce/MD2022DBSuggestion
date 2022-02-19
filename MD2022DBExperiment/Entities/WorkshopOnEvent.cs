using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MD2022DBExperiment.Entities
{
    //An actual Scheduled workshop
    public class WorkshopOnEvent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        //The workshop type
        [Required]
        public Workshops Workshop { get; set; }

        //The event where the workshop is taking place
        [Required]
        public Events Event { get; set; }

        //The guest speaker for this specifc workshop
        [Required]
        public Speakers Speaker { get; set; }

        //Start time of this workshop
        [Required]
        public DateTime StartTime { get; set; }

        //End time of this workshop
        [Required]
        public DateTime EndTime { get; set; }

        //Depends if number of possible participants is set by location capacity
        [Required]
        public int MaxParticipants { get; set; }

        //Could be a hardcoded string for now or refering to a Location class later on
        [Required]
        public string Location { get; set; }
    }
}
