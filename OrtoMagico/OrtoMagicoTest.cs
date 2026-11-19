// Le attività del contadino: crea l'orto, innaffia, raccoglie e conta
public class OrtoMagicoTest
{
    public static void Esegui()
    {
        Random random = new Random();
        List<Ortaggio> orto = new List<Ortaggio>();

        // Semina: numero casuale di ortaggi per tipo (da 1 a 5)
        int numZucchine = random.Next(1, 6);
        int numPeperoni = random.Next(1, 6);
        int numPomodori = random.Next(1, 6);

        for (int i = 0; i < numZucchine; i++)
            orto.Add(new Zucchina(200 + random.Next(0, 100), 15 + random.Next(0, 10)));
        for (int i = 0; i < numPeperoni; i++)
            orto.Add(new Peperone("Giallo", 150 + random.Next(0, 60), random.Next(0, 2) == 1));
        for (int i = 0; i < numPomodori; i++)
            orto.Add(new Pomodoro("San Marzano", 80 + random.Next(0, 30)));

        Console.WriteLine($"\n=== L'Orto Magico: {numZucchine} zucchine, {numPeperoni} peperoni, {numPomodori} pomodori ===\n");

        int acerbi = 0, maturi = 0, marci = 0;

        foreach (Ortaggio ortaggio in orto)
        {
            // Innaffia un numero casuale di volte (da 0 a 10)
            int volte = random.Next(0, 11);
            Console.WriteLine($"{ortaggio.nome} innaffiato {volte} volte (giuste: {ortaggio.InnaffiateGiuste})");
            for (int i = 0; i < volte; i++)
            {
                ortaggio.Innaffia();
            }

            int valore = ortaggio.Raccogli();
            if (valore < 0)
            {
                acerbi++;
                Console.WriteLine($"  -> raccolto ACERBO (valore {valore})");
            }
            else if (valore == 0)
            {
                maturi++;
                Console.WriteLine($"  -> raccolto MATURO (valore {valore})");
            }
            else
            {
                marci++;
                Console.WriteLine($"  -> raccolto MARCIO (valore {valore})");
            }
        }

        Console.WriteLine($"\nRisultato: {acerbi} acerbi, {maturi} maturi, {marci} marci");
    }
}
