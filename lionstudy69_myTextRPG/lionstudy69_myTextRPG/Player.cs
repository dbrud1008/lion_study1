using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy69_myTextRPG
{
    public class Player
    {
        public info m_info;

        //데미지 입는 함수
        public void damage(int attack) { m_info.hp -= attack; }

        public info getinfo() { return m_info; }
        public void sethp(int hp) { }


        //직업 선택
        public void job()
        {
            m_info = new info();

            Console.WriteLine("직업을 선택하세요");
            Console.WriteLine("1. 기사   2. 마법사  3. 도둑");
            int input = 0;

            input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    m_info.name = "기사";
                    m_info.attack = 30;
                    m_info.hp = 100;
                    break;
                case 2:
                    m_info.name = "마법사";
                    m_info.attack = 15;
                    m_info.hp = 150;
                    break;
                case 3:
                    m_info.name = "도둑";
                    m_info.attack = 25;
                    m_info.hp = 130;
                    break;
            }

            
        }

        public void Render()
        {
            Console.WriteLine("========================");
            Console.WriteLine("직업 이름: "+ m_info.name);
            Console.WriteLine("체력: "+ m_info.hp + "\t공격력: " + m_info.attack);
        }


        public Player() { }

        ~Player() { } //소멸자
    }
}
