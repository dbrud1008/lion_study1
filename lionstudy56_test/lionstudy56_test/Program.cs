using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy56_test
{
    //부모클래스 (기본유닛)
    class Unit
    {
        public string Name;
        protected int Health;

        public Unit()
        {
            Name = "Unknown";
            Health = 0;
        }

        public virtual void Attack()
        {
            Console.WriteLine($"{Name}가 기본 공격을 합니다. ");
        }

        public virtual void Heal(Unit target)
        {
            Console.WriteLine($"{Name}은 자신을 치료하였습니다. ");
        }


        public virtual void Move()
        {
            Console.WriteLine($"{Name}가 이동합니다. ");
        }

        public virtual void Damage()
        {
        }
    }



    //SCV유닛 (건설과 수리 기능)
    class Shop : Unit
    {
        public Shop()
        {
            Name = "기지";
            Health = 999;
        }

        public override void Attack()
        {
            Console.WriteLine("기지에서 아이템을 구매하였다.");
        }


        public override void Heal(Unit target)
        {
            Console.WriteLine($"기지에 돌아온 {target.Name}의 체력과 마나를 충전하였다.");
        }

    }

    //Marine 유닛(총기 공격)
    class Ari : Unit
    {
        public Ari()
        {
            Name = "아리";
            Health = 40;
        }

        public override void Attack()
        {
            Console.WriteLine("아리가 구슬로 마법 피해를 입혔다!");
        }

        public override void Damage()
        {
            Console.WriteLine("아리는 50 데미지를 입었다.");
        }
    }

    //medic
    class Soraka : Unit
    {
        public Soraka()
        {
            Name = "소라카";
            Health = 50;
        }

        public override void Heal(Unit target)
        {
            Console.WriteLine($"소라카가 {target.Name}을 치료한다.");
        }
    }


    //Tank유닛(강력한 공격)
    class Zedd : Unit
    {
        public Zedd()
        {
            Name = "제드";
            Health = 150;

        }

        public override void Attack()
        {
            Console.WriteLine("제드가 예리한 표창으로 공격한다!");
        }


        public override void Move()
        {
            Console.WriteLine("그림자 스킬로 이동한다.");
        }

        public override void Damage()
        {
            Console.WriteLine("제드는 아리의 공격에 맞아 치명상을 입었다.");
        }

    }




    class Program
    {
        // Unit units = new SCV();
        static void Main(string[] args)
        {
            List<Unit> units = new List<Unit>();
            
            units.Add(new Ari());
            units.Add(new Zedd());
            units.Add(new Soraka());
            units.Add(new Shop());


            //모든 유닛을 순회하며 다형성 적용
            foreach (var unit in units)
            {
                unit.Attack(); //공격
                unit.Damage();
                Console.WriteLine();
            }


            //SCV가 탱크 수리 시도
            Shop scv = new Shop();
            scv.Heal(units[1]);

            //Medic이 Marince 치료시도
            Soraka medic = new Soraka();
            medic.Heal(units[0]); //Marine을 치료

        }
    }
}
