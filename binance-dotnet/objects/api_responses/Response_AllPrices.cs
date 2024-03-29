﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binance_dotnet.objects
{
    public class Response_AllPrices : APIResponse
    {
        public Price[] prices { get; set; }
        public class Price
        {
            public string symbol { get; set; }
            public string price { get; set; }
        }
    }
}
