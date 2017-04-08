using Angular_app.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;

namespace Angular_app.Util
{
    public class Util
    {
        public ResponseTO Create(bool statusFlag, HttpStatusCode statusCode,
                                          string message,object data)
        {
            ResponseTO _response = new ResponseTO();
            _response.Status = statusFlag;
            _response.StatusCode = statusCode;
            _response.Message = message;
            _response.Data = data;

            return _response;
        }
    }
}