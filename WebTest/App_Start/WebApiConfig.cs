using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebTest
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            /*
             * Register a new Constraint
             * var constraintResolver = new DefaultInlineContraintResolver();
             * constraintResolver.ConstraintMap.Add("enum", typeof(EnumerationConstraint))//Created by me.
             * config.MapHttpAttributeRoutes(constraintResolver);
             * */

            //config.Routes.MapHttpRoute(name: "ProdApi",
            //    routeTemplate: "api/prod/{id}",
            //    defaults: new { id = RouteParameter.Optional, controller = "products" });


            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
        }
    }
}
