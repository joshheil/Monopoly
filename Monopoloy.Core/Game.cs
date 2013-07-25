using System;

namespace Monopoloy.Core
{
    public class Game
    {
        private readonly Player[] _players;

        public Game(Player[] players)
        {
            _players = players;
        }

        public void Start()
        {
            if (_players.Length < 2)
            {
                throw new Exception("Insufficient number of players");
            }
        }
    }
}