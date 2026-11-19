namespace Esercizi_livello_6.Esercizio6_4;

public class Prodotto : IEntita
{
    public int Id { get; }
    public string Nome { get; }
    public decimal Prezzo { get; }

    public Prodotto(int id, string nome, decimal prezzo)
    {
        Id = id;
        Nome = nome;
        Prezzo = prezzo;
    }

    public override string ToString() => $"[{Id}] {Nome} - {Prezzo:0.00} €";
}
