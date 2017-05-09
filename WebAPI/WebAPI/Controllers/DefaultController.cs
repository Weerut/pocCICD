using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class DefaultController : ApiController
    {
        [AcceptVerbs("GET")]
        public IHttpActionResult Hi(string name = "no name")
        {
            return Ok($"Hi {name}");
        }

        [AcceptVerbs("GET")]
        public IHttpActionResult Bye(string name = "no name")
        {
            return Ok($"Bye {name}");
        }

        [AcceptVerbs("GET")]
        public IHttpActionResult Yell(string name = "no name")
        {
            return Ok($"Get on {name}");
        }
    }
}
