using System;
using System.Collections.Generic;
using System.Text;

namespace StartsFrom.ApiConnector
{
    public abstract class IConnector
    {
        public Uri BaseUri { get; set; }
        public string RequestUri { get; set; }
        public FeedType FeedType { get; set; }

        public abstract Uri GetLink(string playerName);

        public object GetData(Uri uri)
        {
            return Downloader.Download(uri);
        }
    }
}
