using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy13
{
    class Program
    {
        static void Main(string[] args)
        {
            //증감 연산자
            //int b = 3;

            //전위++b
            //++b;
            //Console.WriteLine("b의 값은: " + b);
            //++b;
            //Console.WriteLine("b의 값은: " + b);

            ////후위 b++
            //b++;
            //Console.WriteLine("b의 값은: " + b);

            //// -> 전위, 후위의 차이
            //Console.WriteLine("b의 값은: " + (++b)); //전위는 지금 27번 코드에서 더해줌 +1
            //Console.WriteLine("b의 값은: " + (b++)); //후위는 지금 28번 코드에서 안 더하고 다음 29번 코드부터 더해줌
            //Console.WriteLine("b의 값은: " + (b));   //그래서 29번 라인은 +1 된 값으로 나옴

            //--b;
            //Console.WriteLine("b의 값은: " + b);


            //두 값을 비교하여 관계를 평가한다.
            // == 같다 != 같지않다 a<b, c> d, <= , =>
            //int x = 5, y = 10;

            //Console.WriteLine(x < y); // 비교이기 때문에 true or false
            //Console.WriteLine(x == y); // 같은가?의 질문으로 같지 않아서 false
            //Console.WriteLine(x != y); // 같지 않은가?의 질문으로 true
            //Console.WriteLine(x > y); // 비교인데 틀렸음 false
            //Console.WriteLine(x >= y); // x가 크거나 작냐?의 질문으로 false
            //Console.WriteLine(x <= y); // y가 크거나 작냐?의 질문으로 true


            //논리 연산자
            //bool a = true, b = false;
            //Console.WriteLine(a && b); //AND : a랑 b가 true로 참이어야 됨, 아니면 false, true를 1로 표현
            //Console.WriteLine(a || b); //OR : 둘 중 하나만 true여도 true, 둘 다 false면 false
            //Console.WriteLine(!a); // NOT : false

            //bool a = false;
            //bool b = false;

            //b = !a;
            //Console.WriteLine(b); //ture
            //// a가 b를 덮어씌워버림 그래서 b가 false든 true든 a의 값으로 나옴


            //비트 연산자
            //8421
            //int x = 5; //0101
            //int y = 3; //0011

            //Console.WriteLine(x & y); // And : 1 (0001)
            //Console.WriteLine(x | y); // OR : 7 (0111)
            //Console.WriteLine(x ^ y); // XOR : 같은 것을 더하면 0이 됨 ex) 1+1 = 0, 0+0 = 0 (0110)
            //// 0101
            //// 0011
            //// -> 0110
            //Console.WriteLine(~x); //NOT : -6


            //시프트 연산자
            //int value = 4; //0100
            //Console.WriteLine(value << 1); //왼쪽이동 : 8 (1000) -> *2
            //Console.WriteLine(value << 2); //왼쪽이동 : 16 = 2x2x4
            //Console.WriteLine(value >> 1); //오른쪽 이동 : 2 (0010) -> /2


            ////삼항 연산자
            //int a = 10, b = 20;

            //int max;

            //max = (a < b) ? a : b;
            //// 1. (a < b) 비교 => false
            //// 2. ( 비교 ) ? 참 : 거짓 ;
            //// 3. 비교 했을 때 false 이면 b의 값이 max가 되고, true이면 a의 값이 max가 된다.
            //Console.WriteLine(max);

            ////응용법
            //int key = 1;

            //string str;
            //str = (key == 1) ? "문이 열렸습니다." : "문이 열리지 않았습니다.";

            //Console.WriteLine(str); //문이 열렸습니다.


            //연산자 우선 순위
            int result = 10 + 2 * 5; //곱셈이 덧셈보다 우선
            Console.WriteLine(result);

            int adjustedResult = (10 + 2) * 5; //괄호 우선
            Console.WriteLine(adjustedResult);

        }
    }
}
