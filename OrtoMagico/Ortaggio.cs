

public abstract class Ortaggio
{
    protected static Random random = new Random();

    protected int innaffiate = 0;   
    protected bool marcito = false; 

    
    public string nome;
    public string colore;
    public double peso; // in grammi

    
    public Ortaggio(string nome, string colore, double peso)
    {
        this.nome = nome;
        this.colore = colore;
        this.peso = peso;
    }

   
    public virtual void MostraInfo()
    {
        Console.WriteLine($"Ortaggio: {nome}, Colore: {colore}, Peso: {peso} g");
    }
    
    public void Cresci(double grammi)
    {
        peso = peso + grammi;
        Console.WriteLine($"{nome} è cresciuto! Nuovo peso: {peso} g");
    }

    // Ogni ortaggio ha un numero preciso di innaffiate 
    public abstract int InnaffiateGiuste { get; }

   
    public virtual void Innaffia()
    {
        innaffiate++;
    }

    ////< 0 acerbo, 0 maturo, > 0 marcio
    public virtual int Raccogli()
    {
        if (marcito)
        {
            return Math.Max(1, innaffiate - InnaffiateGiuste);
        }
        return innaffiate - InnaffiateGiuste;
    }

    
    protected void Marcisci(string motivo)
    {
        if (!marcito)
        {
            marcito = true;
            Console.WriteLine($"  {nome}: {motivo}! È marcito in anticipo.");
        }
    }
}
