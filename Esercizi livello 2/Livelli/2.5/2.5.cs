namespace Esercizi_livello_2.Esercizio2_5;



public static class Esercizio
{
    public static void Esegui()
    {
        Console.WriteLine("Esercizio 2.5");

        
        Console.WriteLine();
        Console.WriteLine("--- 1) int (tipo valore) ---");
        int a = 10;
        int b = a;      // b riceve una COPIA del valore di a
        b = 99;
        Console.WriteLine("a = " + a + ", b = " + b);   // a resta 10

        
        Console.WriteLine();
        Console.WriteLine("--- 2) struct (tipo valore) ---");
        PuntoStruct s1 = new PuntoStruct(1, 2);
        PuntoStruct s2 = s1;   // s2 è una COPIA di s1
        s2.X = 100;
        Console.WriteLine("s1 = " + s1 + ", s2 = " + s2);   // s1 non cambia

        
        Console.WriteLine();
        Console.WriteLine("--- 3) class (tipo riferimento) ---");
        PuntoClasse c1 = new PuntoClasse(1, 2);
        PuntoClasse c2 = c1;   // c2 punta allo STESSO oggetto di c1
        c2.X = 100;
        Console.WriteLine("c1 = " + c1 + ", c2 = " + c2);   // cambia anche c1!

        
        Console.WriteLine();
        Console.WriteLine("--- 4) passaggio a un metodo ---");
        PuntoStruct s3 = new PuntoStruct(5, 5);
        PuntoClasse c3 = new PuntoClasse(5, 5);

        SpostaStruct(s3);   // il metodo riceve una copia
        SpostaClasse(c3);   // il metodo riceve il riferimento allo stesso oggetto

        Console.WriteLine("struct dopo il metodo: " + s3);   // (5, 5)
        Console.WriteLine("class  dopo il metodo: " + c3);   // (6, 6)

        
        Console.WriteLine();
        Console.WriteLine("--- 5) confronto ---");
        PuntoClasse c4 = new PuntoClasse(1, 1);
        PuntoClasse c5 = new PuntoClasse(1, 1);
        PuntoClasse c6 = c4;
        Console.WriteLine("c4 == c5: " + (c4 == c5));   // False: stessi valori, oggetti diversi
        Console.WriteLine("c4 == c6: " + (c4 == c6));   // True: stesso oggetto
    }

    static void SpostaStruct(PuntoStruct p)
    {
        p.X++;
        p.Y++;
    }

    static void SpostaClasse(PuntoClasse p)
    {
        p.X++;
        p.Y++;
    }
}
