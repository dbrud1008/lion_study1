using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy11_test1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!"); // 문자열 출력

            //Console.Write("이름을 입력해주세요.");

            Console.WriteLine("게임을 시작하시겠습니까? (Y/N): ");

            // 특정 키 입력 대기
            ConsoleKeyInfo keyInfo = Console.ReadKey(true); // true를 주면 입력한 문자를 숨기는 옵션

            // 입력한 키에 따라 행동
            if (keyInfo.Key == ConsoleKey.Y) // Y 키를 체크
            {
                Console.WriteLine("\n게임 시작합니다!");
                // 게임 시작 로직
            }
            else if (keyInfo.Key == ConsoleKey.N) // N 키를 체크
            {
                Console.WriteLine("\n게임을 종료합니다.");
                // 게임 종료 로직
            }
            else
            {
                Console.WriteLine("\n잘못된 입력입니다. Y 또는 N을 입력하세요.");
            }
        }
    }
}
