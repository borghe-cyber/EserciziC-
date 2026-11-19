namespace Esercizi_livello_1.Esercizi;
//Chiedi all'utente nome ed età, poi stampa: Ciao Marco, tra 10 anni avrai 35 anni.
public static class Esercizio1_1
{
    public static void Esegui()
    {
        int eta;
        Console.WriteLine("Inserisci l' eta ");
        eta = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Età inserita è "+eta);
        
        string nome;
        Console.WriteLine("Inserisci il tuo nome");
        nome = Console.ReadLine()!; 
        Console.WriteLine("Il nome inserito" +nome);

        Console.WriteLine("Ciao "+nome+ " tra 10 anni avrai " +(eta+10));
        
    }
}
