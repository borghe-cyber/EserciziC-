public class Veicolo
{
    public string Marca { get;  private set; }
    public string Modello { get; private set; }
    public int Anno { get; private set; }

    public Veicolo(string marca, string modello, int anno)
    {
        this.Marca = marca;
        this.Modello = modello;
        this.Anno = anno;
    }

    public virtual string Descrizione()
    {
        return $"Marca: {Marca}, Modello: {Modello}, Anno: {Anno}";
    }
}