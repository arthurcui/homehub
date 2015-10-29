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

        [HttpGet, Route("listings")]
        public IEnumerable<Listing> Get()
        {
            return _repository.GetAllListings();
        }

        [HttpGet, Route("listings/{id}x")]
        public JObject Geccc(int id)
        {
            return JObject.Parse("{A:'" + id +"a'}");
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
