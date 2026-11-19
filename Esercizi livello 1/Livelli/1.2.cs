namespace Esercizi_livello_1.Esercizi;
//Leggi un numero intero e stampa se è pari o dispari e se è positivo, negativo o zero.
//Usa l'operatore % e un if / else if / else.

public static class Esercizio1_2
{
    public static void Esegui()
    {
        Console.WriteLine("Esercizio 1.2");
        
        int numero;
        Console.WriteLine("Inserire un numero");
        numero = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Il numero inserito "+numero);

        if(numero%2==0)
        {
            Console.WriteLine("Il numero è pari");
        }
        else
        {
            Console.WriteLine("il numero è dispari");
        }
        
        
        
        if(numero<0)
        {
            Console.WriteLine("Il numero è negativo");
        }
        else if(numero==0)
        {
            Console.WriteLine("Il numero è zero");
        }
        else
        {
            Console.WriteLine("Il numero è positivo");
        }

        // Stessa cosa con un'espressione switch
        string segno = numero switch
        {
            < 0 => "negativo",
            0   => "zero",
            > 0 => "positivo"
        };
        Console.WriteLine("Il numero è " + segno);


    }
}
