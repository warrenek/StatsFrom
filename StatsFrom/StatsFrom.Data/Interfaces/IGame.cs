using StatsFrom.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatsFrom.Data.Interfaces
{
    public interface IGame
    {
        GameEnum GameEnum { get; set; }
        PlatformEnum Platform { get; set; }
        GenreEnum Genre { get; set; }


        public abstract void SetGenre();
    }
}
