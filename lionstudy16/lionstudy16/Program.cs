using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lionstudy16
{
    class Program
    {
        static void Main(string[] args)
        {
            //실습
            Console.WriteLine("대장장이 키우기");
            Console.WriteLine(" ");
            Console.WriteLine("게임을 시작하시겠습니까? (Y/N)");

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            if (keyInfo.Key == ConsoleKey.Y)
            {
                Console.WriteLine("\n게임 시작합니다!");
                //게임 시작 로직
                Console.ReadLine();
                Console.Clear();

                Random rand = new Random();
                int pmoney = 3000;
                int input;
                int rnd;

                Thread.Sleep(500);

                //무한반복
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("1. 나무캐기   2. 장비뽑기   3. 나가기");
                    Console.Write("어떤 것을 하시겠습니까? : ");
                    input = int.Parse(Console.ReadLine());

                    if (input == 1) //나무캐기 화면
                    {
                        while (true)
                        {
                            Console.WriteLine("나무캐기 (Enter)");
                            Console.WriteLine("뒤로가기 (x)");

                            string str = Console.ReadLine();

                            pmoney += 100;
                            Console.WriteLine("소지금: " + pmoney);
                            if (str == "x")
                            {
                                Console.WriteLine("뒤로가기");
                                break;
                            }
                        }
                    }

                    else if (input == 2) //장비뽑기
                    {
                        if (pmoney >= 1000) //돈이 있는지 확인 후 뽑기
                        {
                            pmoney -= 1000;

                            //20번 뽑기
                            for (int i = 1; i <= 20; i++)
                            {
                                rnd = rand.Next(1, 101);

                                if (rnd == 1) //1%
                                {
                                    Console.WriteLine("도끼등급 SSS");
                                }
                                else if (rnd >= 2 && rnd <= 6)
                                {
                                    Console.WriteLine("도끼등급 SS");
                                }
                                else if (rnd >= 7 && rnd <= 17)
                                {
                                    Console.WriteLine("도끼등급 S");
                                }
                                else if (rnd >= 18 && rnd <= 38)
                                {
                                    Console.WriteLine("도끼등급 A");
                                }
                                else if (rnd >= 39 && rnd <= 69)
                                {
                                    Console.WriteLine("도끼등급 B");
                                }
                                else
                                {
                                    Console.WriteLine("도끼등급 C");
                                }
                                Thread.Sleep(500); //0.5초 간격으로 뽑혀라
                            }
                        }
                        else
                        {
                            Console.WriteLine("돈이 부족합니다. \n");
                            Thread.Sleep(2000); //2초
                        }
                    }
                    else if (input == 3)
                    {
                        Console.WriteLine("나갑니다.");
                        Environment.Exit(0);
                        //break;
                    }
                }

            }
            else if (keyInfo.Key == ConsoleKey.N)
            {
                Console.WriteLine("\n게임 종료합니다.");
                //게임 종료 로직
            }
            else
            {
                Console.WriteLine("\n잘못된 입력입니다. Y 또는 N을 입력하세요!");
            }
        }
    }
}
