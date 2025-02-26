using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy24_함수_문제
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q7. 두 수의 합을 구하는 함수
            //Console.WriteLine("두 개의 정수를 입력하세요 ");
            //string input = Console.ReadLine();
            //string[] numbers = input.Split(' ');

            //int num1 = int.Parse(numbers[0]);
            //int num2 = int.Parse(numbers[1]);

            //Console.WriteLine($"{num1}과 {num2}의 합: {Add(num1, num2)}");


            //Q8. 문자열을 입력받아 길이를 반환하는 함수
            //Console.Write("문자열 입력: ");
            //string input = Console.ReadLine();
            //Console.WriteLine("문자열 길이: " + back(input));


            //Q9. 세 개의 정수를 입력받아 가장 큰 값을 반환하는 함수를 작성하세요.
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("가장 큰 수: " + maxnum(a, b, c));

        }

        static int maxnum(int a, int b, int c)
        {
            int max = 0;
            if (a > b && a > c)
            {
                max = a;
            }
            else if (b > a && b > c)
            {
                max = b;
            }
            else
            {
                max = c;
            }
            return max;
        }

        static int back(string input)
        {
            return input.Length;
        }



        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
