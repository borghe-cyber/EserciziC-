public class Altoparlante : DispositivoBase, IRegolabile, IConnesso
{
    public int Livello { get; set; } // volume in %
    public string IndirizzoIP { get; private set; }

    public Altoparlante(string nome, string indirizzoIP) : base(nome)
    {
        IndirizzoIP = indirizzoIP;
    }

    public void Regola(int valore)
    {
        if (valore >= 0 && valore <= 100)
        {
            Livello = valore;
        }
    }

    public override string Stato()
    {
        if (Acceso)
        {
            return $"{Nome}: ACCESO, volume {Livello}%";
        }
        else
        {
            return $"{Nome}: SPENTO";
        }
    }
}
