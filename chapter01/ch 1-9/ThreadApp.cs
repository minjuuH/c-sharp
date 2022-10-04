using System;
using System.Threading;         //멀티스레드를 지원하기 위해 제공된 네임스페이스

class ThreadApp
{
    static void ThreadBody()    //스레드 몸체
    {
        Console.WriteLine("In the thread body ...");
    }
    public static void Main()
    {
        ThreadStart ts = new ThreadStart(ThreadBody);   //델리게이트 객체 생성
        Thread t = new Thread(ts);                      //스레드 객체 생성
        Console.WriteLine("*** Start of Main");
        t.Start();  //Start() 메소드 호출 -> 스레드 실행 시작
        Console.WriteLine("*** End of Main");
    }
}