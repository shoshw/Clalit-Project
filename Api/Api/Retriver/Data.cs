using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace Api.Retriver
{
    public class Data
    {
        public string GetCoinsFromUrl()
        {
            string Url = "https://www.boi.org.il/currency.xml";
            var webClient = new WebClient();
            var json_data = string.Empty;
            try
            {
                json_data = webClient.DownloadString(Url);
            }
            catch
            {
                throw new Exception("url isn't available");
            }
            return json_data;
        }
    }
}