using System;
using System.Collections.Generic;
using TresetaApp.Enums;

namespace TresetaApp.Models
{
    public class GameSetup
    {
        public GameSetup(int playUntilPoints, int expectedNumberOfPlayers)
        {
            Id = Guid.NewGuid().ToString();
            PlayUntilPoints = playUntilPoints;
            ExpectedNumberOfPlayers=expectedNumberOfPlayers;
        }

        public string Id { get; set; }
        public string Password { get; set; }
        public int PlayUntilPoints { get; set; }
        public int ExpectedNumberOfPlayers { get; set; }

        public TypeOfDeck TypeOfDeck { get; set; }
    }
}