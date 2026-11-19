while (true)
{
    Console.WriteLine();
    Console.WriteLine("=== Esercizi livello 0 ===");
    Console.WriteLine("1) Arrey");
    Console.WriteLine("2) Arrey2");
    Console.WriteLine("3) ForEach");
    Console.WriteLine("4) Lista");
    Console.WriteLine("5) ListaEs1");
    Console.WriteLine("6) ListaEs2");
    Console.WriteLine("7) ListaEs3");
    Console.WriteLine("8) ListaEs4");
    Console.WriteLine("9) ListaRemuve");
    Console.WriteLine("0) Esci");
    Console.Write("Scegli un esercizio: ");

    switch (Console.ReadLine())
    {
        case "1": Esercizi.Arrey(); break;
        case "2": Esercizi.Arrey2(); break;
        case "3": Esercizi.ForEach(); break;
        case "4": Esercizi.Lista(); break;
        case "5": Esercizi.ListaEs1(); break;
        case "6": Esercizi.ListaEs2(); break;
        case "7": Esercizi.ListaEs3(); break;
        case "8": Esercizi.ListaEs4(); break;
        case "9": Esercizi.ListaRemuve(); break;
        case "0": return;
        default: Console.WriteLine("Scelta non valida."); break;
    }
}


public static class Esercizi
{
    public static void Arrey()
    {
         int[] voti = { 7, 8, 6, 9, 10 };
         

        Console.WriteLine(voti[0]); 
        Console.WriteLine(voti[1]); 
        Console.WriteLine(voti[2]);
        Console.WriteLine(voti[3]); 
        Console.WriteLine(voti[4]);

        int[] numeri = new int[5];
         

        Console.WriteLine(numeri[0]); 
        Console.WriteLine(numeri[1]); 
        Console.WriteLine(numeri[2]);
        Console.WriteLine(numeri[3]); 
        Console.WriteLine(numeri[4]);

        string[] nomi = { "Luca", "Marco", "Anna" };

        Console.WriteLine(nomi[0]);
        Console.WriteLine(nomi[1]); 
        Console.WriteLine(nomi[2]);


        int[] numerii = { 10, 20, 30, 40, 50 };

        for (int i = 0; i < numerii.Length; i++)
        {
            Console.WriteLine(numerii[i]);
        }


            int[] numeriii = { 5, 10, 15, 20 };

            int somma = 0;

            for (int i = 0; i < numeriii.Length; i++)
            {
                somma = somma + numeriii[i];
            }

            Console.WriteLine("Somma: " + somma);

            string[] boys = { "Luca", "Anna", "Marco" };

            foreach (string boy in boys)
            {
                Console.WriteLine(boys);
            }
    }


    public static void Arrey2()
    {
        // Init
        Random rnd = new Random(DateTime.Now.Second);

        // Array mono-dimensione
        int[] sequence = new int[]
        {
            rnd.Next(1024),
            rnd.Next(1024),
            rnd.Next(1024),45,
            rnd.Next(1024),345
        };

        int[] sequence2 = new int[6];

        Console.WriteLine($"Terzo item: {sequence[2]}");

        String[,] items2 = new string[4,2]
        {
            {"frutta","pesca"},
            {"frutta","mela"},
            {"ortaggio","insalta"},
            {"ortaggio","patata"}
        };

        Console.WriteLine($"Secondo ortaggio: {items2[3,1]}");
    }


    public static void ForEach()
    {
        int[] numeri = {10,20,30,40};


        foreach (int numero in numeri)
        {
            Console.WriteLine(numero);
        }
    }


    public static void Lista()
    {
    // /////////////////Scrivi un programma C# ///////////////
    // // 1. Crei una lista di numeri interi chiamata numeri.
    // // 2. Aggiunga i numeri 5, 10, 15 e 20 usando Add().
    // // 3. Stampi il primo elemento della lista.
    // // 4. Stampi quanti elementi contiene la lista.



    // // class Program
    // // {
    // // 	public static void Main(string[] args)
    // // 	{
    // //         List<int> numeri = new List<int>();
    // //         numeri.Add(5);
    // //         numeri.Add(10);
    // //         numeri.Add(15);
    // //         numeri.Add(20);

    // //         Console.WriteLine(numeri[0]);
    // //         Console.WriteLine(numeri.Count);
    // //         Console.WriteLine("Stampo tutti gli elementi della lista:");
            
    // //         for(int i = 0; i < numeri.Count; i++)
    // //         {
    // //             Console.WriteLine(numeri[i]);
    // //         }

    // // 	}
    // // }

    // class Program
    // {
    //     public static void Main(string[] args)
    //     {
    //         List<int> numeri = new List<int>();
    //         numeri.Add(10);
    //         numeri.Add(20);
    //         numeri.Add(30);
    //         numeri.Add(40);
    //         numeri.Add(50);

    //         Console.WriteLine("Stampo tutti gli elementi della lista:");
    //         foreach (int numero in numeri)
    //         {
    //             Console.Write(" "+numero);
    //         }
    //         Console.WriteLine("");
    //         Console.WriteLine(numeri[2]); // qui scelgo il numero che volgio stampare 

    //         numeri[1]= 99;
    //         Console.WriteLine(numeri[1]); // qui scelgo il numero che volgio stampare

    //         Console.WriteLine("ultimo elemento lista: " + numeri[numeri.Count - 1]);
    //         Console.WriteLine("numero totale elementi lista: "+numeri.Count);

    //     }
    // }

    // class Program
    // {
    //     public static void Main(string[] args)
    //     {
    //         List<int> numeri = new List<int>{5, 15, 25, 35};
    //         Console.WriteLine(numeri[2]);
           
    //     }    
    // }

        Console.WriteLine("Lista: le versioni dell'esercizio sono tutte commentate");
    }


    // Crea una lista di interi chiamata numeri.
    // Inserisci usando Add() i numeri 5, 10, 15, 20, 25, 30.
    // Elimina il valore 15 utilizzando Remove().
    // Elimina il secondo elemento utilizzando RemoveAt().
    // Stampa il primo elemento della lista.
    // Stampa l'ultimo elemento usando Count - 1.
    // Stampa quanti elementi sono rimasti.
    // Svuota la lista utilizzando Clear().
    // Stampa nuovamente Count per verificare che sia vuota.
    public static void ListaEs1()
    {
        List<int> numeri = new List<int>();

        numeri.Add(5);
        numeri.Add(10);
        numeri.Add(15);
        numeri.Add(20);
        numeri.Add(25);
        numeri.Add(30);

        for(int i=0;i<numeri.Count;i++)
        {
            Console.WriteLine("numero "+numeri[i]);
        }

        numeri.Remove(15); // valore 
        numeri.RemoveAt(1); // posizione 

        Console.WriteLine(numeri[0]);
        Console.WriteLine(numeri.Count-1);

        for(int i=0;i<numeri.Count;i++)
        {
            Console.WriteLine("numero "+numeri[i]);
        }
        numeri.Clear();
        Console.WriteLine(numeri.Count);

    }


    public static void ListaEs2()
    {
        List<int> numeri = new List<int>();
        numeri.AddRange([2,4,6,8,10]);

        foreach(int n in numeri)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine("Moltiplicazione");

        for(int i=0;i<numeri.Count;i++)
        {
            numeri[i]= numeri[i]*3;
        }

        foreach(int n in numeri)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine(numeri[0]);
        Console.WriteLine(numeri[numeri.Count-1]);
            
    }


    // Crei una lista chiamata numeri contenente 45, 12, 78, 23, 56, 9.
    // Utilizzi Contains() per controllare se è presente il numero 23, stampando un messaggio appropriato.
    // Utilizzi IndexOf() per trovare e stampare la posizione del numero 56.
    // Ordini la lista in ordine crescente con Sort().
    // Stampi tutti gli elementi ordinati con foreach.
    // Inverta l'ordine della lista con Reverse().
    // Stampi nuovamente tutti gli elementi con foreach.
    public static void ListaEs3()
    {
        List<int> numeri = new List<int>();
        numeri.AddRange([45,12,78,23,56,9]);
        
        if(numeri.Contains(23))
        {
            Console.WriteLine("Nella lista è presente il numero 23 ");
        }
        Console.WriteLine(numeri.LastIndexOf(56));
        
        numeri.Sort();

        foreach(int n in numeri)
        {
            Console.WriteLine(n);
        }
         
        numeri.Reverse();

        foreach(int n in numeri)
        {
            Console.WriteLine(n);
        }


    }


    // Crei una lista numeri contenente 12, 45, 7, 80, 23, 60, 5.
    // Utilizzi Find() per trovare il primo numero maggiore di 30 e stamparlo.
    // Utilizzi FindAll() per creare una nuova lista con tutti i numeri maggiori di 30.
    // Stampi questa nuova lista con foreach.
    // Utilizzi RemoveAll() sulla lista originale per eliminare tutti i numeri minori di 20.
    // Stampi la lista originale dopo la rimozione.
    public static void ListaEs4()
    {
        // Creo una lista vuota di numeri interi
       List<int> numeri1 = new List<int>();
        List<int> numeri = new List<int>();

        // Aggiungo tutti i numeri alla lista in un colpo solo
        numeri.AddRange([12, 45, 7, 80, 23, 60, 5]);
        numeri1=numeri;
        // Find scorre la lista dall'inizio e restituisce il PRIMO elemento
        // che rispetta la condizione.
        // n => n > 30 significa: "per ogni numero n, è quello giusto se n > 30"
        // 12 -> no, 45 -> sì -> si ferma e restituisce 45
        int risultato = numeri.Find(n => n > 30);

        // Stampo il risultato (45)
        Console.WriteLine(risultato);

        foreach (int numero in numeri)
        {
            Console.WriteLine(numero);
        }   
        numeri.RemoveAll(n => n < 20);
        
           foreach (int numero1 in numeri)
        {
            Console.WriteLine(numero1);
        }  



    }


    public static void ListaRemuve()
    {
        List<int> numeri = new List<int>{10,20,30,40,50};
        Console.WriteLine("Stampo tutti gli elementi della lista:");
        Console.WriteLine(numeri[0]); // Primo elemento
        Console.WriteLine(numeri[1]); // Secondo elemento
        Console.WriteLine(numeri[2]); // Terzo elemento
        Console.WriteLine(numeri[3]); // Quarto elemento
        Console.WriteLine(numeri[4]); // Quinto elemento

        numeri.Remove(30); // Rimuove l'elemento con valore 30
        Console.WriteLine("Dopo la rimozione:");
        foreach (int n in numeri)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("Elementi nella lista: " + numeri.Count); // Conta gli elementi nella lista
        numeri.Insert(2, 30); // Inserisce 30 all'indice 2, gli elementi successivi scalano a destra
        Console.WriteLine("Dopo il reinserimento:");
        foreach (int n in numeri)
        {
            Console.WriteLine(n);
        }
    }
}
