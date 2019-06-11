using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebTest.Controllers
{
    [RoutePrefix("products")]//I Can chanege the Route
    public class ProductsController : ApiController
    {
        [Route("")]
        [AcceptVerbs("GET", "VIEW")]//Visible from POSTMAN
        [Route("~/prods")]//Override the route
        public IEnumerable<string> GetAllProducts()
        {
            return new string[] { "product1", "product2" };
        }


        // GET: api/Products
        [HttpGet, Route("")]//There's no problem if I change the name of the name with Get prefix
        public IEnumerable<string> Get()
        {
            return new string[] { "product1", "product2" };
        }

        // GET: api/Products/5
        //The way to create a constraint is putting the type before the id, like this, {id:int}, gets an 404 error
        //if is not sent an integer.
        //BE CAREFUL, duplicate the constraint in all references {id}
        [HttpGet, Route("{id:int:range(1000,3000)}")]
        public string Get(int id)
        {
            return "product" + id;
        }

        [HttpGet, Route("{id}/orders/{custId}")]
        public string GetProductsForCustomer(int id, int custId)
        {
            return "product-orders" + custId;
        }
        // POST: api/Products
        [HttpPost, Route("")]
        public void CreateProduct([FromBody]string value)
        {
        }
        [HttpPut, Route("{id:int:range(1000,3000)}")]
        // PUT: api/Products/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Products/5
        [HttpDelete, Route("{id:int:range(1000,3000)}")]
        public void Delete(int id)
        {
        }
    }
}
