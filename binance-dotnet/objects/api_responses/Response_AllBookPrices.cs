﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binance_dotnet.objects
{
    public class Response_AllBookPrices : APIResponse
    {
        public BookPrice[] bookprices { get; set; }
        public class BookPrice
        {
            public string symbol { get; set; }
            public string bidPrice { get; set; }
            public string bidQty { get; set; }
            public string askPrice { get; set; }
            public string askQty { get; set; }
        }
    }



}
