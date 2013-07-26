using System;

namespace Monopoly.Core
{
    public class Game
    {
        public static Board Start(Player[] players)
        {
            if (players.Length < 2)
            {
                throw new Exception("Insufficient number of players");
            }

            return new Board();
        }
    }
}