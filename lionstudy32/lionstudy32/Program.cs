using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy32
{
    //클래스
    //데이터들을 모아서 함수(메서드)을 묶는 느낌 -> new 키워드로 할당
    //구조체랑 비슷함
    class Person
    {
        public string Name;
        public int Age;

        //기본생성자
        //클래스가 객체로 생성될때 자동으로 실행되는 특별한 메서드
        //클래스와 같은 이름을 가지며, 반환형이 없다 (void도 사용하지 않음)
        //객체를 만들때 필요한 초기값을 설정할 때 사용 많이한다.
        
        public Person(string name, int age) //외부에서 입력 받아서 넣어주려고 함
        {
            //초기화 해준 값이 public string name, public int age에 들어감
            Name = name;
            Age = age;
            Console.WriteLine("매개변수있는 생성자가 실행됨");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름: {Name}, 나이: {Age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ////내장형 구조체
            //DateTime now = DateTime.Now; //현재 시간을 불러냄
            //Console.WriteLine($"Current Date and Time: {now}");

            //TimeSpan duration = new TimeSpan(1, 30, 0); //시간을 표시해주는 형태
            //Console.WriteLine($"Duration: {duration}"); //01:30:00



            //class Person
            Person p1 = new Person("철수", 25); //객체 생성 (instance)
            p1.ShowInfo();

            Person p2 = new Person("영희", 30);
            p2.ShowInfo();

        }
    }
}
