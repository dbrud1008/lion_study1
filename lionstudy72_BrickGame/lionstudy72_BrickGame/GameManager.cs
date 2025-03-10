using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy72_BrickGame
{
    public class GameManager
    {
        Ball ball = null;
        Bar m_PBar = null;
        Wall m_wall = null;

        public void Initialize()
        {
            if (ball == null)
            {
                ball = new Ball();
                ball.Initialize();
            }

            //바
            if (m_PBar == null)
            {
                m_PBar = new Bar();
                m_PBar.Initialize();
            }

            if (m_wall == null)
            {
                m_wall = new Wall();
                m_wall.Initialize();
            }

            //볼에서 바와 벽돌을 사용해야 할 것 같다.
            ball.SetBar(m_PBar);
        }

        public void Progress()
        {
            ball.Progress();
            m_PBar.Progress(ref ball);
        }

        public void Render()
        {
            Console.Clear();
            ball.Render();
            m_PBar.Render();
        }

        public void Release()
        {
            ball.Release();
            m_PBar.Release();
        }

    }
}
