using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy72_BrickGame
{
    public class Wall
    {
        public WallData m_wall = new WallData();

        public void Initialize()
        {
            m_wall.x = 0;
            m_wall.y = 0;

        }

        public void Progress()
        {

        }

        public void Render()
        {
            //Random rand = new Random();

            Console.SetCursorPosition(2, 10);
            Console.Write("■");
            Console.SetCursorPosition(3, 10);
            Console.Write("■");
            Console.SetCursorPosition(4, 10);
            Console.Write("■");

        }
    }
}
