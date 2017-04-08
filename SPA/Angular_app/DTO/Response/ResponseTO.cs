using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace Angular_app.DTO.Response
{
    public class ResponseTO
    {
        public bool Status { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}