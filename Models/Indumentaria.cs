namespace TP04_CZERNUSZKA_KOZIUPA.Models;

public class Indumentaria{
    public int medias{get;private set;}
    public int pantalon{get;private set;}
    public int camiseta{get;private set;}

    public Indumentaria(int m, int p, int c){
        medias = m; pantalon = p; camiseta = c;
    }
    public Indumentaria(){
        
    }
}