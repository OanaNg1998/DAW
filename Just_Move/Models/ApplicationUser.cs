using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Just_Move.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string AddressId { get; set; }
        public string IntrestDomain { get; set; }


        public virtual ICollection<UserSubscription> UserSubscription { get; set; }
        public virtual Address Address { get; set; }


    }
}
