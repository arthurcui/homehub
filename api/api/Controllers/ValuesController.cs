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
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
//        public JObject Get(int id)
//        {
//            string json = @"{
// CPU: 'Intel',
//""Version"": " + id + @",
// Drives: [
//   'DVD read/writer',
//   '500 gigabyte hard drive'
// ]
//}";

//            return JObject.Parse(json);
//        }

        public A Get(int id)
        {
            var b = new B { S = "within B", II = new[] { 1, 2 } };
            var a = new A { S = "in A", I = 100, B = b };

            return a;
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

    public class A
    {
        public string S;// { get; set; }
        public int I;// { get; set; }
        public B B;// { get; set; }
    }
    public class B
    {
        public string S;// { get; set; }
        public int[] II;// { get; set; }
    }

}
