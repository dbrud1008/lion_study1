using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//네임스페이스
//클래스, 함수, 변수 이름이 충돌하는 것을 방지하기 위해 사용

namespace dev1
{
    class MyClass
    {
        public static void SayHello()
        {
            //Console.WriteLine("안녕하세요 !MyNamespace의 MyClass입니다.");
        }
    }
}

namespace lionstudy27
{
    class Program
    {

        //일반적인 함수
        static int Add(int a, int b)
        {
            return a + b;
        }

        //화살표 함수
        static int AddArrow(int a, int b) => a + b; //한 줄로 표현
            //중괄호 {} return 생략 가능


        //일반적인 함수
        static void PrintMessage()
        {
            Console.WriteLine("하이요");
        }

        //화살표 함수
        static void PrintMessageArrow() => Console.WriteLine("하잉");
        
        static void Main(string[] args)
        {
            //dev1.MyClass.SayHello();


            //C# 화살표 함수
            //C#에서 화살표 함수 => 람다 표현식이라고도 함
            //간결한 방식으로 함수를 정의할 수 있다.
            Console.WriteLine(Add(3, 5));
            Console.WriteLine(AddArrow(3, 5));

            PrintMessage();
            PrintMessageArrow();
        }
    }
}
