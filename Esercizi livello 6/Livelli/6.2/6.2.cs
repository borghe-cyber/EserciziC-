namespace Esercizi_livello_6.Esercizio6_2;



/*
public static class Esercizio
{
    public static void Esegui()
    {
        Biblioteca biblioteca = new Biblioteca();

        biblioteca.Aggiungi(new Libro("978-88-01", "Il nome della rosa", "Umberto Eco", 1980));
        biblioteca.Aggiungi(new Libro("978-88-02", "Il pendolo di Foucault", "Umberto Eco", 1988));
        biblioteca.Aggiungi(new Libro("978-88-03", "Se questo è un uomo", "Primo Levi", 1947));


        Console.WriteLine("\nPresto 978-88-01...");
        try
        {
            biblioteca.Presta("978-88-01");
            Console.WriteLine("Prestito riuscito");
        }
        catch (LibroNonTrovatoException ex)
        {
            Console.WriteLine($"[Non trovato] {ex.Message}");
        }
        catch (LibroGiaInPrestitoException ex)
        {
            Console.WriteLine($"[Già in prestito] {ex.Message}");
        }
        catch (BibliotecaException ex)
        {
            Console.WriteLine($"[Errore biblioteca] {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[Errore imprevisto] {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Operazione terminata");
        }

        Console.WriteLine("\nPresto di nuovo 978-88-01...");
        try
        {
            biblioteca.Presta("978-88-01");
            Console.WriteLine("Prestito riuscito");
        }
        catch (LibroNonTrovatoException ex)
        {
            Console.WriteLine($"[Non trovato] {ex.Message}");
        }
        catch (LibroGiaInPrestitoException ex)
        {
            Console.WriteLine($"[Già in prestito] {ex.Message}");
        }
        catch (BibliotecaException ex)
        {
            Console.WriteLine($"[Errore biblioteca] {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[Errore imprevisto] {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Operazione terminata");
        }

   
        Console.WriteLine("\nPresto 999-99-99...");
        try
        {
            biblioteca.Presta("999-99-99");
            Console.WriteLine("Prestito riuscito");
        }
        catch (LibroNonTrovatoException ex)
        {
            Console.WriteLine($"[Non trovato] {ex.Message}");
        }
        catch (LibroGiaInPrestitoException ex)
        {
            Console.WriteLine($"[Già in prestito] {ex.Message}");
        }
        catch (BibliotecaException ex)
        {
            Console.WriteLine($"[Errore biblioteca] {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[Errore imprevisto] {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Operazione terminata");
        }

        
        Console.WriteLine("\nRestituisco 978-88-02...");
        try
        {
            biblioteca.Restituisci("978-88-02");
            Console.WriteLine("Restituzione riuscita");
        }
        catch (LibroNonTrovatoException ex)
        {
            Console.WriteLine($"[Non trovato] {ex.Message}");
        }
        catch (LibroGiaInPrestitoException ex)
        {
            Console.WriteLine($"[Già in prestito] {ex.Message}");
        }
        catch (BibliotecaException ex)
        {
            Console.WriteLine($"[Errore biblioteca] {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[Errore imprevisto] {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Operazione terminata");
        }

        Console.WriteLine("\nCatalogo:");
        foreach (Libro l in biblioteca.Libri)
            Console.WriteLine($"  [{l.ISBN}] {l.Titolo} - {l.Autore} - {(l.Disponibile ? "disponibile" : "in prestito")}");
    }
}
*/

//VERSIONE OTTIMIZZATA
public static class Esercizio
{
    public static void Esegui()
    {
        Biblioteca biblioteca = new Biblioteca();

        biblioteca.Aggiungi(new Libro("978-88-01", "Il nome della rosa", "Umberto Eco", 1980));
        biblioteca.Aggiungi(new Libro("978-88-02", "Il pendolo di Foucault", "Umberto Eco", 1988));
        biblioteca.Aggiungi(new Libro("978-88-03", "Se questo è un uomo", "Primo Levi", 1947));

        // Ogni riga equivale a uno dei vecchi blocchi try/catch/finally
        Prova("Presto 978-88-01...",          () => biblioteca.Presta("978-88-01"),      "Prestito riuscito");
        Prova("Presto di nuovo 978-88-01...", () => biblioteca.Presta("978-88-01"),      "Prestito riuscito");
        Prova("Presto 999-99-99...",          () => biblioteca.Presta("999-99-99"),      "Prestito riuscito");
        Prova("Restituisco 978-88-02...",     () => biblioteca.Restituisci("978-88-02"), "Restituzione riuscita");

        Console.WriteLine("\nCatalogo:");
        foreach (Libro l in biblioteca.Libri)
            Console.WriteLine($"  [{l.ISBN}] {l.Titolo} - {l.Autore} - {(l.Disponibile ? "disponibile" : "in prestito")}");
    }


    private static void Prova(string descrizione, Action operazione, string messaggioSuccesso)
    {
        Console.WriteLine($"\n{descrizione}");
        try
        {
            operazione();
            Console.WriteLine(messaggioSuccesso);
        }
        // Ordine importante: dalla più specifica alla più generica
        catch (LibroNonTrovatoException ex)    { Console.WriteLine($"[Non trovato] {ex.Message}"); }
        catch (LibroGiaInPrestitoException ex) { Console.WriteLine($"[Già in prestito] {ex.Message}"); }
        catch (BibliotecaException ex)         { Console.WriteLine($"[Errore biblioteca] {ex.Message}"); }
        catch (Exception ex)                   { Console.WriteLine($"[Errore imprevisto] {ex.Message}"); }
        finally
        {
            Console.WriteLine("Operazione terminata");
        }
    }
}
