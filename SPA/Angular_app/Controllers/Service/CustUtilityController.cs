namespace Angular_app.Controllers.Service
{
    #region Import
    using Angular_app.DAL;
    using Angular_app.DTO;
    using Angular_app.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    #endregion

    [Route("api/customer")]
    public class CustUtilityController : ApiController
    {
        // GET api/custutility
        public IEnumerable<CustomerTO> Get()
        {
            //DAL 
            CustomerHandler dal = new CustomerHandler();
            var customers = dal.GetCustomers();
            return customers;
        }

        // GET api/custutility/5
        public string Get(int id)
        {
            CustomerHandler dal = new CustomerHandler();
            var customer = dal.GetCustomer(id);
            
            return customer.ToString();

        }

        // POST api/custutility
        public HttpResponseMessage Post([FromBody]CustomerTO customer)
        {
            CustomerHandler dal = new CustomerHandler();
            bool flag = dal.AddCustomer(customer);
            
            return Request.CreateResponse(HttpStatusCode.OK, flag);
        }

        // PUT api/custutility/5
        public void Put(int id, [FromBody]CustomerTO customer)
        {
        }

        // DELETE api/custutility/5
        public void Delete(int id)
        {
        }

    }

    
}
