using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace lionstudy19_나만의게임
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //인코딩 폰트 안 깨지기
            //콘솔 창 크기 설정
            Console.SetWindowSize(80, 25);

            //콘솔 버퍼 크기도 설정(스크롤없이 고정된 창 유지)
            Console.SetBufferSize(80, 25);

            Console.CursorVisible = false; //커서 숨기기

            Console.SetCursorPosition(0, 0);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");

            for (int i = 1; i <= 15; i++)
            {
                Console.SetCursorPosition(0, i);
                if (i == 7)
                {
                    Console.Write("┃                              🎁  가챠겟또 RPG  🎁                            ┃");
                }
                else if (i == 13)
                {
                    Console.Write("┃                [ Y : 시작하기 ]               [ N : 종료하기 ]               ┃");
                }
                else
                {
                    Console.Write("┃                                                                              ┃");
                }
            }
            Console.SetCursorPosition(0, 16);
            Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            if (keyInfo.Key == ConsoleKey.Y)
            {
                Console.Clear();
                Console.WriteLine("게임에 접속 중입니다!");
                Thread.Sleep(2000);

                Console.Clear();

                Random rand = new Random();
                Console.WriteLine("🎁 접속 보상: 무기 뽑기권 1장!");
                Thread.Sleep(1000);
                Console.WriteLine("🎁 접속 보상: 소지금 2000 지급!");
                Console.ReadLine();

                int pmoney = 2000;
                int get = 1;
                int input;
                int rnd;
                int power = 100;
                int def = 100;
                int health = 200;
                bool isAlive = true;

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("                        어떤 것을 하시겠습니까?                         ");
                    Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
                    Console.WriteLine("┃        1. 상점              2. 뽑기               3. 모험           ┃");
                    Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
                    Console.WriteLine("( X ) 나가기");
                    input = int.Parse(Console.ReadLine());

                    if (input == 1) //상점
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("1. ⚔️ 공격 무기 뽑기권 1장 골드: 1000");
                            Console.WriteLine("2. 🛡️ 방어 무기 뽑기권 1장 골드: 1000");
                            Console.WriteLine("3. 나가기");
                            input = int.Parse(Console.ReadLine());

                            if (input == 1) // 공격 무기 뽑기
                            {
                                if (pmoney >= 1000)
                                {
                                    pmoney -= 1000;
                                    get += 1;
                                    Console.Clear();
                                    Console.WriteLine("⚔️ 공격 무기 뽑기권 1장을 구입하셨습니다!");
                                    Thread.Sleep(1000);
                                }
                                else
                                {
                                    Console.WriteLine("골드가 부족합니다. (1000 골드 필요)");
                                    Thread.Sleep(1000);
                                }
                            }
                            else if (input == 2)
                            {
                                if (pmoney >= 1000)
                                {
                                    pmoney -= 1000;
                                    get += 1;
                                    Console.Clear();
                                    Console.WriteLine("🛡️ 방어 무기 뽑기권 1장을 구입하셨습니다!");
                                    Thread.Sleep(1000);
                                }
                                else
                                {
                                    Console.WriteLine("골드가 부족합니다. (1000 골드 필요)");
                                    Thread.Sleep(1000);
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    else if (input == 2) //뽑기
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("1. ⚔️ 공격 무기 뽑기   뽑기권 1장 소모");
                            Console.WriteLine("2. 🛡️ 방어 무기 뽑기   뽑기권 1장 소모");
                            Console.WriteLine("3. 나가기");
                            input = int.Parse(Console.ReadLine());

                            if (input == 1) // 공격 무기 뽑기
                            {
                                if (get >= 1)
                                {
                                    get -= 1;
                                    rnd = rand.Next(1, 101); // 1 ~ 100 랜덤

                                    if (rnd <= 10)
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("! 축하드립니다 !");
                                        Console.WriteLine("SSS급 뭐든지 베어버리는 장미칼 (공격력 + 50) 획득!");
                                        power += 50;
                                    }
                                    else if (rnd <= 30)
                                    {
                                        Console.WriteLine("");

                                        Console.WriteLine("SS급 고급 희귀의 칼 (공격력 + 30) 획득!");
                                        power += 30;
                                    }
                                    else if (rnd <= 70)
                                    {
                                        Console.WriteLine("");

                                        Console.WriteLine("A급 적당한 쇠칼 (공격력 + 20) 획득!");
                                        power += 20;
                                    }
                                    else
                                    {
                                        Console.WriteLine("");

                                        Console.WriteLine("B급 곧 부서질 것 같은 녹슨 칼 (공격력 + 5) 획득!");
                                        power += 5;
                                    }
                                    Thread.Sleep(3000); //5초

                                }
                                else
                                {
                                    Console.WriteLine("뽑기권이 부족합니다!");
                                    Thread.Sleep(1000);
                                }

                            }
                            else if (input == 2) //방어 무기 뽑기
                            {
                                if (get >= 1)
                                {
                                    get -= 1;
                                    rnd = rand.Next(1, 101); // 1 ~ 100 랜덤

                                    if (rnd == 1)
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("! 축하드립니다 !");
                                        Console.WriteLine("SSS급 캡틴 아메리카의 방패 (방어력 + 50) 획득!");
                                        def += 50;
                                    }
                                    else if (rnd <= 10)
                                    {
                                        Console.WriteLine("");

                                        Console.WriteLine("SS급 강철 방패 (방어력 + 30) 획득!");
                                        def += 30;
                                    }
                                    else if (rnd <= 30)
                                    {
                                        Console.WriteLine("");

                                        Console.WriteLine("A급 그냥저냥 막아주는 방패 (방어력 + 20) 획득!");
                                        def += 20;
                                    }
                                    else
                                    {
                                        Console.WriteLine("");

                                        Console.WriteLine("B급 못 막을 것 같은 방패 (방어력 + 5) 획득!");
                                        def += 5;
                                    }
                                    Thread.Sleep(3000); //5초

                                }
                                else
                                {
                                    Console.WriteLine("뽑기권이 부족합니다!");
                                    Thread.Sleep(1000);
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    else if (input == 3) //모험
                    {
                        Console.Clear();
                        Console.WriteLine(" 모험을 떠나는 중입니다. ");
                        Thread.Sleep(500);
                        Console.WriteLine(" 모험을 떠나는 중입니다.. ");
                        Thread.Sleep(500);
                        Console.WriteLine(" 모험을 떠나는 중입니다... ");
                        Thread.Sleep(500);
                        Console.WriteLine(" 모험을 떠나는 중입니다.... ");
                        Thread.Sleep(500);

                        Console.Clear();
                        Console.WriteLine("⚠️ 몬스터를 마주쳤다! ⚠️");

                        int eventChance = rand.Next(1, 101); // 1 ~ 100 랜덤 이벤트

                        if (eventChance <= 30) //30% 확률로 공격을 막았다
                        {
                            Console.WriteLine("");
                            Console.WriteLine(" 몬스터의 기습 공격!");
                            int damage = rand.Next(5, 21); //5 ~ 20
                            Thread.Sleep(500);

                            Console.WriteLine("");
                            Console.WriteLine($" 몬스터의 기습 공격을 막았다! 방어력 -{damage}");
                            def -= damage;
                            Thread.Sleep(500);

                            Console.WriteLine("");
                            Console.WriteLine("몬스터에게 기습 공격을 하였다!");
                            int power1 = rand.Next(5, 11); //5 ~ 10
                            int def1 = rand.Next(5, 11); //5 ~ 20
                            int gold = rand.Next(500, 1301); //5 ~ 20

                            Thread.Sleep(500);

                            Console.WriteLine("");
                            Console.WriteLine("전투에 승리하였다!");
                            Console.WriteLine($" 공격력 +{power1}  방어력 +{def1} ");
                            power += power1;
                            pmoney += gold;

                            def += def1;
                        }
                        else if (eventChance <= 70) //40% 공격을 못막았다
                        {
                            Console.WriteLine("");
                            Console.WriteLine("몬스터의 기습 공격!");
                            int damage = rand.Next(5, 21); //5 ~ 20
                            Thread.Sleep(500);

                            Console.WriteLine("");
                            Console.WriteLine($" 몬스터의 기습 공격에 당했다! 체력 -{damage} ");
                            health -= damage;
                            Thread.Sleep(500);
                            Console.WriteLine("");
                            Console.WriteLine(" 몬스터의 기습 공격!");

                            Console.WriteLine("");
                            Thread.Sleep(500);

                            Console.WriteLine($" 몬스터의 기습 공격을 막았다! 방어력 -{damage}");
                            def -= damage;

                            Thread.Sleep(500);

                            Console.WriteLine("");
                            Console.WriteLine("몬스터에게 공격을 하였다!");
                            int power1 = rand.Next(5, 11); //5 ~ 10
                            int def1 = rand.Next(5, 11); //5 ~ 20
                            int gold = rand.Next(500, 1301); //5 ~ 20

                            Thread.Sleep(500);

                            Console.WriteLine("");
                            Console.WriteLine("전투에 승리하였다!");
                            Console.WriteLine($" 공격력 +{power1}  방어력 +{def1} ");
                            power += power1;
                            def += def1;
                            pmoney += gold;

                        }
                        else //30% 확률로 회복
                        {
                            Console.WriteLine("");
                            Console.WriteLine("몬스터에게 공격을 하였다!");
                            int power1 = rand.Next(5, 11); //5 ~ 10
                            int def1 = rand.Next(5, 11); //5 ~ 20
                            int gold = rand.Next(500, 1301); //5 ~ 20
                            Thread.Sleep(500);

                            Console.WriteLine("");
                            Console.WriteLine("전투에 승리하였다!");
                            Console.WriteLine($" 공격력 +{power1}  방어력 +{def1} ");
                            Console.WriteLine($" 골드 +{gold} ");
                            power += power1;
                            def += def1;
                            pmoney += gold;
                        }

                        if (health <= 0)
                        {
                            Console.WriteLine("\n 💀 체력이 0이 되어 사망했습니다... GAME OVER! 💀");
                            isAlive = false;
                        }

                        Console.ReadLine();
                    }
                    else if (input == 'x')
                    {
                        Console.WriteLine("게임을 종료하겠습니다.");
                        Environment.Exit(1);
                    }
                }
            }
        }
    }
}
