using GiocoTurni.Personaggi;

namespace GiocoTurni.Nemici;

public class Nemico : Personaggio
{
    
    private const int VitaPerLivello = 10;
    private const int DannoPerLivello = 5;

    
    public int Livello { get; }

    
    public int Danno { get; } 

    // Esperienza che l'EROE riceve quando uccide questo nemico // Nota per dopo Solo chi da il colpo di grazia riceve i punti gli altri NADA
    public int EsperienzaRilasciata => Livello * 30;

    // Il livello si sceglie alla creazione e non cambia più.
    // vitaBase e dannoBase sono i valori del nemico a livello 1
    public Nemico(int vitaBase, int dannoBase, int livello)
        : base("", CalcolaVita(vitaBase, livello))
    {
        if (livello < 1)
        {
            livello = 1;
        }

        this.Livello = livello;
        this.Nome = GetType().Name; // nome del mostro coincide con quello della classe molto comodo evito ripetizioni 

        
        this.Danno = dannoBase + (livello - 1) * DannoPerLivello;
    }

    // Il nemico colpisce il bersaglio con il suo danno.
    // Ricevi attacco essendo in personaggio la classe madre , ho messo visual perche ogni eroe ha la sua condizione
    // Il cavaliere non prende direttamente danno perche nel suo caso ha un armatura 
    public void Attacca(Personaggio bersaglio)
    {
        if (!IsVivo) return; // un mostro morto non attacca 

        bersaglio.RiceviAttacco(Danno);
    }

    // in base alla vita ovviamente la vita sale altrimenti che gusto c'è
    private static int CalcolaVita(int vitaBase, int livello)
    {
        if (livello < 1)
        {
            livello = 1;
        }

        return vitaBase + (livello - 1) * VitaPerLivello;
    }

    public override string Stato()
    {
        return $"{Nome} (liv. {Livello}): vita {PuntiVita}/{VitaMassima}, danno {Danno}";
    }
}
