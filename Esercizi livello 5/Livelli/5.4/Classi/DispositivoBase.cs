public abstract class DispositivoBase : IDispositivo
{
    public string Nome {get; private set;}
    public bool Acceso {get; private set;}

    public DispositivoBase(string Nome)
    {
        this.Nome=Nome;
    }

    public abstract string Stato();

    public virtual void Accendi()
    {
        Acceso = true;
        Console.WriteLine($"{Nome} acceso.");
    }

    public virtual void Spegni()
    {
        Acceso = false;
        Console.WriteLine($"{Nome} spento.");
    }
}
