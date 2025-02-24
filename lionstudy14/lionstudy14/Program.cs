using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy14
{
    class Program
    {
        static void Main(string[] args)
        {
            ////조건문
            //int score = 85;
            //if (score >= 90) //점수가 90점 이상일 때
            //{
            //    Console.WriteLine("A학점");
            //}
            //else
            //{
            //    Console.WriteLine("B 학점");
            //}

            //string GameID = "멋사zl존";

            //if (GameID == "멋사zl존")
            //{
            //    Console.WriteLine("아이디가 일치합니다."); //true = 참
            //}
            //else
            //{
            //    Console.WriteLine("아이디가 일치하지 않습니다."); //flase = 거짓
            //}

            //int score = 75;

            //if (score >= 90)
            //{
            //    Console.WriteLine("A 학점");
            //}
            //else if (score >= 80)
            //{
            //    Console.WriteLine("B 학점");
            //}
            //else if (score >= 70)
            //{
            //    Console.WriteLine("C 학점");
            //}
            //else
            //{
            //    Console.WriteLine("F 학점");
            //}


            ////가지고 있는 소지금을 입력하세요
            //Console.Write("가지고 있는 소지금을 입력하세요: ");
            //int gold = int.Parse(Console.ReadLine());
            //int att = 0;

            //string GameID = "멋사검존";
            //Console.WriteLine("캐릭터: " + GameID);

            //if (gold > 600)
            //{
            //    Console.WriteLine("무기: 전설의 검");
            //    att = 7;
            //}
            //else if (gold > 500)
            //{
            //    Console.WriteLine("무기: 유령검");
            //    att = 6;
            //}
            //else if (gold > 400)
            //{
            //    Console.WriteLine("무기: 엑스칼리버");
            //    att = 5;
            //}
            //else if (gold > 300)
            //{
            //    Console.WriteLine("무기: 집판검");
            //    att = 4;

            //}
            //else if (gold > 200)
            //{
            //    Console.WriteLine("무기: 진은검");
            //    att = 3;

            //}
            //else if (gold > 100)
            //{
            //    Console.WriteLine("무기: 카타나");
            //    att = 2;
            //}
            //else
            //{
            //    Console.WriteLine("무기: 무한의대검");
            //    att = 1;
            //}

            //Console.WriteLine("공격력: 100 + " + att);



            //오후문제
            //문제1.세 정수의 최대값 구하기
            Console.Write("a의 값을 입력해주세요: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b의 값을 입력해주세요: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c의 값을 입력해주세요: ");
            int c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("최대값 : " + a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("최대값 : " + b);
            }
            else
            {
                Console.WriteLine("최대값 : " + c);
            }

            Console.WriteLine("================");

            //문제2. 점수에 따른 학점 평가
            Console.Write("점수를 입력해주세요: ");
            int score = int.Parse(Console.ReadLine());

            if (score >= 90)
            {
                Console.WriteLine("A학점");
            }
            else if (score >= 80)
            {
                Console.WriteLine("B학점");
            }
            else if (score >= 70)
            {
                Console.WriteLine("C학점");
            }
            else if (score >= 60)
            {
                Console.WriteLine("D학점");
            }
            else
            {
                Console.WriteLine("F학점");
            }
        }
    }
}
