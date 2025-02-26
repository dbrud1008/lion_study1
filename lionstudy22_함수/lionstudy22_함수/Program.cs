using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lionstudy22_함수
{
    class Program
    {
        //1단계 함수
        //반환형 함수이름 (매개변수)

        //키워드가 왜 붙는지? ? ?
        //-> 메모리 영역
        // 스택 (stack)   --> ex) int
        // 힙 (heap) --> new로 할당해주는 것, 개발자가 메모리를 직접 넣어주는 것
        // 정적 메모리 (static memory) --> static이 붙은..?

        //static int count = 0; //정적 메모리에 해당됨
        //프로그램 종료전까지 유지

        //c#에서 쓰는 방법
        //static void Print()
        //{
        //    //분할
        //    Console.WriteLine("로딩화면");
        //}

        static void Loading()
        {
            Console.WriteLine("로딩중.");
            Thread.Sleep(1000);
            Console.WriteLine("로딩중..");
            Thread.Sleep(1000);
            Console.WriteLine("로딩중...");
            Thread.Sleep(1000);
        }

        //2단계
        //입력
        static void AttackFunction(int Attack)
        {
            Console.WriteLine("공격력은 : " + Attack);
        }

        //3단계
        //출력
        static int BaseAttack() //택배를 보낼때 정수형으로 보내는 것 때문에 void가 아닌 int형으로 보낸다.
                                //보내는 거 없다: void
        {
            //기본공격력 10
            int attack = 10;

            return attack;
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            //count++;
            //Console.WriteLine(count);

            //Print(); //Main이 첫 실행인데 Print() 함수로 인해 Print()로 가서 실행하게 됨 -> 나눠서하기 때문에 가독성이 좋아짐
            //Console.WriteLine("메인화면");

            //Loading();
            //Console.WriteLine("게임을 시작합니다.");
            //Console.ReadLine();


            //int Attack = 0;
            //int BAttack = 0;
            //Console.WriteLine("캐릭터의 공격력을 입력: ");
            //Attack = int.Parse(Console.ReadLine());

            ////기본공격력
            //BAttack = BaseAttack();

            //AttackFunction(BAttack + Attack);


            //두 수를 더하는 함수를 만들어서 오류를 해결하세요.
            int result = Add(10, 20);
            Console.WriteLine($"10 + 20 = {result}");
        }
    }
}
