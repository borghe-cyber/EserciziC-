while (true)
{
    Console.WriteLine();
    Console.WriteLine("=== Esercizi livello 4 ===");
    Console.WriteLine("1) Esercizio 4.1");
    Console.WriteLine("2) Esercizio 4.2");
    Console.WriteLine("3) Esercizio 4.3");
    Console.WriteLine("4) Esercizio 4.4");
    Console.WriteLine("5) Esercizio 4.5");
    Console.WriteLine("0) Esci");
    Console.Write("Scegli un esercizio: ");

    switch (Console.ReadLine())
    {
        case "1": Esercizi_livello_4.Esercizio4_1.Esercizio.Esegui(); break;
        case "2": Esercizi_livello_4.Esercizio4_2.Esercizio.Esegui(); break;
        case "3": Esercizi_livello_4.Esercizio4_3.Esercizio.Esegui(); break;
        case "4": Esercizi_livello_4.Esercizio4_4.Esercizio.Esegui(); break;
        case "5": Esercizi_livello_4.Esercizio4_5.Esercizio.Esegui(); break;
        case "0": return;
        default: Console.WriteLine("Scelta non valida."); break;
    }
}
