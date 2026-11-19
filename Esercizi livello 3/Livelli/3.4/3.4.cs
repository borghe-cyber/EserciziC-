namespace Esercizi_livello_3.Esercizio3_4;

// Esercizio 3.4 - Oggetti immutabili
// Crea una classe Data (giorno, mese, anno) immutabile: proprietà solo get o init,
// valori controllati nel costruttore (anni bisestili inclusi).
// Aggiungi AggiungiGiorni(int n) che restituisce una nuova Data invece di modificare quella esistente.
// ★ Riscrivi la stessa idea come record e confronta il codice:
//   cosa ti regala il compilatore (uguaglianza, ToString, with)?

public static class Esercizio
{
    public static void Esegui()
    {
        Console.WriteLine("Esercizio 3.4");

    
        Console.WriteLine();
        Console.WriteLine("--- 1) controlli e bisestili ---");
        Console.WriteLine("29/02/2024 → " + new Data(29, 2, 2024));   // 2024 bisestile
        Console.WriteLine("29/02/2000 → " + new Data(29, 2, 2000));   // 2000 bisestile (divisibile per 400)
        ProvaData(29, 2, 2023);   // 2023 non bisestile
        ProvaData(29, 2, 1900);   // 1900 non bisestile (divisibile per 100 ma non per 400)
        ProvaData(31, 4, 2024);   // aprile ha 30 giorni
        ProvaData(10, 13, 2024);  // mese 13 non esiste

        
        Console.WriteLine();
        Console.WriteLine("--- 2) AggiungiGiorni ---");
        Data oggi = new Data(28, 2, 2024);
        Data domani = oggi.AggiungiGiorni(1);
        Data dopodomani = oggi.AggiungiGiorni(2);
        Console.WriteLine(oggi + " + 1  = " + domani);       // 29/02/2024
        Console.WriteLine(oggi + " + 2  = " + dopodomani);   // 01/03/2024
        Console.WriteLine("oggi è ancora " + oggi);          // non è cambiata!
        Console.WriteLine(new Data(31, 12, 2024) + " + 1  = " + new Data(31, 12, 2024).AggiungiGiorni(1));
        Console.WriteLine(new Data(1, 3, 2023) + " - 1  = " + new Data(1, 3, 2023).AggiungiGiorni(-1));
        Console.WriteLine(new Data(1, 1, 2024) + " + 366 = " + new Data(1, 1, 2024).AggiungiGiorni(366));

        
        Console.WriteLine();
        Console.WriteLine("--- 3) classe contro record ---");

        Data c1 = new Data(15, 6, 2024);
        Data c2 = new Data(15, 6, 2024);
        DataRecord r1 = new DataRecord(15, 6, 2024);
        DataRecord r2 = new DataRecord(15, 6, 2024);

        
        Console.WriteLine("classe:  c1 == c2      → " + (c1 == c2));        // False: oggetti diversi
        Console.WriteLine("classe:  c1.Equals(c2) → " + c1.Equals(c2));     // False
        Console.WriteLine("record:  r1 == r2      → " + (r1 == r2));        // True: stessi valori
        Console.WriteLine("record:  r1.Equals(r2) → " + r1.Equals(r2));     // True

    
        Console.WriteLine("classe ToString: " + c1);   // quello scritto a mano
        Console.WriteLine("record ToString: " + r1);   // quello generato dal compilatore

    
        DataRecord r3 = r1 with { Anno = 2025 };
        Console.WriteLine("r1 with { Anno = 2025 } → " + r3);
        Console.WriteLine("r1 è ancora                → " + r1);

        
        Console.WriteLine("record + 20 giorni → " + r1.AggiungiGiorni(20));
    }

    static void ProvaData(int giorno, int mese, int anno)
    {
        try
        {
            Data d = new Data(giorno, mese, anno);
            Console.WriteLine(giorno + "/" + mese + "/" + anno + " → " + d);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(giorno + "/" + mese + "/" + anno + " → Errore: " + ex.Message);
        }
    }
}
