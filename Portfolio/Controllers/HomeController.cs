using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Repos()
        {
            var repoList = Repo.GetRepos();
            return View(repoList);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}