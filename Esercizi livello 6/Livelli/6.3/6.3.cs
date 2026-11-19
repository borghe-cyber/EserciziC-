namespace Esercizi_livello_6.Esercizio6_3;



public static class Esercizio
{
    public static void Esegui()
    {
        
        Console.WriteLine("--- Pila<int> ---");
        Pila<int> numeri = new Pila<int>(2);
        for (int i = 1; i <= 5; i++)
        {
            numeri.Push(i * 10);
            Console.WriteLine($"Push {i * 10} -> Count = {numeri.Count}, Capacità = {numeri.Capacita}");
        }

        Console.WriteLine($"Peek: {numeri.Peek()}");
        Console.WriteLine($"Pop:  {numeri.Pop()}");
        Console.Write("foreach (dalla cima): ");
        foreach (int n in numeri)
            Console.Write($"{n} ");
        Console.WriteLine();

        // --- Pila<string> ---
        Console.WriteLine("\n--- Pila<string> ---");
        Pila<string> parole = new Pila<string>();
        parole.Push("primo");
        parole.Push("secondo");
        parole.Push("terzo");

        Console.Write("Svuoto con Pop: ");
        while (!parole.IsEmpty)
            Console.Write($"{parole.Pop()} ");
        Console.WriteLine($"\nIsEmpty: {parole.IsEmpty}");

        
        try
        {
            parole.Pop();
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"[Errore] {ex.Message}");
        }

        // --- Pila<Persona> ---
        Console.WriteLine("\n--- Pila<Persona> ---");
        Pila<Persona> persone = new Pila<Persona>();
        persone.Push(new Persona("Mario", "Rossi", 30));
        persone.Push(new Persona("Anna", "Bianchi", 25));
        persone.Push(new Persona("Luca", "Verdi", 40));

        Console.WriteLine($"In cima c'è: {persone.Peek()}");
        Console.WriteLine("Tutte le persone (foreach):");
        foreach (Persona p in persone)
            Console.WriteLine($"  {p}");
    }
}
