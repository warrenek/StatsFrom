using StatsFrom.Data.Enums;
using StatsFrom.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatsFrom.Data.Classes
{
    public class Game : IGame
    {
        public Game(GameEnum game, PlatformEnum platform)
        {
            this.GameEnum = game;
            this.Platform = Platform;
            SetGenre();
        }



        public GameEnum GameEnum { get; set; }
        public PlatformEnum Platform { get; set; }
        public GenreEnum Genre { get; set; }

        public void SetGenre()
        {
            switch (GameEnum)
            {
                case GameEnum.COD:
                    this.Genre = GenreEnum.FPS;
                    break;
            }
        }
    }
}
