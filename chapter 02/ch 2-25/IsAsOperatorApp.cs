using System;

class IsAsOperatorApp
{
    static void IsOperator(object obj)
    {
        //obj is (자료형) -> obj를 해당 자료형으로 바꿀 수 있는지 bool 값 반환
        Console.WriteLine($"{obj} is int: {(obj is int)}");
        Console.WriteLine($"{obj} is string: {(obj is string)}");
    }
    static void AsOperator(object obj)
    {
        //obj as (자료형) -> obj를 해당 자료형으로 변환한 값 반환
        //변환할 수 없다면 null 값 반환
        Console.WriteLine($"{obj} as string == null: {(obj as string == null)}");
    }
    public static void Main()
    {
        IsOperator(10);
        IsOperator("ABC");
        AsOperator(10);
        AsOperator("ABC");
    }
}