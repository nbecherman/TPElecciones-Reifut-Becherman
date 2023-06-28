using Microsoft.AspNetCore.Mvc;

namespace TPElecciones.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
