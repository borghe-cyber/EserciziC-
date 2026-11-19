using System.Net;

namespace Esercizi_livello_2.Esercizio2_1;



public static class Esercizio
{
    public static void Esegui()
    {
        Persona p1 = new Persona("Marco","Rossi",2000);
        Persona p2 = new Persona("Luigi","Gialli",1900);
        Persona p3 = new Persona("Anna","Pappalardo",1000);


        p1.Presentati();
        p2.Presentati();
        p3.Presentati();



    }
}
