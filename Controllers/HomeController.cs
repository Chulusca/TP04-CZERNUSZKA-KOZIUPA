using Microsoft.AspNetCore.Mvc;
using TP04_CZERNUSZKA_KOZIUPA.Models;

namespace TP04_CZERNUSZKA_KOZIUPA.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() 
    {
        ViewBag.DicIndumentaria = Equipos.dicIndumentaria;
        ViewBag.ListaEquipos = Equipos.ListaEquipos;
        ViewBag.ListaPantalones = Equipos.ListaPantalones;
        ViewBag.ListaMedias = Equipos.ListaMedias;
        ViewBag.ListaRemeras = Equipos.ListaRemeras;
        return View();
    }
    public IActionResult SelectIndumentaria(){
        ViewBag.ListaEquipos = Equipos.ListaEquipos;
        ViewBag.ListaPantalones = Equipos.ListaPantalones;
        ViewBag.ListaMedias = Equipos.ListaMedias;
        ViewBag.ListaRemeras = Equipos.ListaRemeras;
        return View("SelectIndumentaria");
    }
    public IActionResult GuardarIndumentaria(int Equipo, int Remera, int Pantalon, int Media){
        Indumentaria item = new Indumentaria(Media ,Pantalon ,Remera );
        Equipos.IngresarIndumentaria(Equipo, item);
        return RedirectToAction("Index");
    }
}
