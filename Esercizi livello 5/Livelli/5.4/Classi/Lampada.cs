public class Lampada : DispositivoBase, IRegolabile, IConsumoEnergetico
{
    public int Livello { get; set; }

    public Lampada(string nome) : base(nome) { }

    public void Regola(int valore)
    {
        if (valore >= 0 && valore <= 100)
        {
            Livello = valore;
        }
    }

    public double ConsumoWatt()
    {
        if (Acceso)
        {
            return Livello * 0.6;
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
            return $"{Nome}: ACCESA, luminosità {Livello}%";
        }
        else
        {
            return $"{Nome}: SPENTA";
        }
    }
}
