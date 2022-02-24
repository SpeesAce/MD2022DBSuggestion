using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MD2022DBExperiment.Entities
{
    //Holds the actual registrations to Scheduled workshops
    public class Registrations
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        //A scheduled workshop
        [Required]
        public Timeslots WorkshopRegistration { get; set; }

        //The participant of the workshop
        [Required]
        public IdentityUser User { get; set; }

        //Timestamp of registration
        public DateTime CreatedOn { get; set; }
    }
}
