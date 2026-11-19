namespace Esercizi_livello_5.Esercizio5_3;

// Interfaccia comune a tutti i metodi di pagamento
// (es. CartaDiCredito, PayPal, Bonifico...)
public interface IMetodoPagamento
{
    // Nome del metodo di pagamento (es. "Carta di credito")
    string Nome { get; }

    // Esegue il pagamento dell'importo indicato.
    // Restituisce true se il pagamento è andato a buon fine.
    bool Paga(decimal importo);
}
