public abstract class Forma
{
    public abstract double CalcolaArea();
    public abstract double CalcolaPerimetro();

    public string Descrivi()
    {
        return $"{GetType().Name} - Area: {CalcolaArea():F2}, Perimetro: {CalcolaPerimetro():F2}";
    }
    

}