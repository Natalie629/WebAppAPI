using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Net;

namespace WebAppAPI.Controllers
{
    //public class ValuesController1 : ApiController
    public class WebApiController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}



/*
 * 
 * using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using MvcWebApiCRUDDemo.Models;
using System.Net;
 
namespace MvcWebApiCRUDDemo.Controllers
{
    public class CustomerController : ApiController
    {
        //建立一個靜態的倉儲，這裡使用靜態的目的是為了讓資料可以被CRUD，
        //而不會因，重新建立此倉儲物件，而造成重塞資料的問題。
        private static readonly ICustomerRepository _repository = new CustomerRepository();
 
        // GET /api/customer
        public IEnumerable<customer> Get()
        {
            return _repository.GetAll();
        }
 
        // GET /api/customer/5
        public Customer Get(int id)
        {
            Customer customer = _repository.Get(id);
            if (customer == null)
            {
                //如果找不到，就拋出HTTP的Response例外，內容是尋找不到，也就是404
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return customer;
        }
 
        // POST /api/customer
        public HttpResponseMessage Post(Customer customer)
        {
            customer = _repository.Add(customer);
            var response = new HttpResponseMessage<customer>(customer, HttpStatusCode.Created);
 
            string uri = Url.Route(null, new { id = customer.Id });
            response.Headers.Location = new Uri(Request.RequestUri, uri);
 
            return response;
        }
 
        // PUT /api/customer/5
        public void Put(int id, Customer customer)
        {
            customer.Id = id;
            if (!_repository.Update(customer))
            {
                //如果找不到，就拋出HTTP的Response例外，內容是尋找不到，也就是404
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }
 
        // DELETE /api/customer/5
        public HttpResponseMessage Delete(int id)
        {
            _repository.Delete(id);
            return new HttpResponseMessage(HttpStatusCode.NoContent);
        }
    }
}
</customer></customer>
 * 
 * 
 */
