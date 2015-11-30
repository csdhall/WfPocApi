using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace WfPocApi.Controllers
{

    public class ValuesController : ApiController
    {
        // GET api/values
        public Task<HttpResponseMessage> Get()
        {
            HttpClient client = new HttpClient();
            return client.GetAsync("http://localhost:2558/");
            //http://localhost:2558/
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
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
