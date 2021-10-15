using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Candles_Database.Models
{
    public class CandleTypeViewModel
    {
        public List<Candles> Candle { get; set; }
        public SelectList Types { get; set; }
        public string CandleType { get; set; }
        public string SearchString { get; set; }
    }
}
