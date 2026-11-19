namespace Esercizi_livello_4.Esercizio4_4;

public class ProdottoAlimentare : Prodotto
{
    private DateTime dataScadenza;

    public DateTime DataScadenza
    {
        get { return dataScadenza; }
        private set
        {
            if (value < DateTime.Today)
            {
                throw new ArgumentException("La data di scadenza non può essere nel passato.", nameof(DataScadenza));
            }
            dataScadenza = value;
        }
    }

    public ProdottoAlimentare(string codice, string nome, decimal prezzo, DateTime dataScadenza)
        : base(codice, nome, prezzo)
    {
        this.DataScadenza = dataScadenza;

        Console.WriteLine($"Scadenza: {DataScadenza:dd/MM/yyyy}");
    }

    public ProdottoAlimentare(string codice, string nome)
        : this(codice, nome, 1.00m, DateTime.Today.AddDays(30))
    {
    }
}
