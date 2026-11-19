namespace Esercizi_livello_3.Esercizio3_4;

// Classe IMMUTABILE: una volta creata, una Data non cambia mai.
// - le proprietà hanno solo get (niente set): si assegnano solo nel costruttore
// - i metodi che "modificano" restituiscono una NUOVA Data
public class Data
{
    public int Giorno { get; }
    public int Mese { get; }
    public int Anno { get; }

    public Data(int giorno, int mese, int anno)
    {
        Controlla(giorno, mese, anno);   // se i valori non vanno bene, l'eccezione esce qui
        Giorno = giorno;
        Mese = mese;
        Anno = anno;
    }

    // ---------- metodi static: servono alla classe, non a una data in particolare ----------

    // Bisestile se divisibile per 4, ma non per 100, a meno che non sia divisibile per 400.
    // 2024 sì, 2023 no, 1900 no, 2000 sì.
    public static bool Bisestile(int anno)
    {
        return (anno % 4 == 0 && anno % 100 != 0) || anno % 400 == 0;
    }

    public static int GiorniNelMese(int mese, int anno)
    {
        switch (mese)
        {
            case 2:
                return Bisestile(anno) ? 29 : 28;
            case 4:
            case 6:
            case 9:
            case 11:
                return 30;
            default:
                return 31;
        }
    }

    public static void Controlla(int giorno, int mese, int anno)
    {
        if (anno < 1)
        {
            throw new ArgumentOutOfRangeException(nameof(anno), "L'anno deve essere almeno 1.");
        }
        if (mese < 1 || mese > 12)
        {
            throw new ArgumentOutOfRangeException(nameof(mese), "Il mese deve essere tra 1 e 12.");
        }
        int massimo = GiorniNelMese(mese, anno);
        if (giorno < 1 || giorno > massimo)
        {
            throw new ArgumentOutOfRangeException(nameof(giorno),
                "Il giorno deve essere tra 1 e " + massimo + " per " + mese + "/" + anno + ".");
        }
    }

    // ---------- AggiungiGiorni: NON modifica questa data, ne crea una nuova ----------

    // Funziona anche con n negativo (torna indietro).
    public Data AggiungiGiorni(int n)
    {
        // copie locali: le proprietà sono solo get, quindi non potremmo cambiarle comunque
        int g = Giorno;
        int m = Mese;
        int a = Anno;

        // avanti
        while (n > 0)
        {
            int rimastiNelMese = GiorniNelMese(m, a) - g;
            if (n <= rimastiNelMese)
            {
                g += n;
                n = 0;
            }
            else
            {
                n -= rimastiNelMese + 1;   // salto al primo giorno del mese dopo
                g = 1;
                m++;
                if (m > 12)
                {
                    m = 1;
                    a++;
                }
            }
        }

        // indietro
        while (n < 0)
        {
            if (-n < g)
            {
                g += n;
                n = 0;
            }
            else
            {
                n += g;                    // salto all'ultimo giorno del mese prima
                m--;
                if (m < 1)
                {
                    m = 12;
                    a--;
                }
                g = GiorniNelMese(m, a);
            }
        }

        return new Data(g, m, a);
    }

    // ToString scritto a mano (nel record lo genera il compilatore)
    public override string ToString()
    {
        return Giorno.ToString("D2") + "/" + Mese.ToString("D2") + "/" + Anno;
    }
}
