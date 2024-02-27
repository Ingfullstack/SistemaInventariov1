using Microsoft.AspNetCore.Mvc;

namespace SistemaInventariov1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AlmacenesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
