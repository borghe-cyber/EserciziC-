using GiocoTurni;
using GiocoTurni.Nemici;
using GiocoTurni.Personaggi;

//  lista degli eroi: il nome di ogni giocatore viene chiesto prima della partita
var eroi = new List<Personaggio>
{
    new Cavaliere(ChiediNome("Cavaliere 1")),
    new Cavaliere(ChiediNome("Cavaliere 2")),
    new Mago(ChiediNome("Mago")),

};

// Lista dei mostri
var mostri = new List<Nemico>
{
    new Goblin(1),
    new Goblin(1),
    new Goblin(2),
    new Goblin(2),
    new Orco(3)
};

var partita = new Partita(eroi, mostri);
partita.Gioca();


// Chiede il nome del giocatore e lo fa confermare 

static string ChiediNome(string ruolo)
{
    while (true)
    {
        Console.Write($"Inserisci il nome del giocatore ({ruolo}): ");
        string nome = (Console.ReadLine() ?? "").Trim();

        if (nome == "")
        {
            Console.WriteLine("Il nome non può essere vuoto.");
            continue;
        }

        Console.Write($"Hai scritto \"{nome}\". Confermi? (s/n): ");
        string risposta = (Console.ReadLine() ?? "s").Trim().ToLower();

        if (risposta == "s")
        {
            Console.WriteLine($"Benvenuto {nome}!\n");
            return nome;
        }

        Console.WriteLine("Ok, riscrivi il nome.");
    }
}
