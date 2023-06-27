using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Route.Constraints
{
    public class CustomConstraint : IRouteConstraint
    {
        //bir midleware gibi araya giriyor.
        public bool Match(HttpContext httpContext, 
            IRouter route, 
            string routeKey, 
            RouteValueDictionary values, 
            RouteDirection routeDirection)
        {
            var idValues = values[routeKey];
            return true;
        }
    }
}
