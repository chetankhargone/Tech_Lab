using Angular_app.DAL;
using Angular_app.DTO.Response;
using Angular_app.Mapper;
using Angular_app.ViewModel.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Angular_app.Controllers.Service
{
    [AllowAnonymous]
    public class AccountUtilController : BaseController
    {
        private readonly ObjectMapper _mapper;

        [Route("api/user/login")]
        public IHttpActionResult Post(LoginVM model)
        {
            if(model.Username == "chetan" && model.Password == "login")
            {
                //var customer = _mapper.Map(model);
               // CustomerHandler dal = new CustomerHandler();
                _util = new Util.Util();
                _responseObj = _util.Create(true,HttpStatusCode.OK,"User Valid",true);
                return Ok(_responseObj);
            }
            else
            {
                 _responseObj = _util.Create(false,HttpStatusCode.InternalServerError,"Credentials invalid",null);
                 return Ok(_responseObj);
                 
            }
        }

    }
}
