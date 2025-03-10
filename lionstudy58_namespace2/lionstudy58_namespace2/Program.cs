using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy58_namespace2
{
    class Person
    {
        private string name;  //필드 클래스의 데이터를 저장한는 멤버
        //private : 외부에서 못 쓰게 막기

        public void SetName(string n)
        {
            name = n;
        }
        public string GetName()
        {
            return name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.SetName("Bob");
            Console.WriteLine(p.GetName());
        }
    }
}
