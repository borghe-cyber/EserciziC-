public class ContoBancario
{
    public decimal Saldo { get; private set; } // public davanti vale per il get, il set è private

    public ContoBancario(decimal Saldo)
    {
        this.Saldo=Saldo;
    }
    public decimal Deposita(decimal importo)
    {
        if (importo < 0)
        {
            throw new ArgumentException("L'importo da depositare non può essere negativo.");
        }
        Console.WriteLine("Il Saldo attuale prima del deposito "+Saldo);
        Console.WriteLine("Importo da depositare "+importo);
        Saldo=Saldo+importo;    
        Console.WriteLine("Saldo attuale dopo il deposito "+Saldo);
        return importo;
        
    } 
    public decimal Preleva(decimal importo)
    {
        if (importo < 0)
        {
            throw new ArgumentException("L'importo da prelevare non può essere negativo.");
        }
        if (importo > Saldo)
        {
            throw new InvalidOperationException("Saldo insufficiente: disponibili " + Saldo + ", richiesti " + importo + ".");
        }
        Console.WriteLine("Il Saldo attuale prima del prelievo "+Saldo);
        Console.WriteLine("Importo da prelevare "+importo);
        Saldo=Saldo-importo;
        Console.WriteLine("Saldo attuale dopo il prelievo "+Saldo);
        return importo;

    }



}