using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy72_BrickGame
{
    class Program
    {
        [DllImport("msvcrt.dll")]
        public static extern int _getch(); //c언어 함수 가져오기

        public static void gotoxy(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //인코딩 폰트 안 깨지기
            Console.CursorVisible = false; // 커서 없애기

            Console.SetWindowSize(80, 25); // 콘솔 창 크기 설정 (가로 80, 세로 25)
            Console.SetBufferSize(80, 25); // 버퍼 크기도 동일하게 설정 (스크롤 방지)

            GameManager gm = new GameManager();
            gm.Initialize();

            int Curr = Environment.TickCount;

            while(true)
            {
                if(Curr+50 < Environment.TickCount)
                {
                    Curr = Environment.TickCount;

                    gm.Progress();
                    gm.Render();
                }
            }
        }
    }
}
