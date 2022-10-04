using System;

//제네릭 클래스(범용 클래스) : 자료형을 매개변수로 가지는 클래스
//형 매개변수: 자료형에 해당하는 형 매개변수, <> 안에 기술
class Stack<StackType>
{
    private StackType[] stack = new StackType[100];
    private int sp = -1;
    public void Push(StackType element)
    {
        stack[++sp] = element;
    }
    public StackType Pop()
    {
        return stack[sp--];
    }
}

class GenericClass
{
    public static void Main()
    {
        Stack<int> stk1 = new Stack<int>();         //정수형 스택
        Stack<double> stk2 = new Stack<double>();   //실수형 스택
        stk1.Push(1);   stk1.Push(2); stk1.Push(3);
        Console.WriteLine($"interger stack : {stk1.Pop()} {stk1.Pop()} {stk1.Pop()}");
        stk2.Push(1.5); stk2.Push(2.5); stk2.Push(3.5);
        Console.WriteLine($"  double stack : {stk2.Pop()} {stk2.Pop()} {stk2.Pop()}");
    }
}