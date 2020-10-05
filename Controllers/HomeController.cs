using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projeto.NET.Models;
using Projeto_.NET.Models;
using Projeto_.NET_CORE.Models;

namespace Projeto_.NET.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Time BVB = Time.getInstance("Borussia Dortmund", 1909, 24, "O Borussia Dortmund venceu oito campeonatos alemães, 7 DFB-Pokals, seis DFL-Supercups, uma Liga dos Campeões, uma Taça dos Clubes Vencedores de Taças e uma Copa Intercontinental. A conquista da Taça dos Clubes Vencedores de Taças em 1966 fez deles o primeiro clube alemão a conquistar um título europeu.");

            return View(BVB);
        }
        public IActionResult Home()
        {
            return View("Home");
        }
        public ViewResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
