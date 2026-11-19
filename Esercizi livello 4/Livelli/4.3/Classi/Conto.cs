public class Conto
{
    public string Nome { get; private set; }
    public string Cognome { get; private set; }

    public decimal Saldo { get; private set; }

    public Conto(string nome, string cognome, decimal saldoIniziale)
    {
        Nome = nome;
        Cognome = cognome;
        Saldo = saldoIniziale;
    }

    public void Deposita(decimal importo)
    {
        if (importo <= 0)
        {
            throw new ArgumentException("L'importo da depositare deve essere maggiore di zero.");
        }

        Saldo += importo;
    }
    public void Preleva(decimal importo)
    {
        if (importo <= 0)
        {
            throw new ArgumentException("L'importo da prelevare deve essere maggiore di zero.");
        }

        if (importo > Saldo)
        {
            throw new InvalidOperationException("Saldo insufficiente per il prelievo.");
        }

        Saldo -= importo;
    }

    public void ApplicaInterresse()
    {
        if(Saldo>10)
        {
            Saldo = Saldo + (Saldo * 1.5m);
        }
        if(Saldo>20)
        {
            Saldo = Saldo + (Saldo * 2.0m);
        }
        if(Saldo>30)
        {
            Saldo = Saldo + (Saldo * 2.5m);
        }
        if(Saldo>40)
        {
            Saldo = Saldo + (Saldo * 3.0m);
        }
        if(Saldo>50)
        {
            Saldo = Saldo + (Saldo * 3.5m);
        }
    }
    public void StampaSaldo()
    {
        Console.WriteLine($"Saldo attuale: {Saldo:C}");
    }
}