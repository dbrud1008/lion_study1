using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy43_generics
{
    class Program
    {
        //1 - 8. 제너릭 사용하기 (Generics)
        //<T> 특정 타입에 종속되지 않은 범용 클래스를 만들 수 있다. (모든 타입을 가져올 수 있음)
        //class Cup<T>
        //{
        //    public T Content { get; set; }
        //}


        //커스텀 마이징
        class SimpleCollection: IEnumerable<int>
        {
            private int[] data = { 1,2,3,4,5};
            public IEnumerator<int> GetEnumerator()
            {
                foreach(var item in data)
                {
                    yield return item;
                }
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        static void Main(string[] args)
        {
            var collection = new SimpleCollection();

            foreach(var i in collection)
            {
                Console.WriteLine(i);
            }



            //Cup<string> cupOfString = new Cup<string> { Content = "Coffee" };
            //Cup<int> cupOfInt = new Cup<int> { Content = 42 };

            //Console.WriteLine($"CupOfString: {cupOfString.Content}");
            //Console.WriteLine($"cupOfInt: {cupOfString.Content}");


            ////후입선출 구조(거꾸로 출력)
            //Stack<int> stack = new Stack<int>();

            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);

            //while(stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}



            //List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            //names.Add("Dave");

            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}



            ////IEnumberator
            ////C# 컬렉션 순ㄴ회 반복할 수 있는 인터페이스
            //ArrayList list = new ArrayList { "Apple", "Banana", "Cherry"};
            //IEnumerator enumerator = list.GetEnumerator();

            //while(enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current);
            //}



            //Dictionary <T,T> 제너릭 클래스
            Dictionary<string, int> ages = new Dictionary<string, int>();

            ages["금도끼"] = 10;
            ages["은도끼"] = 5;
            ages["돌도끼"] = 1;
            
            foreach(var pair in ages)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }

        }
    }
}
