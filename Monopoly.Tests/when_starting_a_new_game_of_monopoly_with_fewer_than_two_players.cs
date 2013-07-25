using System;
using Machine.Specifications;
using Monopoloy.Core;

namespace Monopoly.Tests
{
    public class when_starting_a_new_game_of_monopoly_with_fewer_than_two_players
    {
        private Establish context = () =>
        {
            _game = new Game(new [] { new Player() });  
        };

        private Because of = () => _exception = Catch.Exception(() => _game.Start());

        private It should_not_start_the_game = () => _exception.Message.ShouldEqual("Insufficient number of players");

        private static Game _game;
        private static Exception _exception;
    }
}