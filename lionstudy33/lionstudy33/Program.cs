using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy33
{
    //마린 클래스를 만드세요.
    //이름, 미네랄
    //기본생성자, 인자 있는 생성자
    class Marin
    {
        public string Name;
        public int mineral;

        public Marin()
        {
            Name = "마린";
            mineral = 50;
        }

        public Marin(string _name, int _ral)
        {
            Name = _name;
            mineral = _ral;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름: {Name}, 미네랄: {mineral}");
        }
    }


    //배럭클래스를 만드세요 barracks (스타 이름임.,.)
    //Barracks 150
    //this 키워드를 사용해보자!
    //this란? 자기자신을 가르킨다.
    
    class Barracks
    {
        public string Name;
        public int mineral;
        public Barracks()
        {
            Name = "배럭";
            mineral = 150;
        }

        public Barracks(string Name, int mineral)
        {
            this.Name = Name; //헷갈리는 변수명 때문에 프로그램이 인식하기 힘들어 표시해놓는 느낌, 같은 이름을 쓰고 싶을때
            this.mineral = mineral;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름: {Name}, 미네랄: {mineral}");
        }
    }



    class Scv
    {
        public string Name;
        public int mineral;

        public Scv()
        {
            Name = "마린";
            mineral = 50;
        }

        public Scv(string _name, int _ral)
        {
            Name = _name;
            mineral = _ral;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름: {Name}, 미네랄: {mineral}");
        }
    }

    class Mineral
    {
        public int mineral;

        public Mineral()
        {
            mineral = 1500;
        }

        public void SnowInfo()
        {
            Console.WriteLine($"미네랄: {mineral}");
        }
    }

    //Game 클래스 만들기
    class Game
    {
        //static 키워드가 있을 때
        public static int mineral;
        public static int gas;
        public static int charCount;

        public static void ShowInfo()
        {
            Console.WriteLine($"미네랄 {mineral} | 가스 {gas} | 인구수 {charCount}");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Game.mineral = 50; // 위의 Game static 키워드가 있을때 바로 사용 가능
            Game.gas = 0;
            Game.charCount = 4;
            Game.ShowInfo();

            Marin marin = new Marin("불꽃테란", 100);
            Scv scv = new Scv("열받은 SCV", 70);
            Barracks barracks = new Barracks();

            //클래스의 배열
            Mineral[] mineral = new Mineral[7];

            //각 배열에 new 객체화
            for(int i = 0; i<mineral.Length; i++)
            {
                mineral[i] = new Mineral();
                mineral[i].SnowInfo();
            }

            marin.ShowInfo();
            scv.ShowInfo();
            barracks.ShowInfo();
        }
    }
}
