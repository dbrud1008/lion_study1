using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy59_Person
{
    class Person
    {
        public string Name;
        public int Age;
        public Person() //생성자
        {
            Name = "Unknown";
            Age = 0;
        }

        public Person(string name) //매개변수가 다른 생성자
        {
            Name = name;
            Age = 0;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person(); //생성자 호출
            Person p1 = new Person("Bob"); //1개의 매개변수 있는 생성자
            Person p2 = new Person("카타리나", 20); //2개의 매개변수 (name, age)

            Console.WriteLine(p.Name + ", " + p.Age);
            Console.WriteLine(p1.Name + ", " + p1.Age);
            Console.WriteLine(p2.Name + ", " + p2.Age);
        }
    }
}
