using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MD2022DBExperiment.Entities
{
    //Holds a type of workshop
    public class Workshops
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        //The name of the workshop
        [Required]
        public string Name { get; set; }

        //The information on what the workshop is about
        [Required]
        public string Description { get; set; }

        //How long the workshop lasts
        [Required]
        public int Duration { get; set; }

        //In case a certain workshop always allows same amount of participants
        //[Required]
        //public int MaxParticipants { get; set; }

        
        //https://www.vives.be/nl/over-vives/kalender/management-days detailes on workshops mention these attributes
        //public enum Language {get;set;}
        //publlic string TargetGroup {get;set;}
        //public enum Category {get;set;}
        //public double Price {get;set}
    }
}
