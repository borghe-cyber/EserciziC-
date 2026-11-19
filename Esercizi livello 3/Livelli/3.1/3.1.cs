namespace Esercizi_livello_3.Esercizio3_1;

// Conto bancario
// Crea una classe ContoBancario con titolare, IBAN e saldo.
// Il saldo è una proprietà con get pubblico e private set: si modifica solo con Deposita(decimal importo) e Preleva(decimal importo).
// Importi negativi o prelievi superiori al saldo devono lanciare un'eccezione (ArgumentException / InvalidOperationException).
// Usa decimal, non double, per i soldi. Domanda: perché?

public static class Esercizio
{
    public static void Esegui()
    {
        Console.WriteLine("Esercizio 3.1");
        ContoBancario conto1 = new ContoBancario(8.50m); // il suffisso m serve per far nascere come m ; 

        conto1.Deposita(1.50m);
        conto1.Preleva(5.00m);
    }
}
