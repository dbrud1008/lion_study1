using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy34
{
    //캡슐화
    //클래스 안에 서로 연관되어 있는 속성과 기능을 하나로 만들어 데이터를 외부로부터 보호하는 것
    class Person
    {
        //public string name; //내부 변수

        ////값 설정하기 (Setter)**
        ////세터 함수(주로 set을 붙여서 함)
        //public void SetName(string newName)
        //{
        //    name = newName;
        //}

        ////값 가져오기 (Getter)**
        //public string GetName()
        //{
        //    return name;
        //}

        //private string name; //내부변수

        //public string Name //프로퍼티
        //{
        //    //getter setter를 간편히 한 번에 쓴다.
        //    get { return name; } //Getter
        //    set { name = value; } //Setter
        //}

        public string Name { get; set; } //자동 구현 프로퍼티

        public int Count
        {
            get { return Count; }
        }
        public float Balance { get; private set; } //외부 변경 불가

        public void AddBal()
        {
            Balance += 100;
        }

    }

    //마린클래스 프로퍼티 이용해서 이름과 미네랄 만들기
    //이름: 마린, 미네랄: 50
    class Marin
    {
        public string Name { get; private set; } = "마린";
        public int Mineral { get; set; } = 100;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //C#에서 get/set 방식의 함수와 프로퍼티 비교
            //객체의 값을 읽고(get), 설정(set)하는 방식으로 함수(get/set 메서드) 또는
            //** 프로퍼티 (property)** 사용할 수 있다.
            //Person p = new Person();

            //p.Name = "홍길동";
            //p.AddBal(); //외부에선 바꿀 수 없다.

            //Console.WriteLine("이름: " + p.Name + " Count: " + p.Count + " Balance" +p.Balance);

            Marin m = new Marin();
            Console.WriteLine("이름: " + m.Name + "미네랄: " + m.Mineral);
        }
    }
}
