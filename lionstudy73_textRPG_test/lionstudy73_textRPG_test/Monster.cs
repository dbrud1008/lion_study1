using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy73_textRPG_test
{
    class Monster
    {
        public INFO info_monster;

        public void SetDamage(int attack) //데미지 받음
        {
            info_monster.hp -= attack;
        }

        public INFO GetMonster()
        {
            return info_monster;
        }

        public void SetMonster(INFO monster)
        {
            info_monster = monster;
        }

        public void Render()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("몬스터 이름: " + info_monster.name);
            Console.WriteLine("공격력: " + info_monster.attack, "체력: " + info_monster.hp);
        }

        public Monster() { }
        ~Monster() { }
    }
}
