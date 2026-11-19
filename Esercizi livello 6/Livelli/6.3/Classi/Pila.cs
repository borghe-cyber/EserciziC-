namespace Esercizi_livello_6.Esercizio6_3;

using System.Collections;


public class Pila<T> : IEnumerable<T>
{
    private T[] _elementi;
    private int _count;

    public Pila(int capacitaIniziale = 4)
    {
        if (capacitaIniziale < 1)
            throw new ArgumentOutOfRangeException(nameof(capacitaIniziale), "La capacità deve essere almeno 1");

        _elementi = new T[capacitaIniziale];
        _count = 0;
    }

    public int Count => _count;

    public bool IsEmpty => _count == 0;

    // Solo per vedere il raddoppio in azione
    public int Capacita => _elementi.Length;

    public void Push(T elemento)
    {
        if (_count == _elementi.Length)
        {
            // Array pieno: ne creo uno grande il doppio e ci copio dentro i vecchi elementi
            T[] nuovo = new T[_elementi.Length * 2];
            Array.Copy(_elementi, nuovo, _count);
            _elementi = nuovo;
        }

        _elementi[_count] = elemento;
        _count++;
    }

    public T Pop()
    {
        if (IsEmpty)
            throw new InvalidOperationException("Impossibile fare Pop: la pila è vuota");

        _count--;
        T elemento = _elementi[_count];
        _elementi[_count] = default!; // libero il riferimento (utile con i tipi riferimento)
        return elemento;
    }

    public T Peek()
    {
        if (IsEmpty)
            throw new InvalidOperationException("Impossibile fare Peek: la pila è vuota");

        return _elementi[_count - 1];
    }

    
    public IEnumerator<T> GetEnumerator()
    {
        for (int i = _count - 1; i >= 0; i--)
        {
            yield return _elementi[i];
        }
    }

    
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
