using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy50_class_and_4
{
    //업캐스팅(Upcasting)
    //자식 클래스->부모클래스로 변환하는것
    //암시적 변환이 가능(컴파일러가 자동변환)
    //안전: 데이터 손실 없이 변환가능

    class Animal //부모 클래스
    {
        public void Speak()
        {
            Console.WriteLine("동물이 소리를 냅니다.");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("멍멍!");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();  //자식 클래스 객체 생성
            Animal myAnimal = myDog; //업캐스팅(Dog->animal)

            myAnimal.Speak(); //사용가능 

            ///myAnimal.Bark()  오류 업캐스팅후 자식 클래스의 메서드는 접근 불가

        }
    }
}
