using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy72_BrickGame
{
    public class Ball
    {
        BallData ball = new BallData();

        public BallData GetBall()
        {
            return ball;
        }

        public void SetX(int x) { ball.nX += x; }
        public void SetY(int y) { ball.nY += y; }
        public void SetBall(BallData tball)
        {
            ball = tball;
        }

        public void SetReady(int Ready)
        {
            ball.nReady = Ready;
        }



        //C# 공의 방향 배열 정의
        int[,] g_WallCollision = new int[4, 6]
        {
            {  3,  2, -1, -1, -1, 4 },
            { -1, -1, -1, -1,  2, 1 },
            { -1,  5,  4, -1, -1,-1 },
            { -1, -1,  1,  0,  5,-1 }
        };

        Bar m_pBar;

        Wall t_wall;

        //Bar클래스 가져오기
        public void SetBar(Bar bar) { m_pBar = bar; }

        public void SetWall(Wall wall) { t_wall = wall; }



        //움직일 bar
        //block

        public void ScreenWall()
        {
            Program.gotoxy(0, 0);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Program.gotoxy(0, 1);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 2);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 3);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 4);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 5);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 6);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 7);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 8);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 9);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 10);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 11);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 12);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 13);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 14);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 15);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 16);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 17);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 18);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 19);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 20);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 21);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 22);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 23);
            Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

        }

        public int Collistion(int x, int y)
        {
            //벽충돌
            if (y == 0) //윗 벽
            {
                ball.nDirect = g_WallCollision[0, ball.nDirect];    //2
                return 1;       //공의 방향이 바뀌면 1 리턴
            }

            if (x == 1) //왼쪽 끝벽
            {
                ball.nDirect = g_WallCollision[1, ball.nDirect]; //1 = 충돌한 벽, ball.nDirect = 나가는 방향
                return 1;
            }

            if (x == 77) //오른쪽 끝벽
            {
                ball.nDirect = g_WallCollision[2, ball.nDirect];
                return 1;
            }

            if (y == 23) //아래 벽
            {
                ball.nDirect = g_WallCollision[3, ball.nDirect];
                return 1;
            }

            //Bar충돌처리
            if (x >= m_pBar.m_tBar.nX[0] && x <= m_pBar.m_tBar.nX[2] + 1 &&
                y == (m_pBar.m_tBar.nY)) //바 위 충돌
            {
                if (ball.nDirect == 1)
                    ball.nDirect = 2;
                else if (ball.nDirect == 2)
                    ball.nDirect = 1;
                else if (ball.nDirect == 5)
                    ball.nDirect = 4;
                else if (ball.nDirect == 4)
                    ball.nDirect = 5;

                return 1; //방향이 바뀐다.
            }

            if (x >= m_pBar.m_tBar.nX[0] && x <= m_pBar.m_tBar.nX[2] + 1 &&
              y == (m_pBar.m_tBar.nY + 1)) //바 아래 충돌
            {
                if (ball.nDirect == 1)
                    ball.nDirect = 2;
                else if (ball.nDirect == 2)
                    ball.nDirect = 1;
                else if (ball.nDirect == 5)
                    ball.nDirect = 4;
                else if (ball.nDirect == 4)
                    ball.nDirect = 5;

                return 1; //방향이 바뀐다.

            }

            if()

            return 0;
        }

            //return 0;

        public void Initialize()
        {
            ball.nReady = 0; //공 안 움직임 = 1   움직임 = 0
            ball.nDirect = 1;
            ball.nX = 30;
            ball.nY = 10;
        }

        public void Progress()
        {
            if(ball.nReady == 0) //0이 움직이는 것
            {
                //공의 방향에 따른 스위치문
                switch(ball.nDirect)
                {
                    case 0: //위
                        if(Collistion(ball.nX, ball.nY - 1) == 0) //충돌 처리, 일찍 체크를 위한 ball.nY -1
                            ball.nY--;
                        break;
                    case 1: //오른쪽 위
                        if (Collistion(ball.nX + 1, ball.nY - 1) == 0)
                        {
                            ball.nX++;
                            ball.nY--;
                        }
                        break;
                    case 2: //오른쪽 아래
                        if (Collistion(ball.nX + 1, ball.nY + 1) == 0)
                        {
                            ball.nX++;
                            ball.nY++;
                        }
                        break;
                    case 3: //아래
                        if (Collistion(ball.nX, ball.nY + 1) == 0) //충돌 처리, 일찍 체크를 위한 ball.nY -1
                            ball.nY++;
                        break;
                    case 4: //왼쪽 아래
                        if (Collistion(ball.nX - 1, ball.nY + 1) == 0)
                        {
                            ball.nX--;
                            ball.nY++;
                        }
                        break;
                    case 5: //왼쪽 위
                        if (Collistion(ball.nX - 1, ball.nY - 1) == 0)
                        {
                            ball.nX--;
                            ball.nY--;
                        }
                        break;
                }
            }
        }

        public void Render()
        {
            ScreenWall();
            Program.gotoxy(ball.nX, ball.nY);
            Console.Write("●");
        }

        public void Release() { }
    }
}
