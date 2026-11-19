namespace GiocoTurni.Personaggi;
public class Personaggio
{
    public string Nome { get; set; }
    public int PuntiVita { get; set; }

   
    
    public int VitaMassima { get; protected set; }

    public Personaggio(string nome, int puntiVita)
    {
        this.Nome = nome;
        this.PuntiVita = puntiVita;
        this.VitaMassima = puntiVita;
    }

    public bool IsVivo => PuntiVita > 0;

    // ho messo il virtual perchè per ogni eroe le spoecifiche sono diverse quando sale di livello 
    public virtual void ApplicaBonusLivello()
    {
    }

    // Le classi figlie possono cambiarlo con override perche ad esempio il cavalgiere prima subisce danno alla corazza
    public virtual void RiceviAttacco(int danno)
    {
        if (danno <= 0) return;
        PuntiVita = Math.Max(0, PuntiVita - danno);
    }

    // Visulazzio lo stato del personaggio , la ripedo dopo ogni azione comodo e pratico 
    public virtual string Stato()
    {
        return $"{Nome}: vita {PuntiVita}/{VitaMassima}";
    }
}
