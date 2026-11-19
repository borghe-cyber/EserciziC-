namespace Esercizi_livello_6.Esercizio6_4;

public class Studente : IComparable<Studente>, IEntita
{
    public int Id { get; }
    public string Nome { get; }
    public decimal Media { get; }

    public Studente(int id, string nome, decimal media)
    {
        if (media < 0 || media > 10)
            throw new ArgumentOutOfRangeException(nameof(media), "La media deve essere tra 0 e 10.");

        Id = id;
        Nome = nome;
        Media = media;
    }

    public int CompareTo(Studente? altro)
    {
        if (altro is null) return 1;
        return Media.CompareTo(altro.Media);
    }

    public override string ToString() => $"[{Id}] {Nome} (media {Media})";
}
