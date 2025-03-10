using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy44_null
{
    class Program
    {
        static void Main(string[] args)
        {
            ////null값
            ////참조형식 null을 가질 수 있으며, 값 형식은 기본적으로 null읕 가질 수 없다.

            //string str = null;

            //if (str == null) //null 초기화
            //{
            //    Console.WriteLine("str is null");
            //}


            //int? nullableInt = null;
            //Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");

            //nullableInt = 10;

            //Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");



            ////null 값을 다루는 연산자 소개하기 ?? , ?. 연산자
            ////?? 연산자를 이용해 null인 경우 대체값을 제공하고, ?.은 null안전 접근을 합니다.
            //string str = null;

            //Console.WriteLine(str ?? "DefaultValue"); //str이 null이면 "DefaultValue" 출력

            //str = "Hello";
            //Console.WriteLine(str?.Length); //str이 null이 아니므로 길이 출력



            ////LINQ : 확장 메서드 형태로 제공
            ////LINQ(Language Integrated Query)를 사용해 컬렉션을 쿼리할 수 있다.
            ////짝수를 출력하는 코드를 좀 더 간편히 할 수 있음
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //var evenNumbers = numbers.Where(n => n % 2 == 0);

            //foreach (var num in evenNumbers)
            //{
            //    Console.WriteLine(num);
            //}
        }
    }
}
