namespace Esercizi_livello_4.Esercizio4_5;


public static class Esercizio
{
    public static void Esegui()
    {
        Console.WriteLine("Esercizio 4.5");
        // Scrivi qui il codice dell'esercizio 4.5

        List<Animale> animali = new List<Animale>
        {
            new Cane("Fido", "Labrador"),
            new Gatto("Micio", "Siamese"),
            new Cane("Rex", "Pastore Tedesco"),
        };

        foreach (Animale animale in animali)
        {
            animale.Presentati();
            animale.FaiVerso(); 
            Console.WriteLine();
        }

        
        IVerso verso = new Gatto("Luna", "Persiano");
        verso.FaiVerso();
    }
}
