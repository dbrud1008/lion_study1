using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy36_shootingGame_my
{
    public class Bullet //총알 발사
    {
        public int x; //좌표 x
        public int y; //좌표 y
        public bool fire; //발사 여부 true or false
    }

    public class Player //비행기
    {
        //대치 함수, 문자를 받는 함수
        [DllImport("msvcrt.dll")]
        static extern int _getch();  //c언어 함수 가져옴

        public int playerX;
        public int playerY;
        public Bullet[] playerBullet = new Bullet[20]; //한 번에 최대 20개의 미사일을 보낼 수 있음

        public Player() //생성자
        {
            //플레이어 좌표위치 초기화 -> 움직일때마다 초기화 해야함
            playerX = 0;
            playerY = 12; //세로의 중앙에서 시작해야하기 때문에 12

            for(int i = 0; i<20; i++) //총알 초기화
            {
                playerBullet[i] = new Bullet(); //초기화를 20번 반복한다.
                playerBullet[i].x = 0;
                playerBullet[i].y = 0;
                playerBullet[i].fire = false;
            }

        }

        public void GameMain() //메인 게임 생성
        {
            KeyControl();
            PlayerDrow();
        }

        public void BulletDrow() //총알 그리기
        {
            string bullet = "@";

            for(int i = 0; i<20; i++)
            {
                Console.SetCursorPosition(playerBullet[i].x - 1, playerBullet[i].y);

                Console.Write(bullet);

                playerBullet[i].x++;

                if (playerBullet[i].x > 78)
                {
                    playerBullet[i].fire = false;
                }
            }
        }

        public void PlayerDrow() //비행기 그리기
        { 
        }

        public void ClashEnemyAndBullet(Enemy enemy)
        {

        }


        public void KeyControl() //키 입력 받기
        {
            int pressKey; //정수형 변수선언 키값

            if(Console.KeyAvailable) //키가 눌렸을 때 true
            {
                //아스키 코드표
                pressKey = _getch();

                if (pressKey == 0 || pressKey == 224) // 화살표 키 또는 특수 키 감지
                {
                    pressKey = _getch(); // 실제 키 값 읽기
                }

                switch (pressKey)
                {
                    case 72:
                        playerY--; //위쪽 방향키: 위로 가야하니까 위로 가면 -1
                        if (playerY < 1) //위쪽 경계선
                            playerY = 1;
                        break;

                    case 65:
                        playerX--; //왼쪽 방향키
                        if (playerX < 1) //왼쪽 경계선
                            playerX = 1;
                        break;

                    case 90:
                        playerX++;
                        if (playerX > 75) //오른쪽 경계선 통과하지 않게
                            playerX = 75;
                        break;

                    case 77:
                        playerY++;
                        if (playerY > 75)
                            playerY = 75;
                        break;

                    case 32:
                        for (int i =0; i<20; i++)
                        {
                            //미사일 발사기능
                            if (playerBullet[i].fire == false)
                            {
                                playerBullet[i].fire = true;
                                playerBullet[i].x = playerX + 5;
                                playerBullet[i].y = playerY + 1;

                                break;
                            }
                        }
                        break;
                }
            }
        }

        public void FireBullet() //총알 발사
        {

        }
    }


    public class Enemy //적
    {
        public void EnemyDrow()
        {

        }

        public void EnemyMove()
        {

        }
    }

    public class Item
    {
        public void ItemDraw()
        {

        }

        public void ItemMove()
        {

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

            //플레이어와 적 생성
            Player player = new Player();
            Enemy enemy = new Enemy();

            //프레임 속도
            int delayTime = Environment.TickCount; // 1/1000 초 흐른다.

            while (true) //무한반복
            {
                if(delayTime + 50 < Environment.TickCount)
                {
                    delayTime = Environment.TickCount; //현재 시간 세팅
                    Console.Clear(); // 무한 클리어와 재생 반복

                    player.GameMain(); //메인을 불러오기

                    enemy.EnemyMove(); //적 가져오기

                    enemy.EnemyDrow(); //적 그려진 것
                }
            }
        }
    }
}
