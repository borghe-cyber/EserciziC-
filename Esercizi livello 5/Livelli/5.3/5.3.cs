namespace Esercizi_livello_5.Esercizio5_3;

// Esercizio 5.3
// Le classi di questo esercizio vanno nella cartella "Classi" accanto a questo file,
// sempre con: namespace Esercizi_livello_5.Esercizio5_3;

public static class Esercizio
{
    public static void Esegui()
    {
      

        List<IMetodoPagamento> metodi = new List<IMetodoPagamento>
        {
            new CartaDiCredito("Mario Rossi", 500),
            new PayPal("mario@email.it", 200),
            new Bonifico("IT60X0542811101000000123456", 300)
        };

       
        Console.WriteLine("\n--- Pagamento da 150 € ---");
        foreach (IMetodoPagamento metodo in metodi)
        {
            metodo.Paga(150);
        }

        
        Console.WriteLine("\n--- Pagamento da 200 € ---");
        foreach (IMetodoPagamento metodo in metodi)
        {
            bool esito = metodo.Paga(200);
            Console.WriteLine($"  -> {metodo.Nome}: {(esito ? "OK" : "FALLITO")}");
        }

        Console.WriteLine("\n--- Dati non validi ---");
        IMetodoPagamento paypalSbagliato = new PayPal("email-senza-chiocciola", 100);
        paypalSbagliato.Paga(10);

        IMetodoPagamento bonificoSbagliato = new Bonifico("DE123", 100);
        bonificoSbagliato.Paga(10);

        IMetodoPagamento carta = new CartaDiCredito("Luca Bianchi", 100);
        carta.Paga(-5);
    }
}
