namespace Esercizi_livello_1.Esercizi;

public static class Esercizio1_5
{
    public static double Somma(double a, double b)
    {
        return a + b;
    }

    public static double Sottrazione(double a, double b)
    {
        return a - b;
    }

    public static double Moltiplicazione(double a, double b)
    {
        return a * b;
    }

    public static double Divisione(double a, double b)
    {
        return a / b;
    }

    public static double Radice(double a)
    {
        return Math.Sqrt(a);
    }

    public static double Potenza(double baseNum, double esponente)
    {
        return Math.Pow(baseNum, esponente);
    }

    public static void Esegui()
    {
        Console.WriteLine("Inserisci il primo numero");
        double a = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Inserisci il secondo numero");
        double b = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Somma: " + Somma(a, b));
        Console.WriteLine("Sottrazione: " + Sottrazione(a, b));
        Console.WriteLine("Moltiplicazione: " + Moltiplicazione(a, b));
        Console.WriteLine("Divisione: " + Divisione(a, b));
        Console.WriteLine("Radice del primo numero: " + Radice(a));
        Console.WriteLine("Potenza (primo elevato al secondo): " + Potenza(a, b));
    }
}
