namespace GiocoTurni.Personaggi;

public class SistemaLivelli
{
    
    private readonly Personaggio proprietario;

    public int Livello { get; private set; } = 1;
    public int Esperienza { get; private set; } = 0;

    
    public int EsperienzaNecessaria => Livello * 100; // comodo perchè ogni livello attuale la condizione per passare al successivo 
                                                    // nota 1*100 = 100 serveno 100 punti per il livello 1 e cosi via 

    public SistemaLivelli(Personaggio proprietario)
    {
        this.proprietario = proprietario;
    }

    
    public int AggiungiEsperienza(int punti)
    {
        if (punti <= 0) return 0;

        Esperienza = Esperienza + punti;
        int livelliGuadagnati = 0;

        // ho messo il ciclo nel caso raro che si fanno due livelli insieme
        while (Esperienza >= EsperienzaNecessaria)
        {
            Esperienza = Esperienza - EsperienzaNecessaria; 
            Livello = Livello + 1;
            livelliGuadagnati = livelliGuadagnati + 1;

            // Raggiungere un nuovo livello ovviamente porta a dei benefici
            proprietario.ApplicaBonusLivello();
        }

        // Tutte le volte che salgo di livello la vita torna al massimo 
        if (livelliGuadagnati > 0)
        {
            proprietario.PuntiVita = proprietario.VitaMassima;
        }

        return livelliGuadagnati;
    }

    public override string ToString()
    {
        return $"liv. {Livello}, exp {Esperienza}/{EsperienzaNecessaria}";
    }
}
