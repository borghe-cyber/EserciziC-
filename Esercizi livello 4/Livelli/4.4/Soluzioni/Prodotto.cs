// namespace Esercizi_livello_4.Esercizio4_4.Soluzioni;

// // Livello 1 della gerarchia: la classe base.
// // Contiene quello che hanno TUTTI i prodotti.
// public class Prodotto
// {
//     public string Codice { get; private set; }
//     public string Nome { get; private set; }
//     public decimal Prezzo { get; private set; }

//     public Prodotto(string codice, string nome, decimal prezzo)
//     {
//         if (prezzo < 0)
//         {
//             throw new ArgumentOutOfRangeException(nameof(prezzo), "Il prezzo non può essere negativo.");
//         }
//         this.Codice = codice;
//         this.Nome = nome;
//         this.Prezzo = prezzo;
//     }

//     // virtual: le classi figlie possono cambiare il modo di calcolare il prezzo
//     public virtual decimal PrezzoFinale()
//     {
//         return Prezzo;
//     }

//     public virtual string Descrizione()
//     {
//         return $"[{Codice}] {Nome} - Prezzo: {Prezzo:0.00} € → Finale: {PrezzoFinale():0.00} €";
//     }

//     public override string ToString()
//     {
//         return Descrizione();
//     }
// }
