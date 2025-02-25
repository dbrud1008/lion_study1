using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lionstudy15
{
    class Program
    {
        static void Main(string[] args)
        {

            ////swtich문
            ////swtich와 if 차이 : 가독성의 차이. 
            //int day = 3;
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("월요일");
            //        break; //break가 있어야 멈춤, 없으면 멈추지 않고 쭉 보여짐
            //    case 2:
            //        Console.WriteLine("화요일");
            //        break;
            //    case 3:
            //        Console.WriteLine("수요일");
            //        break;
            //    case 4:
            //        Console.WriteLine("목요일");
            //        break;
            //    case 5:
            //        Console.WriteLine("금요일");
            //        break;
            //    default: //나머지
            //        Console.WriteLine("주말입니다.");
            //        break;


            ////캐릭터를 선택하세요 (1. 검사 2. 마법사 3. 도적)
            //Console.WriteLine("캐릭터를 선택하세요");
            //Console.WriteLine("1. 검사  2. 마법사  3. 도적");
            //int Chose = int.Parse(Console.ReadLine());

            //switch (Chose)
            //{
            //    case 1:
            //        Console.WriteLine("검사");
            //        Console.WriteLine("공격력 100");
            //        Console.WriteLine("방어력 90");
            //        break;
            //    case 2:
            //        Console.WriteLine("마법사");
            //        Console.WriteLine("공격력 110");
            //        Console.WriteLine("방어력 80");
            //        break;
            //    case 3:
            //        Console.WriteLine("도적");
            //        Console.WriteLine("공격력 115");
            //        Console.WriteLine("방어력 70");
            //        break;
            //    default: //나머지
            //        Console.WriteLine("잘못된 입력입니다.");
            //        break;
            //}


            ////반복문
            ////초기화 / 조건문 / 증감식
            //for (int i = 1; i <= 5; i++) //여긴 선위 후위 없음, 정수형 변수를 for 안에서 정의하고, i가 5보다 작거나 같을 때 끝, i 1씩 증가한다
            //{
            //    Console.WriteLine("숫자: " + i);
            //}

            ////응용 : 무한 반복
            //for (; ; )
            //{
            //    Console.WriteLine("중요한 건 꺾이지 않는 마음");
            //}

            ////0부터 9까지 출력하기
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            ////1부터 10까지의 합 구하기
            //int sum = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    sum += i; // sum = sum + 1;

            //    //중간 값이 궁금할때?
            //    Console.WriteLine($"sum: {sum}, i: {i}");
            //}

            //Console.WriteLine("1부터 10까지의 합: " + sum);


            ////while문
            ////while(조건식)
            ////for는 괄호안에 초기화 조건문 증감식을 다 넣지만, while는 따로따로 해야함
            //int count = 1; //초기화
            //while (count <= 5) //조건식
            //{
            //    Console.WriteLine("Count: " + count);
            //    count++; //증가, 감소

            //    if (count == 3) //중간에 3일때 종료하고 싶음
            //    {
            //        Console.WriteLine("3일때 반복문 탈출");
            //        break;
            //    }
            //}

            //Console.WriteLine("Count: " + count);


            ////랜덤
            //Random rand = new Random(); //랜덤 객체를 생성한다.

            ////0이상 10 미만의 랜덤 정수 생성
            //for (int i = 0; i < 10; i++) //이 행동을 10번 반복한다의 반복문
            //{
            //    int randomNumber = rand.Next(0, 10); //0, 10 이렇게 하면 0 ~ 9만 나옴, 전까지만 출력
            //    Console.WriteLine("0이상 10미만의 랜덤 정수: " + randomNumber);
            //}

            //for (int i = 0; i < 10; i++) //float 실수형으로 뽑기
            //{
            //    double randomNumber = rand.NextDouble(); //0, 10 이렇게 하면 0 ~ 9만 나옴, 전까지만 출력
            //    Console.WriteLine("랜덤 실수: " + randomNumber);
            //}

            //int randomInRange = 0;
            //for (int i = 0; i < 100; i++)
            //{
            //    randomInRange = rand.Next(5, 15); // 5부터 14까지
            //    Console.WriteLine("5부터 14까지: " + randomInRange);

            //}


            ////대장장이 키우기
            ////도끼등급 SSS  10%
            ////도끼등급 SS   40%
            ////도끼등급 S    50%

            //Random rand = new Random();
            //int rnd = 0; //초기값
            //for (int i = 0; i < 20; i++)
            //{
            //    rnd = rand.Next(1, 101); //1 ~ 100

            //    if (rnd >= 1 && rnd <= 10) // 1 ~ 10 => 10%
            //    {
            //        Console.WriteLine("도끼등급 SSS");
            //    }
            //    else if (rnd >= 11 && rnd <= 40) // 11 ~ 40 => 40%
            //    {
            //        Console.WriteLine("도끼등급 SS");
            //    }
            //    else
            //    {
            //        Console.WriteLine("도끼등급 S");
            //    }
            //    Thread.Sleep(500); // 0.5초 정도 간격을 두고 뽑아라. 
            //}


            ////do while
            ////1회는 무조건 실행하고, while문과 같이 조건 진행
            ////불편해서 많이 안 쓰이긴 함
            //int x = 5;
            //do
            //{
            //    Console.WriteLine("최소 한 번은 실행됩니다.");
            //    x--;
            //} while (x > 0); //조건이 여기에 붙음, 세미콜론까지 넣어야함 여긴


            ////break 문 : 반복문을 탈출할 수 있다.
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        break;
            //    }

            //    Console.WriteLine(i);
            //}


            ////continue
            ////현재 반복을 건너뛰고 다음 반복으로 넘어간다.

            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        continue; //컨티뉴면 출력하기 전에 for문으로 돌아간다. 그래서 한 번 넘어가고 출력(if에 적합하지 않아), 넘어가고 출력을 반복한다.
            //    }
            //    Console.WriteLine(i); //홀수만 출력
            //}


            ////goto를 이용한 반복문
            ////goto를 사용할 때는 사실상 한번밖에 없어요. 2중 반복문을 한번에 탈출할 때 입니다.
            ////하지만 goto를 쓰는 것보다 break를 두 번쓰는 게 좋다!
            //int n = 1;
            //start:
            //if(n <= 5)
            //{
            //    Console.WriteLine(n);
            //    n++;

            //    goto start; //레이블로 이동 -> start:로 => 코드가 많아지면 복잡해져서 잘 안씀
            //}

        }
    }
}
