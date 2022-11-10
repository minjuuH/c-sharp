using System;
using System.Text;  //StringBuilder 클래스 사용을 위한 네임스페이스

class StringApp
{
    public static void Main()
    {
        StringApp obj = new StringApp();
        string str = "Class name is ";
        Console.WriteLine(str + obj.ToString());
        //ToString(): System.Object 클래스 내에 정의
        StringBuilder sb = new StringBuilder();
        sb.Append(str); sb.Append(obj.ToString());
        Console.WriteLine(sb);
    }
}