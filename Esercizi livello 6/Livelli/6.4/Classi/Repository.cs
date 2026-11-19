namespace Esercizi_livello_6.Esercizio6_4;

public class Repository<T> where T : IEntita
{
    private readonly Dictionary<int, T> _elementi = new Dictionary<int, T>();

    public int Count => _elementi.Count;

    public void Aggiungi(T elemento)
    {
        if (_elementi.ContainsKey(elemento.Id))
            throw new InvalidOperationException($"Esiste già un elemento con Id {elemento.Id}");

        _elementi.Add(elemento.Id, elemento);
    }

    public T? TrovaPerId(int id)
    {
        if (_elementi.TryGetValue(id, out T? elemento))
            return elemento;

        return default;
    }

    public IReadOnlyList<T> TuttiGliElementi()
    {
        return _elementi.Values.ToList();
    }

    public bool Elimina(int id)
    {
        return _elementi.Remove(id);
    }
}
