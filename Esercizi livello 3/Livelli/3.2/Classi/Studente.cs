// Il controllo sta dentro la proprietà, non sparso nei metodi. Se domani aggiungi un metodo CompiAnni() che fa Età = Età + 1;
//  è controllato automaticamente: se lo studente ha 99 anni, scatta l'eccezione.
// Con il modo del costruttore dovresti ricordarti di ripetere lo stesso if in ogni metodo che modifica l'età.
// Prima o poi ne dimentichi uno, e un dato sbagliato entra.
// Inoltre, se un giorno la regola cambia (per esempio l'età minima diventa 16), modifichi una riga sola.

public class Studente
{
    // static: appartiene alla CLASSE, non al singolo studente → è uno solo, condiviso da tutti
    private static int contatore = 0;
    public static int NumeroStudenti { get { return contatore; } }

    public string Matricola { get; }   // solo get: si assegna nel costruttore e poi non cambia più

    public string Nome;

    private int età;        // campo privato: qui sta davvero il valore dell'età
    private decimal media;  // campo privato: qui sta davvero il valore della media

    public int Età
    {
        get { return età; }
        set
        {
            if (value < 14 || value > 99)
            {
                throw new ArgumentOutOfRangeException(nameof(Età), "L'età deve essere tra 14 e 99.");
            }
            età = value;
        }
    }

    public decimal Media
    {
        get { return media; }
        set
        {
            if (value < 0 || value > 10)
            {
                throw new ArgumentOutOfRangeException(nameof(Media), "La media deve essere tra 0 e 10.");
            }
            media = value;
        }
    }

    public Studente(string Nome,int Età,decimal Media)
    {
        this.Nome=Nome;
        this.Età=Età;
        this.Media=Media;

        // in fondo: se Età o Media non sono validi, l'eccezione esce prima
        // e il numero di matricola non viene "bruciato"
        contatore++;
        Matricola = "S" + contatore.ToString("D4");   // D4 = 4 cifre con zeri davanti → S0001
    }


}