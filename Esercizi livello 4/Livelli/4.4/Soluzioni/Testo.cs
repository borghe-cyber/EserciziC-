namespace Esercizi_livello_4.Esercizio4_4;

// Classe di soli appunti: non contiene codice eseguibile, solo commenti.
public static class Testo
{
    // =====================================================================
    // LA MIA VERSIONE ORIGINALE DEI COSTRUTTORI DI Prodotto
    // =====================================================================
    //
    // public Prodotto(string codice, string nome, decimal prezzo)
    // {
    //     if (prezzo < 0)
    //     {
    //         throw new ArgumentOutOfRangeException(nameof(prezzo), "Il prezzo non può essere negativo.");
    //     }
    //     if (prezzo == 0)
    //     {
    //         throw new ArgumentOutOfRangeException(nameof(prezzo), "Il prezzo non può essere zero.");
    //     }
    //     this.Codice = codice;
    //     this.Nome = nome;
    //     this.Prezzo = prezzo;
    // }
    //
    // public Prodotto(string codice, string nome)
    // {
    //     this.Codice = codice;
    //     this.Nome = nome;
    //     this.Prezzo = 1.00m;
    //
    //     Console.WriteLine($"Codice: {Codice}, Nome: {Nome}, Prezzo: {Prezzo:C}");
    // }
    //
    // public void Stampa()
    // {
    //     Console.WriteLine($"Codice: {Codice}, Nome: {Nome}, Prezzo: {Prezzo:C}");
    // }
    //
    // =====================================================================
    // IL PROBLEMA
    // =====================================================================
    //
    // I due costruttori fanno quasi la stessa cosa, ma ognuno per conto suo:
    // - le assegnazioni (Codice, Nome, Prezzo) sono scritte DUE volte;
    // - il secondo costruttore SALTA i controlli sul prezzo, perché gli if
    //   stanno solo nel primo.
    //
    // =====================================================================
    // LA CORREZIONE: : this(...)
    // =====================================================================
    //
    // public Prodotto(string codice, string nome) : this(codice, nome, 1.00m)
    // {
    // }
    //
    // : this(...) è come : base(...), ma invece di chiamare il costruttore
    // del PADRE chiama un altro costruttore della STESSA classe.
    // Il secondo costruttore "delega" al primo, passandogli 1.00m come prezzo.
    //
    // Cosa succede con new Prodotto("P002", "Matita"):
    //   1. C# sceglie il secondo costruttore (2 argomenti);
    //   2. PRIMA del suo corpo segue : this(codice, nome, 1.00m)
    //      ed esegue TUTTO il primo costruttore: controlli + assegnazioni;
    //   3. poi esegue il corpo del secondo, che è vuoto { }.
    //
    // Perché conviene:
    //   - il codice è scritto UNA volta sola (nel primo costruttore);
    //   - i controlli valgono SEMPRE, anche con il costruttore corto;
    //   - c'è un solo costruttore "principale", gli altri sono scorciatoie.
    //
    // I due costruttori sono LEGATI, in una sola direzione:
    //   - il secondo dipende dal primo: senza il primo non funziona;
    //   - il primo non sa che il secondo esiste e funziona da solo;
    //   - se cambi il primo (es. aggiungi un controllo), vale anche per il secondo;
    //   - se cambi la firma del primo, il compilatore ti obbliga ad aggiornare il : this(...).
    //   - non si può fare un giro chiuso (primo → secondo → primo): il compilatore lo blocca.
    //
    // La stampa nel costruttore è stata tolta: un costruttore deve CREARE
    // l'oggetto, non stampare. Per stampare si usa un metodo apposito.
}
