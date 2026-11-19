const string RESULT_CHARGE_LABEL = "Carica batteria al";

Console.WriteLine("Recupero valore batteria...");

var rnd = new Random();
int batteryLevel = rnd.Next(0, 101);
bool inCharge = rnd.Next(0, 10) <= 5;

Console.WriteLine($"Valore letto: {batteryLevel} ({(inCharge ? "In carica" : "Non in carica")})");

Console.ForegroundColor = batteryLevel switch
{
    < 25 => ConsoleColor.Red,
    < 50 => ConsoleColor.Yellow,
    < 75 => ConsoleColor.Green,
    _    => ConsoleColor.Magenta
};

Console.WriteLine($"{RESULT_CHARGE_LABEL} {batteryLevel} %");
if (inCharge)
    Console.WriteLine("Caricamento in corso...");

Console.ResetColor();