using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy69_myTextRPG
{
    class MainGame
    {
        public Player F_player = null;
        public Field F_Field = null;

        public void Initialize()
        {
            F_player = new Player();
            F_player.job();
        }

        public void Progress()
        {
            int input = 0;
            while(true)
            {
                Console.Clear();
                F_player.Render();
                Console.WriteLine("1. 사냥터  2. 종료 :  ");
                input = int.Parse(Console.ReadLine());

                if (input == 2)
                    break;

                if (input == 1)
                {
                    if(F_Field == null)
                    {
                        F_Field = new Field();
                        F_Field.SetPlayer(ref F_player);
                    }
                    F_Field.Progress();
                }
            }
        }

        public MainGame() { }
        ~MainGame() { }
    }
}
