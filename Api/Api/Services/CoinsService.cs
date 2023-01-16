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
            Root root = null;
            List<Coin> negativeTrendCoins = new List<Coin>();
            var json_data = string.Empty;
            try
            {
                json_data = new Data().GetCoinsFromUrl();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            root = JsonConvert.DeserializeObject<Root>(json_data);
            negativeTrendCoins = root.exchangeRates.Where(c => c.currentExchangeRate < 1).ToList();
            return negativeTrendCoins;
        }

    }
}