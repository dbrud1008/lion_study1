using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy3
{
    class Program
    {
        static void Main(string[] args)
        {
            //리터럴 : 코드에서 고정된 값을 의미
            int hp = 100; //정수형 리터럴
            double att = 56.7; //소수점인 실수형 리터럴
            char st = 'S';
            string name = "Ace";

            Console.WriteLine("캐릭터");
            Console.WriteLine("공격력: " + att);
            Console.WriteLine("체력: " + hp);
            Console.WriteLine("등급: " + st);
            Console.WriteLine("캐릭터 이름: " + name);
        }
    }
}
