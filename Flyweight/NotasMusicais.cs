using System;
using DesignPattern2.Flyweight;

public class NotasMusicais
{
    private static Dictionary<string, INota> notas = new Dictionary<string, INota>()
    {
        {"do", new Do() },
        {"re", new Re() },
        {"mi", new Mi() },
        {"fa", new Fa() },
        {"sol", new Sol() },
        {"la", new La() },
        {"si", new Si() }
    };


    public INota Pega(string nota)
    {
        return notas[nota];
    }

}
