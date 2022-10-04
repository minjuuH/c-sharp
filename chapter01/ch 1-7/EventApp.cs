using System;

delegate void MyEventHandler(); //이벤트 처리기를 위한 델리게이트 정의
// -> C#에서 기본 제공하는 System.EventHandler 델리게이트 사용 시 생략

class EventApp
{
    public EventHandler MyEvent;                    //이벤트 선언
    void MyEventHandler(object sender, EventArgs e) //이벤트 처리기 작성
    {
        Console.WriteLine("Hello world");
    }
    public EventApp()       //생성자
    {
        this.MyEvent += new EventHandler(MyEventHandler);   //이벤트 처리기 등록
    }
    public void InvokeEvent()
    {
        if (MyEvent != null)
            MyEvent(this, null);                    //이벤트 발생
    }
    public static void Main()
    {
        new EventApp().InvokeEvent();
    }
}
