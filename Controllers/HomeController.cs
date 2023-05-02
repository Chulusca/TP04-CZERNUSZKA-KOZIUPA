using Microsoft.AspNetCore.Mvc;

namespace TP04_CZERNUSZKA_KOZIUPA.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
