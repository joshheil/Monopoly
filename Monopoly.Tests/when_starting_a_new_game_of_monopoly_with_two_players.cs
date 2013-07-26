using System;
using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;
using Monopoly.Core;

namespace Monopoly.Tests
{
    public class when_starting_a_new_game_of_monopoly_with_two_players
    {
        private Establish context = () =>
        {
            _game = new Game();
        };

        private Because of = () => _board = _game.Start(new[] { new Player(), new Player() });

        private It should_create_a_board = () => _board.ShouldNotBeNull();

        It should_start_both_players_on_the_start_square = () =>
        {
            var playersPositions = _game.GetPlayersPositions();
            playersPositions.All(x => x.Value.Equals(0)).ShouldBeTrue();
        };

        private static Game _game;
        private static Board _board;
    }
}