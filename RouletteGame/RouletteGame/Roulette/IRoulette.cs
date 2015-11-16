namespace RouletteGame.Roulette
{
    public interface IRoulette
    {
        void Spin();
        Field GetResult();
    }
}