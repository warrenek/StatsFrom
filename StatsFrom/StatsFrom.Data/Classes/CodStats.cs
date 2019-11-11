using Microsoft.AspNetCore.Mvc;
using StatsFrom.Data.Enums;
using StatsFrom.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatsFrom.Data.Classes
{
    public class CodStats : IFPSStats
    {
        public CodStats(int Kills, int Deaths, int Assists, decimal KDRatio, int Wins, int Looses, decimal WinRatio)
        {
            this.Kills = Kills;
            this.Deaths = Deaths;
            this.Assists = Assists;
            this.KDRatio = KDRatio;
            this.Wins = Wins;
            this.Looses = Looses;
            this.WinRatio = WinRatio;
            this.Game = new Game(GameEnum.COD, PlatformEnum.NA);
        }

        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Assists { get; set; }
        public decimal KDRatio { get; set; }
        public int Wins { get; set; }
        public int Looses { get; set; }
        public decimal WinRatio { get; set; }
        public int HeadShots { get; set; }
        public decimal Accuracy { get; set; }
        [HiddenInput(DisplayValue = false)]
        public Game Game { get; set; }
    }
}
