using RouletteGame.Roulette;

namespace RouletteGame.Bets
{
    public class Bet : IBet
    {
        protected Bet(string playerName, uint amount)
        {
            PlayerName = playerName;
            Amount = amount;
        }


        public string PlayerName { get; }

        public uint Amount { get; }

        public virtual uint WonAmount(Field field)
        {
            return 0;
        }
    }
}