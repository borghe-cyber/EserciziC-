public class Persona
{
    public string Nome;
    public string Cognome; 
    public int AnnoNascita;
    public int Eta;

    public Persona(string nome, string cognome, int annoNascita)
    {
        this.Nome = nome;
        this.Cognome = cognome;
        this.AnnoNascita = annoNascita;
        this.Eta = CalcolaEta();
    }

    public int CalcolaEta()
    {
        return DateTime.Now.Year - AnnoNascita;
    }

    public void Presentati()
    {
        Console.WriteLine("Sono " + Nome + " " + Cognome + " e ho " + Eta + " anni.");
    }
}
