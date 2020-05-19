using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Exercicio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mvc.Models;

namespace Mvc.Controllers
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
            return View();
        }

        public IActionResult Gerar()
        {
            Gerador gerador = new Gerador();
            var lista = gerador.Gerar();

            return View(lista);
        }
    }
}
