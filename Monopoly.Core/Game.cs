using System;

namespace Monopoly.Core
{
    public class Game
    {
        private Player[] _players;

        public Player[] Players { get { return _players; } }

        public Board Start(Player[] players)
        {
            _players = players;
            if (players.Length < 2)
            {
                throw new Exception("Insufficient number of players");
            }

            return new Board();
        }

        public void GoThroughARound()
        {
            foreach (var player in _players)
            {   
                player.AdvanceByRollingDice();
            }
        }

        public Snapshot WhereAreWe()
        {
            var snapshot = new Snapshot(_players);
            return snapshot;
        }
    }
}