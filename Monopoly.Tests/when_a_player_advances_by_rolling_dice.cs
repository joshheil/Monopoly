using System;
using Machine.Specifications;
using Monopoly.Core;

namespace Monopoly.Tests
{
    [Subject(typeof (Player))]
    public class when_a_player_advances_by_rolling_dice
    {
        private Establish context = () =>
        {
            _player = new Player();
        };

        private Because of = () => _player.AdvanceByRollingDice();

        It should_advance_players_position = () =>
        {
            _player.Position.ShouldBeGreaterThanOrEqualTo(1);
            _player.Position.ShouldBeLessThanOrEqualTo(6);
        };

        private static Player _player;
    }
}