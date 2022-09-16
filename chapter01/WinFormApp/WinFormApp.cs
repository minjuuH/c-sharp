using System;
using System.Windows.Forms; //그냥 입력했을 때 참조 오류가 발생 -> 참조에 System.Windows.Forms.dll을 추가해줌

class WinFormApp : Form     //Form 클래스 상속
{
    WinFormApp()    //생성자
    {
        this.Text = "Hello!";  //타이틀 이름
    }
    public static void Main()
    {
        Application.Run(new WinFormApp());  //윈도우창 생성
        //Application : 애플리케이션을 시작 및 중지하기 위한 메서드
        //Application.Run(Form) : 애플리케이션 루프를 실행하고 지정한 Form을 표시
    }
}
