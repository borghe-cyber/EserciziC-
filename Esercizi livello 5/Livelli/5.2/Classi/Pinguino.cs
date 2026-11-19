namespace Esercizi_livello_5.Esercizio5_2;

public class Pinguino : INuotatore, ICamminatore
{
    public void Nuota()
    {
        Console.WriteLine("Il pinguino nuota velocissimo sott'acqua.");
    }

    public void Cammina()
    {
        Console.WriteLine("Il pinguino cammina goffamente sul ghiaccio.");
    }
}
