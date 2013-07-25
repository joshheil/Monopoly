using System;
using Machine.Specifications;
using Monopoly.Core;

namespace Monopoly.Tests
{
    public class when_starting_a_new_game_of_monopoly_with_two_players
    {
        private Establish context = () =>
        {
            _game = new Game(new[] { new Player(), new Player()});
        };

        private Because of = () => _exception = Catch.Exception(() => _game.Start());

        private It should_start_the_game = () => _exception.ShouldBeNull();

        private static Game _game;
        private static Exception _exception;
    }
}