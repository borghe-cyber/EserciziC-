namespace Esercizi_livello_5.Esercizio5_3;

// Metodo di pagamento con bonifico bancario.
// Il conto è identificato da un IBAN e ha un saldo.
// Ogni bonifico costa una commissione fissa, che si aggiunge all'importo.
public class Bonifico : IMetodoPagamento
{
    private const decimal Commissione = 1.50m;

    private string iban;
    private decimal saldo;

    public Bonifico(string iban, decimal saldo)
    {
        this.iban = iban;
        this.saldo = saldo;
    }

    // Proprietà richiesta dall'interfaccia
    public string Nome => "Bonifico";

    // Metodo richiesto dall'interfaccia
    public bool Paga(decimal importo)
    {
        // Un IBAN italiano inizia con "IT" ed è lungo 27 caratteri
        if (!iban.StartsWith("IT") || iban.Length != 27)
        {
            Console.WriteLine($"Bonifico rifiutato: IBAN \"{iban}\" non valido.");
            return false;
        }

        if (importo <= 0)
        {
            Console.WriteLine("Importo non valido.");
            return false;
        }

        decimal totale = importo + Commissione;

        if (totale > saldo)
        {
            Console.WriteLine($"Bonifico di {importo} € (+ {Commissione} € di commissione) rifiutato: saldo insufficiente ({saldo} €).");
            return false;
        }

        saldo -= totale;
        Console.WriteLine($"Bonifico di {importo} € effettuato (commissione {Commissione} €). Saldo residuo: {saldo} €.");
        return true;
    }
}
