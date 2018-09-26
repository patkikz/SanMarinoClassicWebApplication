using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SanMarinoClassicWebsite.Models;
using SanMarinoClassicWebsite.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SanMarinoClassicWebsite.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        // GET: /<controller>/
        //    private readonly IPieRepository _pieRepository;

        //    public HomeController(IPieRepository pieRepository)
        //    {
        //        _pieRepository = pieRepository;
        //    }

        //    public ViewResult Index()
        //    {
        //        var homeViewModel = new HomeViewModel
        //        {
        //            PiesOfTheWeek = _pieRepository.IsPieOfTheWeek
        //        };

        //        return View(homeViewModel); 
        //    }
        //}
    }
}
