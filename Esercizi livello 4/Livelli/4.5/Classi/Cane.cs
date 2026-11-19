namespace Esercizi_livello_4.Esercizio4_5;

public class Cane : Animale
{
    public Cane(string nome, string razza) : base(nome, razza)
    {
    }

    public override void FaiVerso()
    {
        Console.WriteLine($"{Nome} abbaia: Bau bau!");
    }
}
