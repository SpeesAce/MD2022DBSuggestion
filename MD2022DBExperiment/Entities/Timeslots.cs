using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MD2022DBExperiment.Entities
{
    //An actual Scheduled workshop, replaces timeslot
    public class Timeslots
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        //The workshop type
        [Required]
        public Workshops Workshop { get; set; }

        //Start time of this workshop
        [Required]
        public DateTime StartTime { get; set; }

        //Set Location for this workshop
        [Required]
        public Locations Location { get; set; }
    }
}
