using System;

delegate void SampleDelegate();     //델리케이트 정의
class DelegateClass
{
    public void DelegateMethod()    //델리게이트할 메소드
    {
        Console.WriteLine("In the DelegateClass.DelegateMethod ...");
    }
}

class DelegateApp
{
    public static void Main()
    {
        DelegateClass obj = new DelegateClass();
        SampleDelegate sd = new SampleDelegate(obj.DelegateMethod); //델리게이트에 메소드 연결
        sd();   //obj.DelegateMethod() 호출
    }
}
