namespace Monopoly.Core
{
    public class Player
    {
        public int Position { get; private set; }

        public void AdvanceByRollingDice()
        {
            Position += Dice.Roll();
        }
    }
}