namespace Esercizi_livello_1.Esercizi;

public static class Esercizio1_4
{
    public static void Esegui()
    {
        Random random = new Random();
        int dim = random.Next(1,51); 
        Console.WriteLine("Numero generato: " + dim);
    
        int[] numeri = new int[dim];

        for (int i = 0; i < dim; i++)
        {
            numeri[i] =random.Next(1,101);
            Console.WriteLine(numeri[i]);
        }

        int max=numeri[0];
        int min=numeri[0];
        int somma=0;

        for (int i = 0; i < dim; i++)
        {
            if(numeri[i]>max)
            {
                max=numeri[i];
            }
            if(numeri[i]<min)
            {
                min=numeri[i];
            }
            somma=somma+numeri[i];
        }

        Console.WriteLine("Il massimo è " +max);
        Console.WriteLine("Il minimo è " +min);
        Console.WriteLine("La somma è " +somma);
        float media=somma/dim;
        Console.WriteLine("Il minimo è " +min);
        

    }
}
