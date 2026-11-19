// namespace Esercizi_livello_4.Esercizio4_4.Soluzioni;

// // Livello 3: un ProdottoAlimentare che in più va conservato in frigo.
// // Eredita TUTTO: da ProdottoAlimentare (DataScadenza, GiorniAllaScadenza, Scaduto)
// // e, attraverso lui, da Prodotto (Codice, Nome, Prezzo).
// public class ProdottoFresco : ProdottoAlimentare
// {
//     public const decimal ScontoUltimoGiorno = 0.50m;   // -50% il giorno della scadenza

//     public double TemperaturaConservazione { get; private set; }

//     public ProdottoFresco(string codice, string nome, decimal prezzo, DateOnly dataScadenza, double temperaturaConservazione)
//         : base(codice, nome, prezzo, dataScadenza)   // passa i dati a ProdottoAlimentare, che li passa a Prodotto
//     {
//         this.TemperaturaConservazione = temperaturaConservazione;
//     }

//     public override decimal PrezzoFinale()
//     {
//         if (GiorniAllaScadenza == 0)
//         {
//             return Prezzo - Prezzo * ScontoUltimoGiorno;   // ultimo giorno: sconto più forte
//         }
//         return base.PrezzoFinale();   // negli altri casi vale la regola di ProdottoAlimentare
//     }

//     public override string Descrizione()
//     {
//         return $"{base.Descrizione()} | Conservare a {TemperaturaConservazione} °C";
//     }
// }
