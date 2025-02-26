using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy23
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Q1. 배열 요소 출력
            ////크기가 5인 정수 배열을 만들고, {10,20,30,40,50} 값을 저장한 후 출력하세요.
            //int[] num = new int[] { 10, 20, 30, 40, 50 };
            ////반복문 배열 이용
            //for (int i = 0; i < 5; i++) // 0 1 2 순차적으로 반복되는 것
            //{
            //    Console.Write(num[i] + " ");
            //}

            //Q2. 배열 요소 합 구하기
            //사용자가 5개의 정수를 입력하면 배열에 저장하고, 모든 수의 합을 출력하세요.

            //int[] number = new int[5];
            //int sum = 0;

            //Console.Write("숫자 입력: ");

            //for (int i = 0; i < number.Length; i++)
            //{
            //    number[i] = int.Parse(Console.ReadLine()); 

            //    sum += number[i];
            //}

            //Console.WriteLine("총점: " + sum);


            //Q3. 최대값 찾기
            //정수 배열 {3, 8, 15, 6, 2}에서 가장 큰 값을 찾아 출력하세요.
            //int[] num = new int[5] { 3, 8, 15, 6, 2 };
            //int maxnumber = 0;
            //for (int i = 0; i<num.Length; i++)
            //{
            //    if (maxnumber < num[i])
            //        maxnumber = num[i];
            //}
            //Console.WriteLine("최대값: " + maxnumber);


            //반복문 문제
            //Q4. 1부터 10까지 출력 (for문)
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write(i+" ");
            //}


            //Q5. 짝수만 출력 (while문)
            //int a = 1;
            //while (a <= 10)
            //{
            //    if (a % 2 == 0)
            //    {
            //        Console.Write(a + " ");
            //    }
            //    a++;
            //}
            //Console.WriteLine();


            //Q6. 배열 요소 출력 (foreach문)
            // foreach문을 사용하여 배열 {1,2,3,4,5}의 요소를 출력하세요.
            //반복문
            int[] b = { 1,2,3,4,5 };
            foreach (int c in b)// 새로운 변수를 만들어서 대신 순환하게함
            {
                Console.Write(c+" ");
            }
        }
    }
}
