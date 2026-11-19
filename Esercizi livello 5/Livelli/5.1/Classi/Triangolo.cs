public class Triangolo : Forma
{
    public double LatoA { get; }
    public double LatoB { get; }
    public double LatoC { get; }

    public Triangolo(double latoA, double latoB, double latoC)
    {
        if (latoA <= 0 || latoB <= 0 || latoC <= 0)
            throw new ArgumentException("I lati devono essere maggiori di zero.");
        if (latoA + latoB <= latoC || latoA + latoC <= latoB || latoB + latoC <= latoA)
            throw new ArgumentException("I lati non formano un triangolo valido.");
        LatoA = latoA;
        LatoB = latoB;
        LatoC = latoC;
    }

    // Formula di Erone
    public override double CalcolaArea()
    {
        double s = CalcolaPerimetro() / 2;
        return Math.Sqrt(s * (s - LatoA) * (s - LatoB) * (s - LatoC));
    }

    public override double CalcolaPerimetro()
    {
        return LatoA + LatoB + LatoC;
    }
}
