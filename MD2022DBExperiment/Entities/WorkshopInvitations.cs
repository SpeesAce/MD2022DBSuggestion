using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MD2022DBExperiment.Entities
{
    //Holds the invitations to which certain groupmembers were allowed to register by their groupleader
    public class WorkshopInvitations
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        //Timestamp on when invitation was send, can be used to track potential deadline to register
        //[Required]
        //public DateTime TimeStamp { get; set; }

        //The actual Scheduled workshop to which the groupmember is invited
        [Required]
        public Timeslots Timeslots { get; set; }

        //The member that is invited to participate to a specific workshop
        [Required]
        public GroupMembers GroupMember { get; set; }

        //Bit value to track whether invitation is accepted
        [Required]
        public bool Accepted { get; set; } = false;
    }
}
