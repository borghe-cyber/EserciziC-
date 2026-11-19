public class Camion : Veicolo
{
    public int carico {get; private set ; }

    public Camion(string marca, string modello, int anno,int carico) : base(marca,modello,anno)
    {
        this.carico=carico;
    }

    public override string Descrizione()
    {
        return $"{base.Descrizione()}, Carico: {carico} kg";
    }
    public void DescrizioneCamion()
    {
        Console.WriteLine("La marca del camion è: " + Marca + ", il modello è: " + Modello + ", l'anno di produzione è: " + Anno + ", il carico massimo è: " + carico + " kg");
    }

}