using Machine.Specifications;
using Monopoly.Core;

namespace Monopoly.Tests
{
    [Subject(typeof(Game))]
    public class when_the_game_goes_through_a_round
    {
        private Establish context = () =>
        {
            _game = new Game();
            _game.Start(new[] {new Player(), new Player()});
        };

        private Because of = () => _game.GoThroughARound();

        It should_advance_player1_by_the_roll_of_dice = () =>
        {
            var player1Position = _game.Players[0].Position;
            player1Position.ShouldBeGreaterThanOrEqualTo(1);
            player1Position.ShouldBeLessThanOrEqualTo(6);
        };

        It should_advance_player2_by_the_roll_of_dice = () =>
        {
            var player2Position = _game.Players[1].Position;
            player2Position.ShouldBeGreaterThanOrEqualTo(1);
            player2Position.ShouldBeLessThanOrEqualTo(6);
        };

        private static Game _game;
    }
}