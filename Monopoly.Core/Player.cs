namespace Monopoly.Core
{
    public class Player
    {
        private int _position;

        public int Position { get { return _position; } }

        public void AdvanceByRollingDice()
        {
            _position += Dice.Roll();
        }
    }
}