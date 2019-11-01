using System;
using System.Collections.Generic;
using System.Text;

namespace StatsFrom.Data.Interfaces
{
    public interface IStats<T> where T : IGame
    {
        int Wins { get; set; }
        int Looses { get; set; }
        decimal WinRatio { get; set; }
        T Game { get; set; }
    }
}
