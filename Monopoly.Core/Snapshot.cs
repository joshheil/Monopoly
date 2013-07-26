using System.Collections.Generic;

namespace Monopoly.Core
{
    public class Snapshot
    {
        private readonly IList<Player> _players;

        public Snapshot(IList<Player> players)
        {
            _players = players;
        }

        public IEnumerable<Player> Players { get { return _players; } }

        public void AddPlayer(Player player)
        {
            _players.Add(player);
        }
    }
}