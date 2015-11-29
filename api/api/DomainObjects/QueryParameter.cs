using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api.DomainObjects
{
    public class QueryParameter
    {
        // Meta data
        public int? Offset { get; set; }
        public int? Limit { get; set; }
        public string[] SortBy { get; set; }
        public int? SortOrder { get; set; }
        
        // Filters
        public string Polygon { get; set; }
        public int?[] Status { get; set; }

        public decimal? ListPriceLow { get; set; }
        public decimal? ListPriceHigh { get; set; }
        public int? AgeLow { get; set; }
        public int? AgeHigh { get; set; }
        public int? NumberOfBedroomsLow { get; set; }
        public int? NumberOfBedroomsHigh { get; set; }
        public decimal? LotSizeLow { get; set; }
        public decimal? LotSizeHigh { get; set; }
        public decimal? FinishedTotalLow { get; set; }
        public decimal? FinishedTotalHigh { get; set; }
    }
}