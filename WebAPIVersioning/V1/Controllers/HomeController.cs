using Microsoft.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebAPIVersioning.V1.Models;

namespace WebAPIVersioning.V1.Controllers
{
    [ApiVersion("1.0")]
    [RoutePrefix("v{version:apiVersion}/values")]
    public class HomeController : ApiController
    {
        [Route("Get")]
        [HttpGet]
        public IHttpActionResult GetValuesAsync()
        {
            var response = new Response { VersionId = 1, Message = "This is Version 1" };
            return Ok(response);
        }
    }
}
