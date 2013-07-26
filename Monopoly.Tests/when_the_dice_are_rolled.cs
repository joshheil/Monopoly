using Machine.Specifications;
using Monopoly.Core;

namespace Monopoly.Tests
{
    [Subject(typeof (Dice))]
    public class when_the_dice_are_rolled
    {
        private Because of = () =>
        {
            _rollOutcome = Dice.Roll();
        };

        It should_generate_a_number_between_1_and_6 = () =>
        {
            _rollOutcome.ShouldBeGreaterThanOrEqualTo(1);
            _rollOutcome.ShouldBeLessThanOrEqualTo(6);
        };

        private static int _rollOutcome;
    }
}