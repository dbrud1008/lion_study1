using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lionstudy39_myGame3
{
    public class attack
    {
        public int x;
        public int y;
        public bool fire;

        public int enemyAttX;
        public int enemyAttY;
    }

    public class Player
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();  //c언어 함수 가져옴

        public int playerX;
        public int playerY;

        public attack[] playerAttack = new attack[15];

        public attack[] enemyAttacks; // 적의 공격을 관리할 배열
        public attack[] enemyAttacks2; // 적의 공격을 관리하기 위한 두 번째 배열

        public int Score = 100;


        public Player()
        {
            playerX = 12;
            playerY = 12;

            for(int i = 0; i < 15; i++)
            {
                playerAttack[i] = new attack();
                playerAttack[i].x = 0;
                playerAttack[i].y = playerY + 2;
                playerAttack[i].fire = false;
            }
        }

        public void GameMain()
        {
            //키를 입력하는 부분
            KeyControl();
            //플레이얼를 그려준다.
            PlayerDraw();
            attackDraw();
            //UI점수
            UItop();
            UIbottom();

            //if (item.ItemLife)
            //{
            //    item.ItemMove();
            //    item.ItemDraw();
            //    CrashItem();
            //}


        }

        public void KeyControl()
        {
            int pressKey;

            if (Console.KeyAvailable)
            {
                pressKey = _getch();


                switch (pressKey)
                {
                    case 72:
                        for (int i = 0; i < 15; i++)
                        {
                            //미사일이 false 발사가능
                            if (playerAttack[i].fire == false)
                            {
                                playerAttack[i].fire = true;
                                //플레이어 앞에서 미사일 쏘기 + 5
                                playerAttack[i].x = playerX + 5;
                                playerAttack[i].y = playerY;
                                //한발씩 쏘겠다.
                                break;
                            }
                        }
                        break;
                    
                    case 80:
                        for (int i = 0; i < 15; i++)
                        {
                            //미사일이 false 발사가능
                            if (playerAttack[i].fire == false)
                            {
                                playerAttack[i].fire = true;
                                //플레이어 앞에서 미사일 쏘기 + 5
                                playerAttack[i].x = playerX + 5;
                                playerAttack[i].y = playerY + 2;
                                //한발씩 쏘겠다.
                                break;
                            }
                        }
                        break;

                    //case 75: //방향키 위
                    //         //미사일 15개
                    //    for (int j = 0; j < enemyAttacks.Length; j++)
                    //    {
                    //        if (enemyAttacks[j].fire)
                    //        {
                    //            // 적 공격의 Y 좌표가 플레이어 Y와 일치하면
                    //            if (enemyAttacks[j].enemyAttY == playerY)
                    //            {
                    //                // X 좌표 비교
                    //                if (enemyAttacks[j].enemyAttX >= playerX && enemyAttacks[j].enemyAttX <= (playerX + 3))
                    //                {
                    //                    enemyAttacks[j].fire = false; // 공격 비활성화
                    //                    Console.SetCursorPosition(58, 8);
                    //                    Console.WriteLine("왼쪽 공격을 막았다!"); // 메시지 표시
                    //                    return; // 확인되면 종료
                    //                }
                    //            }
                    //        }
                    //    }
                    //    break;

                    //case 77: //방향키 아래
                    //    for (int j = 0; j < enemyAttacks.Length; j++)
                    //    {
                    //        if (enemyAttacks[j].fire)
                    //        {
                    //            // 적 공격의 Y 좌표가 플레이어 Y + 2와 일치하면
                    //            if (enemyAttacks[j].enemyAttY == playerY + 2)
                    //            {
                    //                // X 좌표 비교
                    //                if (enemyAttacks[j].enemyAttX >= playerX && enemyAttacks[j].enemyAttX <= (playerX + 3))
                    //                {
                    //                    enemyAttacks[j].fire = false; // 공격 비활성화
                    //                    Console.SetCursorPosition(58, 8);
                    //                    Console.WriteLine("오른쪽 공격을 막았다!"); // 메시지 표시
                    //                    return; // 확인되면 종료
                    //                }
                    //            }
                    //        }
                    //    }
                    //    break;
                }
            }
        } 

        //---------------------------------------------------------------------------------------------------

        public void attackDraw()
        {
            string bullet = "▶"; //미사일모습

            for(int i =0; i<15; i++)
            {
                if (playerAttack[i].fire ==true)
                {
                    Console.SetCursorPosition(playerAttack[i].x - 1, playerAttack[i].y);
                    Console.Write(bullet);

                    playerAttack[i].x++; //미사일 오른쪽으로 날라가기

                    if (playerAttack[i].x > 78)
                    {
                        playerAttack[i].fire = false;  //미사일 false 다시 준비상태
                    }
                }
            }
        }

        public void PlayerDraw()
        {
            String[] player = new string[]
            {
                "く😎/",
                " ( ヘ",
                "く   "
            };

            for (int i = 0; i < player.Length; i++)
            {
                //콘솔좌표 설정 플레이어X 플레이어Y
                Console.SetCursorPosition(playerX, playerY + i);
                //문자열배열 출력
                Console.WriteLine(player[i]);
            }

            string playerText = "You";
            Console.SetCursorPosition(13, 16);
            Console.Write(playerText);

        }

        public void ClashEnemyAndBullet(Enemy enemyAtt)
        {
            //미사일 15개
            for (int i = 0; i < 15; i++)
            {
                //살아있는 미사일
                if (playerAttack[i].fire)
                {
                    // 미사일의 Y값이 적의 Y값과 일정 범위 내에 있을 때
                    if (playerAttack[i].y >= (enemyAtt.enemyY - 1) && playerAttack[i].y <= (enemyAtt.enemyY + 2))
                    {
                        // X 좌표 비교
                        if (playerAttack[i].x >= (enemyAtt.enemyX - 1) && playerAttack[i].x <= (enemyAtt.enemyX + 1))
                        {
                            //확률 추가
                            Random rand = new Random();
                            int hitChance = rand.Next(1, 101); // 1에서 100까지의 난수

                            if (hitChance <= 40)
                            {
                                enemyAtt.enemyHP -= 15;

                                Console.SetCursorPosition(58, 8);
                                Console.Write("(* Д *)아파!");

                                Thread.Sleep(100);

                                Score += 100;
                            }
                            else
                            {
                                Console.SetCursorPosition(56, 8);
                                Console.Write(" ┌──────────┐");
                                Console.SetCursorPosition(56, 9);
                                Console.Write("│  회피지롱~ │");
                                Console.SetCursorPosition(56, 10);
                                Console.Write(" └──────────┘");

                                Thread.Sleep(100);
                            }
                            playerAttack[i].fire = false; // 미사일 비활성화

                            if (enemyAtt.enemyHP <= 0)
                            {
                                Clear();
                            }
                        }
                    }
                }
            }

            // 적의 공격 판별
            for (int j = 0; j < enemyAtt.enemyAttacks.Length; j++)
            {
                if (enemyAtt.enemyAttacks[j].fire) // 적의 공격이 발사된 경우
                {
                    // 적의 공격 Y 좌표가 플레이어의 Y 좌표와 일치할 때
                    if (enemyAtt.enemyAttY >= (playerY - 1) && enemyAtt.enemyAttY <= (playerY + 2))
                    {
                        // X 좌표 비교
                        if (enemyAtt.enemyAttX <= (playerX + 3) && enemyAtt.enemyAttX >= playerX)
                        {
                            Console.SetCursorPosition(58, 10);
                            Console.WriteLine("공격을 막았다!");
                            enemyAtt.enemyAttacks[j].fire = false; // 적의 미사일 비활성화
                        }
                    }
                }
            }
        }

        public void Clear()
        {
            Console.Clear();

            Console.SetCursorPosition(3, 12);
            Console.Write("  ___________________________________________________");
            Console.Write("      __      _       _____     __      ____       / ");
            Console.Write("    /    )    /       /    '    / |     /    )    /  ");
            Console.Write("---/---------/-------/__-------/__|----/___ /----/---");
            Console.Write("  /         /       /         /   |   /    |    /    ");
            Console.Write("_(____/____/____/__/____ ____/____|__/_____|___o_____");
        }

        public void UItop()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("   ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine("   ┃                                Stage 1                                 ┃");
            Console.WriteLine("   ┃                                                                        ┃");
            Console.WriteLine($"   ┃                              Score:    {Score}                             ┃");
            Console.WriteLine("   ┃                                                                        ┃");
            Console.WriteLine("   ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

        }

        public void UIbottom()
        {
            Console.SetCursorPosition(3, 21);
            Console.WriteLine("[조작법]");
            Console.SetCursorPosition(3, 22);
            Console.WriteLine("공격: ↑ ↓");
        }

    }

    public class Enemy
    {
        public int enemyX;
        public int enemyY;

        public int enemyAttX;
        public int enemyAttY;

        public attack[] enemyAttacks; // 적의 공격을 관리할 배열
        public attack[] enemyAttacks2; // 적의 공격을 관리하기 위한 두 번째 배열

        private Random rand = new Random();

        public int enemyHP = 300; //적의 체력


        public Enemy()
        {
            enemyX = 60;
            enemyY = 12;

            // 공격 배열 초기화
            enemyAttacks = new attack[5];
            for (int i = 0; i < enemyAttacks.Length; i++)
            {
                enemyAttacks[i] = new attack();
                enemyAttacks[i].fire = false; // 초기 상태는 발사되지 않은 상태
            }

            // 두 번째 공격 배열 초기화
            enemyAttacks2 = new attack[5];
            for (int i = 0; i < enemyAttacks2.Length; i++)
            {
                enemyAttacks2[i] = new attack();
                enemyAttacks2[i].fire = false; // 초기 상태는 발사되지 않은 상태
            }
        }

        public void EnemyDraw()
        {
            String[] enemy = new string[]
            {
                "`🥴/",
                " √ )",
                " / >"
            };

            for (int i = 0; i < enemy.Length; i++)
            {
                //콘솔좌표 설정 플레이어X 플레이어Y
                Console.SetCursorPosition(enemyX, enemyY + i);
                //문자열배열 출력
                Console.WriteLine(enemy[i]);
            }

            Console.SetCursorPosition(70, 6);
            Console.Write($"HP: {enemyHP} ");

            string playerText = "Enemy";
            Console.SetCursorPosition(60, 16);
            Console.Write(playerText);
        }

        //public void EnemyAttack()
        //{
        //    Random Count = new Random();
        //    int attackCount = Count.Next(5, 10);

        //    // 랜덤 위치에서 적의 공격을 발사
        //    for (int j = 0; j < attackCount; j++)
        //    {
        //        // 각 공격에 대해
        //        for (int i = 0; i < enemyAttacks.Length; i++)
        //        {
        //            if (!enemyAttacks[i].fire) // 공격이 발사되지 않은 경우
        //            {
        //                enemyAttacks[i].fire = true;
        //                enemyAttacks[i].enemyAttX = enemyX - 3; // 적의 X 위치에서 시작
        //                enemyAttacks[i].enemyAttY = enemyY; // Y 위치를 랜덤으로 설정 (적과 관련된 Y 범위)
        //                break; // 한 번에 한 발만 발사
        //            }
        //        }
        //    }

        //    // 두 번째 공격 배열에서 미사일 발사 (Y 좌표가 enemyY + 2로 설정됨)
        //    for (int j = 0; j < attackCount; j++)
        //    {
        //        for (int i = 0; i < enemyAttacks2.Length; i++)
        //        {
        //            if (!enemyAttacks2[i].fire) // 공격이 발사되지 않은 경우
        //            {
        //                enemyAttacks2[i].fire = true;
        //                enemyAttacks2[i].enemyAttX = enemyX - 1; // 적의 X 위치에서 시작
        //                enemyAttacks2[i].enemyAttY = enemyY + 2; // Y 좌표를 적Y + 2로 설정
        //                break; // 한 번에 한 발만 발사하도록
        //            }
        //        }
        //    }
        //}

        //public void UpdateAttacks()
        //{
        //    // 모든 공격의 위치를 업데이트
        //    for (int i = 0; i < enemyAttacks.Length; i++)
        //    {
        //        if (enemyAttacks[i].fire)
        //        {
        //            Console.SetCursorPosition(enemyAttacks[i].enemyAttX, enemyAttacks[i].enemyAttY);
        //            Console.Write("◁"); // 공격 표시

        //            enemyAttacks[i].enemyAttX--; // 왼쪽으로 이동

        //            // 화면 밖으로 나가면 비활성화
        //            if (enemyAttacks[i].enemyAttX < 0)
        //            {
        //                enemyAttacks[i].fire = false; // 발사 상태를 false로 변경
        //            }
        //        }
        //    }

        //    for (int i = 0; i < enemyAttacks2.Length; i++)
        //    {
        //        if (enemyAttacks2[i].fire)
        //        {
        //            Console.SetCursorPosition(enemyAttacks2[i].enemyAttX, enemyAttacks2[i].enemyAttY);
        //            Console.Write("◁"); // 두 번째 공격 표시

        //            enemyAttacks2[i].enemyAttX--; // 왼쪽으로 이동

        //            // 화면 밖으로 나가면 비활성화
        //            if (enemyAttacks2[i].enemyAttX < 0)
        //            {
        //                enemyAttacks2[i].fire = false; // 발사 상태를 false로 변경
        //            }
        //        }
        //    }
        //}

        
        //아이템 클래스
        //public class Item
        //{
        //    public string ItemName;
        //    public string ItemSprite;
        //    public int itemX = 0;
        //    public int itemY = 0;
        //    public bool ItemLife = false;

        //    public void ItemDraw()
        //    {
        //        Console.SetCursorPosition(itemX, itemY);
        //        ItemSprite = "Item★";
        //        Console.Write(ItemSprite);
        //    }

        //    public void ItemMove()
        //    {
        //        //if(itemX <=1 || itemY <=1)
        //        //{
        //        //    ItemLife = false;
        //        //}


        //    }




        //}
    }

    public class Map
    {
        public void map()
        {
            Console.SetCursorPosition(0, 15);
            Console.Write("   ==========================================================================");
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

    public class Start
    {
        Stage stage1 = new Stage();

        public void gamestart()
        {
            Console.SetCursorPosition(3, 3);
            Console.Write(" ==========================================================================");
            Console.SetCursorPosition(5, 6);
            Console.Write("______________________________________________________________________");
            Console.SetCursorPosition(3, 7);

            Console.Write("      __                                  __                            ");
            Console.SetCursorPosition(3, 8);

            Console.Write("    /    )                              /    )                          ");
            Console.SetCursorPosition(3, 9);

            Console.Write(" --/----------__----_--_-----__---------\\-------_/_-----__----)__---_/_-");
            Console.SetCursorPosition(3, 10);

            Console.Write("  /  --,    /   )  / /  )  /___)         \\      /     /   )  /   )  /   ");
            Console.SetCursorPosition(3, 11);

            Console.Write("_(____/____(___(__/_/__/__(___ ______(____/____(_ ___(___(__/______(_ __");

            Console.SetCursorPosition(3, 14);
            Console.Write(" ==========================================================================");

            Console.SetCursorPosition(20, 18);
            Console.Write("Y : 게임 시작              N : 게임 종료");

            ConsoleKeyInfo StartKey = Console.ReadKey(true);
            if (StartKey.Key == ConsoleKey.Y)
            {

                Console.Clear();

                stage1.StageNumber1();
                Thread.Sleep(2000);
            }
            else if (StartKey.Key == ConsoleKey.N)
            {
                Console.SetCursorPosition(35, 18);
                Console.WriteLine("게임을 종료합니다.");
            }
            else
            {
                Console.SetCursorPosition(35, 21);
                Console.WriteLine("잘못된 입력입니다!");
            }


        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //인코딩 폰트 안 깨지기
            Console.CursorVisible = false;

            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            //플레이어 생성
            Player player = new Player();
            Enemy enemy = new Enemy(); //적생성
            Map map1 = new Map();
            Stage stage1 = new Stage();
            Start start1 = new Start();

            //유니티처럼 속도 프레임속도
            int dwTime = Environment.TickCount;  // 1/1000 초가 흐른다.

            start1.gamestart();

            while (true) //무한반복
            {
                //0.05초 지연
                if (dwTime + 50 < Environment.TickCount)
                {
                    //현재시간 세팅
                    dwTime = Environment.TickCount;
                    Console.Clear();

                    //플레이어
                    player.GameMain();

                    //enemy.EnemyAttack();
                    //enemy.EnemyAttMove();//적이동
                    enemy.EnemyDraw();//적그리기
                    //enemy.UpdateAttacks();

                    map1.map();

                    //충돌처리
                    player.ClashEnemyAndBullet(enemy);
                }
            }
        }
    }
}
