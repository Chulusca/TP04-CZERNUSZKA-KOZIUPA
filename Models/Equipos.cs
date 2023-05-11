namespace TP04_CZERNUSZKA_KOZIUPA.Models;
using System.Collections.Generic;
public static class Equipos{
    public static List<string>ListaEquipos {get;private set;} = new List<string>() {
        "River", "Boca", "San Lorenzo", "Riestra", "Barracas Central", "Aldosivi", "Estudiantes de la plata", "Instituto", "Chacarita", "Nueva Chicago"
    };
    public static List<string>ListaMedias {get;private set;} = new List<string>() {
        "medias_amarillas.png", "medias_azules.png", "medias_blancas.png", "medias_bordo.png", "medias_grises.png", "medias_negras.png", "medias_negras2.png", "medias_rojas.png", "medias_verdeneon.png", "medias_verdes.png"
    };
    public static List<string>ListaPantalones {get;private set;} = new List<string>() {
        "pantalon_azul.png", "pantalon_azuloscuro.png", "pantalon_blanco.png", "pantalon_bordo.png", "pantalon_gris.png", "pantalon_naranja.png", "pantalon_negro.png", "pantalon_rojo.png", "pantalon_rosa.png", "pantalon_violeta.png"
    };
    public static List<string>ListaRemeras {get;private set;} = new List<string>() {
        "remera_amarilla.png", "remera_azul.png", "remera_blanca.png", "remera_celeste.png", "remera_gris.png", "remera_naranja.png", "remera_negra.png", "remera_roja.png", "remera_verde.png", "remera_violeta.png"
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