using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lionstudy31_shootingGame1
{
    class Program
    {
        struct player
        {
            public int playerX;
            public int playerY;

            public string[] text;

            public player(int playerX, int playerY)
            {

                this.playerX = playerX;
                this.playerY = playerY;
                this.text = new string[]
                {
                    " . /) /)\r\n( ･`ω´･)╮−−＝＝≡≡≡ ♡♡♡.\r\n",

                };
                //배열 문자열로 그리기
                
            }

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //인코딩 폰트 안 깨지기
            Console.SetWindowSize(80, 25); // 콘솔 창 크기 설정 (가로 80, 세로 25)
            Console.SetBufferSize(80, 25); // 버퍼 크기도 동일하게 설정 (스크롤 방지)

            player player = new player(0, 12);
            
            //int x = 10, y = 10;

            //좌표를 움직이게 한는 것
            //ConsoleKeyInfo keyInfo;

            //Console.CursorVisible = false; //커서 없애기

            //while (true)
            //{
            //Console.Clear(); //화면 지우기
            //Console.SetCursorPosition(x, y);
            //Console.Write("●"); //현재 위치 출력

            //keyInfo = Console.ReadKey(true); //키 입력 받기 (화면 출력)

            ////방향키 입력에 따른 좌표 변경
            //switch(keyInfo.Key)
            //{
            //    case ConsoleKey.UpArrow: if (y > 0) y--; break;//UpArrow = 위 방향키
            //    case ConsoleKey.DownArrow: if (y < Console.WindowHeight - 1) y++; break;
            //    case ConsoleKey.LeftArrow: if (x > 0) x--; break; //밖으로 나가지 않게 0보다 커야함
            //    case ConsoleKey.RightArrow: if (x < Console.WindowWidth - 1) x++; break;
            //    case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
            //    case ConsoleKey.Escape: return; //ESC로 종료
            //    // 위의 내용 결론: ● 방향키에 따라 움직임 -> 화면을 벗어나지 않게

            //}

            //string[] player = new string[]
            //    {
            //        "->",
            //        ">>>",
            //        "->",
            //    }; //배열 문자열로 그리기

            int playerX = 0;
            int playerY = 12;

            //좌표를 움직이게 하는 것
            ConsoleKeyInfo keyInfo;

            Console.CursorVisible = false; //커서 없애기


            //시간 1초루프
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long prevSecond = stopwatch.ElapsedMilliseconds; // 1000분의 1초


            while (true)
            {
                long currentSecond = stopwatch.ElapsedMilliseconds; //현재시간 가져오기
                if(currentSecond - prevSecond >= 100) //(현재시간) - (이전 시간) >= 1000
                {
                    Console.Clear();

                    if(Console.KeyAvailable) //키가 눌렸을 때 true
                    {
                        keyInfo = Console.ReadKey(true); //키 입력 받기 (화면 출력 X)

                        //방향키 입력에 따른 좌표 변경
                        switch (keyInfo.Key)
                        {
                            case ConsoleKey.UpArrow: if (playerY > 0) playerY--; break;//UpArrow = 위 방향키
                            case ConsoleKey.DownArrow: if (playerY < Console.WindowHeight - 3) playerY++; break;
                            case ConsoleKey.LeftArrow: if (playerX > 0) playerX--; break; //밖으로 나가지 않게 0보다 커야함
                            case ConsoleKey.RightArrow: if (playerX < Console.WindowWidth - 1) playerX++; break;
                            case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
                            case ConsoleKey.Escape: return; //ESC로 종료
                                                            // 위의 내용 결론: ● 방향키에 따라 움직임 -> 화면을 벗어나지 않게
                                                            // x, y를 playerx, playery로 변경
                        }
                    }

                    //문자열 그려지는 for문
                    for (int i = 0; i < player.text.Length; i++)
                    {
                        //콘솔좌표 설정 플레이어x 플레이어y
                        Console.SetCursorPosition(playerX, playerY + i);
                        //문자열배열 출력
                        Console.WriteLine(player.text[i]);
                    }

                    //Thread.Sleep(100); //빨리 지워지는 것 때문에 0.1초 값을 넣음
                                       // -> 0.1초 멈춰라! 라는 코드인데, delay로 바꾸려면?
                                       // -> 시간 1초 루프 참고


                    //Console.WriteLine("1초 루프");
                    prevSecond = currentSecond; //이전 시간 업데이트
                    //위의 코드 : 이전 시간 = 현재 시간;
                    // -> 키를 눌러야만 갱신되는 프레임을 일반적인 시간 흐름으로 갱신 시키는 것
                }

 
            }
        }
    }
}
