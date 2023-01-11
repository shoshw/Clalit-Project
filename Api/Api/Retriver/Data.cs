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
            var w = new WebClient();
            var json_data = string.Empty;
            try
            {
                json_data = w.DownloadString(Url);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }
            return json_data;

        }
    }
}