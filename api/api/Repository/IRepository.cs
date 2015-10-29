using api.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.Repository
{
    public interface IRepository
    {
        IEnumerable<Listing> GetAllListings();
    }
}
