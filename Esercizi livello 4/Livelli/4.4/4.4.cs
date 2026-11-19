namespace Esercizi_livello_4.Esercizio4_4;

// Esercizio 4.4
// Le classi di questo esercizio vanno nella cartella "Classi" accanto a questo file,
// sempre con: namespace Esercizi_livello_4.Esercizio4_4;

public static class Esercizio
{
    public static void Esegui()
    {
        Prodotto p1 = new Prodotto("ABC123", "Prodotto 1", 10.50m);
        Prodotto p2 = new Prodotto("XYZ789", "Prodotto 2");
        Prodotto p3 = new Prodotto("12345", "Prodotto 3", -5.00m); // esempio di eccezione per prezzo negativo
        Prodotto p4 = new Prodotto("1234567", "Prodotto 4", 15.00m); // esempio di eccezione per codice troppo lungo
        Prodotto p5 = new Prodotto("123456", "", 20.00m); // esempio di eccezione per nome vuoto
       
        ProdottoFresco pf1 = new ProdottoFresco("PF1", "Prodotto Fresco 1", 5.00m, 5.0);
        ProdottoFresco pf2 = new ProdottoFresco("PF2", "Prodotto Fresco 2", 7.50m, -30.0); // esempio di eccezione per temperatura troppo bassa
        ProdottoFresco pf3 = new ProdottoFresco("PF3", "Prodotto Fresco 3", 6.00m, 10.0); // esempio di eccezione per temperatura troppo alta

        ProdottoAlimentare pa1 = new ProdottoAlimentare("PA1", "Prodotto Alimentare 1", 3.00m, DateTime.Today.AddDays(10));
        ProdottoAlimentare pa2 = new ProdottoAlimentare("PA2", "Prodotto Alimentare 2", 4.50m, DateTime.Today.AddDays(-5));
        ProdottoAlimentare pa3 = new ProdottoAlimentare("PA3", "Prodotto Alimentare 3", 2.50m, DateTime.Today.AddDays(15));

    }
}
