namespace Monopoly.Core
{
    public class Player
    {
        public Player()
        {
            Money = 1500;
        }

        public int Position { get; private set; }

        public int Money { get; set; }
        

        public void AdvanceByRollingDice()
        {
            Position += Dice.Roll();
        }
    }
}