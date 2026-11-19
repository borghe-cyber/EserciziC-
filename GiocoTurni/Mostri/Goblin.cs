namespace GiocoTurni.Nemici;

public class Goblin : Nemico
{
    // si sceglie il livello dopo , vita e danni sono gia fissi 
    public Goblin(int livello) : base(30, 10, livello)
    {
    }
}
