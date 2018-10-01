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

        public string  Claims { get; set; }

    }
}
