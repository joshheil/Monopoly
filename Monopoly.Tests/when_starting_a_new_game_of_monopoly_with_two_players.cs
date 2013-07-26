using System;
using Machine.Specifications;
using Monopoly.Core;

namespace Monopoly.Tests
{
    public class when_starting_a_new_game_of_monopoly_with_two_players
    {
        private Because of = () => _board = Game.Start(new[] { new Player(), new Player() });

        private It should_create_a_board = () => _board.ShouldNotBeNull();

        It should_start_both_players_on_the_start_square = () =>
        {
            
        };

        private static Board _board;
    }
}