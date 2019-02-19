using Microsoft.Web.Http.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Routing;

namespace WebAPIVersioning
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var constraintResolver = new DefaultInlineConstraintResolver();
            constraintResolver.ConstraintMap["apiVersion"] = typeof(ApiVersionRouteConstraint);
            config.AddApiVersioning();
            // Web API routes
            config.MapHttpAttributeRoutes(constraintResolver);            
        }
    }
}
