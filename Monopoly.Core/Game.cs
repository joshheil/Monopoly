using System;
using System.Collections.Generic;

namespace Monopoly.Core
{
    public class Game
    {
        private Dictionary<Player, int> _playersPositions;

        public Board Start(Player[] players)
        {
            if (players.Length < 2)
            {
                throw new Exception("Insufficient number of players");
            }

            _playersPositions = new Dictionary<Player, int>();
            foreach (var player in players)
            {
                _playersPositions.Add(player, 0);
            }

            return new Board();
        }

        public IDictionary<Player, int> GetPlayersPositions()
        {
            return _playersPositions;
        }
    }
}