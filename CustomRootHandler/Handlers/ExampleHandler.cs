namespace CustomRootHandler.Handlers
{
    public class ExampleHandler
    {
        public  RequestDelegate Handler()
        {
            // geriye Request delegate türü içinede bir HttpContext almalı
            return async x =>
            {
                // yapılcak işlemler Gelen HttpContex türü burda x i temsil ediyor
            };
                 
        }
    }
}
