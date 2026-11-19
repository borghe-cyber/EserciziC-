namespace Esercizi_livello_5.Esercizio5_3;

// Metodo di pagamento con carta di credito.
// Ha un plafond (credito disponibile) che diminuisce a ogni pagamento.
public class CartaDiCredito : IMetodoPagamento
{
    private string titolare;
    private decimal plafond;

    public CartaDiCredito(string titolare, decimal plafond)
    {
        this.titolare = titolare;
        this.plafond = plafond;
    }

    // Proprietà richiesta dall'interfaccia
    public string Nome => "Carta di credito";

    // Metodo richiesto dall'interfaccia
    public bool Paga(decimal importo)
    {
        if (importo <= 0)
        {
            Console.WriteLine("Importo non valido.");
            return false;
        }

        if (importo > plafond)
        {
            Console.WriteLine($"Pagamento di {importo} € rifiutato: plafond insufficiente ({plafond} €).");
            return false;
        }

        plafond -= importo;
        Console.WriteLine($"{titolare} ha pagato {importo} € con {Nome}. Plafond residuo: {plafond} €.");
        return true;
    }
}
