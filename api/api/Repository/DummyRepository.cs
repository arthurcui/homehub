using System;
using System.Collections.Generic;
using System.Linq;
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
            _listings.Add(new Listing
            {
                Address = new Address
                {
                    Street = "1000 10"
                },
                ListPrice = 1000,
                NumberOfBedrooms = 10,
            });
            _listings.Add(new Listing
            {
                Address = new Address
                {
                    Street = "2000 10"
                },
                ListPrice = 2000,
                NumberOfBedrooms = 10,
            });
            _listings.Add(new Listing
            {
                Address = new Address
                {
                    Street = "1000 20"
                },
                ListPrice = 1000,
                NumberOfBedrooms = 20,
            });
            _listings.Add(new Listing
            {
                Address = new Address
                {
                    Street = "2000 20"
                },
                ListPrice = 2000,
                NumberOfBedrooms = 20,
            });
        }

        public IEnumerable<Listing> SearchListings(QueryParameter parameter)
        {
            IEnumerable<Listing> result = _listings;

            if(parameter.Status != null)
                result = result.Where(listing => parameter.Status.Contains(listing.Status));

            if (parameter.ListPriceLow != null)
                result = result.Where(listing => listing.ListPrice >= parameter.ListPriceLow);

            if (parameter.ListPriceHigh != null)
                result = result.Where(listing => listing.ListPrice <= parameter.ListPriceHigh);

            IOrderedEnumerable<Listing> orderedResult = null;
            if (parameter.SortBy != null)
            {
                orderedResult = result.OrderBy(listing => 0);
                foreach (var sortField in parameter.SortBy)
                    switch (sortField.ToLowerInvariant())
                    {
                        case "price":
                            orderedResult = parameter.SortOrder == 0 ? orderedResult.ThenBy(listing => listing.ListPrice) : orderedResult.ThenByDescending(listing => listing.ListPrice);
                            break;
                        case "bedroom":
                            orderedResult = parameter.SortOrder == 0 ? orderedResult.ThenBy(listing => listing.NumberOfBedrooms) : orderedResult.ThenByDescending(listing => listing.NumberOfBedrooms);
                            break;
                    }
            }

            if(orderedResult != null)
                result = orderedResult.Skip((int)parameter.Offset).Take((int)parameter.Limit);
            else
                result = result.Skip((int)parameter.Offset).Take((int)parameter.Limit);

            return result;
        }
    }
}