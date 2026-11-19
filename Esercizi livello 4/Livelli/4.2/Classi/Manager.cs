public class Manager : Impiegato
{
    public const decimal BonusPerMembro = 0.10m;

    public decimal StipendioFisso { get; private set; }
    public int MembriTeam { get; private set; }

    public Manager(string nome, string cognome, decimal stipendioFisso, int membriTeam) : base(nome, cognome)
    {
        this.StipendioFisso = stipendioFisso;
        this.MembriTeam = membriTeam;
    }

    // stipendio fisso + bonus del 10% per ogni membro del team
    public override decimal CalcolaStipendio()
    {
        return StipendioFisso + StipendioFisso * BonusPerMembro * MembriTeam;
    }

    public override void Descrizione()
    {
        Console.WriteLine($"Manager: {Nome} {Cognome}, Fisso: {StipendioFisso:0.00} €, Membri del Team: {MembriTeam}, Stipendio: {CalcolaStipendio():0.00} €");
    }
}
