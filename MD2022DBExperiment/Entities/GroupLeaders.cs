using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MD2022DBExperiment.Entities
{
    //Holds the GroupLeaders. Can be used for both for approved or pending 
    public class GroupLeaders
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        //The organisation to which the leader belongs
        [Required]
        public String Organisation { get; set; }

        //His function within his organisation
        [Required]
        public string JobTitle { get; set; }

        [Required]       
        public IdentityUser User { get; set; } 

        //public DateTime Timestamp {get;set;}      //Could be used to track when a request was made
        //public DateTime ApprovedOn {get;set;}     //Could be used to track when access got granted
        //public Administrators ApprovedBy {get;set} //Could be used to track who granted access
    }
}
