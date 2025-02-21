using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy4
{
    class Program
    {
        static void Main(string[] args)
        {
            ////문자열
            //string greeting;
            //greeting = "Hello, World!";

            //Console.WriteLine(greeting); //출력 : Hello, world!

            //전체 주석 cirl + /

            /*
            //변수 선언과 초기화를 한 번에 수행
            int score = 100; //정수형 변수 선언과 동시에 100으로 초기화
            double temperature = 36.5; // 실수형 변수 선언과 초기화
            string city = "Seoul"; //문자열 변수 선언과 초기화

            //변수 출력
            Console.WriteLine(score); //출력 100
            Console.WriteLine(temperature); //출력 36.5
            Console.WriteLine(city); //출력 Seoul
            */

            /*
            //같은 데이터 타입의 변수를 쉼표로 구분해서 선언
            int x = 10, y = 20, z = 30; //정수형 변수를 x,y,z를 선언하고 초기화

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            */

            /*
            //상수
            const double Pi = 3.14159; //상수 pi 선언 및 초기화
            const int MaxScore = 100; //정수형 상수 선언

            //출력
            Console.WriteLine("Pi: " + Pi); //출력 Pi: 3.14159
            Console.WriteLine("MaxScore " + MaxScore); //출력 MaxScore: 100
            */

            int damge = 16755, hp = 78103, hit = 36, special = 1017, subdue = 41, swift = 611, patience = 22, skill = 39;

            Console.WriteLine("기본 특성");
            Console.WriteLine("공격력: " + damge);
            Console.WriteLine("최대 생명력: " + hp);

            Console.WriteLine("전투 특성");
            Console.WriteLine("치명: " + hit);
            Console.WriteLine("특화: " + special);
            Console.WriteLine("제압: " + subdue);
            Console.WriteLine("신속: " + swift);
            Console.WriteLine("인내: " + patience);
            Console.WriteLine("숙련: " + skill);

        }
    }
}
