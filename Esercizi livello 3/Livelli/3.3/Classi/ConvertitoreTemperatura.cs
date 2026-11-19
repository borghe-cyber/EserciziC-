namespace Esercizi_livello_3.Esercizio3_3;

// static class: non si può fare "new ConvertitoreTemperatura()".
// Contiene solo metodi static, che si chiamano con il nome della classe:
// ConvertitoreTemperatura.CelsiusToFahrenheit(100)
// Ha senso perché convertire non richiede di ricordare nessun dato: entra un numero, esce un numero.
public static class ConvertitoreTemperatura
{
    public static double CelsiusToFahrenheit(double celsius)
    {
        return celsius * 9 / 5 + 32;
    }

    public static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    public static double CelsiusToKelvin(double celsius)
    {
        return celsius + 273.15;
    }
}
