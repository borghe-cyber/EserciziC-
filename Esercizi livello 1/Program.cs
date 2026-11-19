using Esercizi_livello_1.Esercizi;

while (true)
{
    Console.WriteLine();
    Console.WriteLine("=== Esercizi livello 1 ===");
    Console.WriteLine("1) Esercizio 1.1");
    Console.WriteLine("2) Esercizio 1.2");
    Console.WriteLine("3) Esercizio 1.3");
    Console.WriteLine("4) Esercizio 1.4");
    Console.WriteLine("5) Esercizio 1.5");
    Console.WriteLine("0) Esci");
    Console.Write("Scegli un esercizio: ");

    switch (Console.ReadLine())
    {
        case "1": Esercizio1_1.Esegui(); break;
        case "2": Esercizio1_2.Esegui(); break;
        case "3": Esercizio1_3.Esegui(); break;
        case "4": Esercizio1_4.Esegui(); break;
        case "5": Esercizio1_5.Esegui(); break;
        case "0": return;
        default: Console.WriteLine("Scelta non valida."); break;
    }
}
