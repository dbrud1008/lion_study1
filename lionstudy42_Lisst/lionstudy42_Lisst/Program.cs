using System;
using System.Collections;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy42_Lisst
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1. List : 가변의 크기를 저장할 때 사용
            //List<string> names = new List<string> { "Alice", "Bob", "Charlie" };

            //names.Add("Dave");
            //names.Remove("Bob");

            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}////1. List : 가변의 크기를 저장할 때 사용
            //List<string> names = new List<string> { "Alice", "Bob", "Charlie" };

            //names.Add("Dave");
            //names.Remove("Bob");

            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}




            //1-1.
            //List<int> list = new List<int>();

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);

            ////foreach(int i in list)
            ////{
            ////    Console.WriteLine(i);
            ////}

            ////Console.WriteLine(list[1]);
            ////list.Insert(1, 100);
            ////Console.WriteLine(list[1]);

            ////Console.WriteLine(list[0]);

            //list.Insert(1, 100);
            //Console.WriteLine(list.Count);

            //list[2] = 200;

            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}



            //1 - 2. Stack

            //Stack stack = new Stack(); //위의 using 제너릭 삭제하면 타입을 안 써도 사용 가능

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);

            //while(stack.Count>0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}


            //1 - 3. Queue
            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);

            //while (queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}

            ////1 - 4. 실습
            //Queue queue = new Queue();

            //queue.Enqueue("q");
            //queue.Enqueue("w");
            //queue.Enqueue("e");
            //queue.Enqueue("r");
            //queue.Enqueue("점멸");
            //queue.Enqueue("평타");


            //while (queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}


            ////1 - 5. ArrayList
            //ArrayList arrayList = new ArrayList();

            ////요소추가
            //arrayList.Add(1); //정수
            //arrayList.Add("Hello"); //문자열
            //arrayList.Add(3.14); //실수

            ////요소 접근
            //Console.WriteLine("ArrayList 요소:");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            ////요소 제거
            //arrayList.Remove(1); //값이 1인 요소 제거

            //Console.WriteLine("\n ArrayList 요소 제거 후: ");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}


            ////1 - 7. Hashtable 클래스
            ////키-값 쌍을 저장하는 컬렉션이다.
            ////키를 이용해 값을 빠르게 검색

            //Hashtable hashtable = new Hashtable();

            //hashtable["Alice"] = 25;
            //hashtable["Bob"] = 30;
            //hashtable["포션"] = 20;

            //Console.WriteLine("Hashtable 요소: ");

            //foreach(DictionaryEntry entry in hashtable)
            //{
            //    Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            //}

            ////특정 키의 값을 가져오기
            //Console.WriteLine($"\n Alice의 나이: {hashtable["Alice"]}");

            ////요소 제거
            //hashtable.Remove("Bob");

            //Console.WriteLine("Hashtable 요소: ");

            //foreach (DictionaryEntry entry in hashtable)
            //{
            //    Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            //}

        }
    }
}
