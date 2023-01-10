using Api.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace Api.Services
{
    public class CoinsService
    {
        public List<Coin> GetNegetiveCoins()
        {
            string Url = "https://www.boi.org.il/currency.xml";        
            List<Coin> coins = new List<Coin>();
            List<Coin> negativeTrendCoins = new List<Coin>();
            var w = new WebClient();
            var json_data = string.Empty;
            try
            {
                json_data = w.DownloadString(Url);
                json_data = json_data.Split('[')[1];
                json_data = json_data.Split(']')[0];
                json_data = '[' + json_data + ']';

                coins = JsonConvert.DeserializeObject<List<Coin>>(json_data);
            }
            catch (Exception e)
            {
                throw new Exception("api isnt available" + e.Message);
            }
            negativeTrendCoins = coins.Where(c => c.currentExchangeRate < 1).ToList();
            return negativeTrendCoins;
        }

    }
}