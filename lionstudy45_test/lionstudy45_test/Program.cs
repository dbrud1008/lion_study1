using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy45_test
{
    class Program
    {

        //public class Warrior
        //{
        //    public string name;
        //    public int score;
        //    public int strength;
        //}

        static void Main(string[] args)
        {

            //Q1.
            //Warrior warrior = new Warrior();
            //warrior.name = "용사";
            //warrior.score = 100;
            //warrior.strength = 50;

            //Console.WriteLine($"이름: {warrior.name} 점수: {warrior.score} 힘: {warrior.strength}");

            //Q2.
            //Console.Write("정수를 입력하세요: ");
            //try
            //{
            //    int Input = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"올바른 숫자: {Input}");
            //}
            //catch(FormatException)
            //{
            //    Console.WriteLine("올바른 숫자를 입력하세요!");
            //}


            ////Q3.
            //List<string> names = new List<string> { "사과", "바나나", "포도" };
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //Queue queue = new Queue();
            //queue.Enqueue("첫 번째 작업");
            //queue.Enqueue("두 번째 작업");
            //queue.Enqueue("세 번째 작업");

            //Console.WriteLine("");

            //while (queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}

            //Console.WriteLine("");

            //Stack<int> stack = new Stack<int>();

            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);

            //while(stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}


            ////Q4.
            //Console.Write("문자열을 입력하세요: ");
            //string Input = Console.ReadLine();

            //Console.WriteLine($"ToUpper: {Input.ToUpper()}");
            //Console.WriteLine($"replaced C#: {Input.Replace("C#", "CSharp")}");
            //Console.WriteLine($"Length of name: {Input.Length}");


            //Q5.
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = numbers.Where(n => n % 2 == 0);

            Console.WriteLine("[짝수]");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("");

            int sum = numbers.Sum();
            Console.WriteLine("숫자의 합: " + sum);





        }
    }
}
