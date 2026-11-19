namespace Esercizi_livello_5.Esercizio5_2;

public class Anatra : IVolante, INuotatore, ICamminatore
{
    public void Vola()
    {
        Console.WriteLine("L'anatra vola sopra lo stagno.");
    }

    public void Nuota()
    {
        Console.WriteLine("L'anatra nuota tranquilla.");
    }

    public void Cammina()
    {
        Console.WriteLine("L'anatra cammina dondolando.");
    }
}
