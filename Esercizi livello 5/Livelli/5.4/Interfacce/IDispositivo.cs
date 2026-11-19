public interface IDispositivo
{
    string Nome { get; } // nome in sola lettura 
    bool Acceso { get; } // stato in sola lettura 
    void Accendi();
    void Spegni();
    string Stato(); // metodo: restituisce lo stato attuale come testo
}
