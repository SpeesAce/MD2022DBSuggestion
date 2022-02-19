using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MD2022DBExperiment.Entities
{
    public class AppUser : IdentityUser
    {
        public Administrator Admins { get;set }

        public GroupLeaders Groupleaders { get;set }

        public
    }
}
