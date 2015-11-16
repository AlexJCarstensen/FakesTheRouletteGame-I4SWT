namespace RouletteGame
{
    public class EvenOddBet : Bet
    {
        private readonly bool _evenOdd;
        public EvenOddBet(string playerName, uint amount, bool evenOdd) : base(playerName, amount)
        {
            _evenOdd = evenOdd;
        }

        public override uint WonAmount(Field field)
        {
            if (field.Even == _evenOdd) return 2*Amount;
            return 0;
        }

        public override string ToString()
        {
            var evenOddString = _evenOdd ? "even" : "odd";
            return $"{Amount}$ even/odd bet on {evenOddString}";
        }
    }
}