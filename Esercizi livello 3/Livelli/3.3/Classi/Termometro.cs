namespace Esercizi_livello_3.Esercizio3_3;

// Il termometro salva UN SOLO valore: i gradi Celsius.
// Fahrenheit e Kelvin non sono salvati da nessuna parte: vengono CALCOLATI ogni volta che li leggi.
// Così non possono mai essere "disallineati" rispetto ai Celsius.
public class Termometro
{
    public const double ZeroAssoluto = -273.15;   // sotto questa temperatura non si può andare

    private double celsius;

    public double Celsius
    {
        get { return celsius; }
        set
        {
            if (value < ZeroAssoluto)
            {
                throw new ArgumentOutOfRangeException(nameof(Celsius), "La temperatura non può essere sotto lo zero assoluto (" + ZeroAssoluto + " °C).");
            }
            celsius = value;
        }
    }

    // proprietà calcolate: solo get, nessun campo dietro
    public double Fahrenheit
    {
        get { return ConvertitoreTemperatura.CelsiusToFahrenheit(celsius); }
    }

    public double Kelvin
    {
        get { return ConvertitoreTemperatura.CelsiusToKelvin(celsius); }
    }

    public Termometro(double celsius)
    {
        Celsius = celsius;   // passa dal set → controllo zero assoluto
    }

    // Per creare un termometro partendo dai Fahrenheit: converte e salva comunque in Celsius
    public static Termometro DaFahrenheit(double fahrenheit)
    {
        return new Termometro(ConvertitoreTemperatura.FahrenheitToCelsius(fahrenheit));
    }

    public override string ToString()
    {
        return Celsius.ToString("0.##") + " °C = "
            + Fahrenheit.ToString("0.##") + " °F = "
            + Kelvin.ToString("0.##") + " K";
    }
}
