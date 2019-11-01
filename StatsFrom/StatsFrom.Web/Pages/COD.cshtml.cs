using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StatsFrom.Data;
using StatsFrom.Data.Classes;
using StatsFrom.Data.Enums;

namespace StatsFrom.Web.Pages
{
    public class CODModel : PageModel
    {
        [BindProperty]
        public CodStats Data { get; set; }

        public void OnGet()
        {
            Data = new CodStats(1, 1, 1, 1, 1, 1, 1);
            Data.Accuracy = 1;
            Data.HeadShots = 1;
        }

    }
}