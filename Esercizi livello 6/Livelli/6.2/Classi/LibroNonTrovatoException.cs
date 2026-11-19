namespace Esercizi_livello_6.Esercizio6_2;

public class LibroNonTrovatoException : BibliotecaException
{
    public string ISBN { get; }

    public LibroNonTrovatoException(string isbn)
        : base($"Nessun libro trovato con ISBN {isbn}")
    {
        ISBN = isbn;
    }
}
