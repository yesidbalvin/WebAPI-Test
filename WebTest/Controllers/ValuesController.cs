using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using WebTest.Models;

namespace WebTest.Controllers
{
    public class ValuesController : ApiController
    {
        // GET: api/Values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Values/5
        [HttpPut]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Values/5
        [HttpDelete]
        public void Delete(int id)
        {
        }

        [HttpGet, Route("complex")]
        public IHttpActionResult ComplexTest([FromUri] ComplexTypeDto obj)
        {
            return Json(obj);
        }

        [HttpPut, Route("bodytest")]
        public string BodyTest([FromBody] string value)
        {
            return value;
        }

        [HttpGet, Route("dates/{*myDate:datetime}")]//     .../dates/12/1/2022
        public string GetDate(DateTime myDate)
        {
            return myDate.ToLongDateString();
        }
        [HttpGet, Route("segments/{*array:maxlength(256)}")]//     .../segments/test/test2/test4/test/6
        //It is necessary to create a IModelBinder to split the parameter as an array
        //GetSegments([ModelBinder(typeof(StringArrayWildcardBinder))] string[] array)
        public string[] GetSegments(string[] array)
        {
            return array;
        }
    }
}
