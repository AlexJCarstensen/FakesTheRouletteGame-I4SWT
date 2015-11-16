using System;

namespace RouletteGame
{
    public interface IBet
    {
        string PlayerName { get; }
        uint Amount { get; }
        uint WonAmount(Field field);
    }
}