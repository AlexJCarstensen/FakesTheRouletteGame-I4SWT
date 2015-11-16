using RouletteGame.Roulette;

namespace RouletteGame.Bets
{
    public class ColorBet : Bet
    {
        private readonly uint _color;
        public ColorBet(string playerName, uint amount, uint color) : base(playerName, amount)
        {
            _color = color;
        }

        public override uint WonAmount(Field field)
        {
            if (field.Color == _color)
            {
                return 2*Amount;
            }
            return 0;
        }

        public override string ToString()
        {
            string colorString;
            switch (_color)
            {
                case Field.Red:
                    colorString = "Red";
                    break;
                case Field.Black:
                    colorString = "Black";
                    break;
                default:
                    colorString = "Green";
                    break;
            }
            return $"{Amount}$ color bet on {colorString}";
        }
    }
}