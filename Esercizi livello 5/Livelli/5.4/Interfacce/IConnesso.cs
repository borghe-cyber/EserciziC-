public interface IConnesso
{
    string IndirizzoIP { get; } // indirizzo IP in sola lettura
    string InfoRete() => $"Connesso a {IndirizzoIP}";   // default

}

