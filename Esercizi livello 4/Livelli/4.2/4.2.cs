namespace Esercizi_livello_4.Esercizio4_2;



public static class Esercizio
{
    public static void Esegui()
    {
        Console.WriteLine("Esercizio 4.2");

        List<Impiegato> dipendenti = new List<Impiegato>
        {
            new Operaio("Mario", "Rossi", 150, 10m),     // senza straordinari: 150 × 10 = 1500
            new Operaio("Luigi", "Verdi", 170, 10m),     // 160 × 10 + 10 × 10 × 1,5 = 1750
            new Manager("Anna", "Bianchi", 3000m, 4)     // 3000 + 3000 × 0,10 × 4 = 4200
        };

   
        decimal totale = 0;
        foreach (Impiegato i in dipendenti)
        {
            i.Descrizione();
            totale += i.CalcolaStipendio();
        }
        Console.WriteLine($"Totale stipendi: {totale:0.00} €");

    }
}
