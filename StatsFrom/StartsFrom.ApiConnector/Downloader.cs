using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace StartsFrom.ApiConnector
{
    public static class Downloader
    {
        public static object Download(Uri uri)
        {
            using (WebClient webClient = new WebClient())
            {
                return webClient.DownloadString(uri);
            }
            //WebRequest webRequest = WebRequest.Create(uri);
            //webRequest.Method = "GET";
            //WebResponse webResponse = webRequest.GetResponse();
            //return webResponse.;
        }
    }
}
