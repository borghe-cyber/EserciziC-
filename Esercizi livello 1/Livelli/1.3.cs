namespace Esercizi_livello_1.Esercizi;

//FizzBuzz
//Stampa i numeri da 1 a 100. Per i multipli di 3 stampa Fizz, per i multipli di 5 Buzz,
// per i multipli di entrambi FizzBuzz.
//Attenzione all'ordine delle condizioni: il caso "multiplo di 15" va controllato per primo.

public static class Esercizio1_3
{
    public static void Esegui()
    {
         int[] numeri = new int[100];

        for (int i = 0; i < numeri.Length; i++)
        {
            numeri[i] = i + 1;

            if(numeri[i]%15==0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if(numeri[i]%3==0)
            {
                Console.WriteLine("Fizz");
            }
            else if(numeri[i]%5==0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(numeri[i]);
            }
        }

    }
}

