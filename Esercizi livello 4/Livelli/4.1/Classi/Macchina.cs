public class Macchina : Veicolo
{
    public int NumeroPorte { get; private set; }

    public Macchina(string marca, string modello, int anno, int numeroPorte) : base(marca, modello, anno)
    {
        this.NumeroPorte = numeroPorte;
    }

    public override string Descrizione()
    {
        return $"{base.Descrizione()}, Numero di porte: {NumeroPorte}";
    }
    public void DescrizioneMacchina()
    {
        Console.WriteLine("La marca della macchina è: " + Marca + ", il modello è: " + Modello + ", l'anno di produzione è: " + Anno + ", il numero di porte è: " + NumeroPorte);
    }
}