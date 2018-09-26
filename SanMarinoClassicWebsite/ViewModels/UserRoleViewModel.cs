﻿using Microsoft.AspNetCore.Identity;
using SanMarinoClassicWebsite.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SanMarinoClassicWebsite.ViewModels
{
    public class UserRoleViewModel
    {
        public UserRoleViewModel()
        {
            Users = new List<IdentityUser>();
        }

        public string UserId { get; set; }

        public string RoleId { get; set; }

        public List<IdentityUser> Users { get; set; }
    }
}
