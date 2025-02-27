using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy28
{
    class Program
    {
        //열거형이란?
        //Enumeration  enum
        //숫자 값에 이름을 부여하는 자료형
        //가독성을 높ㅇ고, 의미 있는 값으로 표현 가능
        //기본적으로 첫 번째 값은 0부터 시작하며 1씩 증가

        //기본적으로 enum 사용법
        enum DayOfWeek
        {
            Sunday, //0
            Monday, //1
            Tuesday, //2
            Wednesday, //3
            Thursday, //4
            Friday, //5
            Saturday //6
        }


        //2. enum 값 변경 (0부터 시작하고 싶지 않을때)
        enum StatusCode
        {
            Success = 200,
            BadRequest = 400,
            Unaauthorized = 401,
            NotFound = 404
        }

        
        enum Weapontype
        {
            Sword,
            bow,
            Staff
        }

        static void ChooseWeapon(Weapontype weapon)
        {
            if(weapon == Weapontype.Sword)
            {
                Console.WriteLine("검을 선택했습니다.");
            }
            else if(weapon == Weapontype.bow)
            {
                Console.WriteLine("활을 선택했습니다.");
            }
            else if(weapon == Weapontype.Staff)
            {
                Console.WriteLine("지팡이를 선택했습니다.");
            }
        }

        static void Main(string[] args)
        {
            ////Math 클래스 사용
            ////수학적 계산
            //Console.WriteLine($"Pi: {Math.PI}");
            //Console.WriteLine($"Square root of 25: {Math.Sqrt(25)}");
            //Console.WriteLine($"Power (2^3): {Math.Pow(2,3)}");
            //Console.WriteLine($"Round(3.75): {Math.Round(3.75)}");

            //DayOfWeek today = DayOfWeek.Wednesday;

            ////숫자를 직접 사용하지 않고, 의미 있는 이름으로 관리 가능
            //Console.WriteLine(today);
            //Console.WriteLine((int)today);


            //StatusCode status = StatusCode.NotFound;
            //Console.WriteLine(status);
            //Console.WriteLine((int)status);

            ChooseWeapon(Weapontype.Sword);
        }
    }
}
