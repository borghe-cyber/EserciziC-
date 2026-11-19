namespace Esercizi_livello_5.Esercizio5_4;

// Devi scrivere il software che gestisce i dispositivi di una casa intelligente.
// Il nucleo dell’esercizio è il polimorfismo: la classe Casa non conosce le singole classi concrete 
// (lampada, termostato...) e lavora solo tramite interfacce.

public static class Esercizio
{
    public static void Esegui()
    {
        var l = new Lampada("Lampada Salotto");
        Console.WriteLine(l.Stato());          // Lampada Salotto: SPENTA

        l.Accendi();                           // Lampada Salotto acceso.
        l.Regola(70);
        Console.WriteLine(l.Stato());          // Lampada Salotto: ACCESA, luminosità 70%
        Console.WriteLine(l.ConsumoWatt());    // 42

        l.Regola(500);                         // Valore non valido per Lampada Salotto: ...
    }
}
