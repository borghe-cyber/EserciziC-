namespace Esercizi_livello_2.Esercizio2_2;

// Esercizio 2.2
// Le classi di questo esercizio vanno nella cartella "Classi" accanto a questo file,
// sempre con: namespace Esercizi_livello_2.Esercizio2_2;

public static class Esercizio
{
    public static void Esegui()
    {
        Random random = new Random();
        decimal b = Math.Round((decimal)(random.NextDouble() * 17 + 3), 2);
        decimal a = Math.Round((decimal)(random.NextDouble() * 17 + 3), 2);
        Console.WriteLine("Valore della base "+b);
        Console.WriteLine("Valore dell' altezza "+a);

        // Rettangolo: costruttore con 2 parametri (base, altezza)
        Rettangolo rettangolo = new Rettangolo(b, a);
        rettangolo.calcoloPerimentro();
        rettangolo.calcoloArea();

        Console.WriteLine();

        // Quadrato: costruttore con 1 parametro (altezza = lato)
        Rettangolo quadrato = new Rettangolo(a);
        quadrato.PerimentroQuadrato();
        quadrato.AreaQuadrato();
    }
}
