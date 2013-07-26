using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monopoly.Core;

namespace Monopoly.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            var board = game.Start(new[] {new Player(), new Player()});
            game.WhereAreWe();
        }
    }
}
