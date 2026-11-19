public class Rettangolo
{
    public decimal Base;
    public decimal Altezza;

    public Rettangolo(decimal Base,decimal Altezza)
    {
        this.Base=Base;
        this.Altezza=Altezza;
    }

    public void calcoloPerimentro()
    {
        decimal Perimetro=Math.Round((Base+Altezza)*2, 2);
        Console.WriteLine("Il perimentro del rettangolo è " + Perimetro);
    }
    public void calcoloArea()
    {
        decimal Area=Math.Round(Base*Altezza, 2);
        Console.WriteLine("Area del rettangolo è " + Area );
    }

    public Rettangolo(decimal Altezza)
    {
        this.Altezza=Altezza;
    }

    public void PerimentroQuadrato()
    {
        decimal Perimetro=Math.Round(Altezza*4, 2);
        Console.WriteLine("Il perimetro del quadrato è "+Perimetro);
    }

    public void AreaQuadrato()
    {
        decimal Area = Math.Round(Altezza*Altezza, 2);
        Console.WriteLine("Area del quadrato è " + Area);
    }


}