namespace Esercizi_livello_4.Esercizio4_3;


public static class Esercizio
{
    public static void Esegui()
    {
        Conto conto = new Conto("Mario", "Rossi", 1000m);

        Console.WriteLine($"Saldo iniziale: {conto.Saldo}");

        conto.Deposita(500m);
        Console.WriteLine($"Saldo dopo il deposito: {conto.Saldo}");

        conto.Preleva(200m);
        Console.WriteLine($"Saldo dopo il prelievo: {conto.Saldo}");

        conto.ApplicaInterresse();
        Console.WriteLine($"Saldo dopo l'applicazione degli interessi: {conto.Saldo}");
        
    }
}
