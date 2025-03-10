using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy29
{
    struct Rectangle
    {
        public int width;
        public int height;

        public int GetArea() => width * height;
    }

    struct Point
    {
        public int x;
        public int y;
    }

    class Program
    {

        //C# 구조체
        //클래스와 비슷하지만, 값 타입(Value Type)이며 가볍고 빠름
        //주로 간단한 데이터 묶음을 만들때 사용

        //struct Point
        //{
        //    //public : 어디서든 사용가능하게 권한
        //    //private : 나만 사용하려고 하는 키워드
        //    public int X;
        //    public int Y;

        //    //생성자 정의 -> 처음에 생성할 때 동작하는 함수
        //    public Point(int x, int y)
        //    {
        //        X = x;
        //        Y = y;
        //    }
        //    public void Print()
        //    {
        //        Console.WriteLine($"좌표: {X}, {Y}");
        //    }
        //}


        //문제
        //구조체를 이용해서 학생 3명의 이름 성적을 받고 국어,영어,수학을 출력하시오.
        //이름     국어    영어    수학
        //홍길동    100     80      70
        //홍길동    100     80      70
        //홍길동    100     80      70
        struct Student
        {
            public string name;
            public int iKor;
            public int iEng;
            public int iMath;

            //학생 정보를 출력하는 함수
            public void Print()
            {
                //-10은 왼쪽에서부터 10칸을 밀어주겠다 (한글은 2칸으로 간주)
                Console.WriteLine($"{name,-5} {iKor,5} {iEng,5} {iMath,5}");
            }
        }


        
        //struck Point는 X,Y좌표 값을 저장하는 구조체
        //구조체는 클래스와 다르게 new 없이 사용 가능
        static void Main(string[] args)
        {
            //Point p; //구조체 선언 (초기화 필요)

            //p.X = 10;
            //p.Y = 20;

            //p.Print();

            //Point p1 = new Point(5, 15);
            //p1.Print();


            //1번 방법
            //var reck = new Rectangle { width = 5, height = 4 };
            //2번 방법
            //Rectangle rect;
            //rect.width = 10;
            //rect.height = 20;


            //Console.WriteLine($"Area : {rect.GetArea()}");


            //Point[] points = new Point[2];

            //points[0].x = 10;
            //points[0].y = 10;

            //points[1].x = 20;
            //points[1].y = 20;


            //foreach(var point in points)
            //{
            //    Console.WriteLine($"Point: ({point.x},{point.y})");
            //}


            //학생 배열 선언
            Student[] students = new Student[3];

            for(int i=0; i<students.Length; i++)
            {

                Console.WriteLine("학생성적을 입력하세요.");
                Console.Write("학생이름: ");
                students[i].name = Console.ReadLine();
                Console.Write("국어: ");
                students[i].iKor = int.Parse(Console.ReadLine());
                Console.Write("영어: ");
                students[i].iEng = int.Parse(Console.ReadLine());
                Console.Write("수학: ");
                students[i].iMath = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("이름       국어   영어  수학");
            
            foreach(Student std in students)
            {
                std.Print();
            }



        }
    }
}
