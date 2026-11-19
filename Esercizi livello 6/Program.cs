while (true)
{
    Console.WriteLine();
    Console.WriteLine("=== Esercizi livello 6 ===");
    Console.WriteLine("1) Esercizio 6.1");
    Console.WriteLine("2) Esercizio 6.2");
    Console.WriteLine("3) Esercizio 6.3");
    Console.WriteLine("4) Esercizio 6.4");
    Console.WriteLine("0) Esci");
    Console.Write("Scegli un esercizio: ");

    switch (Console.ReadLine())
    {
        case "1": Esercizi_livello_6.Esercizio6_1.Esercizio.Esegui(); break;
        case "2": Esercizi_livello_6.Esercizio6_2.Esercizio.Esegui(); break;
        case "3": Esercizi_livello_6.Esercizio6_3.Esercizio.Esegui(); break;
        case "4": Esercizi_livello_6.Esercizio6_4.Esercizio.Esegui(); break;
        case "0": return;
        default: Console.WriteLine("Scelta non valida."); break;
    }
}
