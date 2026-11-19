namespace Esercizi_livello_2.Esercizio2_5;

// class = TIPO RIFERIMENTO: la variabile contiene l'indirizzo dell'oggetto
public class PuntoClasse
{
    public int X;
    public int Y;

    public PuntoClasse(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return "(" + X + ", " + Y + ")";
    }
}
