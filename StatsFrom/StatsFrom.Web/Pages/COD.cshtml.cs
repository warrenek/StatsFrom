using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using StartsFrom.ApiConnector;
using StatsFrom.Data;
using StatsFrom.Data.Classes;
using StatsFrom.Data.Enums;

namespace StatsFrom.Web.Pages
{
    public class CODModel : PageModel
    {
        [BindProperty]
        public PlayerInput player { get; set; }

        public CodStats Data { get; set; }


        public void SetData()
        {
            try
            {
                MyCallofdutyComConnector connector = new MyCallofdutyComConnector();
                connector.BaseUri = new Uri("https://my.callofduty.com/");
                connector.RequestUri = "api/papi-client/stats/cod/v1/title/mw/platform/battle/gamer/PLAYERNAME%23HASHTAG/profile/type/mp";
                connector.FeedType = FeedType.JSON;
                string data = connector.GetData(connector.GetLink(player.playerName, player.hashTag)).ToString();

                dynamic deserialized = JsonConvert.DeserializeObject(data);


                Data = new CodStats((int)deserialized.data.lifetime.all.properties.kills,
                                    (int)deserialized.data.lifetime.all.properties.deaths,
                                    (int)deserialized.data.lifetime.all.properties.assists,
                                    (decimal)deserialized.data.lifetime.all.properties.kdRatio,
                                    (int)deserialized.data.lifetime.all.properties.wins,
                                    (int)deserialized.data.lifetime.all.properties.losses,
                                    (decimal)deserialized.data.lifetime.all.properties.winLossRatio);
                Data.Accuracy = (decimal)deserialized.data.lifetime.all.properties.accuracy;
                Data.HeadShots = (int)deserialized.data.lifetime.all.properties.headshots;
            }
            catch (Exception) { }
        }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            SetData();

            return this.Page();
        }

        public class PlayerInput
        {
            public String playerName { get; set; }
            public String hashTag { get; set; }
        }

    }
}