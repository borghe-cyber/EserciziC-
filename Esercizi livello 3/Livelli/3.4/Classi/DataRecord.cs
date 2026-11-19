namespace Esercizi_livello_3.Esercizio3_4;

// Stessa idea di Data, ma come RECORD.
// Il compilatore genera da solo:
// - Equals, GetHashCode, == e != che confrontano i VALORI (non l'indirizzo)
// - ToString che stampa nome e proprietà: DataRecord { Giorno = 29, Mese = 2, Anno = 2024 }
// - il supporto a "with" per creare una copia con qualche valore cambiato
public record DataRecord
{
    // init: si può assegnare solo durante la creazione (costruttore o with), poi non cambia più
    public int Giorno { get; init; }
    public int Mese { get; init; }
    public int Anno { get; init; }

    public DataRecord(int giorno, int mese, int anno)
    {
        Data.Controlla(giorno, mese, anno);   // riuso gli stessi controlli della classe
        Giorno = giorno;
        Mese = mese;
        Anno = anno;
    }

    public DataRecord AggiungiGiorni(int n)
    {
        // riuso il calcolo di Data per non riscriverlo
        Data nuova = new Data(Giorno, Mese, Anno).AggiungiGiorni(n);
        return new DataRecord(nuova.Giorno, nuova.Mese, nuova.Anno);
    }
}
