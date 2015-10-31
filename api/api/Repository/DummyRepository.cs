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
                Address = new Address
                {
                    Number = "888",
                    Street = "Canada Way",
                    City = "Vancouver",
                    Province = "BC",
                    PostalCode = "V8V8V8",
                    Country = "Canada"
                },
                ListPrice = 1680000.00m,
                LotSize = 10000.00m,
                FinishedTotal = 3888.00m,
                NumberOfBedrooms = 8,
                Age = 18
            });
            _listings.Add(new Listing
            {
                Address = new Address
                {
                    Unit = "8",
                    Number = "518",
                    Street = "Williams Road",
                    City = "Richmond",
                    Province = "BC",
                    PostalCode = "V7E1K1",
                    Country = "Canada"
                },
                ListPrice = 980000.00m,
                FinishedTotal = 1888.00m,
                NumberOfBedrooms = 4,
                Age = 8
            });
        }

        public IEnumerable<Listing> GetAllListings()
        {
            return _listings;
        }
    }
}