while (true)
{
    Console.WriteLine();
    Console.WriteLine("=== Esercizi livello 3 ===");
    Console.WriteLine("1) Esercizio 3.1");
    Console.WriteLine("2) Esercizio 3.2");
    Console.WriteLine("3) Esercizio 3.3");
    Console.WriteLine("4) Esercizio 3.4");
    Console.WriteLine("0) Esci");
    Console.Write("Scegli un esercizio: ");

    switch (Console.ReadLine())
    {
        case "1": Esercizi_livello_3.Esercizio3_1.Esercizio.Esegui(); break;
        case "2": Esercizi_livello_3.Esercizio3_2.Esercizio.Esegui(); break;
        case "3": Esercizi_livello_3.Esercizio3_3.Esercizio.Esegui(); break;
        case "4": Esercizi_livello_3.Esercizio3_4.Esercizio.Esegui(); break;
        case "0": return;
        default: Console.WriteLine("Scelta non valida."); break;
    }
}
