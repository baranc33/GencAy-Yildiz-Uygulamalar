namespace MiddlewareExample.Middlewares
{
    public class HelloMiddleware
    {
        RequestDelegate _next;

        // öncelikle bu middle wareden sonra gelecek Middle ware 'i ctor içinde alalım
        public HelloMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        // bir önceki midllewarein bu middlewari tetikleye bilmesi için
        // bu metot imzasının olması gerekiyor.
        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine("Bu Middle Ware başladı");

            // bir sonraki midllewar'i tetikliyoruz.
            await _next.Invoke(context);

            Console.WriteLine("Geri Döndü");
        }

    }
}
