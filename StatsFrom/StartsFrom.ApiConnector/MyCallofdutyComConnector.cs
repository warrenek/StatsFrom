﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StartsFrom.ApiConnector
{
    public class MyCallofdutyComConnector : IConnector
    {
        public override Uri GetLink(string playerName, string hashTag)
        {
            Uri result;
            if (Uri.TryCreate(BaseUri, RequestUri.ToLower().Replace("playername", playerName).Replace("hashtag", hashTag), out result))
                return result;
            else
                return null;

        }
    }
}
