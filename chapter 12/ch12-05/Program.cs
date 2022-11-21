using System;
using System.Drawing;

namespace ch12_05 {
    internal class Program {
        public static void Main(string[] args)
        {
            //Rectangle 객체 생성
            Rectangle rect1 = new Rectangle(10, 20, 60, 30);
            Rectangle rect2 = new Rectangle(60, 30, 50, 60);
            Rectangle rect3 = Rectangle.Intersect(rect1, rect2);    //rect1과 rect2의 교차 영역만을 가지는 Rectangle 객체

            Console.WriteLine("교차 영역: {0}", rect3.ToString());
            rect3 = Rectangle.Union(rect1, rect2);  //두 사각 영역을 전부 포함하는 가장 작은 영역 반환
            Console.WriteLine("  합 영역: {0}", rect3.ToString());
            rect3.Offset(10, 20);   //사각 영역의 위치 이동
            Console.WriteLine("이동 영역: {0}", rect3.ToString());
            rect3.Inflate(20, 20);  //Rectangle을 지정한 크기만큼 확장한 값 반환
            Console.WriteLine("확장 영역: {0}", rect3.ToString());
        }
    }
}
