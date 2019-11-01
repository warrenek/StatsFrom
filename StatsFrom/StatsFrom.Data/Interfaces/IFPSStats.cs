using StatsFrom.Data.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatsFrom.Data.Interfaces
{
    public interface IFPSStats : IStats<Game>
    {
        int Kills { get; set; }
        int Deaths { get; set; }
        int Assists { get; set; }
        decimal KDRatio { get; set; }
    }
}
