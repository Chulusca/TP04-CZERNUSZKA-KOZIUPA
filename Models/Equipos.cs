namespace TP04_CZERNUSZKA_KOZIUPA.Models;
using System.Collections.Generic;
public static class Equipos{
    public static List<string>ListaEquipos {get;private set;} = new List<string>() {
        "River", "Boca", "San Lorenzo", "Riestra", "Barracas Central", "Aldosivi", "Estudiantes de la plata", "Instituto", "Chacarita", "Nueva Chicago"
    };
    public static List<string>ListaMedias {get;private set;} = new List<string>() {
        "medias_amarillas.png", "medias_azules.png", "medias_blancas.png", "medias_bordo.png", "medias_grises.png", "medias_negras.png", "medias_negras2.png", "medias_rojas", "medias_verdeneon.png", "medias_verde.png"
    };
    public static List<string>ListaPantalones {get;private set;} = new List<string>() {
        "", "", "", "", "", "", "", "", "", ""
    };
    public static List<string>ListaRemeras {get;private set;} = new List<string>() {
        "", "", "", "", "", "", "", "", "", ""
    };
    
    public static Dictionary<int, Indumentaria>dicIndumentaria {get; private set;} = new Dictionary<int, Indumentaria>();

    public static bool IngresarIndumentaria(int Equipo, Indumentaria item){
        if (dicIndumentaria.ContainsKey(Equipo)){
            return false;
        }
        else{
            dicIndumentaria.Add(Equipo, item);
            return true;
        }
    }
}