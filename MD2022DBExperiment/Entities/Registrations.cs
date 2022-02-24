using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MD2022DBExperiment.Entities
{
    //Holds the actual registrations to Scheduled workshops
    public class Registrations
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        //A scheduled workshop
        public Timeslots WorkshopRegistration { get; set; }

        //The participant of the workshop
        public GroupMembers GroupMember { get; set; }

        //Timestamp of registration
        public DateTime Timestamp { get; set; }
    }
}
