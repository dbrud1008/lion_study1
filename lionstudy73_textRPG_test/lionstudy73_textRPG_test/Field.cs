using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy73_textRPG_test
{
    class Field
    {
        Player info = null;
        Monster info_monster = null;

        public void SetPlayer(ref Player player)
        {
            info = player;
        }


        //싸울 공간
        public void Progress()
        {
            int input = 0;

            while(true)
            {
                Console.Clear();
                info.Render();
                DrawMap();

                input = int.Parse(Console.ReadLine());

                if (input == 4)
                    break;
                if (input <= 3)
                {
                    switch(input)
                    {
                        case 1:
                            Create("초보몹", 30, 3, out info_monster);
                            break;
                        case 2:
                            Create("중수몹", 50, 6, out info_monster);
                            break;
                        case 3:
                            Create("고수몹", 70, 9, out info_monster);
                            break;

                    }
                }
            }
        }

        public void Fight()
        {
            int iInput = 0;

            while(true)
            {
                Console.Clear();
                info.Render();
                info_monster.Render();

                Console.WriteLine("1. 공격  2. 도망");
                iInput = int.Parse(Console.ReadLine());

                if(iInput == 1)
                {
                    info.SetDamage(info_monster.GetMonster().attack);

                    info_monster.SetDamage(info.GetInfo().attack);

                    if(info.GetInfo().hp <=0)
                    {
                        info.SetHp(100);
                        break;
                    }
                }

                if(iInput == 2 || info_monster.GetMonster().hp <= 0)
                {
                    info_monster = null;
                    break;
                }
            }
        }


        public void Create(string m_name, int m_attack, int m_hp, out Monster monster)
        {
            monster = new Monster();
            INFO info_monster = new INFO();

            info_monster.name = m_name;
            info_monster.attack = m_attack;
            info_monster.hp = m_hp;

            monster.SetMonster(info_monster);
        }

        public void DrawMap()
        {
            Console.WriteLine("1. 초보맵");
            Console.WriteLine("2. 중수맵");
            Console.WriteLine("3. 고수맵");
            Console.WriteLine("4. 전단계");
            Console.WriteLine("=============");
            Console.WriteLine("맵을 선택하세요 : ");
        }

        public Field() { }

        ~Field() { }
    }
}
