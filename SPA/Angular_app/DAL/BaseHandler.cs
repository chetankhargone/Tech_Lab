using Angular_app.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Angular_app.DAL
{
    public abstract class BaseHandler
    {
        protected Util.Util _util;
        protected ObjectMapper _mapper;
    }
}