using Api.Models;
using Api.Retriver;
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
            List<Coin> coins = new List<Coin>();
            List<Coin> negativeTrendCoins = new List<Coin>();
            var json_data = string.Empty;
            try
            {
                json_data = new Data().GetCoinsFromUrl();
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