using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy69_myTextRPG
{
    public class Monster
    {
        public info m_monster;
        public void damage(int attack) { m_monster.hp -= attack;  }

        public void monster(info tmonster) { m_monster = tmonster; }
        public info getmonster() { return m_monster; }

        public void Render()
        {
            Console.WriteLine("========================");
            Console.WriteLine("몬스터 이름: " + m_monster.name);
            Console.WriteLine("체력: " + m_monster.hp + "\t공격력: " + m_monster.attack);
        }

        public Monster() { }
        ~Monster() { }
    }
}
