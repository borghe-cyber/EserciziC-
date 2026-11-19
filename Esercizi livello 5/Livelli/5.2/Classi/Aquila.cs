namespace Esercizi_livello_5.Esercizio5_2;

public class Aquila : IVolante, ICamminatore
{
    public void Vola()
    {
        Console.WriteLine("L'aquila vola alta nel cielo.");
    }

    public void Cammina()
    {
        Console.WriteLine("L'aquila cammina sulla roccia.");
    }
}
