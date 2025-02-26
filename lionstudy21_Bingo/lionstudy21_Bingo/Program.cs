using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy21_Bingo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] iArray = new int[25];

            //////스왑
            ////int a = 10;
            ////int b = 20;
            ////int t = 0; //잠시 담는 용도 (임시)

            ////t = a; //t에 a값을 잠시! 집어넣음
            ////a = b; //a를 가져오고, b의 값을 a에 넣음
            ////b = t; //b를 가져오고, t의 값을 넣음

            ////Console.Write("a: " + a + " b: " + b);

            //////why? : a=b를 하면 b의 값이 a로 가기 때문에 a,b 둘 다 20으로 됨.
            //////t를 통해 a = 10, b = 20으로 서로 바꿔주는 방법
            //////C# 지원됨. ex) a,b = b,a

            ////1차원 배열
            //for(int i =0; i<25; i++)
            //{
            //    iArray[i] = i + 1; //i = 0 ~ 24까지의 인덱스를 가지고 있음. i + 1; 함수 때문에 1 ~ 25가 됨.
            //}

            //Random rand = new Random();
            ////셔플 숫자가 랜덤 배치
            //for (int i = 0; i < 100; i++)
            //{
            //    int iA = rand.Next(0, 25); //0 ~ 24
            //    int iB = rand.Next(0, 25);
            //    int iT = 0;

            //    iT = iArray[iA];
            //    iArray[iA] = iArray[iB];
            //    iArray[iB] = iT;
            //}


            //int input = 0;
            //int iCount = 0;
            //int iBingo = 0;

            //while (true)
            //{
            //    Console.Clear();
            //    //빙고판
            //    for (int i = 0; i < 5; i++)
            //    {
            //        for (int j = 0; j < 5; j++)
            //        {
            //            if (iArray[i * 5 + j] == 0) // 0일때 *추가
            //            {
            //                Console.Write(" * ");
            //            }
            //            else
            //            {
            //                Console.Write(iArray[i * 5 + j].ToString("D2") + " ");
            //            }

            //            //1. i가 0일때, j가 0일때 i*5+j = 0
            //            //2. j가 있는 반복문이 j가 최대 4가 될때까지 반복 => i가 0일때 0,1,2,3,4 출력
            //            //3. 다시 i 반복문으로 돌아가 i가 1이 되었을 때 j가 최대 4가 될때까지 반복 => 5,6,7,8,9 출력
            //            //-> 이런 식으로 총 5x5 빙고판이 나옴
            //        }
            //        Console.WriteLine();
            //    }

            //    Console.WriteLine("빙고 숫자: " + iBingo);
            //    Console.WriteLine("숫자를 입력하세요: "); //입력한 숫자가 *이 된다.
            //    input = int.Parse(Console.ReadLine());
            //    iBingo = 0;

            //    for (int i = 0; i < 25; i++)
            //    {
            //        if (iArray[i] == input)
            //        {
            //            iArray[i] = 0;
            //            break;
            //        }
            //    }


            //    //빙고가 됐는지 체크 로직

            //    //가로 체크
            //    for (int i = 0; i<5; i++)
            //    {
            //        for(int j=0; j<5; j++)
            //        {
            //            if (iArray[i * 5 +j] == 0) //가로로 0인지 찾는 것
            //            {
            //                ++iCount;
            //            }

            //            if(iCount == 5) //별이 5개이면
            //            {
            //                ++iBingo;
            //            }
            //        }
            //        iCount = 0;
            //    }

            //    //세로 체크
            //    for(int i =0; i<5; i++)
            //    {
            //        for(int j=0; j<5; j++)
            //        {
            //            if (iArray[i + 5 *j] == 0) // 0 + 5 * 0 => 0
            //                                       // 0 + 5 * 1 => 5
            //                                       // 0 + 5 * 2 => 10
            //                                       // -> 이런 방식으로 세로를 체크한다.
            //            {
            //                ++iCount;
            //            }

            //            if (iCount == 5)
            //            {
            //                ++iBingo;
            //            }
            //        }
            //        iCount = 0;
            //    }

            //    //대각선 오른쪽 체크
            //    //00 01 02 03 04
            //    //05 06 07 08 09
            //    //10 11 12 13 14
            //    //15 16 17 18 19
            //    //20 21 22 23 24

            //    //04 08 12 16 20 규칙을 찾기
            //    for(int i=0; i<5; i++)
            //    {
            //        if (iArray[i*4+4] == 0)
            //        {
            //            ++iCount;
            //        }

            //        if (iCount == 5)
            //        {
            //            ++iBingo;
            //        }
            //    }
            //    iCount = 0;

            //    //대각선 왼쪽 체크
            //    //00 06 12 18 24 규칙을 찾기

            //    for (int i = 0; i < 5; i++)
            //    {
            //        if (iArray[i * 6] == 0)
            //        {
            //            ++iCount;
            //        }

            //        if (iCount == 5)
            //        {
            //            ++iBingo;
            //        }
            //    }
            //    iCount = 0;

            //    if(iBingo >= 5)
            //    {
            //        Console.WriteLine("빙고 성공");
            //        break;
            //    }

            //}

            // -------------------------

            int[,] board = new int[5, 5]; //5x5 빙고판
            bool[,] marked = new bool[5, 5]; //선택된 숫자 체크

            int bingoCount = 0;

            Random random = new Random();

            //빙고판 초기화
            int[] numbers = new int[25];

            for (int i = 0; i < 25; i++) 
                numbers[i] = i + 1;

            //랜덤 섞기(firsher-Yates shuffle)
            for(int i =0; i<100; i++)
            {
                int a = random.Next(25);
                int b = random.Next(25);

                //C#의 튜플(Tuple)문법을 활용하여 두 변수의 값을 교환(Swap)하는 방법
                (numbers[a], numbers[b]) = (numbers[b], numbers[a]);
            }

            //2차원 배열로 변환
            int index = 0;
            for(int i =0; i<5; i++)
            {
                for(int j=0; j<5; j++)
                {
                    board[i, j] = numbers[index++];
                }
            }

            while(bingoCount<5)
            {
                Console.Clear();

                //빙고판 출력
                Console.WriteLine("현재 빙고판");

                for(int i = 0; i<5; i++)
                {
                    for(int j=0; j<5; j++)
                    {
                        if (marked[i, j])
                            Console.Write(" X ");
                        else
                            Console.Write($"{board[i, j],2} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine($"현재 빙고 개수: {bingoCount}");
                Console.Write("숫자를 입력하세요(1 ~ 25): ");

                //숫자 입력
                int number = int.Parse(Console.ReadLine());

                bool found = false;
                for(int i = 0; i<5; i++)
                {
                    for(int j=0; j<5; j++)
                    {
                        if (board[i,j] == number)
                        {
                            marked[i, j] = true; //숫자를 X로 변경
                        }
                    }
                    if (found) break;
                }

                //빙고 개수 체크
                bingoCount = 0;

                //가로체크
                for(int i=0; i<5; i++)
                {
                    bool rowBingo = true;
                    for (int j = 0; j < 5; j++)
                        if (!marked[i, j]) rowBingo = false;
                    if (rowBingo) bingoCount++;
                }

                //세로체크
                for(int j=0; j<5; j++)
                {
                    bool colBingo = true;

                    for (int i = 0; i < 5; i++)
                        if (!marked[i, j]) colBingo = false;

                    if (colBingo) bingoCount++;
                }

                //대각선 체크 (왼쪽위 -> 오른쪽 아래)
                bool diag1Bingo = true;

                for(int i =0; i<5; i++)
                {
                    if (!marked[i, i]) diag1Bingo = false;
                }
                if (diag1Bingo) bingoCount++;

                //대각선 체크 (오른쪽위 -> 왼쪽 아래)
                bool diag2Bingo = true;

                for (int i = 0; i < 5; i++)
                    if (!marked[i, 4 - i]) diag2Bingo = false;

                if (diag2Bingo) bingoCount++;

            }
            //00 01 02 03 04
            //10 11 12 13 14
            //20 21 22 23 24
            //30 31 32 33 34
            //40 41 42 43 44

            Console.WriteLine("빙고 5개 완성! 게임 종료");
        }
    }
}
