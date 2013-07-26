using System.Linq;
using Machine.Specifications;
using Monopoly.Core;

namespace Monopoly.Tests
{
    [Subject(typeof (Game))]
    public class when_playing_the_game
    {
        private Establish context = () =>
        {
            _game = new Game();
            _player1 = new Player();
            _player2 = new Player();
            _game.Start(new[] { _player1, _player2 });
        };

        private Because of = () =>
        {
            _snapshot = _game.WhereAreWe();
        };

        It should_know_the_current_position_of_each_player = () =>
        {
            _snapshot.Players.First().Position.ShouldEqual(0);
            _snapshot.Players.Second().Position.ShouldEqual(0);
        };

        private static Game _game;
        private static Snapshot _snapshot;
        private static Player _player1;
        private static Player _player2;
    }
}