using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class Coin
    {
        public string key { get; set; }
        public double currentExchangeRate { get; set; }
        public double currentChange { get; set; }
        public int unit { get; set; }
        public DateTime lastUpdate { get; set; }
    }
}