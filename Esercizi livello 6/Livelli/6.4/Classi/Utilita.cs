namespace Esercizi_livello_6.Esercizio6_4;

public static class Utilita
{
    public static T Massimo<T>(IEnumerable<T> elementi) where T : IComparable<T>
    {
        using IEnumerator<T> it = elementi.GetEnumerator();

        if (!it.MoveNext())
            throw new InvalidOperationException("Impossibile calcolare il massimo: la sequenza è vuota");

        T massimo = it.Current;

        while (it.MoveNext())
        {
            if (it.Current.CompareTo(massimo) > 0)
                massimo = it.Current;
        }

        return massimo;
    }
}
