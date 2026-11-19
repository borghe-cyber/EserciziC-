namespace Esercizi_livello_2.Esercizio2_3;

public class Contatore
{
    public int conta;  

    public Contatore(int conta = 0)
    {
        this.conta = conta;
    }

    public void Incrementa()
    {
        conta++;
    }

    public void Decrementa()
    {
        if (conta > 0)   // non scende mai sotto zero
        {
            conta--;
        }
    }

    public void Reset()
    {
        conta = 0;
    }

    public int Valore()
    {
        return conta;
    }
}
