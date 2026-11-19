namespace Esercizi_livello_6.Esercizio6_4;


public static class Esercizio
{
    public static void Esegui()
    {
       
        Console.WriteLine("--- Massimo<T> ---");

        int[] numeri = { 4, 17, -3, 42, 8 };
        Console.WriteLine($"Massimo tra numeri:   {Utilita.Massimo(numeri)}");          // 42

        List<double> decimali = new List<double> { 3.14, 2.71, 9.81 };
        Console.WriteLine($"Massimo tra double:   {Utilita.Massimo(decimali)}");        // 9.81

        string[] parole = { "mela", "zucchina", "banana", "kiwi" };
        Console.WriteLine($"Massimo tra stringhe: {Utilita.Massimo(parole)}");          // zucchina (ordine alfabetico)

        List<Studente> studenti = new List<Studente>
        {
            new Studente(1, "Luca", 8m),
            new Studente(2, "Anna", 9.5m),
            new Studente(3, "Marco", 7m),
        };
        Console.WriteLine($"Studente migliore:    {Utilita.Massimo(studenti)}");        // Anna

       
        try
        {
            Utilita.Massimo(new List<int>());
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"[Errore] {ex.Message}");
        }

       
        Console.WriteLine("\n--- Repository<Studente> ---");
        Repository<Studente> repoStudenti = new Repository<Studente>();
        foreach (Studente s in studenti)
            repoStudenti.Aggiungi(s);

        StampaTutti(repoStudenti);

        Console.WriteLine($"TrovaPerId(2):  {repoStudenti.TrovaPerId(2)}");
        Console.WriteLine($"TrovaPerId(99): {repoStudenti.TrovaPerId(99)?.ToString() ?? "non trovato"}");

        
        try
        {
            repoStudenti.Aggiungi(new Studente(1, "Doppione", 6m));
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"[Errore] {ex.Message}");
        }

        Console.WriteLine($"Elimina(3):  {repoStudenti.Elimina(3)}");    // True
        Console.WriteLine($"Elimina(3):  {repoStudenti.Elimina(3)}");    // False, non c'è più
        StampaTutti(repoStudenti);

        
        Console.WriteLine("\n--- Repository<Prodotto> ---");
        Repository<Prodotto> repoProdotti = new Repository<Prodotto>();
        repoProdotti.Aggiungi(new Prodotto(10, "Tastiera", 49.90m));
        repoProdotti.Aggiungi(new Prodotto(11, "Mouse", 19.50m));
        StampaTutti(repoProdotti);

        
    }

    
    private static void StampaTutti<T>(Repository<T> repo) where T : IEntita
    {
        Console.WriteLine($"Elementi ({repo.Count}):");
        foreach (T elemento in repo.TuttiGliElementi())
            Console.WriteLine($"  {elemento}");
    }
}
