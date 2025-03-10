using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy46
{
    class Program
    {
        static void Main(string[] args)
        {
            ////OrderBy 순차적 정렬
            //string[] names = { "Charlie", "Alice", "Bob" };
            //var sortedNames = names.OrderBy(n => n);

            ////람다식 아래의 코드를 축약한 것을 n => n
            ////int Identity(int n){ return n; }

            //foreach (var name in sortedNames)
            //{
            //    Console.WriteLine(name);
            //}

            ////A로 시작하는 첫번째 문자열을 찾는 코드
            //var firstName = names.First(n => n.StartsWith("A"));

            //Console.WriteLine($"First name starting with A: {firstName}");



            ////메서드구문, 쿼리 구문
            //int[] nums = { 5, 3, 8, 1 };

            ////메서드 구문
            //var sortedMeshod = nums.OrderByDescending(n => n);

            ////쿼리 구문
            //var sortedQuery = from n in nums
            //                  orderby n
            //                  select n;

            //Console.WriteLine("Meshod syntax: ");
            //foreach (var n in sortedMeshod)
            //    Console.WriteLine(n);

            //Console.WriteLine("Query syntax: ");
            //foreach (var n in sortedQuery)
            //{
            //    Console.WriteLine(n);
            //}



            //Select()로 길이 추출
            //select 개념 : 조건에 따라서 각 요소를 새로운 형태(컬렉션)로 변환
            //string[] words = { "apple", "banana", "cherry" };
            //var lengths = words.Select(w => w.Length);

            //foreach (var length in lengths)
            //{
            //    Console.WriteLine(length);
            //}

            ////대문자로 변환
            //var upperWords = words.Select(w => w.ToUpper());
            //foreach(var word in upperWords)
            //{
            //    Console.WriteLine(word);
            //}


            ////sum 알고리즘
            //int[] data = { 1, 2, 3, 4, 5 };
            //int sum = 0;

            //foreach (var d in data) 
            //    sum += d;

            //Console.WriteLine($"Sum: {sum}");


            ////count 알고리즘
            //float[] data = { 80, 75, 71 };

            ////int count = data.Length; //개수
            ////Console.WriteLine($"Count: {count}");

            //double avg = data.Average();
            //Console.WriteLine($"Average: {avg}");


            ////MAX 알고리즘
            //int[] data = { 10, 3, 5, 2, 8 };
            //int max = data.Max();
            //Console.WriteLine($"Max: {max}");


            ////Min 알고리즘
            //int[] data = { 10, 3, 5, 2, 8 };

            //int min = data.Min();
            //Console.WriteLine($"Min : {min}");



            ////NEAR 알고리즘 (근삿값)
            ////특정 값에 가장 가까운 값을 찾는 것
            //int[] data = { 10, 12, 20, 25, 30 };
            //int target = 22;
            //int nearest = data[0];

            //foreach(var d in data)
            //{
            //    if (Math.Abs(d - target) < Math.Abs(nearest - target))
            //        nearest = d; //Math.Abs = 절댓값으로 변환 ( 마이너스도 양수로 만들어줌 )
            //}

            //Console.WriteLine($"Nearest to {target}: {nearest}");



            ////RANK 알고리즘 (순위)
            ////각 요소가 몇 번째로 큰지 순위 매기기
            //int[] scores = { 90, 70, 50, 70, 40 };

            //for(int i = 0; i<scores.Length; i++)
            //{
            //    int rank = 1;
            //    for(int j = 0; j<scores.Length; j++)
            //    {
            //        if (scores[j] > scores[i])
            //            rank++;
            //    }
            //    Console.WriteLine($"Score: {scores[i]}, Rank: {rank}");

            //}



            ////SORT 알고리즘 (순서대로 나열)
            //int[] data = { 5, 2, 8, 1, 9 };
            //Array.Sort(data);

            //foreach (var d in data)
            //{
            //    Console.WriteLine(d);
            //}



            ////SEARCH 알고리즘 (특정 값 검색)
            //int[] data = { 5, 2, 8, 1, 9 };
            //int target = 8;
            //int index = -1;

            //for(int i = 0; i<data.Length; i++)
            //{
            //    if (data[i] == target)
            //    {
            //        index = i;
            //        break;
            //    }
            //}
            //Console.WriteLine(index >= 0 ? $"Found at index {index}" : "Not Found");



            //GROUP 알고리즘 (특정 기준으로 그룹화)
            string[] fruits = { "apple", "banana", "blueberry", "cherry", "apricot" };

            //LINQ의 GroupBy()를 사용
            var groups = fruits.GroupBy(f => f[0]); //첫 글자로 그룹화

            foreach(var group in groups)
            {
                Console.WriteLine($"Key: {group.Key}"); //Key: a Key: b Key: c

                //해당 그룹에 속한 모든 요소 출력
                foreach(var item in group)
                {
                    Console.WriteLine($" {item}");
                }
            }
        }
    }
}
