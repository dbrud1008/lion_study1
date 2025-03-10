using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy41_is
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1. 값 형식과 참조 형식
            ////스택에 저장되고, 참조형식은 힙에 저장된다.

            //int valueType = 10;
            //object referenceType = valueType;

            //valueType = 20;

            //Console.WriteLine($"ValueType: {valueType}"); //20
            //Console.WriteLine($"Reference: {referenceType}"); //10


            ////2. 박싱 언박싱
            ////값 형식을 참조형식으로 변환(박싱) , 다시 값 형식으로 변환(언박싱)

            //int value = 42;
            //object boxed = value; //박싱
            //int unboxed = (int)boxed; //언방식

            //Console.WriteLine($"Boxed: {boxed}, Unboxed : {unboxed}");


            ////3. is 연산자 형식 비교하기
            ////객체가 특정 형식인지 확인할 수 있다.
            //object obj = "Hello";

            //Console.WriteLine(obj is string); //true - 문자열이냐?의 형식 질문에 대한 답변
            //Console.WriteLine(obj is int); //false - 정수형이냐? 형식 질문에 대한 답변


            ////4. as 연산자로 형식 변환하기
            ////안전하게 형 변환 가능

            //object obj = "Helllo";
            //string str = obj as string;

            //Console.WriteLine(str is string);



            ////5. 패턴 매칭: if 문과 is연산자 사용
            //var obj = 42;

            //if(obj is int number)
            //{
            //    Console.WriteLine($"Number: {number}");
            //}
            //else
            //{
            //    Console.WriteLine("Not a number");
            //}


            ////6. 문자열 다루기
            //string greeting = "Hello";
            //string name = "Alice";

            //string message = greeting + "," + name + "!";
            //Console.WriteLine(message);

            //Console.WriteLine($"Length of name: {name.Length}"); //문자열 길이
            //Console.WriteLine($"To Upper {name.ToUpper()}"); //대문자 변환
            //Console.WriteLine($"Substring: {name.Substring(1)}"); //q부분 문자열


            ////6 - 1. 문자열 처리 관련 주요 API 살펴보기
            ////string 다양한 메서드
            //string text = "C# is awesome!";
            //Console.WriteLine($"Cotains 'awesome' : {text.Contains("awesome")}");
            //Console.WriteLine($"Starts with 'C#' : {text.StartsWith("C#")}");
            //Console.WriteLine($"Index of 'is' : {text.IndexOf("is")}");
            //Console.WriteLine($"Replace 'awesome' with 'great' : {text.Replace("awesome", "great")} ");



            ////6 - 2. StringBuilder 클래스
            ////효율적인 문자열 연결 작업
            //StringBuilder sb = new StringBuilder("Hello");
            //sb.Append(",");
            //sb.Append("World!");
            //Console.WriteLine(sb.ToString());



            ////6 - 3. String과 StringBuiler 클래스 성능차이 비교
            ////반복적으로 문자열을 수정할때 StringBuilder가 효율적이다.
            //int iterations = 10000;
            //Stopwatch sw = Stopwatch.StartNew();

            //string text = "";

            //for(int i =0; i<iterations; i++)
            //{
            //    text += "a";
            //}

            //sw.Stop();
            //Console.WriteLine($"String: {sw.ElapsedMilliseconds}ms");

            //sw.Restart();
            //StringBuilder sb = new StringBuilder();

            //for(int i =0; i<iterations; i++)
            //{
            //    sb.Append("a");
            //}

            //sw.Stop();
            //Console.WriteLine($"StringBuilder: {sw.ElapsedMilliseconds}ms");



            ////7. 예외처리하기
            ////예외는 프로그램 실행 중 발생하는 오류.
            ////예외를 처리하면 프로그램이 중단되지 않고 실행을 계속할 수 있다.
            ////try catch
            ////게임을 실행하면서 오류를 잡고 싶을 때 사용

            //while (true)
            //{
            //    try
            //    {
            //        int[] numbers = { 1, 2, 3 };
            //        Console.WriteLine(numbers[5]); //오류 발생
            //    }
            //    catch (IndexOutOfRangeException ex) //오류 잡기
            //    {
            //        Console.WriteLine($"Error: {ex.Message}");
            //    }
            //}


            ////7 - 1. finally 블록은 에외 발생여부와 상관없이 항상 실행된다.
            //try
            //{
            //    int number = int.Parse("NotNumber"); //오류 발생
            //}
            //catch(FormatException ex)
            //{
            //    Console.WriteLine($"Format Error: {ex.Message}");
            //}
            //finally
            //{
            //    Console.WriteLine("항상 실행됩니다.");
            //}


            ////7 - 2. Exception 클래스로 예외 처리
            //try
            //{
            //    int nuumber = int.Parse("abc");
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine($"General Error: {ex.Message}");
            //}


            ////7 - 3. throw 구문으로 직접 예외 발생시키기
            //try
            //{
            //    int age = -5;
            //    if (age < 0)
            //    {
            //        throw new ArgumentException("Age cannot be negative");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Exception : {ex.Message}");
            //}





        }
    }
}
