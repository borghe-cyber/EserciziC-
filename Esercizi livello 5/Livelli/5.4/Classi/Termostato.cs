public class Termostato : DispositivoBase, IRegolabile, IConsumoEnergetico, IConnesso
{
    public int Livello { get; set; } = 20; // temperatura impostata in °C
    public string IndirizzoIP { get; private set; }

    public Termostato(string nome, string indirizzoIP) : base(nome)
    {
        IndirizzoIP = indirizzoIP;
    }

    public void Regola(int valore)
    {
        if (valore >= 10 && valore <= 30)
        {
            Livello = valore;
        }
    }

    public double ConsumoWatt()
    {
        if (Acceso)
        {
            return Livello * 2.5;
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
            return $"{Nome}: ACCESO, temperatura {Livello}°C";
        }
        else
        {
            return $"{Nome}: SPENTO";
        }
    }
}
