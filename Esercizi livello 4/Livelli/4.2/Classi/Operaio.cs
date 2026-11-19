public class Operaio : Impiegato
{
    public const decimal OreNormali = 160;
    public const decimal TassoStraordinari = 1.5m;

    public decimal OreLavorate { get; private set; }
    public decimal PagaOraria { get; private set; }

    public Operaio(string nome, string cognome, decimal oreLavorate, decimal pagaOraria) : base(nome, cognome)
    {
        this.OreLavorate = oreLavorate;
        this.PagaOraria = pagaOraria;
    }

   
    public override decimal CalcolaStipendio()
    {
        if (OreLavorate <= OreNormali)
        {
            return OreLavorate * PagaOraria;
        }
        decimal straordinari = OreLavorate - OreNormali;
        return OreNormali * PagaOraria + straordinari * PagaOraria * TassoStraordinari;
    }

    public override void Descrizione()
    {
        Console.WriteLine($"Operaio: {Nome} {Cognome}, Ore: {OreLavorate}, Paga oraria: {PagaOraria:0.00} €, Stipendio: {CalcolaStipendio():0.00} €");
    }
}
