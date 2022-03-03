namespace RouteYapilanmasi.Constraints
{
    public class CustomConstraint : IRouteConstraint
    {
        public bool Match(HttpContext? httpContext, 
                        IRouter? route, 
                        string routeKey,
                        RouteValueDictionary values, 
                        RouteDirection routeDirection)
        {
            var idvalue=values[routeKey]; 
            // burda belirttiğimiz kontrolleri yapabilir
            // 5 ten büyükmü içinde harf varmı bir nesne ise bu nesne değerleri dolumu vs.
            return true;
        }
    }
}
