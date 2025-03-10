using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy73_textRPG_test
{
    class GameManager
    {
        public Player info = null;
        public Field info_Field = null;

        public void Initialize()
        {
            info = new Player();
            info.Job();
        }

        public void Progress()
        {
            int iInput = 0;
            while (true)
            {
                Console.Clear();
                info.Render(); //플레이어 출력
                Console.WriteLine("1.사냥터 2.종료 : ");
                iInput = int.Parse(Console.ReadLine());

                if (iInput == 2)
                    break;


                if (iInput == 1)
                {
                    //사냥터 구현
                    if (info_Field == null)
                    {
                        info_Field = new Field();
                        //필드로 갈때 플레이어 넣어주기
                        info_Field.SetPlayer(ref info);
                    }
                    info_Field.Progress();
                }
            }
        }

        public GameManager() { }
        ~GameManager() { }
    }
}
