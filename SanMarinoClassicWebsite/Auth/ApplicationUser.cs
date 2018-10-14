using Microsoft.AspNetCore.Identity;
using SanMarinoClassicWebsite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SanMarinoClassicWebsite.Auth
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime Birthdate { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        /// Navigation property for the claims this user possesses.
        ///

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; } = new List<IdentityUserClaim<string>>();
    }
}