using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy69_myTextRPG
{
    public class Field
    {
        Player F_player = null;
        Monster F_monster = null;

        public void SetPlayer(ref Player Fplayer) { F_player = Fplayer; }

        public void Progress()
        {
            int input = 0;

            while (true)
            {
                Console.Clear();

                F_player.Render();
                DrawMap();

                input = int.Parse(Console.ReadLine());

                if (input == 4)
                    break;
                if (input <= 3)
                {
                    CreateMonster(input);
                    Fight();
                }
            }
        }

        public void Create(string name, int hp, int attack, out Monster Fmonster)
        {
            Fmonster = new Monster();
            info tmonster = new info();

            tmonster.name = name;
            tmonster.hp = hp;
            tmonster.attack = attack;

            Fmonster.monster(tmonster);
        }

        public void CreateMonster(int input)
        {
            switch (input)
            {
                case 1:
                    Create("초보몹", 30, 5, out F_monster);
                    break;
                case 2:
                    Create("중급몹", 50, 7, out F_monster);
                    break;
                case 3:
                    Create("고수몹", 70, 10, out F_monster);
                    break;
            }
        }

        public void Fight()
        {
            int input = 0;

            while (true)
            {
                Console.Clear();
                F_player.Render();
                F_monster.Render();

                Console.WriteLine("1. 공격  2. 도망");
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    F_player.damage(F_monster.getmonster().attack);
                    F_monster.damage(F_player.getinfo().attack);

                    if (F_player.getinfo().hp <= 0)
                    {
                        F_player.sethp(100);
                        break;
                    }
                }
                if (input == 2 || F_monster.getmonster().hp <= 0)
                {
                    F_monster = null;
                    break;
                }
            }
        }

        public void DrawMap()
        {
            Console.WriteLine("1. 초보맵");
            Console.WriteLine("2. 중수맵");
            Console.WriteLine("3. 고수맵");
            Console.WriteLine("4. 전단계");
            Console.WriteLine("=============");
            Console.WriteLine("맵을 선택하세요: ");
        }

        public Field() { }
        ~Field() { }
    }
}
