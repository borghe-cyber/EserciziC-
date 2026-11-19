namespace Esercizi_livello_4.Esercizio4_5;

public class Gatto : Animale
{
    public Gatto(string nome, string razza) : base(nome, razza)
    {
    }

    public override void FaiVerso()
    {
        Console.WriteLine($"{Nome} miagola: Miao!");
    }
}
