namespace RouletteGame
{
    public class NumberBet : Bet
    {
        private readonly uint _fieldNumber;
        public NumberBet(string playerName, uint amount, uint fieldNumber) : base(playerName, amount)
        {
            _fieldNumber = fieldNumber;
        }

        public override uint WonAmount(Field field)
        {
            if (field.Number == _fieldNumber) return 36*Amount;
            return 0;
        }

        public override string ToString()
        {
            return $"{Amount}$ field bet on {_fieldNumber}";
        }
    }
}