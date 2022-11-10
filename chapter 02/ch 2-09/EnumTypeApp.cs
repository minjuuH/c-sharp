using System;

enum Color { Red, Green, Blue };    //열거형

class EnumTypeApp
{
    public static void Main()
    {
        Color c = Color.Red;
        c++;
        int i = (int)c;
        Console.WriteLine($"Cardinality of {c} = {i}");
    }
}