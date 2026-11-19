// abstract: non si può fare new Impiegato(...), esistono solo Operaio e Manager
public abstract class Impiegato
{
    public string Nome { get; private set; }
    public string Cognome { get; private set; }

    public Impiegato(string nome, string cognome)
    {
        this.Nome = nome;
        this.Cognome = cognome;
    }

    // abstract: ogni classe figlia DEVE scriverlo con override
    public abstract decimal CalcolaStipendio();

    public virtual void Descrizione()
    {
        // CalcolaStipendio() esegue la versione della classe figlia (Operaio o Manager)
        Console.WriteLine($"Impiegato: {Nome} {Cognome}, Stipendio: {CalcolaStipendio():0.00} €");
    }
}
