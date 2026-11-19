public class Biblioteca
{
    private readonly Dictionary<string, Libro> _libri = new Dictionary<string, Libro>();

    public IReadOnlyCollection<Libro> Libri => _libri.Values;

    public bool Aggiungi(Libro libro)
    {
        return _libri.TryAdd(libro.ISBN, libro);
    }

    public bool Rimuovi(string isbn)
    {
        return _libri.Remove(isbn);
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

    public bool Presta(string isbn)
    {
        if (_libri.TryGetValue(isbn, out Libro? libro) && libro.Disponibile)
        {
            libro.Disponibile = false;
            return true;
        }
        return false;
    }

    public bool Restituisci(string isbn)
    {
        if (_libri.TryGetValue(isbn, out Libro? libro) && !libro.Disponibile)
        {
            libro.Disponibile = true;
            return true;
        }
        return false;
    }
}
