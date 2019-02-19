using Microsoft.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIVersioning.V2.Models;

namespace WebAPIVersioning.V2.Controllers
{
    [ApiVersion("2.0")]
    [RoutePrefix("v{version:apiVersion}/values")]
    public class HomeController : ApiController
    {
        [Route("Get")]
        [HttpGet]
        public IHttpActionResult GetValuesAsync()
        {
            var response = new Response { VersionId = 2, Message = "This is Version 2" };
            return Ok(response);
        }
    }
}
