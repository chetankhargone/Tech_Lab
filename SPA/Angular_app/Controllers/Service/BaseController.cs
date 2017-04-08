using Angular_app.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Angular_app.Controllers.Service
{
    public class BaseController : ApiController
    {
        protected Util.Util _util;
        protected ResponseTO _responseObj;
        protected IHttpActionResult _response;

      
    }
}
