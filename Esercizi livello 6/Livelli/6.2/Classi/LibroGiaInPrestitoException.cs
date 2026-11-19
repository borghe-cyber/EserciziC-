namespace Esercizi_livello_6.Esercizio6_2;

public class LibroGiaInPrestitoException : BibliotecaException
{
    public string ISBN { get; }

    public LibroGiaInPrestitoException(string isbn, string titolo)
        : base($"Il libro \"{titolo}\" (ISBN {isbn}) è già in prestito")
    {
        ISBN = isbn;
    }
}
