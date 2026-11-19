namespace Esercizi_livello_5.Esercizio5_2;

// Esercizio sulle interfacce e il polimorfismo

public static class Esercizio
{
    public static void Esegui()
    {
        Console.WriteLine("Esercizio 5.2");
        // Scrivi qui il codice dell'esercizio 5.2

        object[] animali = [new Anatra(), new Pinguino(), new Aquila()];

        foreach (var animale in animali)
        {
            Console.WriteLine($"\n--- {animale.GetType().Name} ---");

            if (animale is IVolante volante)
                volante.Vola();
            if (animale is INuotatore nuotatore)
                nuotatore.Nuota();
            if (animale is ICamminatore camminatore)
                camminatore.Cammina();
        }
    }
}
