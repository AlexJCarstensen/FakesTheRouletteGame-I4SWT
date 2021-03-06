﻿using RouletteGame.Roulette;

namespace RouletteGame.Bets
{
    public interface IBet
    {
        string PlayerName { get; }
        uint Amount { get; }
        uint WonAmount(Field field);
    }
}