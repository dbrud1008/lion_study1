using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace lionstudy40_Environment
{
    ////6. 클래스 시그니처 기본구성
    ////C#에서 클래스 시그니처는 클래스의 선언부를 의미한다.

    ////[접근 지정자]         [수정자]       class 클래스 이름 : 부모클래스, 인터페이스
    ////public(공개)          abstract      클래스 이름       : BaseClass, IComparable
    ////private(비공개)       sealed
    ////protected(상속된)     static
    ////                     partial

    ////기본클래스
    //public class Player //부모
    //{
    //    public string Name { get; set; }
    //    public int Score { get; set; }
    //}
    ////상속하는 클래스
    //public class Warrior : Player //자식
    //{
    //    public int Strength { get; set; }
    //}
    ////인터페이스 구현하는 클래스
    //public class Enemy :  IAttackable, IMovable
    //{
    //    public void Attack() { }
    //    public void Move() { }
    //}

    ////추상 클래스 (abstract)
    //public abstract class Animal
    //{
    //    public abstract void MakeSound();
    //}
    class Program
    {
        static void Main(string[] args)
        {
            ////1. 프로그램 강제 종료
            //Console.WriteLine("Exiting the program...");
            //Environment.Exit(0);


            ////2. 환경 변수
            //string path = Environment.GetEnvironmentVariable("PATH");
            //Console.WriteLine($"PATH: {path}");


            ////3. Random 클래스
            //Random random = new Random();
            //int randomNumber = random.Next(1, 101); //1부터 100까지
            //Console.WriteLine("랜덤 숫자: " + randomNumber);


            ////4. 프로그램 실행 시간 구하기
            //Stopwatch stopwatch = Stopwatch.StartNew();
            ////실행코드
            //for(int i = 0; i<100; i ++)
            //{
            //    Thread.Sleep(1); //계산이 너무 빠르기에 0.001초씩 멈춘다.
            //}

            //stopwatch.Stop();

            //Console.WriteLine($"Execution Time: {stopwatch.ElapsedMilliseconds} ms");



            ////5. 정규식 Regex = Regular Expression
            ////회원가입 및 로그인에 활용 가능한 기능
            ////전화번호와 비슷한 패턴을 검색 및 검사를 잘할 수 있게 ex) 전화번호, 이메일 등
            //string input = "Hello, my phone number is 123-456-7890";

            ////전화번호만 추출하기
            //string pattern = @"^\d{3}-\d{3}-\d{4}$"; //전화번호 패턴
            //bool isMatch = Regex.IsMatch(input, pattern);

            //Console.WriteLine($"전화번호가 존재하는가?: {isMatch}");

        }


    }
}
