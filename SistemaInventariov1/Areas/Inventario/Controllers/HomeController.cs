using Microsoft.AspNetCore.Mvc;
using SistemaInventariov1.Modelo.ViewsModels;
using System.Diagnostics;

namespace SistemaInventariov1.Areas.Inventario.Controllers
{
    [Area("Inventario")]
    public class HomeController : Controller
    {

        public IActionResult Index()
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
