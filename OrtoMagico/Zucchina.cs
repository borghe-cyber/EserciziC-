// Zucchina eredita da Ortaggio
public class Zucchina : Ortaggio
{
    public double lunghezza; 

    public Zucchina(double peso, double lunghezza) : base("Zucchina", "Verde", peso)
    {
        this.lunghezza = lunghezza;
    }

    public override void MostraInfo()
    {
        base.MostraInfo();
        Console.WriteLine($"  Lunghezza: {lunghezza} cm");
    }

    
    public override int InnaffiateGiuste => 3;

   
    public override void Innaffia()
    {
        base.Innaffia();
        if (random.NextDouble() < 0.5)
        {
            Marcisci("mangiata dalle lumache");
        }
    }
}
