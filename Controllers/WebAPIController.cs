using mvcDEMO.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace mvcDEMO.Controllers
{
    public class WebAPIController : ApiController
    {
        // GET api/<controller>
        [TestDemo("", 0)]
        public string Get()
        {
            return JsonConvert.SerializeObject(new string[] { "value1", "value2" });
        }

        // Post api/<controller>
        //public string Post(string json)
        //{
        //    return json;
        //}

        public string Post([FromBody]string json)
        {
            return json;
        }

        // POST api/<controller>
        //public void Post1([FromBody] string value)
        //{
        //}

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}