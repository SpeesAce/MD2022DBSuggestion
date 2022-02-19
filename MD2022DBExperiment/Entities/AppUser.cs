using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MD2022DBExperiment.Entities
{
    //All members of this class easily be granted acces or roles trough the use of UserManager<AppUser> & SignInMaanger<AppUser> provided by Microsoft.AspNetCore.Identity;
    public class AppUser : IdentityUser
    {
        public Administrators Admins { get; set; }

        public GroupLeaders Groupleaders { get; set; }

        public GroupMembers GroupMembers { get; set; }

        public Speakers Speakers { get; set; }


    }
}
