using System;

namespace Monopoly.Core
{
    public class Dice
    {
        public static int Roll()
        {
            return new Random().Next(1, 6);
        }
    }
}