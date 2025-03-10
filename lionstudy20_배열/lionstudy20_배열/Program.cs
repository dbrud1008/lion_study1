using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy20_배열
{
    class Program
    {
        static void Main(string[] args)
        {
            //배열
            //중요한 점: 0부터 시작한다.

            //int[] num = new int[3]; //3개 메모리를 만들겠다. new = 할당

            //num[0] = 10;
            //num[1] = 20;
            //num[2] = 30;
            ////3개를 넘어가면 안됨.

            ////Console.WriteLine(num[0]);
            ////Console.WriteLine(num[1]);
            ////Console.WriteLine(num[2]);

            //반복문 배열 이용
            //for(int i =0; i<3; i++) // 0 1 2 순차적으로 반복되는 것
            //{
            //    Console.WriteLine(num[i]);
            //}


            //배열 선언 방법 3가지
            //int[] numbers = { 1, 2, 3 }; //배열은 중괄호로 담고, 간단한 선언과 초기화
            int[] numbers2 = new int[3]; //크기만 지정
            //int[] numbers3 = new int[] { 1, 2, 3 }; //초기화와 함께 선언 --> 개수를 보면서 메모리에 넣어짐


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(numbers2[i]);
            }

            //string[] fruits = { "사과", "바나나", "오렌지" }; //문자열의 배열

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(fruits[i]); //꺼내야 하는 번호 i = 인덱스
            //    //0번 : 사과, 1번: 바나나, 2번: 오렌지
            //}

            ////응용 실습
            ////3명의 국어, 영어, 수학 점수를 입력받고 총점과 평균을 출력하세요.
            //int[] iKor = new int[3]; //국어 점수 3명
            //int[] iEng = new int[3]; //영어 점수 3명
            //int[] iMath = new int[3]; //수학 점수 3명

            //int[] sum = new int[3]; //3개의 총점
            //float[] aver = new float[3]; //3개의 평균

            //for (int i = 0; i < 3; i++)
            //{
            //    //학생 입력 받기
            //    Console.WriteLine("학생 성적 입력하세요 ");
            //    Console.Write("국어: ");
            //    iKor[i] = int.Parse(Console.ReadLine()); //0번에 점수 입력
            //    Console.Write("영어: ");
            //    iEng[i] = int.Parse(Console.ReadLine()); //0번에 점수 입력
            //    Console.Write("수학: ");
            //    iMath[i] = int.Parse(Console.ReadLine()); //0번에 점수 입력
            //    // 입력을 3번 받고 3번 돌림

            //    sum[i] = iKor[i] + iEng[i] + iMath[i];

            //    aver[i] = (float)sum[i] / 3; //총합의 나누기 3을 통해 실수형으로 변환 후 평균 구하기
            //}

            ////출력
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine((i + 1) + "번 학생");
            //    Console.WriteLine($"국어: {iKor[i]} 영어: {iEng[i]} 수학: {iMath[i]}");
            //    Console.WriteLine("총점: " + sum[i]);
            //    Console.WriteLine("평균: " + aver[i].ToString("F2")); //소수점 2번째자리까지 보여주세요.
            //}


            ////1차원 배열
            //int[] score = new int[3];

            //score[0] = 90;
            //score[1] = 85;
            //score[2] = 88;

            //for (int i = 0; i < score.Length; i++) //score.Length = 3, 배열이 몇개인지 잘 모를때를 위해 유용하게 쓰이는 것, 배열 전체
            //{
            //    Console.WriteLine($"점수 {i + 1} : {score[i]}");
            //}


            //double value = 123.456789;
            ////소수점 자릿수를 설정하는 포맷
            //Console.WriteLine(value.ToString("F4"));

            //Console.WriteLine($"소수점 둘째자리: {value:F2}");

            //Console.WriteLine(String.Format("소수점 둘째자리: {0:F2}", value));

            //Console.WriteLine(value.ToString("F0")); //소수점 없이 정수만 출력


            //double value = 123_123_213.12323;
            //Console.WriteLine(value.ToString("N2")); //쉼표 찍는다


            ////2차원 배열 선언
            //int[,] matrix = new int[2, 3] //좌표에서 반대로 된 느낌 3이 가로, 2가 세로 총 6개
            ////{
            ////    //[2,3]의 예시
            ////    {1,2,3 },
            ////    {4,5,6 }
            ////};
            //{{1,2,3},{4,5,6}};

            //for (int i = 0; i < 2; i++) //i가 0잍 때, j의 반복문 다 돌고 i 반복문으로 돌아와 3번 반복
            //{
            //    Console.WriteLine("i = " + i);
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine("j = " + j);
            //    }
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{matrix[i, j]}");
            //    }
            //    Console.WriteLine();
            //}



            //int[][] matrix = new int[2][]; //2개 박스를 가져오고
            //matrix[0] = new int[3]; // 1개의 박스 안에 3개의 구역으로 나누었다.
            //matrix[1] = new int[3];

            ////값 입력, 박스마다 숫자 하나씩 넣어줌
            //matrix[0][0] = 1;
            //matrix[0][1] = 2;
            //matrix[0][2] = 3;

            //matrix[1][0] = 4;
            //matrix[1][1] = 5;
            //matrix[1][2] = 6;

            ////출력
            //for (int i = 0; i < matrix.Length; i++)
            //{
            //    for (int j = 0; j < matrix[i].Length; j++)
            //    {
            //        Console.Write(matrix[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            //가변 배열
            //퍼즐류에서 2차원배열 필수!
            //Console.WriteLine("가변 배열");
            //int[][] jaggedArray = new int[3][]; //빈 곳을 유동적으로 넣을 것이다.

            //jaggedArray[0] = new int[] { 1, 2 };
            //jaggedArray[1] = new int[] { 3, 4, 5 };
            //jaggedArray[2] = new int[] { 6 };

            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        Console.Write($"{jaggedArray[i][j]}");
            //        Console.WriteLine();
            //    }
            //}

            //Console.WriteLine("var 키워드 사용");
            //var numbers = new[] { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"배열 타입: {numbers.GetType()}");

            //배열의 배열이란것(가변 배열)은 사실 배열 안에 다른 배열을 집어넣는 개념입니다.
            //먼저 행 개념의 배열을 만들고 그 다음 열 개념의 배열을 행 개념의 배열안에 집어넣는 것이죠.
            //그래서 말하신대로 int[][y] 로 초기화를 하면 안될 겁니다
            //int[행][열] 이라고 생각하시면 될듯 합니다.


            //string[] fruits = { "사과", "바나나", "체리" };

            ////반복문
            //foreach (string fruit in fruits)// 새로운 변수를 만들어서 대신 순환하게함
            //{
            //    Console.WriteLine(fruit);
            //}

        }
    }
}
