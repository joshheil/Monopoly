using System.Linq;
using Machine.Specifications;
using Monopoly.Core;

namespace Monopoly.Tests
{
    [Subject(typeof(Game))]
    public class when_playing_the_game_after_one_round
    {
        private Establish context = () =>
        {
            _game = new Game();
            _player1 = new Player();
            _player2 = new Player();
            _game.Start(new[] { _player1, _player2 });
            _game.GoThroughARound();
        };

        private Because of = () =>
        {
            _snapshot = _game.WhereAreWe();
        };

        It should_know_the_current_position_of_player_1 = () =>
        {
            _snapshot.Players.First().Position.ShouldBeGreaterThanOrEqualTo(1);
            _snapshot.Players.First().Position.ShouldBeLessThanOrEqualTo(6);
        };

        It should_know_the_current_position_of_player_2 = () =>
        {   
            _snapshot.Players.Second().Position.ShouldBeGreaterThanOrEqualTo(1);
            _snapshot.Players.Second().Position.ShouldBeLessThanOrEqualTo(6);
        };

        private static Game _game;
        private static Snapshot _snapshot;
        private static Player _player1;
        private static Player _player2;
    }
}