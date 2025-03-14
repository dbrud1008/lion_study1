﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //이진수를 정수로 변환
            //Console.Write("2진수를 입력하세요: ");
            //string binaryInput = Console.ReadLine(); //문자열을 입력 받는다
            //int decimalValue = Convert.ToInt32(binaryInput, 2); //2진수 -> 10진수 변환

            ////정수를 이진수로 변환
            //string binaryOutput = Convert.ToString(decimalValue, 2); //10진수 -> 2진수 변환

            //Console.WriteLine($"입력한 이진수: {binaryInput}");
            //Console.WriteLine($"10진수로 변환: {decimalValue}");
            //Console.WriteLine($"다시 이진수로 변환: {binaryOutput}");


            ////var를 사용하여 변수 선언
            //var name = "Alice"; //문자열로 추론
            //var age = 25; //정수로 추론
            //var isStudent = true; //논리값으로 추론

            //Console.WriteLine($"이름: {name}, 나이: {age}, 학생 여부: {isStudent}");


            ////default 키워드 사용한 기본값 설정
            //int defaultInt = default; //기본값: 0
            //string defaultString = default; //기본값: null'

            //bool defaultBool = default; //기본값: false

            //Console.WriteLine($"정수 기본값: {defaultInt}");
            //Console.WriteLine($"문자열 기본값: {defaultString}");
            //Console.WriteLine($"논리값 기본값: {defaultBool}");


            //연산자 활용
            //int a = 5, b = 3;
            //int sum = 0;

            //sum = a + b; //산술 연산자 사용
            //Console.WriteLine($"합: {sum}"); //출력 8 

            //sum = a - b; //산술 연산자 사용
            //Console.WriteLine($"합: {sum}"); //출력 8

            //sum = a * b; //산술 연산자 사용
            //Console.WriteLine($"합: {sum}"); //출력 8

            //sum = a / b; //산술 연산자 사용 -> 정수이기 때문에 소수점 불가능, 몫만 나옴
            //Console.WriteLine($"합: {sum}"); //출력 8

            //sum = a % b; //산술 연산자 사용 -> 나머지 값
            //Console.WriteLine($"합: {sum}"); //출력 8


            ////짝수 홀수 판별
            //int number = 7;
            //int sum = 0;
            //sum = number % 2; // 0 나오면 짝수, 1 나오면 홀수 --> 랜덤 몇개 뽑기 등 유용한 게 많음 
            //Console.WriteLine("짝수 홀수 판별: " + sum);


            //bool isEqual = false; // 거짓 0
            //int a = 5;
            //int b = 5;

            ////관계형 연산자
            //isEqual = (a == b); //a랑 b랑 같은가?

            //Console.WriteLine("같은가? " + isEqual);


            //단항 연산자
            //int number = 5;
            //bool flag = true;

            //Console.WriteLine(+number); //양수 출력: 5
            //Console.WriteLine(-number); //음수 출력: -5
            //Console.WriteLine(!flag); //논리 부정: false


            //~비트 반전
            //10 1010->이진수
            //   0101-> 0이 1로, 1이 0으로, 4바이트

            //int num = 10;
            //int result = ~num; //모든 비트 반전 1111 0101 결과 : -11

            //Console.WriteLine("원래 값: " + num);
            //Console.WriteLine("~ 연산자 적용 후: " + result);


            ////캐스팅
            //double pi = 3.14;
            //int integerPi = (int)pi; //실수형 -> 정수형 변환

            //Console.WriteLine(integerPi); //3


            ////평균값 구하기
            //int iKor = 90;
            //int iEng = 75;
            //int iMath = 58;

            //int sum = 0;
            //float average = 0.0f;

            //sum = iKor + iEng + iMath;
            //average = (float)sum / 3; //평균 -> 정수를 실수로 변환하던가
            //average = sum / 3.0f; //평균 -> 실수 하나로 나눈다던가..

            //Console.WriteLine("총점: " + sum);
            //Console.WriteLine("평균: " + average);

            //int a = 10, b = 3;
            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);
            //Console.WriteLine(a % b);


            ////문자열 연결 연산자
            //string firstName = "Alice";
            //string lastName = "Smith";

            //Console.WriteLine(firstName + " " + lastName); //출력: Alice Smith

            ////할당 연산자
            //int a = 10;
            //a += 5; // a = a + 5;
            //Console.WriteLine(a);
            //a -= 5; // a = a - 5;
            //Console.WriteLine(a);
            //a *= 5; // a = a * 5;
            //Console.WriteLine(a);
            //a /= 5; // a = a / 5;
            //Console.WriteLine(a);
            //a %= 5; // a = a % 5;
            //Console.WriteLine(a);
            //// -> 연결이 되면 누적이 된다
            //// 10 + 5 = 15
            //// 15 - 5 = 10
            //// 10 * 5 = 50
            //// 50 / 5 = 10
            //// 10 % 5 = 0



            //문제1. 학점 평균 계산 프로그램
            Console.Write("국어 점수를 입력하세요: ");
            int iKor = int.Parse(Console.ReadLine());

            Console.Write("영어 점수를 입력하세요: ");
            int iEng = int.Parse(Console.ReadLine());

            Console.Write("수학 점수를 입력하세요: ");
            int iMath = int.Parse(Console.ReadLine());

            int sum = iKor + iEng + iMath;
            float average = (float)sum / 3;

            Console.WriteLine("문제1. 학점 평균 계산 프로그램");
            Console.WriteLine("총점: " + sum);
            Console.WriteLine("평균: " + average);

            Console.WriteLine("============================");

            //문제2. 비트 반전(~) 연산자 활용 프로그램

            //~ 비트 반전
            //10 1010 -> 이진수
            //   0101 -> 0이 1로, 1이 0으로, 4바이트 

            Console.Write("정수를 입력하세요: ");
            int num = int.Parse(Console.ReadLine());
            int result = ~num;

            Console.WriteLine("문제2. 비트 반전(~) 연산자 활용 프로그램");
            Console.WriteLine("원래 값: " + num);
            Console.WriteLine("~ 연산자 적용 후: " + result);



        }
    }
}
