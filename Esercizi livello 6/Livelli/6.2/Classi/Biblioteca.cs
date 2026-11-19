namespace Esercizi_livello_6.Esercizio6_2;




public class Biblioteca
{
    private readonly Dictionary<string, Libro> _libri = new Dictionary<string, Libro>();

    public IReadOnlyCollection<Libro> Libri => _libri.Values;

    public bool Aggiungi(Libro libro)
    {
        return _libri.TryAdd(libro.ISBN, libro);
    }

    public void Rimuovi(string isbn)
    {
        if (!_libri.Remove(isbn))
        {
            throw new LibroNonTrovatoException(isbn);
        }
    }

    public List<Libro> CercaPerAutore(string autore)
    {
        List<Libro> risultati = new List<Libro>();
        foreach (Libro libro in _libri.Values)
        {
            if (libro.Autore.Equals(autore, StringComparison.OrdinalIgnoreCase))
            {
                risultati.Add(libro);
            }
        }
        return risultati;
    }

    public void Presta(string isbn)
    {
        Libro libro = TrovaLibro(isbn);

        if (!libro.Disponibile)
        {
            throw new LibroGiaInPrestitoException(isbn, libro.Titolo);
        }

        libro.Disponibile = false;
    }

    public void Restituisci(string isbn)
    {
        Libro libro = TrovaLibro(isbn);

        if (libro.Disponibile)
        {
            throw new BibliotecaException($"Il libro \"{libro.Titolo}\" non era in prestito");
        }

        libro.Disponibile = true;
    }

    
    private Libro TrovaLibro(string isbn)
    {
        if (!_libri.TryGetValue(isbn, out Libro? libro))
        {
            throw new LibroNonTrovatoException(isbn);
        }
        return libro;
    }
}
