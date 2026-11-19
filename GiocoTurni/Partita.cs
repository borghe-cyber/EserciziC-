using GiocoTurni.Nemici;
using GiocoTurni.Personaggi;

namespace GiocoTurni;

public class Partita
{
    private readonly List<Personaggio> eroi;   
    private readonly List<Nemico> mostri;     
    private readonly Random random = new Random();

    public Partita(List<Personaggio> eroi, List<Nemico> mostri)
    {
        this.eroi = eroi;
        this.mostri = mostri;
    }

    private bool Vittoria => mostri.All(m => !m.IsVivo);

    
    private bool Sconfitta => eroi.All(e => !e.IsVivo);

    public void Gioca()
    {
        Console.WriteLine($"La squadra affronta {mostri.Count} mostri!");
        int turno = 1;

        while (!Vittoria && !Sconfitta)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;   // viola
            Console.WriteLine($"\n===== TURNO {turno} =====");
            Console.ResetColor();
            MostraStato(); // lo ripeto dopo ogni attacco da parte sia dei mostro che degli eroi 

            // Turno degli eroi: agisce ognuno degli eroi vivi , per ora è in ordine 
            foreach (var eroe in eroi)
            {
                if (!eroe.IsVivo) continue;
                if (Vittoria) break; // mostri già tutti morti, inutile continuare

                if (eroe is Cavaliere cavaliere)
                {
                    TurnoCavaliere(cavaliere);
                }
                else if (eroe is Mago mago)
                {
                    TurnoMago(mago);
                }
            }

            if (Vittoria) break;

           
            // Ogni mostro vivo attacca un eroe vivo a caso // Dentro AttaccoCasualeMostro contiene la Random con il numero massimo ovviamente conta nella lista degli eroi
            Console.ForegroundColor = ConsoleColor.Red;   
            Console.WriteLine("\n--- Turno dei mostri ---");
            Console.ResetColor();                          

            foreach (var mostro in mostri)
            {
                if (!mostro.IsVivo) continue;
                if (Sconfitta) break;

                Personaggio bersaglio = AttaccoCasualeMostro();
                mostro.Attacca(bersaglio);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{mostro.Nome} attacca {bersaglio.Nome} ({mostro.Danno} danni)!");

                if (!bersaglio.IsVivo)
                {
                    Console.WriteLine($"{bersaglio.Nome} è caduto!");
                }
                Console.ResetColor();

                MostraStato();
            }

            turno++;
        }

        Console.WriteLine("\n===== FINE PARTITA =====");
        MostraStato();

        if (Vittoria)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Vittoria! Tutti i mostri sono stati abbattuti.");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine("Sconfitta... tutti gli eroi sono caduti.");
        }
    }

    private void MostraStato()
    {
        Console.WriteLine("\nEroi:");
        foreach (var eroe in eroi)
        {
            Console.WriteLine("  " + eroe.Stato() + (eroe.IsVivo ? "" : " [MORTO]"));
        }

        int vivi = mostri.Count(m => m.IsVivo);
        Console.WriteLine($"Mostri ({vivi}/{mostri.Count} vivi):");
        foreach (var mostro in mostri)
        {
            Console.WriteLine("  " + mostro.Stato() + (mostro.IsVivo ? "" : " [MORTO]"));
        }
    }

    // Mostra i mostri vivi numerati e fa scegliere quale colpire
    private Nemico ScegliMostro()
    {
        List<Nemico> vivi = mostri.Where(m => m.IsVivo).ToList();

        // Un solo mostro vivo: niente scelta, si attacca lui
        if (vivi.Count == 1)
        {
            return vivi[0];
        }

        Console.WriteLine("Quale mostro vuoi colpire?");
        for (int i = 0; i < vivi.Count; i++)
        {
            Console.WriteLine($"{i + 1}) {vivi[i].Stato()}");
        }

        int scelta = LeggiScelta(vivi.Count);
        return vivi[scelta - 1]; // la lista parte da 0, le scelte da 1
    }

    private Personaggio AttaccoCasualeMostro()
    {
        List<Personaggio> vivi = eroi.Where(e => e.IsVivo).ToList();
        return vivi[random.Next(vivi.Count)];
    }

    // Se il mostro è morto lo segnala e dà l'esperienza all'eroe che l'ha abbattuto
    private void SegnalaSeMorto(Nemico mostro, Personaggio eroe, SistemaLivelli livelli)
    {
        if (!mostro.IsVivo)
        {
            Console.WriteLine($"{mostro.Nome} è stato abbattuto!");

            int esperienza = mostro.EsperienzaRilasciata;
            int livelliGuadagnati = livelli.AggiungiEsperienza(esperienza);
            Console.WriteLine($"{eroe.Nome} guadagna {esperienza} punti esperienza.");

            if (livelliGuadagnati > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{eroe.Nome} sale al livello {livelli.Livello}! La vita torna al massimo.");
                Console.ForegroundColor = ConsoleColor.Blue; 
            }
        }
    }

    private void TurnoCavaliere(Cavaliere cavaliere)
    {
        Console.WriteLine($"\nTocca a {cavaliere.Nome} (Cavaliere)");
        Console.WriteLine($"1) Attacca ({cavaliere.Danno} danni)");
        Console.WriteLine("2) Difendi (+25 armatura)");

        // Si ripete la domanda finché il cavaliere non sceglie un'azione che può fare
        while (true)
        {
            int scelta = LeggiScelta();
            if (scelta == 1)
            {
                Nemico bersaglio = ScegliMostro();
                cavaliere.Attacca(bersaglio);

                Console.ForegroundColor = ConsoleColor.Blue;   // attacco degli eroi in blu
                Console.WriteLine($"{cavaliere.Nome} colpisce {bersaglio.Nome} con la spada!");
                SegnalaSeMorto(bersaglio, cavaliere, cavaliere.Livelli);
                Console.ResetColor();

                MostraStato();
                return;
            }
            else
            {
                
                if (cavaliere.Armatura >= cavaliere.ArmaturaMassima)
                {
                    Console.WriteLine("L'armatura è già al massimo! Scegli un'altra azione.");
                    continue;
                }

                cavaliere.Difendi();
                Console.WriteLine($"{cavaliere.Nome} alza lo scudo e recupera armatura.");
                return;
            }
        }
    }

    private void TurnoMago(Mago mago)
    {
        Console.WriteLine($"\nTocca a {mago.Nome} (Mago)");

        // Senza mana il mago non può fare niente 
        if (mago.Mana < 10)
        {
            Console.WriteLine($"{mago.Nome} ha finito il mana e salta il turno!");
            return;
        }

        Console.WriteLine($"1) Attacco magico ({mago.DannoMagico} danni, costa 10 mana)");
        Console.WriteLine("2) Cura (+20 vita, costa 20 mana)");

        // Ripete la domanda finché il mago non sceglie un'azione che può fare
        while (true)
        {
            int scelta = LeggiScelta();

            if (scelta == 1)
            {
                Nemico bersaglio = ScegliMostro();
                mago.AttaccoMagico(bersaglio, mago.DannoMagico);

                Console.ForegroundColor = ConsoleColor.Blue;   // attacco degli eroi in blu
                Console.WriteLine($"{mago.Nome} lancia una palla di fuoco su {bersaglio.Nome}!");
                SegnalaSeMorto(bersaglio, mago, mago.Livelli);
                Console.ResetColor();

                MostraStato();
                return;
            }
            else
            {
                if (mago.Mana < 20)
                {
                    Console.WriteLine("Mana insufficiente per curarsi! Scegli un'altra azione.");
                    continue;
                }
                mago.RigeneraVita();
                Console.WriteLine($"{mago.Nome} si cura.");
                return;
            }
        }
    }

   
    private static int LeggiScelta(int massimo = 2)
    {
        while (true)
        {
            Console.Write("Scelta: ");
            string? input = Console.ReadLine();

            if (input == null) return 1;

            
            if (int.TryParse(input, out int numero) && numero >= 1 && numero <= massimo)
                return numero;

            Console.WriteLine($"Scelta non valida, scrivi un numero da 1 a {massimo}.");
        }
    }
}
