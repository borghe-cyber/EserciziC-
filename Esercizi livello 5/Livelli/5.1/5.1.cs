namespace Esercizi_livello_5.Esercizio5_1;

public static class Esercizio
{
    public static void Esegui()
    {
        // Creazione di un triangolo
        Triangolo triangolo = new Triangolo(3, 4, 5);
        Console.WriteLine(triangolo.Descrivi());

        // Creazione di un rettangolo
        Rettangolo rettangolo = new Rettangolo(4, 6);
        Console.WriteLine(rettangolo.Descrivi());

        // Creazione di un cerchio
        Cerchio cerchio = new Cerchio(5);
        Console.WriteLine(cerchio.Descrivi());
    }
}
