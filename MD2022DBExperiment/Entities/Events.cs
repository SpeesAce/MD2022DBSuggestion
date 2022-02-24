using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MD2022DBExperiment.Entities
{
    //Holds the events created by an Admin
    public class Events
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public string Description { get; set; }

        ///I would suggest dropping these for first deployment
        //public string FacebookLink {get;set;} //always the same if even existing atm?
        //public string WebsiteLink {get;set;}  //will always refer to https://www.vives.be/nl/over-vives/kalender/management-days
        //public string FotoLink {get;set;}     //Not a priority
        //public string Organisation {get;set}  //Always Vives for now
        //public string Information {get;set;}  //Can be found in the Description
        //public string ContactUserId {get;set;}    //Always madam Vanrenterghem for now

    }
}
