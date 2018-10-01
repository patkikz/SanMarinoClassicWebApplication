using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace BethanysPieShop.Controllers
{
    // example eto, gusto mo nakaauthorize lang sya sa specific role. so gagamit ka attribute na
    // so etong whole controller, ay nakarestrict langkay publicUser.

        // if specific page naman, tagalin natin sya sa taas
 // strin glang yan dapat may listahan kadin ng mga roles, let's say custom roles.
    public class ContactController : Controller
    {
        // GET: /<controller>/
        // eto free to open without any restriction okay po sir gets ko na po
        // sige good basta gamitin mo lang yung built in na security ni ASP.NET Core :)
        // kasi proven na sya 
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Users")] // etong page nato, restricted lang kay User under PublicUser
        public IActionResult UserUiPage()
        {
            return View();
        }
    }
}
