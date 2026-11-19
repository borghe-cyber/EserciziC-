namespace Esercizi_livello_5.Esercizio5_3;

// Metodo di pagamento con PayPal.
// L'account è identificato da un'email e ha un saldo che diminuisce a ogni pagamento.
public class PayPal : IMetodoPagamento
{
    private string email;
    private decimal saldo;

    public PayPal(string email, decimal saldo)
    {
        this.email = email;
        this.saldo = saldo;
    }

    // Proprietà richiesta dall'interfaccia
    public string Nome => "PayPal";

    // Metodo richiesto dall'interfaccia
    public bool Paga(decimal importo)
    {
        if (!email.Contains('@'))
        {
            Console.WriteLine($"Pagamento rifiutato: email \"{email}\" non valida.");
            return false;
        }

        if (importo <= 0)
        {
            Console.WriteLine("Importo non valido.");
            return false;
        }

        if (importo > saldo)
        {
            Console.WriteLine($"Pagamento di {importo} € rifiutato: saldo PayPal insufficiente ({saldo} €).");
            return false;
        }

        saldo -= importo;
        Console.WriteLine($"Pagamento di {importo} € effettuato con {Nome} ({email}). Saldo residuo: {saldo} €.");
        return true;
    }
}
