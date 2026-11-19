
// Crea le classi Libro (ISBN, titolo, autore, anno, disponibile) e Biblioteca, che contiene un Dictionary<string, Libro> indicizzato per ISBN.


public class Libro
{
    public string ISBN { get; set; }
    public string Titolo { get; set; }
    public string Autore { get; set; }
    public int Anno { get; set; }
    public bool Disponibile { get; set; }

    public Libro(string isbn, string titolo, string autore, int anno)
    {
        this.ISBN = isbn;
        this.Titolo = titolo;
        this.Autore = autore;
        this.Anno = anno;
        this.Disponibile = true;
    }
  
}