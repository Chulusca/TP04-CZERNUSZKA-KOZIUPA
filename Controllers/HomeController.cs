using Microsoft.AspNetCore.Mvc;
using TP04_CZERNUSZKA_KOZIUPA.Models;

namespace TP04_CZERNUSZKA_KOZIUPA.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() 
    {
        ViewBag.DicIndumentaria = Equipos.dicIndumentaria;
        return View();
    }
    public IActionResult SelectIndumentaria(){
        ViewBag.ListaEquipos = Equipos.ListaEquipos;
        ViewBag.ListaPantalones = Equipos.ListaPantalones;
        ViewBag.ListaMedias = Equipos.ListaMedias;
        ViewBag.ListaRemeras = Equipos.ListaRemeras;
        return View("SelectIndumentaria");
    }
    IActionResult GuardarIndumentaria(int Equipo, int Media, int Pantalon, int Remera){
        Indumentaria item = new Indumentaria(Media,Pantalon,Remera);
        if(Equipos.IngresarIndumentaria(Equipo, item)){
            return RedirectToAction("Index");
        }
        else{
            ViewBag.MsjError = "Se cargo incorrectamente los datos.";
            return RedirectToAction("SelectIndumentaria");
        }
    }
}
