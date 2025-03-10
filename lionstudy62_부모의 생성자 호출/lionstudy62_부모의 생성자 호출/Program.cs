using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy62_부모의_생성자_호출
{
    class Parent
    {
        public Parent(string message)
        {
            Console.WriteLine("부모생성자" + message);
        }
    }

    class Child : Parent
    {
        public Child():base("성공~") //부모 생성자 호출
        {
            Console.WriteLine("자식생성자 호출");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
        }
    }
}
