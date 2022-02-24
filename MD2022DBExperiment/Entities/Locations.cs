using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MD2022DBExperiment.Entities
{
    public class Locations
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        //Name (perhaps VIVES classroom namingconvention in the future, Admin's responsibility atm)
        [Required]
        public string Name { get; set; }

        //The information on the Location
        public string Description { get; set; }

        //Maximum number of participants possible for a specific location
        [Required]
        public int MaxParticipants { get; set; }
    }
}
