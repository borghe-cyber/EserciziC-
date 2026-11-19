namespace Esercizi_livello_4.Esercizio4_1;

// Veicoli
// Crea una classe base Veicolo (marca, modello, anno, metodo Descrizione()) e due classi derivate:
// Auto con numero di porte;
// Moto con cilindrata.
// I costruttori delle derivate devono chiamare quello della base con : base(marca, modello, anno).
// Ogni derivata fa override di Descrizione() aggiungendo le proprie informazioni, riusando il testo della base con base.Descrizione().

public static class Esercizio
{
    public static void Esegui()
    {
        Console.WriteLine("Esercizio 4.1");
        Moto moto1 = new Moto("Yamaha", "MT-07", 2021, 689);
        Macchina macchina1 = new Macchina("Fiat", "Panda", 2020, 5);
        Camion camion1 = new Camion("Mercedes", "Actros", 2019, 18000);

        moto1.DescrizioneMoto();
        macchina1.DescrizioneMacchina();
        camion1.DescrizioneCamion();

    }
}
