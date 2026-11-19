namespace Esercizi_livello_2.Esercizio2_4;

public class Rettangolo
{
    public decimal Base;
    public decimal Altezza;

    public Rettangolo(decimal Base,decimal Altezza)
    {
        this.Base=Base;
        this.Altezza=Altezza;
    }

    public decimal calcoloPerimentro()
    {
        return Math.Round((Base+Altezza)*2, 2);
    }
    public decimal calcoloArea()
    {
        return Math.Round(Base*Altezza, 2);
    }

    public Rettangolo(decimal Altezza)
    {
        this.Altezza=Altezza;
        this.Base=Altezza;   // quadrato: base e altezza uguali
    }

    public override string ToString()
    {
        if (Base == Altezza)
        {
            return "Quadrato di lato " + Altezza
                + ": perimetro " + calcoloPerimentro()
                + ", area " + calcoloArea();
        }
        return "Rettangolo " + Base + " x " + Altezza
            + ": perimetro " + calcoloPerimentro()
            + ", area " + calcoloArea();
    }
}
