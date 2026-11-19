public class Cerchio : Forma
{
    public double Raggio { get; }

    public Cerchio(double raggio)
    {
        if (raggio <= 0)
            throw new ArgumentException("Il raggio deve essere maggiore di zero.");
        Raggio = raggio;
    }

    public override double CalcolaArea()
    {
        return Math.PI * Raggio * Raggio;
    }

    public override double CalcolaPerimetro()
    {
        return 2 * Math.PI * Raggio;
    }
}
