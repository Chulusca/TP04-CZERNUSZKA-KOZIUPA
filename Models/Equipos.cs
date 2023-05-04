namespace TP04_CZERNUSZKA_KOZIUPA.Models;
using System.Collections.Generic;
public static class Equipos{
    public static List<string>ListaEquipos {get;private set;} = new List<string>() {
        "River", "Boca", "San Lorenzo", "Riestra", "Barracas Central", "Aldosivi", "Estudiantes de la plata", "Instituto", "Chacarita", "Nueva Chicago"
    };
    public static List<string>ListaMedias {get;private set;} = new List<string>() {
        "", "", "", "", "", "", "", "", "", ""
    };
    public static List<string>ListaPantalones {get;private set;} = new List<string>() {
        "", "", "", "", "", "", "", "", "", ""
    };
    public static List<string>ListaRemeras {get;private set;} = new List<string>() {
        "", "", "", "", "", "", "", "", "", ""
    };
    
    public static Dictionary<string, Indumentaria>dicIndumentaria {get; private set;} = new Dictionary<string, Indumentaria>();

    public static bool IngresarIndumentaria(string Equipo, Indumentaria item){
        if (dicIndumentaria.ContainsKey(Equipo)){
            return false;
        }
        else{
            dicIndumentaria.Add(Equipo, item);
            return true;
        }
    }
}