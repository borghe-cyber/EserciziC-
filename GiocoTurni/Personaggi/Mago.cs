namespace GiocoTurni.Personaggi;

public class Mago : Personaggio
{
    public int Mana { get; set; }

    public Mago(string nome, int puntiVita, int mana) : base(nome, puntiVita)
    {
        this.Mana = mana;
        this.Livelli = new SistemaLivelli(this);
    }

    // Livello ed esperienza del mago gestiti dalla classe dedicata che vale solo per gli eroi 
    public SistemaLivelli Livelli { get; }

    public Mago(string nome) : this(nome, 70, 200)
    {
    }

    // Come dice il nome della funzione la base è 30 e giustamente cresce con i livelli 
    public int DannoMagico { get; private set; } = 30;

    // metodo che cui vengono applicati i bonus per il level+
    public override void ApplicaBonusLivello()
    {
        VitaMassima = VitaMassima + 5;
        Mana = Mana + 50;
        DannoMagico = DannoMagico + 5;
    }
    public void AttaccoMagico(Personaggio bersaglio, int danno)
    {
        if (danno <= 0)
        {
            Console.WriteLine("Danno non valido");
            return;
        }
        if (Mana < 10)
        {
            Console.WriteLine("Hai esaurito il mana");
            return;
        }

        bersaglio.RiceviAttacco(danno);
        Mana -= 10;
    }

    // Praticamente con rigeneraVita converto i punti mana in punti vita
    public void RigeneraVita()
    {
        const int costo = 20;

        if (Mana < costo)
        {
            Console.WriteLine($"{Nome} non ha abbastanza mana per curarsi!");
            return;
        }

        Mana = Mana - costo;
        PuntiVita = PuntiVita + costo;
        if (PuntiVita > VitaMassima) // controllo per non adare oltre la vita massima 
        {
            PuntiVita = VitaMassima; 
        }
    }

    public override string Stato()
    {
        return base.Stato() + $", mana {Mana} ({Livelli})";
    }
}
