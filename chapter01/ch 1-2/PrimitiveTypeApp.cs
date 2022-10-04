using System;

class PrimitiveTypeApp
{
    public static void Main()
    {
        bool b;
        int i = int.MaxValue;   //signed int max 값 저장
        uint j = uint.MaxValue; //unsigned int max 값 저장
        double d = double.MaxValue; //double max 값 저장
        b = (i != 0);   //i는 max 값으로 0이 아니기 때문에 true 저장
        Console.WriteLine($"boolean b = {b}");
        Console.WriteLine($"Max value of signed integer = {i}");
        Console.WriteLine($"Max value of unsigned integer = {j}");
        Console.WriteLine($"Max value of double = {d}");
    }
}
