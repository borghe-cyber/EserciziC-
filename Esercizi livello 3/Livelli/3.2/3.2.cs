namespace Esercizi_livello_3.Esercizio3_2;

// Esercizio 3.2
// Le classi di questo esercizio vanno nella cartella "Classi" accanto a questo file,
// sempre con: namespace Esercizi_livello_3.Esercizio3_2;

public static class Esercizio
{
    public static void Esegui()
    {
        Console.WriteLine("Esercizio 3.2");

        Studente s1 = new Studente("Luca", 20, 8m);
        Studente s2 = new Studente("Anna", 19, 9.5m);

        try
        {
            Studente s3 = new Studente("Errore", 200, 7m);   // età non valida
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Errore: " + ex.Message);
        }

        Studente s4 = new Studente("Marco", 22, 7m);

        Console.WriteLine(s1.Matricola + " " + s1.Nome);   // S0001 Luca
        Console.WriteLine(s2.Matricola + " " + s2.Nome);   // S0002 Anna
        Console.WriteLine(s4.Matricola + " " + s4.Nome);   // S0003 Marco (non S0004)
        Console.WriteLine("Studenti creati: " + Studente.NumeroStudenti);   // 3
    }
}
