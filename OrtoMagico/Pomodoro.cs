// Pomodoro eredita da Ortaggio
public class Pomodoro : Ortaggio
{
    public string varieta; 

    public Pomodoro(string varieta, double peso) : base("Pomodoro", "Rosso", peso)
    {
        this.varieta = varieta;
    }

    public override void MostraInfo()
    {
        base.MostraInfo();
        Console.WriteLine($"  Varietà: {varieta}");
    }


    public override int InnaffiateGiuste => 7;

    private int cimici = 0;
    private const int SogliaCimici = 15;

    
    public override void Innaffia()
    {
        base.Innaffia();
        cimici += random.Next(0, 4); 
        if (cimici > SogliaCimici)
        {
            Marcisci($"attaccato dalle cimici ({cimici})");
        }
    }
}
