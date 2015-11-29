using api.DomainObjects;
using api.Repository;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace api.Controllers
{
    //TODO: re-enable Authorization later
    //[Authorize]
    [RoutePrefix("api/v1")]
    public class ListingsV1Controller : ApiController
    {
        private IRepository _repository;

        public ListingsV1Controller(IRepository repository)
        {
            _repository = repository;
        }

        // http://host.com/api/v1/listings?status=0&status=1&listpricelow=1000000&listpricehigh=2000000
        // http://host.com/api/v1/listings?sortorder=0&sortby=price&sortby=bedroom
        [HttpGet, Route("listings")]
        public IEnumerable<Listing> SearchListings([FromUri]QueryParameter parameter)
        {
            if (parameter == null)
                parameter = new QueryParameter();

            if (parameter.Offset == null)
                parameter.Offset = 0;

            if (parameter.Limit == null)
                parameter.Limit = 50;

            if (parameter.SortOrder == null)
                parameter.SortOrder = 0;

            return _repository.SearchListings(parameter);
        }

        [HttpGet, Route("listings/{id}")]
        public string Geccc(int id, string p1)
        {
            return "" + id + "," + p1;
        }
        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }

}
