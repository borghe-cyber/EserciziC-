namespace Esercizi_livello_3.Esercizio3_3;

// Crea una static class ConvertitoreTemperatura con metodi CelsiusToFahrenheit, FahrenheitToCelsius, CelsiusToKelvin. 
// Poi crea una classe Termometro che conserva la temperatura sempre in Celsius ed espone le proprietà calcolate Fahrenheit e Kelvin (solo get).

public static class Esercizio
{
    public static void Esegui()
    {
        Console.WriteLine("Esercizio 3.3");

        
        Console.WriteLine();
        Console.WriteLine("1) ConvertitoreTemperatura");
        Console.WriteLine("100 °C → " + ConvertitoreTemperatura.CelsiusToFahrenheit(100) + " °F");
        Console.WriteLine("212 °F → " + ConvertitoreTemperatura.FahrenheitToCelsius(212) + " °C");
        Console.WriteLine("0 °C   → " + ConvertitoreTemperatura.CelsiusToKelvin(0) + " K");
       

        Console.WriteLine();
        Console.WriteLine("2) Termometro");
        Termometro t = new Termometro(20);
        Console.WriteLine(t);

        t.Celsius = 36.6;   
        Console.WriteLine(t);   

        Console.WriteLine("Solo Fahrenheit: " + t.Fahrenheit.ToString("0.##"));
        Console.WriteLine("Solo Kelvin:     " + t.Kelvin.ToString("0.##"));
        

        
        Console.WriteLine();
        Console.WriteLine("3) Termometro da Fahrenheit");
        Termometro t2 = Termometro.DaFahrenheit(98.6);
        Console.WriteLine(t2);   

        
        Console.WriteLine();
        Console.WriteLine("4) zero assoluto");
        try
        {
            Termometro t3 = new Termometro(-300);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Errore: " + ex.Message);
        }
    }
}
