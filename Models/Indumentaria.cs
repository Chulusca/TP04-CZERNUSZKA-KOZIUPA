namespace TP04_CZERNUSZKA_KOZIUPA.Models;

class Indumentaria{
    public string medias{get;private set;}
    public string pantalon{get;private set;}
    public string camiseta{get;private set;}

    public Indumentaria(string m, string p, string c){
        medias = m; pantalon = p; camiseta = c;
    }
    public Indumentaria(){
        
    }
}