using lionstudy37_myGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lionstudy37_myGame
{

    public class Player
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();  //c언어 함수 가져옴

        public int playerX; //플레이어 X좌표
        public int playerY; //플레이어 Y좌표

        public Player()
        {
            //플레이어 좌표위치 초기화
            playerX = 0;
            playerY = 11;
        }
        public void GameMain1()
        {
            //키를 입력하는 부분
            KeyControl();
            //플레이어를 그려준다.
            PlayerDraw();

        }

        private void KeyControl()
        {
            int pressKey; //정수형 변수선언 키값

            if (Console.KeyAvailable) //키가 눌렸을 때 true
            {
                //아스키 코드표 참고 필수!
                pressKey = _getch(); //아스키값 왼쪽 오른쪽 입력을 받기 -> 아스키코드표로 움직임

                if (pressKey == 0 || pressKey == 224) // 화살표 키 또는 특수 키 감지
                {
                    pressKey = _getch(); // 실제 키 값 읽기
                }

                switch (pressKey)
                {
                    case 72:
                        playerY--;
                        if (playerY < 1)
                            playerY = 1;
                        break;
                    case 80:
                        playerY++;
                        if (playerY > 21)
                            playerY = 21;
                        break;
                }

            }
        }

        public void PlayerDraw()
        {
            String[] player = new string[]
            {
                "/\\_/\\\r\n(='_' )\r\n(,(\")(\")\r\n"
            };

            for (int i = 0; i < player.Length; i++)
            {
                //콘솔좌표 설정 플레이어x 플레이어y
                Console.SetCursorPosition(playerX, playerY + i);

                //문자열 배열 출력
                Console.WriteLine(player[i]);
            }

        }
    }


    public class Wall
    {
        public int wallX;
        public int wallY;

        public Wall()
        {
            wallX = 30;
            wallY = 0;
        }

        public void wallDraw()
        {
            //string wallString =
            //    "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";

            //for (int i = 0; i < 77; i++)
            //{
            //    wallString += "■";
            //}

            Console.SetCursorPosition(wallX, 0); //좌표설정
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";


        }

        public void wallDraw2()
        {
            Console.SetCursorPosition(wallX, 0); //좌표설정
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.SetCursorPosition(wallX, 1); //좌표설정
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.SetCursorPosition(wallX, 2); //좌표설정
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.SetCursorPosition(wallX, 3); //좌표설정
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.SetCursorPosition(wallX, 4); //좌표설정
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.SetCursorPosition(wallX, 5); //좌표설정
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.SetCursorPosition(wallX, 6); //좌표설정
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.SetCursorPosition(wallX, 7); //좌표설정
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
        }

        public void wallMove()
        {
            wallX--;

            // 벽이 모두 왼쪽으로 넘어갔는지 확인
            if (wallX < 2)
            {
                wallX = 77; // 벽의 위치를 리셋하는 방법을 지정할 수 있습니다.
                wallDraw2(); // 여기에서 wallDraw()를 호출
            }
            else
            {
                wallDraw(); // 벽이 여전히 화면 내에 있는 경우 그리기
            }
    }

        //public void resetWall()
        //{
        //    walls.clear();

        //    for(int i = 0; i < 77; i++)
        //    {
        //        walls.add(new Wall(wallX, wallY));
        //    }
        //}
    }

    public class Item
    {
        public string ItemName;
        public string ItemSprite;
        public int itemX = 77;
        public int itemY = 0;
        public bool ItemLife = false;

        public void ItemDraw()
        {
            Console.SetCursorPosition(itemX, itemY);
            ItemSprite = "★";
            Console.Write(ItemSprite);
        }

        public void ItemMove()
        {
            itemX--;
        }
    }


    public class Stage
    {
        public int stage1X; //Stage1 X좌표
        public int stage1Y; //Stage1 Y좌표

        public Stage()
        {
            stage1X = 0;
            stage1Y = 9;
        }


        public void StageNumber1()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("");
            }

            Console.WriteLine
                ("            ________________________________________________________");
            Console.WriteLine
                ("                  __    ______    __        __      _____       _   ");
            Console.WriteLine
                ("                /    )    /       / |     /    )    /    '     //   ");
            Console.WriteLine
                ("            ----\\--------/-------/__|----/---------/__---------/----");
            Console.WriteLine
                ("                 \\      /       /   |   /  --,    /           /     ");
            Console.WriteLine
                ("            _(____/____/_______/____|__(____/____/____ ______/______");
            Console.WriteLine
                ("                                                                    ");


        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //인코딩 폰트 안 깨지기
            Console.CursorVisible = false; // 커서 없애기

            Console.SetWindowSize(80, 25); // 콘솔 창 크기 설정 (가로 80, 세로 25)
            Console.SetBufferSize(80, 25); // 버퍼 크기도 동일하게 설정 (스크롤 방지)

            Player player = new Player();
            Wall wall = new Wall();
            Stage stage1 = new Stage();

            //유니티처럼 속도 프레임속도
            int dwTime = Environment.TickCount; // 1/1000 초 흐른다.


            stage1.StageNumber1();

            Thread.Sleep(3000);

            while (true)
            {
                if (dwTime + 50 < Environment.TickCount)
                {
                    // 현재시간 세팅
                    dwTime = Environment.TickCount;
                    Console.Clear(); // -> 0.05초 마다 지워주고 그려주고를 반복하는 것

                    //플레이어
                    player.GameMain1();
                    wall.wallDraw();
                    wall.wallMove();
                    //wall.wallDraw2();

                }
            }

        }
    }
}
