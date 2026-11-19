// Peperone eredita da Ortaggio
public class Peperone : Ortaggio
{
    public bool piccante;

    public Peperone(string colore, double peso, bool piccante) : base("Peperone", colore, peso)
    {
        this.piccante = piccante;
    }

    public override void MostraInfo()
    {
        base.MostraInfo();
        Console.WriteLine($"  Piccante: {(piccante ? "Sì" : "No")}");
    }

    //Matura dopo 5 innaffiate
    public override int InnaffiateGiuste => 5;

    // I funghi si formano con probabilità crescente rispetto al numero di innaffiate
    public override void Innaffia()
    {
        base.Innaffia();
        double probabilitaFunghi = innaffiate * 0.03;
        if (random.NextDouble() < probabilitaFunghi)
        {
            Marcisci("attaccato dai funghi");
        }
    }
}
