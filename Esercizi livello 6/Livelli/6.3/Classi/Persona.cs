namespace Esercizi_livello_6.Esercizio6_3;

public class Persona
{
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public int Eta { get; set; }

    public Persona(string nome, string cognome, int eta)
    {
        Nome = nome;
        Cognome = cognome;
        Eta = eta;
    }

    public override string ToString() => $"{Nome} {Cognome} ({Eta} anni)";
}
