using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnboxingGame
{
    public class Program
    {
        public static void Main()
        {

            Game game = new Game(GameStorage.BuildDefaultStorage());
            game.ChooseName();
        }
    }
}
