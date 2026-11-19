namespace Esercizi_livello_4.Esercizio4_4;

public class Prodotto
{
    private string codice = "";   // campo privato: qui sta davvero il valore del codice

    public string Codice
    {
         get{return codice;}   // restituisce il CAMPO 
         private set
        {
            //codice prodotto deve essere lungo esattamente 6 caratteri
            // prima il controllo su null: con || se è vero non viene letto value.Length
            if (value == null || value.Length != 6)
            {
                throw new ArgumentException("Il codice prodotto deve essere lungo esattamente 6 caratteri.", nameof(Codice));
            }
            codice = value;   // salva il valore nel campo
        }
    }
    private string nome = "";   // campo privato: qui sta davvero il valore del nome

    public string Nome
    {
        get { return nome; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Il nome non può essere vuoto.", nameof(Nome));
            }
            nome = value;
        }
    }
    public decimal Prezzo { get; private set; }

    public Prodotto(string codice, string nome, decimal prezzo)
    {
        if (prezzo < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(prezzo), "Il prezzo non può essere negativo.");
        }
        if (prezzo == 0)
        {
            throw new ArgumentOutOfRangeException(nameof(prezzo), "Il prezzo non può essere zero.");
        }
        this.Codice = codice;
        this.Nome = nome;
        this.Prezzo = prezzo;

        Stampa();   // requisito 1: riga a console (vale anche per il secondo costruttore, grazie a : this)
    }
    // delega al primo costruttore, con prezzo 1.00m (spiegazione in Testo.cs)
    public Prodotto(string codice, string nome) : this(codice, nome, 1.00m)
    {
    }
    public void Stampa()
    {
        Console.WriteLine($"Codice: {Codice}, Nome: {Nome}, Prezzo: {Prezzo:C}");
    }
}

