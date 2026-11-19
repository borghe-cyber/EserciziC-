// namespace Esercizi_livello_4.Esercizio4_4.Soluzioni;

// // Livello 2: un Prodotto che in più ha una data di scadenza.
// public class ProdottoAlimentare : Prodotto
// {
//     public const decimal ScontoInScadenza = 0.30m;   // -30% se mancano 2 giorni o meno

//     public DateOnly DataScadenza { get; private set; }

//     public ProdottoAlimentare(string codice, string nome, decimal prezzo, DateOnly dataScadenza)
//         : base(codice, nome, prezzo)   // prima costruisce la parte "Prodotto"
//     {
//         this.DataScadenza = dataScadenza;
//     }

//     // proprietà calcolata: quanti giorni mancano alla scadenza (negativo = già scaduto)
//     public int GiorniAllaScadenza
//     {
//         get { return DataScadenza.DayNumber - DateOnly.FromDateTime(DateTime.Today).DayNumber; }
//     }

//     public bool Scaduto
//     {
//         get { return GiorniAllaScadenza < 0; }
//     }

//     public override decimal PrezzoFinale()
//     {
//         decimal prezzo = base.PrezzoFinale();   // parte dal prezzo calcolato da Prodotto
//         if (!Scaduto && GiorniAllaScadenza <= 2)
//         {
//             prezzo = prezzo - prezzo * ScontoInScadenza;
//         }
//         return prezzo;
//     }

//     public override string Descrizione()
//     {
//         string stato = Scaduto ? "SCADUTO" : $"scade tra {GiorniAllaScadenza} giorni";
//         // base.Descrizione() = la riga di Prodotto, qui aggiungo solo la parte nuova
//         return $"{base.Descrizione()} | Scadenza: {DataScadenza:dd/MM/yyyy} ({stato})";
//     }
// }
