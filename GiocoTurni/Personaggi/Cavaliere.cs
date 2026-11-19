namespace GiocoTurni.Personaggi;

public class Cavaliere : Personaggio
{
    public int Armatura { get; set; }

    public Cavaliere(string nome, int puntiVita, int armatura) : base(nome, puntiVita)
    {
        this.Armatura = armatura;
        this.ArmaturaMassima = armatura;
        this.Livelli = new SistemaLivelli(this);
    }

    // sistemi livelli è la classe che si occupa escusivamente per i livelli 
    public SistemaLivelli Livelli { get; }

    public int ArmaturaMassima { get; protected set; }

    // qui imposto i paramentri del cavaliere vita e armatura che sono cosi quando inizia il gioco
    public Cavaliere(string nome) : this(nome, 100, 50)
    {
    }

    
    public int Totale => PuntiVita + Armatura;

    // Il danno consuma prima l'armatura, il resto passa alla vita
    public override void RiceviAttacco(int danno)
    {
        if (danno <= 0) return;

        int assorbito = Math.Min(Armatura, danno);
        Armatura -= assorbito;

        int restante = danno - assorbito;
        PuntiVita = Math.Max(0, PuntiVita - restante);
    }

    // Parte da 25 e cresce con i livelli.  /// il 25 è un valore fisso il danno base del primo livello 
    public int Danno { get; private set; } = 25;

    
    public void Attacca(Personaggio bersaglio)
    {
        bersaglio.RiceviAttacco(Danno);
    }

    // Bonus per ogni livello: +10 vita massima, +10 armatura massima,
    // armatura riportata al massimo, +5 danno
    public override void ApplicaBonusLivello()
    {
        VitaMassima = VitaMassima + 10;
        ArmaturaMassima = ArmaturaMassima + 10;
        Armatura = ArmaturaMassima;
        Danno = Danno + 5;
    }

    // Si difende // Recupero Punti Armatura
    public void Difendi()
    {
        Armatura = Math.Min(ArmaturaMassima, Armatura + 25);
    }

    public override string Stato()
    {
        return base.Stato() + $", armatura {Armatura}/{ArmaturaMassima} ({Livelli})";
    }


}
