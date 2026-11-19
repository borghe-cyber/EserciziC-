public class Rettangolo : Forma
{
    public double Base { get; }
    public double Altezza { get; }

    public Rettangolo(double baseRett, double altezza)
    {
        if (baseRett <= 0 || altezza <= 0)
            throw new ArgumentException("Base e altezza devono essere maggiori di zero.");
        Base = baseRett;
        Altezza = altezza;
    }

    public override double CalcolaArea()
    {
        return Base * Altezza;
    }

    public override double CalcolaPerimetro()
    {
        return 2 * (Base + Altezza);
    }
}
