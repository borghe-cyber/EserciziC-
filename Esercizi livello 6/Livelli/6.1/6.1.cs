namespace Esercizi_livello_6.Esercizio6_1;

// Crea le classi Libro (ISBN, titolo, autore, anno, disponibile) e Biblioteca, che contiene un Dictionary<string, Libro> indicizzato per ISBN.
// • Metodi: Aggiungi, Rimuovi, CercaPerAutore, Presta(isbn), Restituisci(isbn).
// • La lista interna non deve essere modificabile dall'esterno: esponi solo un IReadOnlyCollection<Libro>.

public static class Esercizio
{
    public static void Esegui()
    {
        Biblioteca biblioteca = new Biblioteca();

        biblioteca.Aggiungi(new Libro("978-88-01", "Il nome della rosa", "Umberto Eco", 1980));
        biblioteca.Aggiungi(new Libro("978-88-02", "Il pendolo di Foucault", "Umberto Eco", 1988));
        biblioteca.Aggiungi(new Libro("978-88-03", "Se questo è un uomo", "Primo Levi", 1947));

        
        Console.WriteLine($"Aggiungo ISBN duplicato: {biblioteca.Aggiungi(new Libro("978-88-01", "Doppione", "X", 2000))}");

        Console.WriteLine("\nLibri di Umberto Eco:");
        foreach (Libro l in biblioteca.CercaPerAutore("umberto eco"))
            Console.WriteLine($"  {l.Titolo} ({l.Anno})");

        Console.WriteLine($"\nPresto 978-88-01: {biblioteca.Presta("978-88-01")}");
        Console.WriteLine($"Presto di nuovo 978-88-01: {biblioteca.Presta("978-88-01")}");
        Console.WriteLine($"Restituisco 978-88-01: {biblioteca.Restituisci("978-88-01")}");
        Console.WriteLine($"Rimuovo 978-88-03: {biblioteca.Rimuovi("978-88-03")}");

        Console.WriteLine("\nCatalogo:");
        foreach (Libro l in biblioteca.Libri)
            Console.WriteLine($"  [{l.ISBN}] {l.Titolo} - {l.Autore} - {(l.Disponibile ? "disponibile" : "in prestito")}");
    }
}
