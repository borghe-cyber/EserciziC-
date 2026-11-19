namespace Esercizi_livello_2.Esercizio2_5;

// struct = TIPO VALORE: la variabile contiene direttamente i dati
public struct PuntoStruct
{
    public int X;
    public int Y;

    public PuntoStruct(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return "(" + X + ", " + Y + ")";
    }
}
