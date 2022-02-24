using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MD2022DBExperiment.Entities
{
    public class GroupMembers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        
        [Required]
        public Groups Group { get; set; }

        [Required]
        public IdentityUser Member { get; set; }

    }
}
