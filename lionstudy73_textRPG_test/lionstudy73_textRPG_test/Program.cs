using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy73_textRPG_test
{
    class Program
    {
        static void Main(string[] args)
        {
            GameManager mainGame = new GameManager();
            mainGame.Initialize();
            mainGame.Progress();
        }
    }
}
