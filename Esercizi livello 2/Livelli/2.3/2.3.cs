namespace Esercizi_livello_2.Esercizio2_3;

// Esercizio 2.3
// Le classi di questo esercizio vanno nella cartella "Classi" accanto a questo file,
// sempre con: namespace Esercizi_livello_2.Esercizio2_3;

public static class Esercizio
{
    public static void Esegui()
    {
        // due contatori separati e indipendenti
        Contatore conta1 = new Contatore(0);    
        Contatore conta2 = new Contatore(0);   

        conta1.Incrementa();      
        conta1.Incrementa();
        conta2.Decrementa();     

        Console.WriteLine("conta1: " + conta1.Valore());
        Console.WriteLine("conta2: " + conta2.Valore());

        conta1.Reset();
        conta1.Decrementa();
        Console.WriteLine("conta1 dopo Reset e Decrementa: " + conta1.Valore());
        Console.WriteLine("conta2 non è cambiato: " + conta2.Valore());
    }
}
