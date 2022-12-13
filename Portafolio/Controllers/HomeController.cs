using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using System.Diagnostics;

namespace Portafolio.Controllers
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
           

            var proyectos = ObtenerProyectos().Take(3);
            var modelo = new HomeIndex() { Proyectos = proyectos };

            return View(modelo);
        }

        private List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() { new Proyecto
            {
                Titulo = "Subra IT",
                Descripcion = "Analista de Aplicaciones",
                Link =  "https://www.subra-it.com/",
                ImagenURL = "/img/logo.png"
            },
             new Proyecto
            {
                Titulo = "Napse Global",
                Descripcion = "Soporte de Aplicaciones | Desarrollador",
                Link =  "https://napse.global/",
                ImagenURL = "/img/napse-big.png"
            },
              new Proyecto
            {
                Titulo = "KaiZen2B",
                Descripcion = "Analista Programador",
                Link =  "http://www.kaizen2b.com/",
                ImagenURL = "/img/KaiZen2B-NuevoLogo.png"
            }
            };
        }

        public IActionResult Privacy()
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