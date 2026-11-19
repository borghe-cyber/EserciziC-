namespace Esercizi_livello_4.Esercizio4_5;


public abstract class Animale : IVerso
{
    public string Nome { get; private set; }
    public string Razza { get; private set; }

    public Animale(string nome, string razza)
    {
        Nome = nome;
        Razza = razza;
    }

    public abstract void FaiVerso();

    public virtual void Presentati()
    {
        Console.WriteLine($"Sono {Nome}, razza {Razza}.");
    }
}
