using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy6
{
    class Program
    {
        static void Main(string[] args)
        {
            //char 형식 : 단일 문자를 표현
            //char letter = 'A'; //문자 'A' 저장
            //char symbol = '#'; //특수 기호 저장
            //char number = '9'; //숫자가 아닌 문자 9

            //Console.WriteLine(letter);
            //Console.WriteLine(symbol);
            //Console.WriteLine(number);


            //string 형식: 여러 문자를 저장
            //string greeting = "Hello world"; //문자열 저장
            //string name = "Alice"; //이름 저장

            //Console.WriteLine(greeting +" "+ name);


            // bool 형식 : 참(true) = 1 , 거짓 (false) = 0
            //bool isRun = true; //프로그램 실행 상태
            //bool isEnd = false; //프로그램 종료 상태

            //Console.WriteLine(isRun);
            //Console.WriteLine(isEnd);


            //닷넷 형식 : 기본 형식의 닷넷 표현
            //Int32 number = 123; //int닷넷 형식 (맨 위에 using System이 없으면 Int32 앞에 System.Int32 로 써야한다.)
            //String text = "Hello"; //string의 닷넷 형식
            //Boolean flag = true; // bool의 닷넷 형식

            //Console.WriteLine(number);
            //Console.WriteLine(text);
            //Console.WriteLine(flag);


            //int 래퍼 형식의 메서드 활용
            int number = 123;

            string numberAsString = number.ToString(); //정수를 문자열로 변환

            //bool 래퍼 형식
            bool flag = true;

            string flagAsString = flag.ToString(); //논리값을 문자열로 변환

            Console.WriteLine(numberAsString);
            Console.WriteLine(flagAsString);
        }
    }
}
