namespace Esercizi_livello_4.Esercizio4_4;

//ProdottoFresco è l’ultimo livello: un prodotto alimentare che va conservato al freddo. 
//È la classe più corta delle tre, perché quasi tutto il lavoro lo fanno già i padri.
//Ereditarietà
//Eredita da ProdottoAlimentare (non direttamente da Prodotto). 
//Così riceve codice, nome, prezzo e scadenza, con tutte le loro validazioni.
//Un dato in più
//Una proprietà TemperaturaMax di tipo double, con la regola: deve essere tra -25 e 8 °C, estremi inclusi.
//Indizio: ti servono due confronti nello stesso if. 
//Pensa a quale operatore usare: vuoi lanciare l’eccezione se la temperatura è troppo bassa oppure troppo alta.

/// Prodotto alimentare da conservare al freddo.
/// Eredita codice, nome, prezzo e scadenza da ProdottoAlimentare
/// Aggiunge la temperatura massima di conservazione.
/// La scadenza è fissa: sempre oggi + 5 giorni.

public class ProdottoFresco : ProdottoAlimentare
{
    private double temperaturaMax;

    public double TemperaturaMax
    {
        get { return temperaturaMax; }
        private set
        {
            // Valida solo tra -25 e 8 °C, estremi inclusi
            if (value < -25 || value > 8)
            {
                throw new ArgumentOutOfRangeException(nameof(TemperaturaMax),
                    "La temperatura massima deve essere tra -25 e 8 °C.");
            }
            temperaturaMax = value;
        }
    }

    // Unico costruttore: 4 parametri
    public ProdottoFresco(string codice, string nome, decimal prezzo, double temperaturaMax)
        : base(codice, nome, prezzo, DateTime.Today.AddDays(5))   // scadenza calcolata qui
    {
        this.TemperaturaMax = temperaturaMax;
        Console.WriteLine("[ProdottoFresco] costruttore eseguito");
    }
}
