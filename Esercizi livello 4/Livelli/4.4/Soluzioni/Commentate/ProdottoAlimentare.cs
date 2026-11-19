// =====================================================================
// COPIA COMMENTATA di Classi/ProdottoAlimentare.cs
// =====================================================================
// Namespace diverso da Classi e da Soluzioni: altrimenti ci sarebbero due classi
// ProdottoAlimentare nello stesso namespace e il progetto non compilerebbe.
namespace Esercizi_livello_4.Esercizio4_4.Soluzioni.Commentate;

// EREDITARIETÀ: ProdottoAlimentare "è un" Prodotto.
// Eredita Codice, Nome, Prezzo e Stampa() senza riscriverli.
//
// Il nome completo Esercizi_livello_4.Esercizio4_4.Prodotto serve solo in questa copia:
// scrivendo solo "Prodotto", C# prenderebbe quello della cartella Soluzioni (più vicino).
// Nel file vero in Classi basta scrivere ": Prodotto".
public class ProdottoAlimentare : Esercizi_livello_4.Esercizio4_4.Prodotto
{
    // ---------------------------------------------------------------------
    // CAMPO PRIVATO
    // ---------------------------------------------------------------------
    // Qui sta davvero il valore della data (come codice e nome in Prodotto).
    // La proprietà non può salvare il valore in se stessa: scrivere
    // "DataScadenza = value" dentro il suo set chiamerebbe il set all'infinito.
    //
    // DateTime è un TIPO VALORE: non può essere null, quindi non serve
    // inizializzarlo come le stringhe (private string nome = "").
    private DateTime dataScadenza;

    // ---------------------------------------------------------------------
    // PROPRIETÀ CON IL CONTROLLO NEL SET
    // ---------------------------------------------------------------------
    // Il controllo sulla data sta qui e non nel costruttore.
    // Così vale SEMPRE: in tutti i costruttori e in qualunque metodo futuro
    // che cambi la data. Non esiste un modo per saltarlo (da fuori della classe).
    //
    // get pubblico  → tutti possono leggere la data
    // private set   → solo questa classe può scriverla, e passa dal controllo
    public DateTime DataScadenza
    {
        get { return dataScadenza; }   // restituisce il CAMPO (minuscolo), non la proprietà
        private set
        {
            // value = il valore che stanno cercando di assegnare.
            //
            // DateTime.Today e non DateTime.Now:
            // Now contiene anche l'ora. Un prodotto che scade oggi (oggi alle 00:00)
            // risulterebbe "nel passato" rispetto, per esempio, a oggi alle 15:00.
            // Today = oggi a mezzanotte: un prodotto che scade oggi è ancora valido.
            if (value < DateTime.Today)
            {
                // ArgumentException: il valore passato non è valido.
                // nameof(DataScadenza) scrive "DataScadenza" come testo:
                // se rinomini la proprietà, si aggiorna da solo.
                throw new ArgumentException("La data di scadenza non può essere nel passato.", nameof(DataScadenza));
            }
            dataScadenza = value;   // il valore è valido: lo salvo nel campo
        }
    }

    // ---------------------------------------------------------------------
    // COSTRUTTORE LUNGO (quello "principale")
    // ---------------------------------------------------------------------
    // : base(codice, nome, prezzo) chiama il costruttore del PADRE (Prodotto).
    // È obbligatorio: Prodotto non ha un costruttore senza parametri.
    // Viene eseguito PRIMA del corpo di questo costruttore.
    public ProdottoAlimentare(string codice, string nome, decimal prezzo, DateTime dataScadenza)
        : base(codice, nome, prezzo)
    {
        // Qui prima c'era l'if sulla data, ora resta solo l'assegnazione.
        // this.DataScadenza (maiuscolo) = la PROPRIETÀ → passa dal set → controllo.
        // dataScadenza (minuscolo, a destra) = il PARAMETRO del costruttore.
        this.DataScadenza = dataScadenza;

        // Riga a console, come in Prodotto.
        // Va DOPO l'assegnazione, così la data è già impostata e controllata.
        // Viene stampata DOPO la riga di Prodotto, perché : base(...) viene eseguito prima.
        // Grazie a : this(...), vale anche per il costruttore corto.
        Console.WriteLine($"Scadenza: {DataScadenza:dd/MM/yyyy}");
    }

    // ---------------------------------------------------------------------
    // COSTRUTTORE CORTO (serve per p2 nel Main)
    // ---------------------------------------------------------------------
    // - I costruttori NON si ereditano: il costruttore corto di Prodotto non vale qui,
    //   ProdottoAlimentare deve avere il suo.
    // - Delega con : this(...) al costruttore lungo qui sopra, passando i valori di default:
    //   prezzo 1.00m e scadenza tra 30 giorni (DateTime.Today.AddDays(30)).
    //   : this(...) è come : base(...), ma chiama un costruttore della STESSA classe.
    // - AddDays non modifica Today, restituisce una NUOVA data.
    //
    // Ordine di esecuzione con new ProdottoAlimentare("PRD002", "Pasta"):
    //   1. : this(...)  → costruttore lungo di ProdottoAlimentare
    //   2. : base(...)  → costruttore di Prodotto (controlli su codice, nome, prezzo + Stampa)
    //   3. corpo del costruttore lungo → DataScadenza passa dal set (controllo data) + stampa scadenza
    //   4. corpo di questo costruttore → vuoto
    //
    // Vantaggio:
    //   - chi crea un prodotto "standard" scrive solo codice e nome;
    //   - i valori di default stanno in un punto solo (se cambiano, si modifica solo questa riga);
    //   - tutti i controlli vengono comunque eseguiti, perché si passa dal costruttore lungo.
    public ProdottoAlimentare(string codice, string nome)
        : this(codice, nome, 1.00m, DateTime.Today.AddDays(30))
    {
        // corpo vuoto: tutto il lavoro lo fa il costruttore lungo
    }
}
