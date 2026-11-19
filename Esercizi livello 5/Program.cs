while (true)
{
    Console.WriteLine();
    Console.WriteLine("=== Esercizi livello 5 ===");
    Console.WriteLine("1) Esercizio 5.1");
    Console.WriteLine("2) Esercizio 5.2");
    Console.WriteLine("3) Esercizio 5.3");
    Console.WriteLine("4) Esercizio 5.4");
    Console.WriteLine("0) Esci");
    Console.Write("Scegli un esercizio: ");

    switch (Console.ReadLine())
    {
        case "1": Esercizi_livello_5.Esercizio5_1.Esercizio.Esegui(); break;
        case "2": Esercizi_livello_5.Esercizio5_2.Esercizio.Esegui(); break;
        case "3": Esercizi_livello_5.Esercizio5_3.Esercizio.Esegui(); break;
        case "4": Esercizi_livello_5.Esercizio5_4.Esercizio.Esegui(); break;
        case "0": return;
        default: Console.WriteLine("Scelta non valida."); break;
    }
}
