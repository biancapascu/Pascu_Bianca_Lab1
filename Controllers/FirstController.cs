using Microsoft.AspNetCore.Mvc;

namespace Pascu_Bianca_Lab1.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {
            return Content("Bine ati venit!");
        }
        public IActionResult Salut()
        {
            return Content("Salut!");
        }
        public IActionResult Mesaj(string nume, int nr)
        {
            return Content(nume+" a selectat "+nr+" produse.");
        }
    }
}
