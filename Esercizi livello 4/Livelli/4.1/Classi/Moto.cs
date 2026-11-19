public class Moto : Veicolo
{
    public int Cilindrata { get; private set; }


    public Moto(string marca, string modello, int anno, int cilindrata) : base(marca, modello, anno)
    {
        this.Cilindrata = cilindrata;
    }

    public override string Descrizione()
    {
        return $"{base.Descrizione()}, Cilindrata: {Cilindrata} cc";
    }
    public void DescrizioneMoto()
    {
        Console.WriteLine("La marca della moto è: " + Marca + ", il modello è: " + Modello + ", l'anno di produzione è: " + Anno + ", la cilindrata è: " + Cilindrata + " cc");
    }
}