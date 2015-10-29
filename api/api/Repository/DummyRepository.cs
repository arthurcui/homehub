using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using api.DomainObjects;

namespace api.Repository
{
    public class DummyRepository : IRepository
    {
        private IList<Listing> _listings;

        public DummyRepository()
        {
            _listings = new List<Listing>();
            _listings.Add(new Listing
            {
                Address = "888 Canada Way, Vancouver, BC V8V8V8",
                ListingPrice = 1680000.00m,
                LotSize = 10000.00m,
                TotalFloorSize = 3888.00m,
                BedroomCount = 8,
                Age = 18
            });
            _listings.Add(new Listing
            {
                Address = "1888 Canada Way, Vancouver, BC V8V8V8",
                ListingPrice = 11680000.00m,
                LotSize = 110000.00m,
                TotalFloorSize = 13888.00m,
                BedroomCount = 18,
                Age = 118
            });
        }

        public IEnumerable<Listing> GetAllListings()
        {
            return _listings;
        }
    }
}