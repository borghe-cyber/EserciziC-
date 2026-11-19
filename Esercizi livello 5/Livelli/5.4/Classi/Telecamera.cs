public class Telecamera : DispositivoBase, IConsumoEnergetico, IConnesso
{
    public string IndirizzoIP { get; private set; }

    public Telecamera(string nome, string indirizzoIP) : base(nome)
    {
        IndirizzoIP = indirizzoIP;
    }

    public double ConsumoWatt()
    {
        if (Acceso)
        {
            return 8;
        }
        else
        {
            return 0;
        }
    }

    public override string Stato()
    {
        if (Acceso)
        {
            return $"{Nome}: ACCESA, in registrazione ({IndirizzoIP})";
        }
        else
        {
            return $"{Nome}: SPENTA";
        }
    }
}
